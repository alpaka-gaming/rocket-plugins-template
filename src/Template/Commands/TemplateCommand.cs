using Rocket.API;
using System.Collections.Generic;

namespace Rocket.Plugins.Template.Commands
{
    public class TemplateCommand : IRocketCommand
    {
        public string Name => "template";
        public string Syntax => "";
        public string Help => Plugin.Instance.Translate("template_help_message");

        public List<string> Aliases => new List<string>();
        public List<string> Permissions => new List<string>();

        public AllowedCaller AllowedCaller => AllowedCaller.Both;

        public void Execute(IRocketPlayer caller, string[] command)
        {
        }
    }
}