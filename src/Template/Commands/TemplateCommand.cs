using Rocket.API;
using System.Collections.Generic;

namespace Rocket.Plugins.Template.Commands
{
    public class TemplateCommand : IRocketCommand
    {
        public string Name => "template";
        public string Syntax { get { return ""; } }
        public string Help => Plugin.Instance.Translate("template_help_message");

        public List<string> Aliases { get { return new List<string>(); } }
        public List<string> Permissions { get { return new List<string>(); } }

        public AllowedCaller AllowedCaller { get { return AllowedCaller.Both; } }

        public void Execute(IRocketPlayer caller, string[] command)
        {
        }
    }
}