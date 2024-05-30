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

    public class PlatformParser
    {
        private Dictionary<string, List<ModelInfo>> platformModels = new Dictionary<string, List<ModelInfo>>();

        public PlatformParser(string filePath)
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

        public List<string> GetAllResponsiblePersons()
        {
            List<string> allResponsiblePersons = new List<string>();
            foreach (var platform in platformModels.Values)
            {
                foreach (var model in platform)
                {
                    allResponsiblePersons.Add(model.ResponsiblePerson);
                }
            }
            return allResponsiblePersons.Distinct().ToList();
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
}
