using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using OpenTK.Graphics.OpenGL; 

namespace GameEngine
{
    class TitleMenuState : IGameObject
    {
        StateSystem _system;
        double _currentRotation = 0; 
        public TitleMenuState(StateSystem system)
        {
            _system = system; 
        }

        #region IGameObject Members
        public void Update(double elapsedTime)
        {
            //System.Console.WriteLine("Updating Title Menu");
            _currentRotation = 10 * elapsedTime; 
        }

        public void Render()
        {
            //System.Console.WriteLine("Rendering Title Menu");
            GL.ClearColor(System.Drawing.Color.SkyBlue);
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            GL.Rotate(_currentRotation, 1, 1, 0); 
            GL.Begin(BeginMode.TriangleStrip);
            {
                GL.Color4(1.0, 0.0, 0.0, 0.5);
                GL.Vertex3(-50, 0, 0);
                GL.Color3(0.0, 1.0, 0.0);
                GL.Vertex3(50, 0, 0);
                GL.Color3(0.0, 0.0, 1.0);
                GL.Vertex3(0, 50, 0); 
            }
            GL.End();
            GL.Finish();
        }
        #endregion
    }
}
