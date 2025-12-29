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
        }

        public override void OnInit()
        {
        }
    }
}