using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace RpgGameApp.CharacterClasses
{
    class FileManager
    {

        // vrati settings folder
        private static String SettingsFolder
        {
            get
            {
                // create a string folder
                string folder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                //add a subfolder
                folder = Path.Combine(folder, "RPG Project");
                folder = Path.Combine(folder, "CharacterSettings");
                if (!Directory.Exists(folder))
                {
                    Directory.CreateDirectory(folder);
                }

                return folder;
            }
        }

        //vrati settings fajl...
        private static String PlayerSettingsFile
        {
            get
            {
                return Path.Combine(SettingsFolder, "Player.xml");
            }
        }

        private static Player DefaultPlayer
        {
            get
            {
                return new Player
                {
                    Name = "",
                    Gender = EntityGender.Unknown,
                    CharacterClass = EntityClass.Unknown,
                    Dexterity = 0,
                    Health = 0,
                    Strength = 0
                };
            }
        }   //ovo smo reimenovali...

        public static Player LoadPlayer()
        {
            if (!File.Exists(PlayerSettingsFile))
            {
                return DefaultPlayer;
            }

            using (Stream stream = File.OpenRead(PlayerSettingsFile))
            {
                XmlSerializer ser = new XmlSerializer(typeof(Player));
                return (Player)ser.Deserialize(stream);
            }
        }

        public static void StoreCharacter(Player player)
        {
            using (Stream stream = File.Create(PlayerSettingsFile))
            {
                XmlSerializer ser = new XmlSerializer(player.GetType());
                ser.Serialize(stream, player);
            }
        }

    }
}
