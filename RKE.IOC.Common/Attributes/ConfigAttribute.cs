using RKE.IOC.Common.Attributes.Abstract;

namespace RKE.IOC.Common.Attributes
{
    public class ConfigAttribute : BaseIoCAttribute
    {
        public string ConfigSectionName { get; set; }
        public string ConfigPath { get; set; }

        public ConfigAttribute(string configsection)
        {
            ConfigSectionName = configsection;
        }

        public ConfigAttribute(string configsection, string configPath)
        {
            ConfigSectionName = configsection;
            ConfigPath = configPath;
        }

        public ConfigAttribute()
        {

        }
    }
}