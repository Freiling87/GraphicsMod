using System.IO;

using BepInEx;
using RogueLibsCore;
using UnityEngine;

namespace SORHD
{
    [BepInPlugin("community.streetsofrogue.SORHD", "SOR HD", "1.0")]
    [BepInProcess("StreetsOfRogue.exe")]

    public class GraphicsMod
    {
        public void Awake()
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:\Program Files (x86)\Steam\steamapps\common\Streets of Rogue\BepInEx\Plugins\Sprites");

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
                string name = Path.GetFileNameWithoutExtension(file.ToString());
                byte[] raw = File.ReadAllBytes(file.ToString());
                Rect region = new Rect(0, 0, 64, 64);
                float ppu = 64f;

                RogueLibs.AddCustomSprite(name, scope, raw, region, ppu);
            }
        }
    }
}