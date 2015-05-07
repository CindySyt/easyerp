namespace EasyErp.Core.Configuration
{
    using System;
    using System.Configuration;
    using System.Xml;

    /// <summary>
    /// Represents a EasyErpConfig
    /// </summary>
    public class EasyErpConfig : IConfigurationSectionHandler
    {
        /// <summary>
        /// In addition to configured assemblies examine and load assemblies in the bin directory.
        /// </summary>
        public bool DynamicDiscovery { get; private set; }

        public string EngineType { get; private set; }

        /// <summary>
        /// Specifices where the themes will be stored (~/Themes/)
        /// </summary>
        public string ThemeBasePath { get; private set; }

        /// <summary>
        /// Indicates whether we should ignore startup tasks
        /// </summary>
        public bool IgnoreStartupTasks { get; private set; }

        /// <summary>
        /// Path to database with user agent strings
        /// </summary>
        public string UserAgentStringsPath { get; private set; }

        /// <summary>
        /// Creates a configuration section handler.
        /// </summary>
        /// <param name="parent">Parent object.</param>
        /// <param name="configContext">Configuration context object.</param>
        /// <param name="section">Section XML node.</param>
        /// <returns>The created section handler object.</returns>
        public object Create(object parent, object configContext, XmlNode section)
        {
            var config = new EasyErpConfig();
            var dynamicDiscoveryNode = section.SelectSingleNode("DynamicDiscovery");
            if (dynamicDiscoveryNode != null &&
                dynamicDiscoveryNode.Attributes != null)
            {
                var attribute = dynamicDiscoveryNode.Attributes["Enabled"];
                if (attribute != null)
                {
                    config.DynamicDiscovery = Convert.ToBoolean(attribute.Value);
                }
            }

            var engineNode = section.SelectSingleNode("Engine");
            if (engineNode != null &&
                engineNode.Attributes != null)
            {
                var attribute = engineNode.Attributes["Type"];
                if (attribute != null)
                {
                    config.EngineType = attribute.Value;
                }
            }

            var startupNode = section.SelectSingleNode("Startup");
            if (startupNode != null &&
                startupNode.Attributes != null)
            {
                var attribute = startupNode.Attributes["IgnoreStartupTasks"];
                if (attribute != null)
                {
                    config.IgnoreStartupTasks = Convert.ToBoolean(attribute.Value);
                }
            }

            var themeNode = section.SelectSingleNode("Themes");
            if (themeNode != null &&
                themeNode.Attributes != null)
            {
                var attribute = themeNode.Attributes["basePath"];
                if (attribute != null)
                {
                    config.ThemeBasePath = attribute.Value;
                }
            }

            var userAgentStringsNode = section.SelectSingleNode("UserAgentStrings");
            if (userAgentStringsNode != null &&
                userAgentStringsNode.Attributes != null)
            {
                var attribute = userAgentStringsNode.Attributes["databasePath"];
                if (attribute != null)
                {
                    config.UserAgentStringsPath = attribute.Value;
                }
            }

            return config;
        }
    }
}