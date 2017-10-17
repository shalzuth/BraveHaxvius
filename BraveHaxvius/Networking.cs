using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using BraveHaxvius.Data;

namespace BraveHaxvius
{
    public class Networking
    {
        public BraveExvius client;
        public Networking()
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
        }
        JObject VersionInfo(String name, String version)
        {
            return new JObject(
                new JProperty(Variable.KeyName, name),
                new JProperty(Variable.Value, version));
        }
        JProperty VersionInfo()
        {
            var os = client.OperatingSystem.Contains("ios") ? "IOS" : client.OperatingSystem.Contains("amazon") ? "AMAZON" : "AND";
            return new JProperty(GameObject.VersionInfo,
                new JArray(
                    VersionInfo("F_APP_VERSION_" + os, client.AppVersion),
                    VersionInfo("F_RSC_VERSION", client.RscVersion),
                    VersionInfo("F_MST_VERSION", client.MstVersion)));
        }
        public JObject DataObject(List<JProperty> inputs)
        {
            var data = new JObject();
            foreach (var input in inputs)
                data.Add(input);
            data.Add(client.UserInfo);
            if (client.Locale == "US" && !String.IsNullOrEmpty(client.TransferCode))
                data.Add(new JProperty(Variable.Facebook, new JArray(new JObject(new JProperty(Variable.UsingFacebook, "0")))));
            else if (!String.IsNullOrWhiteSpace(client.FacebookUserId))
                data.Add(new JProperty(Variable.Facebook, new JArray(new JObject(new JProperty(Variable.UsingFacebook, "1")))));
            if (client.LastSignalKey != "")
                data.Add(new JProperty(GameObject.SignalKey, new JArray(new JObject(new JProperty(Variable.Data, client.LastSignalKey)))));
            data.Add(VersionInfo());
            return data;
        }
        public JObject Packet(String requestID, String encryptedData)
        {
            return new JObject(
                new JProperty(GameObject.Header,
                    new JObject(
                        new JProperty(Variable.Milliseconds, ((int)((DateTime.UtcNow - System.Diagnostics.Process.GetCurrentProcess().StartTime.ToUniversalTime()).TotalMilliseconds)).ToString()),
                        new JProperty(Variable.RequestID, requestID))),
                new JProperty(Variable.Encrypted,
                    new JObject(
                        new JProperty(Variable.Data, encryptedData))));
        }
        public JObject SendPacket(Request request)
        {
            return SendPacket(request, new List<JProperty>());
        }
        public JObject SendPacket(Request request, params JProperty[] inputs)
        {
            var inputList = new List<JProperty>();
            foreach (var input in inputs)
                inputList.Add(input);
            return SendPacket(request, inputList);
        }
        public JObject SendPacket(Request request, List<JProperty> inputs)
        {
            Logger.Out("Sending : " + request.Name + "...");
            var decryptedData = DataObject(inputs);
            var decryptedDataString = JsonConvert.SerializeObject(decryptedData, Formatting.None);
            var encryptedData = Crypto.Encrypt(decryptedDataString, request.EncodeKey);
            var packet = Packet(request.RequestID, encryptedData);
            var packetString = JsonConvert.SerializeObject(packet, Formatting.None);
            var url = "https://lapisv230.gumi.sg/lapisProd/app/php/gme/actionSymbol/";
            //url = "https://lapis-dev.gumi.sg/lapisDev/app/php/gme/actionSymbol/";
            if (client.Locale == "JP")
                url = "https://v29-android.game.exvius.com/lapis/app/php/gme/actionSymbol/";
            var responseString = "";
            JObject responseData = null;
            //responseString = SendData(url + request.Url + ".php", packetString); /*
            try
            {
                responseString = SendData(url + request.Url + ".php", packetString);
                responseData = (JObject)JsonConvert.DeserializeObject(responseString);
            }
            catch (Exception e)
            {
                var ee = e.Message.ToString();
                if (ee.Contains("403"))
                    throw new Exception("IP Banned");
                if (ee.Contains("Unable to connect"))
                    throw new Exception("Bad Proxy");
                if (ee.Contains("400"))
                    throw new Exception("Unk");
                if (ee.Contains("503"))
                    throw new Exception("proxy dead");
                responseString = SendData(url + request.Url + ".php", packetString);
                responseData = (JObject)JsonConvert.DeserializeObject(responseString);
                //return SendPacket(request, inputs);
            }//*/
            var errorMsg = responseData[GameObject.Message]?[Variable.Message];
            if (errorMsg != null)
            {
                var msg = Text.Texts.First(t => t.Key == errorMsg.ToString()).Value;
                if (msg == "Please log in again.")
                {
                    Thread.Sleep(10000);
                    client.UserId = "";
                    client.UserName = "";
                    client.FriendCode = "";
                    client.Password = "";
                    client.GumiId = "";
                    client.GumiToken = "";
                    client.ModelChangeCnt = "";
                    Request Initialize = new Request { Name = "Initialize", Url = "fSG1eXI9", EncodeKey = "rVG09Xnt", RequestID = "75fYdNxq" };
                    var initializeResponse = SendPacket(Initialize);
                    var userInfo = initializeResponse["LhVz6aD2"].First();
                    client.UserId = userInfo["9Tbns0eI"].ToString();
                    client.UserName = userInfo["9qh17ZUf"].ToString();
                    client.FriendCode = userInfo["m3Wghr1j"].ToString();
                    client.Password = userInfo["JC61TPqS"].ToString();
                    if (client.Locale != "JP")
                    {
                        client.GumiId = userInfo["mESKDlqL"].ToString();
                        client.GumiToken = userInfo["iVN1HD3p"].ToString();
                    }
                    client.ModelChangeCnt = userInfo["6Nf5risL"].ToString();
                    Thread.Sleep(2000);

                    return SendPacket(request, inputs);
                }
                throw new Exception(Text.Texts.First(t => t.Key == errorMsg.ToString()).Value);
            }
            var decryptedResponseString = Crypto.Decrypt(responseData[Variable.Encrypted][Variable.Data].ToString(), request.EncodeKey);
            var decryptedResponseData = (JObject)JsonConvert.DeserializeObject(decryptedResponseString);
            var signalResponse = decryptedResponseData[GameObject.SignalKey];
            if (signalResponse != null)
                client.LastSignalKey = signalResponse.First()[Variable.Data].ToString();
            Logger.Out("\tRequest done");
            return decryptedResponseData;
        }
        public String DecodePacket(JObject obj)
        {
            var decryptedDataString = JsonConvert.SerializeObject(obj, Formatting.Indented);
            foreach (var v in Variable.Variables)
                decryptedDataString = decryptedDataString.Replace(v.Key, v.Value);
            foreach (var v in GameObject.GameObjects)
                decryptedDataString = decryptedDataString.Replace(v.Key, v.Value);
            return decryptedDataString;
        }
        private String SendData(String url, String data)
        {
            HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(url);
            webRequest.Headers.Clear();
            webRequest.Method = WebRequestMethods.Http.Post;
            webRequest.Timeout = 150000;
            webRequest.ContentType = "application/x-www-form-urlencoded";
            webRequest.Accept = "*/*";
            webRequest.UserAgent = "FF%20EXVIUS/" + client.BuildVersion.Replace("ver.", "") + " CFNetwork/808.3 Darwin/16.3.0";
            webRequest.AutomaticDecompression = DecompressionMethods.GZip;
            webRequest.Headers[HttpRequestHeader.AcceptEncoding] = "gzip";
            webRequest.Headers[HttpRequestHeader.AcceptLanguage] = "en-us";
            webRequest.KeepAlive = true;
            webRequest.ProtocolVersion = HttpVersion.Version10;
            if (client.ProxyIpAddr != "shalzuthproxy")
                webRequest.Proxy = new WebProxy(client.ProxyIpAddr, client.ProxyPort);
            var content = Encoding.UTF8.GetBytes(data);
            using (Stream stream = webRequest.GetRequestStream())
                stream.Write(content, 0, content.Length);
            using (Stream stream = webRequest.GetResponse().GetResponseStream())
            using (StreamReader reader = new StreamReader(stream, Encoding.UTF8))
                return reader.ReadToEnd();
        }
    }
}
