using MongoDB.Bson;
using MongoDB.Driver;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace videoMongo
{
    class Program
    {
        static void Main(string[] args)
        {
            string targetName = "D2301", startName = "D1-1", fileName = Guid.NewGuid().ToString(); // Parametrelerimizi giriyoruz
            var procInfoUnity = new ProcessStartInfo(Environment.CurrentDirectory +@"\PathProgram\pathprog.exe"); // programın nerede oldğunu belirtiyoruz
            procInfoUnity.Arguments = "\"" + targetName + "\" \"" + startName + "\" \"" + fileName + "\""; // Parametreleri yolu bulancak programa göderiyoruz
            var unityProc = Process.Start(procInfoUnity); // Programı başlatıyoruz
            unityProc.EnableRaisingEvents = true;
            procInfoUnity.UseShellExecute = false;
            unityProc.WaitForExit(); // Video tamamlanıp program kapanana kadar bekliyoruz

			string documentPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var selectedVideo = "";
            var videoPath = documentPath + @"\MapPathFinding\Video\"; // pathprog'ın (diğer program) video'yu kaydettiği yer
            var videos = Directory.GetFiles(videoPath); // O yerdeki tüm videolar çekiyoruz
            selectedVideo = videos.FirstOrDefault((x) => x.Contains(fileName)); // bizim videoyu buluyoruz

            var db = new MongoClient().GetDatabase("videoDB");
            string _id =  PushDatabase(db, selectedVideo); //Server'da çalışacak, server video _id'yi geri gönderecek

            GetVideoFromDatabase(db, _id); // Kiosk'ta çalışacak
        }
        public static void GetVideoFromDatabase(IMongoDatabase db,string _id)
        {
            var videoDocuments = db.GetCollection<VideoDocument>(typeof(VideoDocument).Name);     
            var filter = new BsonDocument { { "_id", _id } };
            var current = videoDocuments.FindOneAndDelete(filter); // databaseden verilen id'ye göre video buluyoruz sonra onu veritabanından siliyoruz
            File.WriteAllBytes("tes2t.mp4", current.Video); // byte dizisini  mp4 e çevirip göstereceğiz  
        }

        public static string PushDatabase(IMongoDatabase db,string fileName)
        {
            var videoDocuments = db.GetCollection<VideoDocument>(typeof(VideoDocument).Name);
            var _video = new byte[16777216]; // En fazla 16 mb olacak şekilde videomuzu byte dizisine çevirip
            var file = File.Open(fileName, FileMode.Open);
            var size = new FileInfo(fileName).Length;
            if (size < 16777216)
            {
                using (var theReader = new BinaryReader(file))
                {
                    _video = theReader.ReadBytes((int)file.Length);
                }
            }
            VideoDocument vd = new VideoDocument(_video);
            videoDocuments.InsertOne(vd); // veri tabanına yazıyoruz
            return vd._id;
        }
    }
}
