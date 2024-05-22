using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjecetsConfigParser
{
    public class PlatformParser
    {
        private Dictionary<string, List<string>> platformDict;

        public PlatformParser(string filePath)
        {
            platformDict = new Dictionary<string, List<string>>();
            ParseFile(filePath);
        }

        private void ParseFile(string filePath)
        {
            // 读取文件的每一行
            string[] lines = File.ReadAllLines(filePath);

            // 解析每一行的平台和机型信息
            foreach (string line in lines)
            {
                string[] parts = line.Split(' ');

                string platform = parts[0].Trim();
                string model = parts[1].Trim();

                // 将平台和机型信息添加到字典中
                if (platformDict.ContainsKey(platform))
                {
                    platformDict[platform].Add(model);
                }
                else
                {
                    platformDict.Add(platform, new List<string> { model });
                }
            }
        }

        public IEnumerable<string> GetAllPlatforms()
        {
            return platformDict.Keys;
        }

        public IEnumerable<string> GetModelsByPlatform(string platform)
        {
            if (platformDict.ContainsKey(platform))
            {
                return platformDict[platform];
            }
            else
            {
                return new List<string>();
            }
        }
    }
}
