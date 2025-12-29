using SwarmUI.Core;
using SwarmUI.Utils;

namespace Eugeniusz.Extensions.MobileUIExtension
{
    public class MobileUIExtension : Extension
    {
        public override void OnFirstInit()
        {
            Logs.Info("MobileUIExtension Version 0.1 started.");
            StyleSheetFiles.Add("Assets/mobileUI.css");
            this.Version = "0.1";
            this.ExtensionAuthor = "Eugeniusz-Gienek";
            this.License = "MIT";
            this.Description = "Mobile-friendly UI";
            var list = new List<string> { "UI" };
            this.Tags = list.ToArray();
        }

        public override void OnInit()
        {
        }
    }
}
