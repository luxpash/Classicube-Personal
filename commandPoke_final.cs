//  Auto-generated command skeleton class.
//  Use this as a basis for custom MCGalaxy commands.
//  File and class should be named a specific way. For example, /update is named 'CmdUpdate.cs' for the file, and 'CmdUpdate' for the class.
// As a note, MCGalaxy is designed for .NET 4.0

// To reference other assemblies, put a "//reference [assembly filename]" at the top of the file
//   e.g. to reference the System.Data assembly, put "//reference System.Data.dll"

// Add any other using statements you need after this
using System;

namespace MCGalaxy.Commands.Chatting
{
    public class CmdPoke : MessageCmd
    {
        // The command's name (what you put after a slash to use this command)
        public override string name { get { return "Poke"; } }

        // Command's shortcut, can be left blank (e.g. "/Copy" has a shortcut of "c")
        //public override string shortcut { get { return ""; } }

        // Which submenu this command displays in under /Help
        //public override string type { get { return "other"; } } //later see if typeget works instead

        // Whether or not this command can be used in a museum. Block/map altering commands should return false to avoid errors.
        public override bool museumUsable { get { return true; } }

        // The default rank required to use this command. Valid values are:
        //   LevelPermission.Guest, LevelPermission.Builder, LevelPermission.AdvBuilder,
        //   LevelPermission.Operator, LevelPermission.Admin, LevelPermission.Nobody
        public override LevelPermission defaultRank { get { return LevelPermission.Guest; } }

        // This is for when a player executes this command by doing /Poke
        //   p is the player object for the player executing the command. 
        //   message is the arguments given to the command. (e.g. for '/update this', message is "this")
        public override void Use(Player p, string message, CommandData data)
        {
            if (message.Length == 0) { Help(p); return; }
            string[] args = message.SplitSpaces();
            string pokeType = null;

            if (args.Length > 1)
            {
                args[1] = args[1].ToLower();
                if (args[1] == "gentle" || args[1] == "friendly" || args[1] == "creepy")
                    pokeType = args[1];
            }
            if (pokeType == null) { TryMessageAction(p, args[0], "λNICK &Spoked λTARGET", false); return; }
            TryMessageAction(p, args[0], "λNICK $Sgave λTARGET &Sa " + pokeType + " poke", false);
        }

        // This is for when a player does /Help Poke
        public override void Help(Player p)
        {
            p.Message("&T/Poke [player]."); //Try with and without the &t to see what happens?
            p.Message("&HValid types are &fgentle, friendly and creepy.");
            p.Message("&HSpecifying no type or a non-existent type results in a normal poke.");
        }
    }
}