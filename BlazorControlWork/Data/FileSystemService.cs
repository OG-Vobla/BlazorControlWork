using MongoDB.Driver;
using MongoDB.Driver.GridFS;

namespace BlazorControlWork.Data
{
    public class FileSystemService
    {
        public void UploadImageToDb(string path, User user)
        {
            var client = new MongoClient();
            var database = client.GetDatabase("ControlWorkDB");
            var gridFS = new GridFSBucket(database);

            using ( FileStream fs = new FileStream(path, FileMode.Open))
            {
                gridFS.UploadFromStream($"{user.Login}.jpg", fs);
            }
        }

        public void DownloadToLocal()
        {
            var client = new MongoClient();
            var database = client.GetDatabase("ControlWorkDB");
            var gridFS = new GridFSBucket(database);
            using (FileStream fs = new FileStream($"{Directory.CreateDirectory(Directory.GetCurrentDirectory() + "/Images/")}DeserializedBall.jpg", FileMode.CreateNew))
            {
                gridFS.DownloadToStreamByName("sss.jpg", fs);
            }
        }
    }
}
