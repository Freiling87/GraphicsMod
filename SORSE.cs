using System.IO;

using BepInEx;
using BepInEx.Logging;
using RogueLibsCore;
using UnityEngine;

namespace SORHD
{
    [BepInPlugin(pluginGuid, pluginName, pluginVersion)]
    [BepInProcess("StreetsOfRogue.exe")]
    [BepInDependency("abbysssal.streetsofrogue.roguelibs", "2.0")]

    public class GraphicsMod : BaseUnityPlugin
    {
        public const string pluginGuid = "community.streetsofrogue.sors";
        public const string pluginName = "Streets of Rogue Sprite Editor";
        public const string pluginVersion = "1.0";

        public static ManualLogSource ConsoleMessage;

        public void Awake()
        {
            Log("Loaded " + pluginName + " " + pluginVersion);

            DirectoryInfo dir = new DirectoryInfo(@"C:\Steam\steamapps\common\Streets of Rogue\BepInEx\Plugins\Sprites");

            DirectoryInfo dirBody = dir.CreateSubdirectory("Body");
            DirectoryInfo dirBodyG = dir.CreateSubdirectory("BodyG");
            DirectoryInfo dirEyes = dir.CreateSubdirectory("Eyes");
            DirectoryInfo dirFacialHair = dir.CreateSubdirectory("FacialHair");
            DirectoryInfo dirFloor = dir.CreateSubdirectory("Floor");
            DirectoryInfo dirHair = dir.CreateSubdirectory("Hair");
            DirectoryInfo dirHead = dir.CreateSubdirectory("Head");
            DirectoryInfo dirHeadPieces = dir.CreateSubdirectory("HeadPieces");
            DirectoryInfo dirItem = dir.CreateSubdirectory("Item");
            DirectoryInfo dirObject = dir.CreateSubdirectory("Object");
            DirectoryInfo dirWall = dir.CreateSubdirectory("Wall");

            LoadSpritesFrom(dirBody, SpriteScope.Extra);
            LoadSpritesFrom(dirBodyG, SpriteScope.Extra);
            LoadSpritesFrom(dirEyes, SpriteScope.Extra);
            LoadSpritesFrom(dirFacialHair, SpriteScope.Extra);
            LoadSpritesFrom(dirFloor, SpriteScope.Extra);
            LoadSpritesFrom(dirHair, SpriteScope.Extra);
            LoadSpritesFrom(dirHead, SpriteScope.Extra);
            LoadSpritesFrom(dirHeadPieces, SpriteScope.Extra);
            LoadSpritesFrom(dirItem, SpriteScope.Items);
            LoadSpritesFrom(dirObject, SpriteScope.Objects);
            LoadSpritesFrom(dirWall, SpriteScope.Extra);
        }
        public void LoadSpritesFrom(DirectoryInfo directory, SpriteScope scope)
        {
            foreach (FileInfo file in directory.EnumerateFiles())
            {
                Log("Loaded Sprite: " + file.Name);

                string name = Path.GetFileNameWithoutExtension(file.ToString());
                byte[] raw = File.ReadAllBytes(file.ToString());
                Rect region = new Rect(0, 0, 64, 64);
                float ppu = 64f;

                RogueLibs.AddCustomSprite(name, scope, raw, region, ppu);
            }
        }
        public static void Log(string logMessage) =>
            ConsoleMessage.LogMessage(logMessage);
    }
}