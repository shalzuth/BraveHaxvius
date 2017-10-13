using System;
using System.Collections.Specialized;
using System.IO;
using System.Net;
using System.Text;
using System.Web;

namespace BraveHaxvius
{
    public class Facebook
    {
        public String Id = "";
        public String AccessToken = "";
        CookieContainer cookies = new CookieContainer();
        String UserAgent = "Mozilla/5.0 (iPhone; CPU iPhone OS 10_2_1 like Mac OS X) AppleWebKit/602.4.6 (KHTML, like Gecko) Version/10.0 Mobile/14D27 Safari/602.1";
        String FacebookUrl = "https://www.facebook.com";
        String LoginUrl = "https://www.facebook.com/login.php?login_attempt=1";
        String AuthorizeUrl = "https://m.facebook.com/v2.8/dialog/oauth?redirect_uri=fb1238083776220999%3A%2F%2Fauthorize%2F&display=touch&state={\"challenge\"%3A\"PpE4heBTCHXuTR3ApSdBb98PSLY%3D\"%2C\"0_auth_logger_id\"%3A\"3146F93F-25AA-4F98-902D-923988CFCCA2\"%2C\"com.facebook.sdk_client_state\"%3Atrue%2C\"3_method\"%3A\"sfvc_auth\"}&scope=user_friends&response_type=token%2Csigned_request&default_audience=friends&return_scopes=true&auth_type=rerequest&client_id=1238083776220999&ret=login&sdk=ios&fbapp_pres=0&logger_id=3146F93F-25AA-4F98-902D-923988CFCCA2";
        String ConfirmUrl = "https://m.facebook.com/v2.8/dialog/oauth/confirm";
        String AcceptUrl = "https://m.facebook.com/v2.8/dialog/oauth/read";
        String UserIdUrl = "https://graph.facebook.com/v2.8/me?access_token=AccessToken&debug=info&fields=id%2Cname%2Cemail&format=json&include_headers=false&sdk=ios";
        String RecoveryUrl = "https://m.facebook.com/login/checkpoint";
        public Boolean TwoFactorAuth = false;
        String loginHtml = "";
        public Facebook()
        {
        }
        public void Login(String email, String password)
        {
            cookies.Add(new CookieCollection());
            var get = GetData(FacebookUrl);
            var loginHtml = PostData(LoginUrl, String.Format("email={0}&pass={1}", email, password));
            if (loginHtml.Contains("checkpointSubmitButton"))
                TwoFactorAuth = true;
        }
        public void FinishTwoFactorAuth(String recoveryCode)
        {
            var code = Console.ReadLine();
            var tokenSearch = "\"dtsg\":{\"token\":\"";
            var token = loginHtml.Substring(loginHtml.IndexOf(tokenSearch) + tokenSearch.Length);
            token = token.Substring(0, token.IndexOf("\""));
            var nhSearch = "name=\"nh\" value=\"";
            var nh = loginHtml.Substring(loginHtml.IndexOf(nhSearch) + nhSearch.Length);
            nh = nh.Substring(0, nh.IndexOf("\""));
            NameValueCollection parameters = HttpUtility.ParseQueryString(String.Empty);
            parameters.Add("fb_dtsg", token);
            parameters.Add("checkpoint_data", "");
            parameters.Add("approvals_code", code);
            parameters.Add("codes_submitted", "1");
            parameters.Add("submit[Submit Code]", "Submit Code");
            parameters.Add("nh", nh);
            var p = parameters.ToString();
            var recovery = PostData(RecoveryUrl, p);
            parameters = HttpUtility.ParseQueryString(String.Empty);
            parameters.Add("fb_dtsg", token);
            parameters.Add("checkpoint_data", "");
            parameters.Add("name_action_selected", "dont_save");
            parameters.Add("submit[Continue]", "Continue");
            parameters.Add("nh", nh);
            p = parameters.ToString();
            var dontsavedevice = PostData(RecoveryUrl, p);
            var login = GetData("https://m.facebook.com/home.php");
        }
        public void AllowFFBE()
        {
            var confirmHtml = GetData(AuthorizeUrl);
            var accessTokenHtml = PostData(ConfirmUrl, GetConfirmTable(confirmHtml));
            try
            {
                AccessToken = GetAccessToken(accessTokenHtml);
            }
            catch
            {
                accessTokenHtml = PostData(AcceptUrl, GetConfirmTable(confirmHtml));
                AccessToken = GetAccessToken(accessTokenHtml);
            }
            var userIdHtml = GetData(UserIdUrl.Replace("AccessToken", AccessToken));
            Id = GetId(userIdHtml);
        }
        String GetConfirmTable(String html)
        {
            html = html.Substring(html.IndexOf("id=\"platformDialogForm\""));
            html = html.Substring(0, html.IndexOf("button"));
            NameValueCollection parameters = HttpUtility.ParseQueryString(String.Empty);
            while (html.Contains("name"))
            {
                html = html.Substring(html.IndexOf("name=") + 6);
                var field = html.Substring(0, html.IndexOf("\""));
                var value = "";
                if (html.Contains("value") && html.IndexOf("value") < html.IndexOf("name="))
                {
                    html = html.Substring(html.IndexOf("value=") + 7);
                    value = html.Substring(0, html.IndexOf("\""));
                }
                parameters.Add(field, value);
            }
            return parameters.ToString();
        }
        String GetAccessToken(String html)
        {
            var token = html.Substring(html.IndexOf("access_token=") + 13);
            token = token.Substring(0, token.IndexOf("&expires"));
            return token;
        }
        String GetId(String html)
        {
            var id = html.Substring(html.IndexOf(": \"") + 3);
            id = id.Substring(0, id.IndexOf("\""));
            return id;
        }
        String GetData(String url)
        {
            return PostData(url, null);
        }
        String PostData(String url, String data)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.CookieContainer = cookies;
            request.UserAgent = UserAgent;
            request.ContentType = "application/x-www-form-urlencoded";
            if (data != null)
            {
                request.Method = WebRequestMethods.Http.Post;
                byte[] byteArray = Encoding.ASCII.GetBytes(data);
                request.ContentLength = byteArray.Length;
                using (Stream requestStream = request.GetRequestStream())
                    requestStream.Write(byteArray, 0, byteArray.Length);
            }
            String html = "";
            using (StreamReader streamReader = new StreamReader((request.GetResponse() as HttpWebResponse).GetResponseStream()))
                html = streamReader.ReadToEnd();
            cookies = request.CookieContainer;
            return html;
        }
    }
}