using System;
using System.Collections.Generic;
using System.Net.Http;
using System.IO;
using System.Net;
using System.Text;

namespace HHY
{
    public static class AccessToken

    {
        // 百度云中开通对应服务应用的 API Key 建议开通应用的时候多选服务
        private static String clientId = "PKOerg4AozcINOnwCnDlkHzG";
        // 百度云中开通对应服务应用的 Secret Key
        private static String clientSecret = "yrkdy5nSD90tEWNnTGhyDViutLjyAA";

        public static String getAccessToken()
        {
            String authHost = "https://aip.baidubce.com/oauth/2.0/token";
            HttpClient client = new HttpClient();
            List<KeyValuePair<String, String>> paraList = new List<KeyValuePair<string, string>>();
            paraList.Add(new KeyValuePair<string, string>("grant_type", "client_credentials"));
            paraList.Add(new KeyValuePair<string, string>("client_id", clientId));
            paraList.Add(new KeyValuePair<string, string>("client_secret", clientSecret));

            HttpResponseMessage response = client.PostAsync(authHost, new FormUrlEncodedContent(paraList)).Result;
            String result = response.Content.ReadAsStringAsync().Result;
            Console.WriteLine(result);
            return result;
        }
            // 人脸对比
        public static string faceMatch(string image_a,string image_b)
        {
            string token = getAccessToken();
            string host = "https://aip.baidubce.com/rest/2.0/face/v3/match?access_token=" + token;
            Encoding encoding = Encoding.Default;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(host);
            request.Method = "post";
            request.KeepAlive = true;
            String str = "[{\"image\": \"" + image_a + "\", \"image_type\": \"BASE64\", \"face_type\": \"LIVE\", \"quality_control\": \"LOW\"},{\"image\": \"" + image_b + "\", \"image_type\": \"BASE64\", \"face_type\": \"IDCARD\", \"quality_control\": \"LOW\"}]";
            byte[] buffer = encoding.GetBytes(str);
            request.ContentLength = buffer.Length;
            request.GetRequestStream().Write(buffer, 0, buffer.Length);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.Default);
            string result = reader.ReadToEnd();
            Console.WriteLine("人脸对比:");
            Console.WriteLine(result);
            return result;
        }
    }
}