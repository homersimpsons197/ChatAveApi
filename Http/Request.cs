using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Chat_Avenue.Http
{
    internal class Request
    {
        //Class
        Form1 f;
        Data.DataSet ds;
        Http.Api api;

        //Array
        Data.DataSet[] userArr;
        Data.DataSet[] urlArr;

        public Request(Form1 f, Data.DataSet ds, Http.Api api)
        {
            this.f = f;
            this.ds = ds;
            this.api = api;
        }

        public void Init(string[] accArr, string[] proxArr, bool a, bool b, bool c, bool d, bool e, bool f)
        {
            userArr = ds.User(accArr, proxArr);
            urlArr = ds.Url(a, b, c, d, e, f);
            Public();
        }

        public void Public()
        {
            for(int i = 0; i < userArr.Length; i++)
            {
                for(int j = 0; j < urlArr.Length; j++)
                {
                    if (urlArr[j] != null)
                    {
                        api.Login(urlArr[j].client, urlArr[j].login, userArr[i].user, userArr[i].proxy, userArr[i].ua);
                        api.Info(urlArr[j].client);
                        f.rtxtLog.Text += "User: " + userArr[i].user + " Proxy: " + userArr[i].proxy;
                        api.PublicMsg(urlArr[j].client, urlArr[j].roomMsg, ds.RoomMsg());                        
                    }
                }
            }
        }
    }
}
