using inspire_core;
using inspire_core.API;
using inspire_core.general;
using inspire_core.input;
using inspire_core.internals;
using inspire_core.physics;
using inspire_core.renderer;
using inspire_core.resources;
using OpenTK;
using System;

namespace Minecraft.Game.World
{
    public class World : Scene
    {
        public World()
        {

        }

        public override void CInitilize()
        {
            InitilizeWorld();
        }

        #region Temporary Code
        bool mouseLocked = false;
        private void CameraControls()
        {
            
            float mouseX = Input.MousePosition.X;
            float mouseY = Input.MousePosition.Y;

            float rotX = .5f - mouseX;
            float rotY = .5f - mouseY;

            camera.transform.Rotation += new Vector3((rotY * 90), (rotX * 180), 0);
            var v = camera.transform.Rotation;
            v.X = Math.Max(-90, Math.Min(90, v.X));
            camera.transform.Rotation = v;

            if (mouseLocked)
                Input.MousePosition = Vector2.One / 2;



            Cursor.Visible = !mouseLocked;

            if (Input.GetKeyDown(OpenTK.Input.Key.Escape))
                mouseLocked = !mouseLocked;


            Vector3 velocity = new Vector3();

            if (Input.GetKey(OpenTK.Input.Key.W))
                velocity += camera.normal;
            if (Input.GetKey(OpenTK.Input.Key.S))
                velocity -= camera.normal;
            if (Input.GetKey(OpenTK.Input.Key.A))
                velocity -= camera.transform.right;
            if (Input.GetKey(OpenTK.Input.Key.D))
                velocity += camera.transform.right;
            if (Input.GetKey(OpenTK.Input.Key.Q))
                velocity -= camera.transform.up;
            if (Input.GetKey(OpenTK.Input.Key.E))
                velocity += camera.transform.up;

            camera.transform.Position += velocity * Time.Delta * 10;
        }
        #endregion

        public override void DoUpdate()
        {
            CameraControls();
        }

        #region Initilization
        private void InitilizeWorld()
        {
            InitilizeEnvironment();
        }
        
        private void InitilizeEnvironment()
        {
            GameCore.This.Renderer.ClearColor = OpenTK.Graphics.Color4.SkyBlue;
            lightData.ambientIntensity = 1f;
            lightData.ambientColor = OpenTK.Graphics.Color4.White;
            AddObject(new Terrain.Terrain { Name="Terrain" });
        }
        #endregion
    }
}
