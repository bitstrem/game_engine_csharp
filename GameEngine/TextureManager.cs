using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;
using OpenTK.Graphics.OpenGL;
using GameEngine;

namespace GameEngine
{
    public class TextureManager : IDisposable
    {
        Dictionary<string, Texture> _texutreDatabase = new Dictionary<string, Texture>();

        public Texture Get(string textureId)
        {
            return _texutreDatabase[textureId];
        }

        public void Dispose()
        {
            foreach (Texture t in _texutreDatabase.Values)
            {
            }
        }

        public void LoadTexture(string textureId, string path)
        {
            if (String.IsNullOrEmpty(path))
            {
                System.Diagnostics.Debug.Assert(false, "Could not open file, [" + path + "].");
            }

            path = "../../" + path; 
            try
            {
                int id = GL.GenTexture();
                GL.BindTexture(TextureTarget.Texture2D, id);

                Bitmap bmp = new Bitmap(path);
                BitmapData bmp_data = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height), ImageLockMode.ReadOnly, System.Drawing.Imaging.PixelFormat.Format32bppArgb);

                GL.TexImage2D(TextureTarget.Texture2D, 0, PixelInternalFormat.Rgba, bmp_data.Width, bmp_data.Height, 0,
                    OpenTK.Graphics.OpenGL.PixelFormat.Bgra, PixelType.UnsignedByte, bmp_data.Scan0);

                bmp.UnlockBits(bmp_data);

                int width = bmp.Width;
                int height = bmp.Height;

                // We haven't uploaded mipmaps, so disable mipmapping (otherwise the texture will not appear).
                // On newer video cards, we can use GL.GenerateMipmaps() or GL.Ext.GenerateMipmaps() to create
                // mipmaps automatically. In that case, use TextureMinFilter.LinearMipmapLinear to enable them.
                GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMinFilter, (int)TextureMinFilter.Linear);
                GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMagFilter, (int)TextureMagFilter.Linear);

                _texutreDatabase.Add(textureId, new Texture(id, width, height));
            }
            catch (Exception e)
            {
                Console.Write(e.ToString()); 
            }

        }
    }
}
