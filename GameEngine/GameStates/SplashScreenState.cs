using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using OpenTK.Graphics.OpenGL;

namespace GameEngine
{
    class SplashScreenState : IGameObject
    {
        StateSystem _system;
        double _delayInSeconds = 3; 

        public SplashScreenState(StateSystem system)
        {
            _system = system; 
        }

        #region IGameObject Members
        public void Update(double elapsedTime)
        {
            _delayInSeconds -= elapsedTime;
            if (_delayInSeconds <= 0) 
            {
                _delayInSeconds = 3;      
                _system.ChangeState("title_menu"); 
                System.Console.WriteLine("Updating Splash");
            }
        }

        public void Render()
        {
            GL.ClearColor(System.Drawing.Color.SkyBlue);
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            System.Console.WriteLine("Rendering Splash");
        }
        #endregion
    }
}
