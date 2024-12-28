using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gamecube_ISO_Organizer.UserControls
{
    public static class SharedFunctions
    {
        public static string GetID(this byte[] bytes)
        {
            using (MemoryStream stream = new MemoryStream(bytes))
            {
                using (StreamReader streamReader = new StreamReader(stream))
                {
                    Char[] c = new char[112]; //Sets a max amount of characters
                    streamReader.Read(c, 0, c.Length); //Reads bytes into characters
                    string charString = new string(c); //Makes string from characters

                    var gameID = charString.Substring(0, 6); //Make GameID from first 6 bytes
                    gameID = "[" + gameID + "]"; //Formats GameID

                    var gameLabel = charString.Substring(32, charString.Length - 32); //make GameLabel
                    gameLabel.TrimEnd(); //Trim spaces off of the end

                    gameLabel = string.Join("", gameLabel.Split(Path.GetInvalidFileNameChars()));

                    var game = gameLabel + " " + gameID;

                    return game;
                }
            }
        }


    }
}
