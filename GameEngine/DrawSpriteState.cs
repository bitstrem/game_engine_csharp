using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using OpenTK.Graphics.OpenGL; 
using GameEngine;

public class DrawSpriteState : IGameObject

{
     TextureManager _textureManger;

    public DrawSpriteState(TextureManager textureManager)
    {
        _textureManger = textureManager; 
    }
    public void Update(double elapsedTime)
    {
    }

    public void Render()
    {
        //Veiw port size; 
        double height = 200;
        double width = 200;
        double halfHeight = height / 2;
        double halfWidth = height / 2;

        //Sprite location
        double x = 0;
        double y = 0;
        double z = 0;

        float topUV = 0;
        float bottomUV = 1;
        float leftUV = 0;
        float rightUV = 1;

        float red = 1;
        float green = 0;
        float blue = 0;
        float alpha = 0.3f; 

        Texture texture = _textureManger.Get("face_alpha");
        GL.Enable(EnableCap.Texture2D);
        GL.BindTexture(TextureTarget.Texture2D, texture.Id);

        //Enable alpha blending
        GL.Enable(EnableCap.Blend);
        GL.BlendFunc(BlendingFactorSrc.SrcAlpha, BlendingFactorDest.OneMinusSrcAlpha); 

        GL.ClearColor(System.Drawing.Color.Black);
        GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

        //Quad for sprites
        GL.Begin(BeginMode.Triangles);
        {
            GL.Color4(red, green, blue, alpha); 
            GL.TexCoord2(leftUV, topUV);
            GL.Vertex3(x - halfHeight, y + halfHeight, z); // top left
            GL.TexCoord2(rightUV, topUV); 
            GL.Vertex3(x + halfWidth, y + halfHeight, z); // top right
            GL.TexCoord2(leftUV, bottomUV); 
            GL.Vertex3(x - halfWidth, y - halfHeight, z); // bottom left

            GL.TexCoord2(rightUV, topUV); 
            GL.Vertex3(x + halfWidth, y + halfHeight, z); // top right 
            GL.TexCoord2(rightUV, bottomUV); 
            GL.Vertex3(x + halfWidth, y - halfHeight, z); // bottom right
            GL.TexCoord2(leftUV, bottomUV); 
            GL.Vertex3(x - halfWidth, y - halfHeight, z); // bottom left

        }
        GL.End(); 
    }
}
