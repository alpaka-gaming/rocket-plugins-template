using Rocket.API.Collections;
using Rocket.Core.Logging;
using Rocket.Core.Plugins;

namespace Rocket.Plugins.Template
{
    public class Plugin : RocketPlugin<Config>
    {
        public Plugin()
        {
            name = "Template";
            Instance = this;
            Config = Instance.Configuration.Instance;
        }

        internal static Plugin Instance;
        internal static Config Config;

        protected override void Load()
        {
            Logger.Log($"[{name}] Successfully Loaded!");
            Instance.Configuration.Save();
        }

        protected override void Unload()
        {
            Logger.Log($"[{name}] Successfully Unloaded!");
        }

        public override TranslationList DefaultTranslations
        {
            get
            {
                return new TranslationList()
                {
                    {"template_help_message", "" }
                };
            }
        }
    }
}