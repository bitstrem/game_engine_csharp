using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenTK.Graphics.OpenGL; 
using System.Runtime.InteropServices; 

namespace GameEngine
{
    public class Renderer
    {
        public Renderer()
        {
            GL.Enable(EnableCap.Texture2D);

            //Enable alpha blending
            //GL.Enable(EnableCap.Blend);
            GL.BlendFunc(BlendingFactorSrc.SrcAlpha, BlendingFactorDest.OneMinusSrcAlpha); 
        }

        public void DrawImmidiateModeVertex(Vector position, Color color, Point uvs)
        {
            GL.Color4(color.Red, color.Green, color.Blue, color.Alpha);
            GL.TexCoord2(uvs.X, uvs.Y);
            //GL.Color4(System.Drawing.Color.Aquamarine); 
            GL.Vertex3(position.X, position.Y, position.Z); 

            ////Veiw port size; 
            //double height = 200;
            //double width = 200;
            //double halfHeight = height / 2;
            //double halfWidth = height / 2;

            ////Sprite location
            //double x = 450;
            //double y = 450;
            //double z = 0;

            //float topUV = 0;
            //float bottomUV = 1;
            //float leftUV = 0;
            //float rightUV = 1;
            //GL.TexCoord2(leftUV, topUV);
            //GL.Vertex3(x - halfHeight, y + halfHeight, z); // top left
            //GL.TexCoord2(rightUV, topUV);
            //GL.Vertex3(x + halfWidth, y + halfHeight, z); // top right
            //GL.TexCoord2(leftUV, bottomUV);
            //GL.Vertex3(x - halfWidth, y - halfHeight, z); // bottom left

            //GL.TexCoord2(rightUV, topUV);
            //GL.Vertex3(x + halfWidth, y + halfHeight, z); // top right 
            //GL.TexCoord2(rightUV, bottomUV);
            //GL.Vertex3(x + halfWidth, y - halfHeight, z); // bottom right
            //GL.TexCoord2(leftUV, bottomUV);
            //GL.Vertex3(x - halfWidth, y - halfHeight, z); // bottom left
        }

        public void DrawSprite(Sprite sprite)
        {
            GL.Begin(BeginMode.Triangles);
            {
                for (int i = 0; i < Sprite.VertexAmount; i++)
                {
                    GL.BindTexture(TextureTarget.Texture2D, sprite.Texture.Id);
                    DrawImmidiateModeVertex(
                        sprite.VectorPositions[i],
                        sprite.VertexColors[i],
                        sprite.VertexUVs[i]); 
                }
            }
            GL.End(); 
        }
    }
}
