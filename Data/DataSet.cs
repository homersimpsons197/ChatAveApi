using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat_Avenue.Data
{
    public class DataSet
    {
        DataSet[] reqArr = new DataSet[6];
        DataSet[] userArr;

        public string user;
        public string proxy;
        public string ua;

        public string channel;
        public string client;
        public string login;
        public string roomMsg;
        public string users;
        public string inbox;
        public string pm;
        public string delMsg;
        public string chatLog;

        public DataSet[] Url(bool adultClicked, bool collegeClicked, bool singleClicked, bool datingClicked, bool generalClicked, bool sexClicked)
        {
            if (adultClicked)
            {
                reqArr[0] = new DataSet();
                reqArr[0].channel = "adultchat";
                reqArr[0].client = "https://adultchat.chat-avenue.com/";
                reqArr[0].login = "https://adultchat.chat-avenue.com/system/encoded/login.php";
                reqArr[0].roomMsg = "https://adultchat.chat-avenue.com/system/chat_process.php";
                reqArr[0].users = "https://adultchat.chat-avenue.com/system/panel/user_list.php";
                reqArr[0].inbox = "https://adultchat.chat-avenue.com/system/box/private_notify.php";
                reqArr[0].pm = "https://adultchat.chat-avenue.com/system/private_process.php";
                reqArr[0].delMsg = "https://adultchat.chat-avenue.com/system/encoded/action_chat.php";
                reqArr[0].chatLog = "https://adultchat.chat-avenue.com/system/chat_log.php";
            }
            
            if (collegeClicked)
            {
                reqArr[1] = new DataSet();
                reqArr[1].channel = "college";
                reqArr[1].client = "https://www.chat-avenue.com/college/";
                reqArr[1].login = "https://www.chat-avenue.com/college/system/encoded/login.php";
                reqArr[1].roomMsg = "https://www.chat-avenue.com/college/system/chat_process.php";
                reqArr[1].users = "https://www.chat-avenue.com/college/system/panel/user_list.php";
                reqArr[1].inbox = "https://www.chat-avenue.com/college/system/box/private_notify.php";
                reqArr[1].pm = "https://www.chat-avenue.com/college/system/private_process.php";
                reqArr[1].delMsg = "https://www.chat-avenue.com/college/system/encoded/action_chat.php";
                reqArr[1].chatLog = "https://www.chat-avenue.com/college/system/chat_log.php";
            }
            
            if (singleClicked)
            {
                reqArr[2] = new DataSet();
                reqArr[2].channel = "single";
                reqArr[2].client = "https://www.chat-avenue.com/single/";
                reqArr[2].login = "https://www.chat-avenue.com/single/system/encoded/login.php";
                reqArr[2].roomMsg = "https://www.chat-avenue.com/single/system/chat_process.php";
                reqArr[2].users = "https://www.chat-avenue.com/single/system/panel/user_list.php";
                reqArr[2].inbox = "https://www.chat-avenue.com/single/system/box/private_notify.php";
                reqArr[2].pm = "https://www.chat-avenue.com/single/system/private_process.php";
                reqArr[2].delMsg = "https://www.chat-avenue.com/single/system/encoded/action_chat.php";
                reqArr[2].chatLog = "https://www.chat-avenue.com/single/system/chat_log.php";
            }
            
            if (datingClicked)
            {
                reqArr[3] = new DataSet();
                reqArr[3].channel = "dating";
                reqArr[3].client = "https://www.chat-avenue.com/dating/";
                reqArr[3].login = "https://www.chat-avenue.com/dating/system/encoded/login.php";
                reqArr[3].roomMsg = "https://www.chat-avenue.com/dating/system/chat_process.php";
                reqArr[3].users = "https://www.chat-avenue.com/dating/system/panel/user_list.php";
                reqArr[3].inbox = "https://www.chat-avenue.com/dating/system/box/private_notify.php";
                reqArr[3].pm = "https://www.chat-avenue.com/dating/system/private_process.php";
                reqArr[3].delMsg = "https://www.chat-avenue.com/dating/system/encoded/action_chat.php";
                reqArr[3].chatLog = "https://www.chat-avenue.com/dating/system/chat_log.php";
            }
            
            if (generalClicked)
            {
                reqArr[4] = new DataSet();
                reqArr[4].channel = "general";
                reqArr[4].client = "https://www.chat-avenue.com/general/";
                reqArr[4].login = "https://www.chat-avenue.com/general/system/encoded/login.php";
                reqArr[4].roomMsg = "https://www.chat-avenue.com/general/system/chat_process.php";
                reqArr[4].users = "https://www.chat-avenue.com/general/system/panel/user_list.php";
                reqArr[4].inbox = "https://www.chat-avenue.com/general/system/box/private_notify.php";
                reqArr[4].pm = "https://www.chat-avenue.com/general/system/private_process.php";
                reqArr[4].delMsg = "https://www.chat-avenue.com/general/system/encoded/action_chat.php";
                reqArr[4].chatLog = "https://www.chat-avenue.com/general/system/chat_log.php";
            }
            
            if (sexClicked)
            {
                reqArr[5] = new DataSet();
                reqArr[5].channel = "sex";
                reqArr[5].client = "https://www.chat-avenue.com/sex/";
                reqArr[5].login = "https://www.chat-avenue.com/sex/system/encoded/login.php";
                reqArr[5].roomMsg = "https://www.chat-avenue.com/sex/system/chat_process.php";
                reqArr[5].users = "https://www.chat-avenue.com/sex/system/panel/user_list.php";
                reqArr[5].inbox = "https://www.chat-avenue.com/sex/system/box/private_notify.php";
                reqArr[5].pm = "https://www.chat-avenue.com/sex/system/private_process.php";
                reqArr[5].delMsg = "https://www.chat-avenue.com/sex/system/encoded/action_chat.php";
                reqArr[5].chatLog = "https://www.chat-avenue.com/sex/system/chat_log.php";
            }
            
            return reqArr;
        }

        public DataSet[] User(string[] accArr, string[] proxArr)
        {
            userArr = new DataSet[accArr.Length];

            for(int i = 0; i < accArr.Length; i++)
            {
                userArr[i] = new DataSet();
                userArr[i].user = accArr[i];
                userArr[i].proxy = proxArr[i];
                userArr[i].ua = UserAgent();
            }

            return userArr;
        }

        public string UserAgent()
        {
            string userAgent = "";
            
            Random rand = new Random();
            int randUa = rand.Next(0, 10);

            switch (randUa)
            {
                case 0:
                    userAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/106.0.0.0 Safari/537.36";
                    break;
                case 1:
                    userAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:105.0) Gecko/20100101 Firefox/105.0";
                    break;
                case 2:
                    userAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/105.0.0.0 Safari/537.36";
                    break;
                case 3:
                    userAgent = "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_15_7) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/106.0.0.0 Safari/537.36";
                    break;
                case 4:
                    userAgent = "Mozilla/5.0 (X11; Linux x86_64; rv:105.0) Gecko/20100101 Firefox/105.0";
                    break;
                case 5:
                    userAgent = "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_15_7) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/105.0.0.0 Safari/537.36";
                    break;
                case 6:
                    userAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:106.0) Gecko/20100101 Firefox/106.0";
                    break;
                case 7:
                    userAgent = "Mozilla/5.0 (Macintosh; Intel Mac OS X 10.15; rv:105.0) Gecko/20100101 Firefox/105.0";
                    break;
                case 8:
                    userAgent = "Mozilla/5.0 (Windows NT 10.0; rv:105.0) Gecko/20100101 Firefox/105.0";
                    break;
                case 9:
                    userAgent = "Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/106.0.0.0 Safari/537.36";
                    break;
            }

            return userAgent;
        }

        public string RoomMsg()
        {
            string msg = "";

            Random rand = new Random();

            string[] arr0 = new string[10] { "hi all", "hii all", "hi", "hiii", "hello", "hello ppl", "hey", "hey there", "hi guys", "good day" };
            int r = rand.Next(0, 10);
            msg += arr0[r] + ",";
            r = rand.Next(0, 2);
            if (r == 0)
            {              
                string[] arr1 = new string[10] { "im f usa w big tits", "f nyc big tits", "who love big tits?", "im in nyc", "f usa seeking male around nyc", "girl in usa here", "big tits ny", "i got big tits", "female usa in here", "im f nyc" };
                r = rand.Next(0, 10);
                msg += " " + arr1[r];
            }
            r = rand.Next(0, 2);
            if (r == 0)
            {
                string[] arr2 = new string[10] { "some guys wanna chat?", "pm?", "inbox?", "man down to chat?", "pm chat?", "chat?", "want men from usa", "is there males around nyc?", "anyone to chat?", "seeking sexy man" };
                r = rand.Next(0, 10);
                msg += " " + arr2[r];
            }

            char last = msg[msg.Length - 1];
            if (last.Equals(','))
            {
                msg = msg.Replace(",", "");
            }

            return msg;
        }
    }
}
