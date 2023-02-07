using Microsoft.VisualBasic.ApplicationServices;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Chat_Avenue.Http
{
    internal class Api
    {
        //Class
        Form1 f;
        Data.TextFormat tf;

        //Restsharp classes
        public static RestClientOptions options;
        public static RestClient client;
        public static RestRequest request;
        public static RestResponse response;

        //Regex class
        Regex filter, filter2, filter3, slash;

        //List
        List<string> str;
        public static List<string> inboxList = new List<string>();
        public static List<string> privList = new List<string>();
        public static List<string> manPrivList = new List<string>();

        //String
        public static string pass = "Ocean%4010";
        public static string cookies;
        public static string token;
        public static string snum;
        public static string pcount;
        public static string room;
        public static string mlast;
        public static string cact;
        public static string priv;
        public static string nnotif;
        public static string chatlogsDir;

        public Api(Form1 f, Data.TextFormat tf)
        {
            this.f = f;
            this.tf = tf;
        }

        public void Login(string urlClient, string urlLogin, string user, string proxy, string ua)
        {
            try
            {
                options = new RestClientOptions(urlClient)
                {
                    Proxy = new WebProxy(proxy),
                    UserAgent = ua,
                    FollowRedirects = true,
                };
                client = new RestClient(options);

                request = new RestRequest(urlLogin, Method.Post);
                request.AddHeader("Connection", "keep-alive");
                var body = $@"password={pass}&username={user}";
                request.AddParameter("application/x-www-form-urlencoded", body, ParameterType.RequestBody);
                response = client.Execute(request);

                cookies = client.CookieContainer.GetCookieHeader(new Uri(urlClient));

                string code = response.StatusCode.ToString();

                f.rtxtLog.Text += "User: " + user + " Proxy: " + proxy + " login " + code + "\n";
            }
            catch (Exception ex)
            {

            }
        }

        public void Info(string urlClient)
        {
            try
            {
                request = new RestRequest(urlClient, Method.Get);
                request.AddHeader("Cookie", cookies);
                response = client.Get(request);

                cookies = client.CookieContainer.GetCookieHeader(new Uri(urlClient));

                string code = response.StatusCode.ToString();

                str = response.Content.Split('\n').ToList();

                filter = new Regex(@"(utk = ')(.*?')");

                foreach (var line in str)
                {
                    Match match = filter.Match(line);
                    if (match.Success)
                    {
                        token = match.ToString().Replace("utk = '", "").Replace("'", "");
                    }
                }

                filter = new Regex(@"(snum = "")(.*?"")");

                foreach (var line in str)
                {
                    Match match = filter.Match(line);
                    if (match.Success)
                    {
                        snum = match.ToString().Replace("snum = \"", "").Replace("\"", "");
                    }
                }

                filter = new Regex(@"(pCount = "")(.*?"")");

                foreach (var line in str)
                {
                    Match match = filter.Match(line);
                    if (match.Success)
                    {
                        pcount = match.ToString().Replace("pCount = \"", "").Replace("\"", "");
                    }
                }

                filter = new Regex(@"(user_room =)(.*?;)");

                foreach (var line in str)
                {
                    Match match = filter.Match(line);
                    if (match.Success)
                    {
                        room = match.ToString().Replace("user_room =", "").Replace(";", "");
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }

        public void Inbox(string urlClient, string urlInbox)
        {
            try
            {
                request = new RestRequest(urlInbox, Method.Post);
                request.AddHeader("cookie", cookies);
                var body = $@"token={token}";
                request.AddParameter("application/x-www-form-urlencoded", body, ParameterType.RequestBody);
                response = client.Execute(request);

                cookies = client.CookieContainer.GetCookieHeader(new Uri(urlClient));

                str = response.Content.Split('\n').ToList();

                filter = new Regex(@"(div data="")(.*?"")");

                foreach (var line in str)
                {
                    Match match = filter.Match(line);
                    if (match.Success)
                    {
                        priv = match.ToString().Replace("div data=\"", "").Replace("\"", "");
                        privList.Add(priv);
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }

        public void Users(string urlClient, string urlUsers)
        {
            try
            {
                request = new RestRequest(urlUsers, Method.Post);
                request.AddHeader("Cookie", cookies);
                var body = $@"token={token}";
                request.AddParameter("application/x-www-form-urlencoded", body, ParameterType.RequestBody);
                response = client.Execute(request);

                cookies = client.CookieContainer.GetCookieHeader(new Uri(urlClient));

                str = response.Content.Split('\n').ToList();

                foreach (var line in str)
                {
                    filter = new Regex(@"(dropUser)(.*?'Male')");
                    foreach (Match match in filter.Matches(line))
                    {
                        manPrivList.Add(match.Value);
                    }
                }
                foreach (var user in manPrivList)
                {
                    filter = new Regex(@"(this)(.*?,')");
                    foreach (Match match in filter.Matches(user))
                    {
                        string id = match.Value.Replace("this,", "").Replace(",'", "");
                        manPrivList.Add(id);
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }

        public void PublicMsg(string urlClient, string urlMsg, string msg)
        {
            try
            {
                request = new RestRequest(urlMsg, Method.Post);
                request.AddHeader("Cookie", cookies);
                var body = $@"content={msg}&snum={snum}&token={token}";
                request.AddParameter("application/x-www-form-urlencoded", body, ParameterType.RequestBody);
                response = client.Execute(request);

                cookies = client.CookieContainer.GetCookieHeader(new Uri(urlClient));

                string code = response.StatusCode.ToString();

                f.rtxtLog.Text += "\nRoomMsg: " + msg + " Status: " + code + "\n     ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++     ";
            }
            catch (Exception ex)
            {

            }
        }

        public void PM(string urlClient, string urlPm, string msg)
        {
            try
            {
                request = new RestRequest(urlPm, Method.Post);
                request.AddHeader("cookie", cookies);
                var body = $@"target={priv}&content={msg}&token={token}";
                request.AddParameter("application/x-www-form-urlencoded", body, ParameterType.RequestBody);
                response = client.Execute(request);

                cookies = client.CookieContainer.GetCookieHeader(new Uri(urlClient));
                string code = response.StatusCode.ToString();
            }
            catch (Exception ex)
            {

            }
        }

        public void BulkPM(string urlClient, string urlPm, string msg)
        {
            try
            {
                foreach (var _priv in manPrivList)
                {
                    var request = new RestRequest(urlPm, Method.Post);

                    request.AddHeader("cookie", cookies);

                    var body = $@"target={_priv}&content={msg}&token={token}";
                    request.AddParameter("application/x-www-form-urlencoded", body, ParameterType.RequestBody);
                    response = client.Execute(request);

                    cookies = client.CookieContainer.GetCookieHeader(new Uri(urlClient));

                    string code = response.StatusCode.ToString();
                }
            }
            catch (Exception ex)
            {

            }
        }

        public void ChatLog()
        {
            try
            {
                request = new RestRequest("https://adultchat.chat-avenue.com/system/chat_log.php", Method.Post);
                request.AddHeader("Cookie", cookies);

                var body = $@"fload=0&caction=0&last=0&snum={snum}&preload=0&priv=0&lastp=0&pcount={pcount}&room={room}&notify={nnotif}&token={token}";
                request.AddParameter("application/x-www-form-urlencoded", body, ParameterType.RequestBody);
                response = client.Execute(request);

                cookies = client.CookieContainer.GetCookieHeader(new Uri("https://adultchat.chat-avenue.com/"));

                str = response.Content.Split('\n').ToList();

                filter = new Regex(@"(mlast"":"")(.*?"")");

                foreach (var line in str)
                {

                    Match match = filter.Match(line);
                    if (match.Success)
                    {
                        mlast = match.ToString().Replace("mlast\":\"", "").Replace("\"", "");
                    }
                }

                filter = new Regex(@"(cact"":"")(.*?"")");

                foreach (var line in str)
                {

                    Match match = filter.Match(line);
                    if (match.Success)
                    {
                        cact = match.ToString().Replace("cact\":\"", "").Replace("\"", "");
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }

        public void ChatLogPriv(string urlClient, string urlChatlog, string user)
        {
            try
            {
                foreach (var _priv in privList)
                {
                    request = new RestRequest("https://adultchat.chat-avenue.com/system/chat_log.php", Method.Post);
                    request.AddHeader("Cookie", cookies);
                    var body = $@"fload=1&caction={cact}&last={mlast}&snum={snum}&preload=1&priv={_priv}&lastp=0&pcount={pcount}&room={room}&notify={nnotif}&token={token}";
                    request.AddParameter("application/x-www-form-urlencoded", body, ParameterType.RequestBody);
                    response = client.Execute(request);

                    inboxList.Add(response.Content);

                    int _cact = Convert.ToInt32(cact);
                    int _mlast = Convert.ToInt32(cact);
                    _cact++;
                    _mlast++;
                    cact = _cact.ToString();
                    mlast = _mlast.ToString();
                }

                string chatlogsDir = $@"{f.Dir} + /{tf.UrlDecode(user)}";                
                string idTextFile = "";
                bool picSent = false;

                if (!Directory.Exists(chatlogsDir))
                {
                    Directory.CreateDirectory(chatlogsDir);
                }

                cookies = client.CookieContainer.GetCookieHeader(new Uri("https://adultchat.chat-avenue.com/"));

                int dataCounter = 0;

                foreach (var id in inboxList)
                {
                    filter = new Regex(@"(curp"":"")(.*?"")");
                    foreach (Match match in filter.Matches(id))
                    {
                        string userId = match.Value.Replace("curp\":\"", "").Replace("\"", "");
                        if (!File.Exists(chatlogsDir + $@"\{userId}.txt"))
                        {
                            idTextFile = chatlogsDir + $@"\{userId}.txt";
                            File.Create(idTextFile).Dispose();
                        }

                        picSent = false;

                        filter2 = new Regex(@"(target_private\\"">)(.*?<)");
                        foreach (Match match2 in filter2.Matches(id))
                        {
                            string msg = match2.Value.ToString().Replace("target_private\\\">", "").Replace("<", "");
                            using (var sw = File.AppendText(idTextFile))
                            {
                                sw.WriteLine("Message: " + msg + "\n");
                                sw.Close();
                            }

                            filter3 = new Regex(@"(upload)(.+?(gif|jpg|bmp|png))", RegexOptions.IgnoreCase);
                            foreach (Match match3 in filter3.Matches(id))
                            {
                                //if (!File.Exists(chatlogsDir + $@"\{userId}pic{picCounter}.txt"))
                                //{
                                //    picTextFile = chatlogsDir + $@"\{userId}pic{picCounter}.txt";
                                //    File.Create(picTextFile).Dispose();
                                //}
                                string rawPicUrl = match3.Value.ToString().Replace("\\/", "/");
                                string picUrl = urlClient + rawPicUrl;
                                if(picSent == false)
                                {
                                    if (!picUrl.Contains("gif"))
                                    {
                                        using (var sw = File.AppendText(idTextFile))
                                        {
                                            picSent = true;
                                            sw.WriteLine("Message: " + picUrl + "\n");
                                            sw.Close();
                                        }
                                    }
                                }
                                
                            }
                        }

                        dataCounter++;
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }

        public void DelMsg(string urlDelMsg, string privId)
        {
            try
            {
                foreach (var _priv in privList)
                {
                    if (_priv.Equals(privId))
                    {
                        request = new RestRequest(urlDelMsg, Method.Post);
                        request.AddHeader("cookie", cookies);
                        var body = $@"private_delete={_priv}&token={token}";
                        request.AddParameter("application/x-www-form-urlencoded", body, ParameterType.RequestBody);
                        response = client.Execute(request);
                    }

                }

            }
            catch (Exception ex)
            {

            }
        }

        public void ChatBot()
        {

        }
    }
}
