using System.IO;
using System.Xml.Linq;

namespace Chat_Avenue
{
    public partial class Form1 : Form
    {
        //Classes
        Data.TextFormat tf;
        Data.DataSet ds;
        Http.Api api;
        Http.Request req;

        //Array
        public static string[] fileArr;
        public static string[] accArr;
        public static string[] proxArr;
        public static string[] msgArr;
        public static string[] pmArr;
        
        //String
        public static string strDir;

        //Bool
        public static bool adultClicked;
        public static bool collegeClicked;
        public static bool singleClicked;
        public static bool datingClicked;
        public static bool generalClicked;
        public static bool sexClicked;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tf = new Data.TextFormat();
            ds = new Data.DataSet();
            api = new Http.Api(this, tf);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            req.Init(accArr, proxArr, adultClicked,collegeClicked, singleClicked, datingClicked, generalClicked, sexClicked);
        }

        private void btnDir_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    strDir = fbd.SelectedPath;
                    txtDir.Text = strDir;
                    fileArr = Directory.GetFiles(fbd.SelectedPath);

                    for (int i = 0; i < fileArr.Length; i++)
                    {
                        if (fileArr[i].Contains("acc"))
                        {
                            lblAcc.ForeColor = Color.Green;
                            accArr = File.ReadAllLines(fileArr[i]).ToArray();
                            accArr = tf.UrlEncode(accArr);
                        }
                        else if (fileArr[i].Contains("prox"))
                        {
                            lblProx.ForeColor = Color.Green;
                            proxArr = File.ReadAllLines(fileArr[i]);
                        }                       
                    }
                }
            }
        }

        private void chAdult_CheckedChanged(object sender, EventArgs e)
        {
            adultClicked = !adultClicked;

            if (adultClicked)
            {
                chAdult.ForeColor = Color.Green;
            }
            else if (!adultClicked)
            {
                chAdult.ForeColor = Color.Red;
            }
        }

        private void chCollege_CheckedChanged(object sender, EventArgs e)
        {
            collegeClicked = !collegeClicked;

            if (collegeClicked)
            {
                chCollege.ForeColor = Color.Green;
            }
            else if (!collegeClicked)
            {
                chCollege.ForeColor = Color.Red;
            }
        }

        private void chSingle_CheckedChanged(object sender, EventArgs e)
        {
            singleClicked = !singleClicked;

            if (singleClicked)
            {
                chSingle.ForeColor = Color.Green;
            }
            else if (!singleClicked)
            {
                chSingle.ForeColor = Color.Red;
            }
        }

        private void chDating_CheckedChanged(object sender, EventArgs e)
        {
            datingClicked = !datingClicked;

            if (datingClicked)
            {
                chDating.ForeColor = Color.Green;
            }
            else if (!datingClicked)
            {
                chDating.ForeColor = Color.Red;
            }
        }

        private void chGeneral_CheckedChanged(object sender, EventArgs e)
        {
            generalClicked = !generalClicked;

            if (generalClicked)
            {
                chGeneral.ForeColor = Color.Green;
            }
            else if (!generalClicked)
            {
                chGeneral.ForeColor = Color.Red;
            }
        }

        private void chSex_CheckedChanged(object sender, EventArgs e)
        {
            sexClicked = !sexClicked;

            if (sexClicked)
            {
                chSex.ForeColor = Color.Green;
            }
            else if (!sexClicked)
            {
                chSex.ForeColor = Color.Red;
            }
        }

        public string Dir
        {
            get { return strDir; }
        }

    }
}