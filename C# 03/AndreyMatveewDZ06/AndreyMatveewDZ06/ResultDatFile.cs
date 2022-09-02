using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndreyMatveewDZ06
{
    public class ResultDatFile
    {
        private string path;
        public string Path
        {
            get => path;
            set => path = value;
        }
        public ResultDatFile(string path)
        {
            Path = path;
            Task.Run( () => CreateFile());
        }
        public void CreateFile()
        {
            var results = CheckFiles();
            string dir = String.Concat(Path, "result.dat");
            using (FileStream fs = new FileStream(dir, FileMode.Create))
            {
                StreamWriter writer = new StreamWriter(fs);
                foreach(var el in results)
                {
                    Console.WriteLine($"{el.Key} {el.Value}");
                    writer.WriteLine(Encoding.ASCII.GetBytes($"{el.Key} {el.Value}"));
                }
            }
        }
        private Dictionary<string,string> CheckFiles()
        {
            Dictionary<string, string> fileData = new Dictionary<string, string>();

            DirectoryInfo directoryInfo = new DirectoryInfo(Path);
            var files = directoryInfo.GetFiles("*", SearchOption.AllDirectories);

            Parallel.ForEach(files, (x) =>
            {
                using (StreamReader sr = new StreamReader(x.FullName))
                {
                    fileData.Add(x.Name, Result(sr.ReadLine()));
                }
            });
            return fileData;
        }
        private string Result(string data)
        {
            var numbers = data.Split(' ');
            var res = "";

            if(Convert.ToInt32(numbers[0]) == 1)
            {
                return (Convert.ToDouble(numbers[1]) * Convert.ToDouble(numbers[2])).ToString();
            }

            if (Convert.ToInt32(numbers[0]) == 2)
            {
                return (Convert.ToDouble(numbers[1]) / Convert.ToDouble(numbers[2])).ToString();
            }
            return res;
        }
    }
}
