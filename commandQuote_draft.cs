//  Auto-generated command skeleton class.
//  Use this as a basis for custom MCGalaxy commands.
//  File and class should be named a specific way. For example, /update is named 'CmdUpdate.cs' for the file, and 'CmdUpdate' for the class.
// As a note, MCGalaxy is designed for .NET 4.0

// To reference other assemblies, put a "//reference [assembly filename]" at the top of the file
//   e.g. to reference the System.Data assembly, put "//reference System.Data.dll"

// Add any other using statements you need after this
using System;
using System.IO;
using MCGalaxy;

namespace MCGalaxy.Commands.Info
{
    public class CmdQuotes : Command
    {
        // The command's name (what you put after a slash to use this command)
        public override string name { get { return "Quote"; } }

        // Command's shortcut, can be left blank (e.g. "/Copy" has a shortcut of "c")
        public override string shortcut { get { return ""; } }

        // Which submenu this command displays in under /Help
        public override string type { get { return "information"; } }

        // Whether or not this command can be used in a museum. Block/map altering commands should return false to avoid errors.
        public override bool museumUsable { get { return true; } }

        // The default rank required to use this command. Valid values are:
        //   LevelPermission.Guest, LevelPermission.Builder, LevelPermission.AdvBuilder,
        //   LevelPermission.Operator, LevelPermission.Admin, LevelPermission.Nobody
        public override LevelPermission defaultRank { get { return LevelPermission.Guest; } }

        // This is for when a player executes this command by doing /Poke
        //   p is the player object for the player executing the command. 
        //   message is the arguments given to the command. (e.g. for '/update this', message is "this")
        public override void Use(Player p, string message)
        {
            p.Message("Hello World!");
        }

        // This is for when a player does /Help Poke
        public override void Help(Player p)
        {
            p.Message("/Poke - Does stuff. Example command.");
        }
    }
}