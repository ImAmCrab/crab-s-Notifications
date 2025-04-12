using StupidTemplate.Classes;
using StupidTemplate.Mods;
using StupidTemplate.Notifications;
using static StupidTemplate.Settings;

namespace StupidTemplate.Menu
{
    internal class Buttons
    {
        public static ButtonInfo[][] buttons = new ButtonInfo[][]
        {
            new ButtonInfo[] { // Main Mods
                new ButtonInfo { buttonText = "Clear Past Notifactions", method =() => NotifiLib.ClearAllNotifications(), isTogglable = false, toolTip = "Clears All Notifactions."},
            },
        };
    }
}
