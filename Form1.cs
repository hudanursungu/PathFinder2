using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PathFindGui
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
            LbFilter.Items.AddRange(LIST);
        }
        string[] LIST = { "D2301", "D2302", "D2303", "D2304", "D2305", "D2306", "D2307", "D2308", "D2309", "D2310", "D2311", "D2312", "D2313", "D2314", "D2315",
             "D2401", "D2402", "D2403", "D2404", "D2405", "D2406", "D2407", "D2408", "D2409", "D2410", "D2411", "D2412", "D2413", "D2414", "D2415"

        ,"KOFİS-1","KOFİS-2","KOFİS-3","KOFİS-6","KOFİS-7","KOFİS-8","KOFİS-9","KOFİS-10","KOFİS-11","KOFİS-12","KOFİS-13","KOFİS-14","KOFİS-15","KOFİS-16"
        ,"BlueCircle"};
        private void TbFilter_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
              
            }
        }

        private void TbFilter_TextChanged(object sender, EventArgs e)
        {
            LbFilter.Items.Clear();
            var tempList = LIST.Where(x => x.ToLower().Contains(TbFilter.Text.ToLower())).ToArray();
            LbFilter.Items.AddRange(tempList);
        }

        private void LbFilter_Click(object sender, EventArgs e)
        {
            AsyncClient client = new AsyncClient();
            client.StartConnecting();
            string targetName = (sender as ListBox).SelectedItem.ToString();
            string startName = "D23-KIOSK-1", fileName = Guid.NewGuid().ToString();
            var viewType = Convert.ToInt32(!RbTopDown.Checked);
            string responsedId = client.SendToServer($"_{targetName}_{startName}_{fileName}_{viewType}");
            GetVideoFromDatabase(responsedId);
        }
        static readonly string server_username = "ohm";
        static readonly string server_password = "741895623ohm";
        static readonly string server_host = "35.204.174.37";
        static readonly int server_port = 8953;
        static readonly string database_name = "cool_db";
        private static IMongoClient Client = new MongoClient($"mongodb://{server_username}:{server_password}@{server_host}:{server_port}/{database_name}");
        private static IMongoDatabase _database = Client.GetDatabase(database_name);

        public  void GetVideoFromDatabase(string _id)
        {
            axWindowsMediaPlayer1.close();
           var videoDocuments = _database.GetCollection<VideoDocument>(typeof(VideoDocument).Name);
            var filter = new BsonDocument { { "_id", _id } };
            var current = videoDocuments.FindOneAndDelete(filter); // databaseden verilen id'ye göre video buluyoruz sonra onu veritabanından siliyoruz
            File.WriteAllBytes("newVid.mp4", current.Video); // byte dizisini  mp4 e çevirip göstereceğiz  
            StartVideo("newVid.mp4");
        }

        public  void StartVideo(string videoPath)
        {
            axWindowsMediaPlayer1.URL = videoPath;
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void RbTopDown_CheckedChanged(object sender, EventArgs e)
        {
            RbFirstPersonView.Checked = !RbTopDown.Checked;
        }

        private void RbFirstPersonView_CheckedChanged(object sender, EventArgs e)
        {
            RbFirstPersonView.Checked = !RbTopDown.Checked;
        }

        private void LbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
