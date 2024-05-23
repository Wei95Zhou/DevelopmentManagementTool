using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjecetsConfigParser
{
    public class PlatformInfo
    {
        public string Name { get; set; }
        public List<ModelInfo> Models { get; set; } = new List<ModelInfo>();
    }

    public class ModelInfo
    {
        public string Name { get; set; }
        public string ResponsiblePerson { get; set; }
    }

    public class FileParser
    {
        private Dictionary<string, List<ModelInfo>> platformModels = new Dictionary<string, List<ModelInfo>>();

        public FileParser(string filePath)
        {
            ParseFile(filePath);
        }

        public List<string> GetAllPlatforms()
        {
            return platformModels.Keys.ToList();
        }

        public List<ModelInfo> GetModelsByPlatform(string platform)
        {
            if (platformModels.ContainsKey(platform))
            {
                return platformModels[platform];
            }
            else
            {
                return new List<ModelInfo>();
            }
        }

        public string GetResponsiblePerson(string platform, string model)
        {
            if (platformModels.ContainsKey(platform))
            {
                var modelInfo = platformModels[platform].FirstOrDefault(m => m.Name.Equals(model, StringComparison.OrdinalIgnoreCase));
                return modelInfo?.ResponsiblePerson;
            }
            return null;
        }

        private void ParseFile(string filePath)
        {
            foreach (string line in File.ReadLines(filePath))
            {
                string[] parts = line.Split(' ');
                if (parts.Length >= 3)
                {
                    string platformName = parts[0];
                    string modelName = parts[1];
                    string responsiblePerson = parts[2];

                    if (!platformModels.ContainsKey(platformName))
                    {
                        platformModels[platformName] = new List<ModelInfo>();
                    }

                    platformModels[platformName].Add(new ModelInfo { Name = modelName, ResponsiblePerson = responsiblePerson });
                }
            }
        }
    }



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
                string owner = parts[2].Trim();

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
