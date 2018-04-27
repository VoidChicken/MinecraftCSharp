using inspire_core;
using inspire_core.API;
using inspire_core.general;
using inspire_core.internals;
using inspire_core.physics;
using inspire_core.renderer;
using inspire_core.resources;
using System.Drawing;

namespace Minecraft.Game
{
    public class Game : IGame
    {
        public Game()
        {

        }

        public override void Initilize()
        {
            InitilizeWindow();
            LoadGame();
        }
        
        private void LoadGame()
        {
            Scene.LoadScene(new World.World());
        }

        private void InitilizeWindow()
        {
            GameCore.This.window.Title = "Minecraft";

            #region Icon

            Bitmap icon = LoadManager.resourceManager.GetImageResource("window/favicon.png");
            Icon dIcon = Icon.FromHandle(icon.GetHicon());
            GameCore.This.window.Icon = dIcon;

            #endregion
        }
    }
}
