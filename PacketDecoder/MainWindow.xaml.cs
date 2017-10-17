using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using Fiddler;
using BraveHaxvius;
using BraveHaxvius.Data;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace PacketDecoder
{
    public partial class MainWindow
    {
        ObservableCollection<Packet> people = new ObservableCollection<Packet>();
        public MainWindow()
        {
            InitializeComponent();
            
            if (Properties.Settings.Default.Cert != "")
            {
                FiddlerApplication.Prefs.SetStringPref("fiddler.certmaker.bc.key", Properties.Settings.Default.Key);
                FiddlerApplication.Prefs.SetStringPref("fiddler.certmaker.bc.cert", Properties.Settings.Default.Cert);
            }
            DataContext = people;
            InstallCertificate();

            AppDomain.CurrentDomain.FirstChanceException += CurrentDomain_FirstChanceException;
            FiddlerApplication.BeforeRequest += delegate (Session oSession)
            {
                oSession.bBufferResponse = true;
            };
            FiddlerApplication.BeforeRequest += FiddlerApplication_BeforeRequest;
            FiddlerApplication.BeforeResponse += FiddlerApplication_BeforeResponse;
            FiddlerApplication.AfterSessionComplete += FiddlerApplication_AfterSessionComplete;
            FiddlerApplication.Startup(8888, true, true, true);
        }

        Boolean installCertificateMessage = false;
        private void CurrentDomain_FirstChanceException(object sender, System.Runtime.ExceptionServices.FirstChanceExceptionEventArgs e)
        {
            BraveHaxvius.Logger.Out(e.ToString());
            if (e.Exception.Message == "A call to SSPI failed, see inner exception.")
            {
                if (installCertificateMessage)
                    return;
                installCertificateMessage = true;
                var ipaddr = System.Net.Dns.GetHostEntry(System.Net.Dns.GetHostName()).AddressList.FirstOrDefault(ip => ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork);
                Application.Current.Dispatcher.InvokeAsync(async () =>
                {
                    var result = await this.ShowMessageAsync("Need to Accept Certificate On Proxied Device!", "Go to " + ipaddr.ToString() + " and download the FiddlerRoot Certificate!");
                    installCertificateMessage = false;
                });
            }
        }
        public static bool InstallCertificate()
        {
            if (!CertMaker.rootCertExists())
            {
                if (!CertMaker.createRootCert())
                    return false;
                if (!CertMaker.trustRootCert())
                    return false;
                Properties.Settings.Default.Cert = FiddlerApplication.Prefs.GetStringPref("fiddler.certmaker.bc.cert", null);
                Properties.Settings.Default.Key = FiddlerApplication.Prefs.GetStringPref("fiddler.certmaker.bc.key", null);
                Properties.Settings.Default.Save();
            }
            return true;
        }
        public static bool UninstallCertificate()
        {
            if (CertMaker.rootCertExists())
            {
                if (!CertMaker.removeFiddlerGeneratedCerts(true))
                    return false;
            }
            Properties.Settings.Default.Cert = "";
            Properties.Settings.Default.Key = "";
            Properties.Settings.Default.Save();
            return true;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            UninstallCertificate();
        }
        int packetCount = 0;
        
        private void FiddlerApplication_BeforeRequest(Session oSession)
        {
            if (oSession.RequestMethod == "CONNECT")
                return;
            if (oSession == null || oSession.oRequest == null || oSession.oRequest.headers == null)
                return;
            if (!oSession.fullUrl.Contains("actionSymbol"))
                return;
            string headers = oSession.oRequest.headers.ToString();
            var reqBody = oSession.GetRequestBodyAsString();
            reqBody = reqBody.Substring(reqBody.IndexOf("{"));
            reqBody = reqBody.Substring(0, reqBody.LastIndexOf("}") + 1);
            string firstLine = oSession.RequestMethod + " " + oSession.fullUrl + " " + oSession.oRequest.headers.HTTPVersion;
            int at = headers.IndexOf("\r\n");
            if (at < 0)
                return;
            headers = firstLine + "\r\n" + headers.Substring(at + 1);
            var url = oSession.fullUrl.Substring(oSession.fullUrl.IndexOf("actionSymbol") + 13).Replace(".php", "");
            var request = Request.Requests.First(r => r.Url == url);
            {
                dynamic json = JsonConvert.DeserializeObject(reqBody);
                if (json != null)
                {
                    var encryptedObject = json[Variable.Encrypted];
                    if (encryptedObject != null)
                    {
                        var encryptedData = encryptedObject[Variable.Data].Value;
                        var decryptedJson = Crypto.Decrypt(encryptedData, request.EncodeKey);
                        if (decryptedJson.Contains(""))
                        {
                        }
                    }
                }
            }
        }
        private void FiddlerApplication_BeforeResponse(Session oSession)
        {
            if (oSession.RequestMethod == "CONNECT")
                return;
            if (oSession == null || oSession.oRequest == null || oSession.oRequest.headers == null)
                return;
            if (!oSession.fullUrl.Contains("actionSymbol"))
                return;
            var time = (int)(DateTime.UtcNow - System.Diagnostics.Process.GetCurrentProcess().StartTime.ToUniversalTime()).TotalMilliseconds;
            string headers = oSession.oRequest.headers.ToString();
            string respHeaders = oSession.oResponse.headers.ToString();
            //var respBody = Encoding.UTF8.GetString(oSession.responseBodyBytes);
            var respBody = oSession.GetResponseBodyAsString();
            respBody = respBody.Substring(respBody.IndexOf("{"));
            respBody = respBody.Substring(0, respBody.LastIndexOf("}") + 1);
            string firstLine = oSession.RequestMethod + " " + oSession.fullUrl + " " + oSession.oRequest.headers.HTTPVersion;
            int at = headers.IndexOf("\r\n");
            if (at < 0)
                return;
            headers = firstLine + "\r\n" + headers.Substring(at + 1);
            var url = oSession.fullUrl.Substring(oSession.fullUrl.IndexOf("actionSymbol") + 13).Replace(".php", "");
            var request = Request.Requests.First(r => r.Url == url);
            {
                dynamic json = JsonConvert.DeserializeObject(respBody);
                if (json != null)
                {
                    var encryptedObject = json[Variable.Encrypted];
                    if (encryptedObject != null)
                    {
                        var encryptedData = encryptedObject[Variable.Data].Value;
                        var decryptedJson = Crypto.Decrypt(encryptedData, request.EncodeKey);
                    }
                }
            }
        }
        private void FiddlerApplication_AfterSessionComplete(Session oSession)
        {
            if (oSession.RequestMethod == "CONNECT")
                return;
            if (oSession == null || oSession.oRequest == null || oSession.oRequest.headers == null)
                return;
            if (!oSession.fullUrl.Contains("actionSymbol"))
                return;
            var time = (int)(DateTime.UtcNow - System.Diagnostics.Process.GetCurrentProcess().StartTime.ToUniversalTime()).TotalMilliseconds;

            string headers = oSession.oRequest.headers.ToString();
            var reqBody = oSession.GetRequestBodyAsString();

            string respHeaders = oSession.oResponse.headers.ToString();
            var respBody = oSession.GetResponseBodyAsString();
            
            string firstLine = oSession.RequestMethod + " " + oSession.fullUrl + " " + oSession.oRequest.headers.HTTPVersion;
            int at = headers.IndexOf("\r\n");
            if (at < 0)
                return;
            headers = firstLine + "\r\n" + headers.Substring(at + 1);

            string output = headers + "\r\n" +
                            (!string.IsNullOrEmpty(reqBody) ? reqBody + "\r\n" : string.Empty) + "\r\n\r\n";
            var url = oSession.fullUrl.Substring(oSession.fullUrl.IndexOf("actionSymbol") + 13).Replace(".php", "");
            var request = Request.Requests.First(r => r.Url == url);

            {
                dynamic json = JsonConvert.DeserializeObject(reqBody);
                var encryptedObject = json[Variable.Encrypted];
                var encryptedData = encryptedObject[Variable.Data].Value;
                var decryptedJson = Crypto.Decrypt(encryptedData, request.EncodeKey);
                var sendpacket = new Packet
                {
                    Time = time,
                    Num = packetCount,
                    Direction = "Send",
                    Url = url,
                    Type = request.Name,
                    EncryptedJson = reqBody,
                    DecryptedJson = decryptedJson,
                };
                packetGrid.BeginInvoke(new Action(() => { people.Add(sendpacket); }));
            }
            {
                dynamic json = JsonConvert.DeserializeObject(respBody);
                if (json != null)
                {
                    var encryptedObject = json[Variable.Encrypted];
                    if (encryptedObject != null)
                    {
                        var encryptedData = encryptedObject[Variable.Data].Value;
                        var decryptedJson = Crypto.Decrypt(encryptedData, request.EncodeKey);
                        var recievepacket = new Packet
                        {
                            Time = time,
                            Num = packetCount++,
                            Direction = "Receive",
                            Url = url,
                            Type = request.Name,
                            EncryptedJson = respBody,
                            DecryptedJson = decryptedJson,
                        };
                        packetGrid.BeginInvoke(new Action(() => { people.Add(recievepacket); }));
                    }
                    else
                    {
                        var errorMsg = json[GameObject.Message]?[Variable.Message];
                        var recievepacket = new Packet
                        {
                            Time = time,
                            Num = packetCount++,
                            Direction = "Receive",
                            Url = url,
                            Type = request.Name,
                            EncryptedJson = errorMsg,
                            DecryptedJson = errorMsg,
                        };
                        packetGrid.BeginInvoke(new Action(() => { people.Add(recievepacket); }));
                    }
                }
            }
        }
        private void MetroWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (FiddlerApplication.IsStarted())
                FiddlerApplication.Shutdown();
        }
        private void PacketGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            encryptedJsonText.Document.Blocks.Clear();
            try
            {
                encryptedJsonText.Document.Blocks.Add(new Paragraph(new Run((packetGrid.SelectedItem as Packet).EncryptedJson.Trim())));
                var decryptedJson = (packetGrid.SelectedItem as Packet).DecryptedJson;
                using (var stringReader = new StringReader(decryptedJson))
                using (var stringWriter = new StringWriter())
                {
                    var jsonReader = new JsonTextReader(stringReader);
                    var jsonWriter = new JsonTextWriter(stringWriter) { Formatting = Formatting.Indented };
                    jsonWriter.WriteToken(jsonReader);
                    decryptedJsonText.Document.Blocks.Clear();
                    decryptedJsonText.Document.Blocks.Add(new Paragraph(new Run(stringWriter.ToString())));
                }
                foreach (var obj in GameObject.GameObjects)
                    decryptedJson = decryptedJson.Replace(obj.Key, obj.Value);
                foreach (var obj in Variable.Variables)
                    decryptedJson = decryptedJson.Replace(obj.Key, obj.Value);
                using (var stringReader = new StringReader(decryptedJson))
                using (var stringWriter = new StringWriter())
                {
                    var jsonReader = new JsonTextReader(stringReader);
                    var jsonWriter = new JsonTextWriter(stringWriter) { Formatting = Formatting.Indented };
                    jsonWriter.WriteToken(jsonReader);
                    gameObjectJsonText.Document.Blocks.Clear();
                    gameObjectJsonText.Document.Blocks.Add(new Paragraph(new Run(stringWriter.ToString())));
                }
                dynamic gameJsonObject = JsonConvert.DeserializeObject(decryptedJson);
                gameObjectView.Items.Clear();
                var tree = Json2Tree(gameJsonObject);
                tree.IsExpanded = true;
                gameObjectView.Items.Add(tree);
            }
            catch { }
        }
        private TreeViewItem Json2Tree(JObject obj)
        {
            var parent = new TreeViewItem
            {
                Header = "Dictionary"
            };
            foreach (var token in obj)
            {
                var child = new TreeViewItem
                {
                    Header = token.Key.ToString()
                };
                if (token.Value.Type.ToString() == "Object")
                {
                    JObject o = (JObject)token.Value;
                    child = Json2Tree(o);
                    parent.Items.Add(child);
                }
                else if (token.Value.Type.ToString() == "Array")
                {
                    int ix = -1;
                    foreach (var itm in token.Value)
                    {
                        if (itm.Type.ToString() == "Object")
                        {
                            var objTN = new TreeViewItem();
                            ix++;
                            var o = (JObject)itm;
                            objTN = Json2Tree(o);
                            objTN.Header = token.Key.ToString() + "[" + ix + "]";
                            child.Items.Add(objTN);
                        }
                        else if (itm.Type.ToString() == "Array")
                        {
                            ix++;
                            var dataArray = new TreeViewItem();
                            foreach (var data in itm)
                            {
                                dataArray.Header = token.Key.ToString() + "[" + ix + "]";
                                dataArray.Items.Add(data.ToString());
                            }
                            child.Items.Add(dataArray);
                        }
                        else
                            child.Items.Add(itm.ToString());
                    }
                    parent.Items.Add(child);
                }
                else
                {
                    child.Header += " = " + token.Value.ToString();
                    parent.Items.Add(child);
                }
            }
            return parent;
        }
    }
}
