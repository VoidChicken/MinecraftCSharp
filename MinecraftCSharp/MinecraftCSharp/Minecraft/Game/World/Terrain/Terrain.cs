using inspire_core;
using inspire_core.API;
using inspire_core.general;
using inspire_core.internals;
using inspire_core.physics;
using inspire_core.renderer;
using inspire_core.resources;
using OpenTK;

namespace Minecraft.Game.World.Terrain
{
    public class Terrain : GameObject
    {

        public Mesh mesh = new Mesh();
        public Texture atlas = new Texture();

        private MeshRenderer meshRenderer;

        public Terrain()
        {
            meshRenderer = AddComponent<MeshRenderer>();
            meshRenderer.mesh = mesh;
            meshRenderer.material = new Material();
            meshRenderer.material.Shader.SetVariable("albedoMap", atlas);
            meshRenderer.material.Shader.SetVariable("albedoColor", Vector4.One);
        }



    }
}
