using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OpenTK.Graphics.OpenGL; 

namespace GameEngine
{
    public partial class Form1 : Form
    {
        FastLoop _fastLoop; 
        bool _fullscreen = false;
        bool _loaded = false;
        StateSystem _system = new StateSystem();
        private TextureManager _textureManager = new TextureManager(); 

        public Form1()
        {
            _fastLoop = new FastLoop(GameLoop);
            InitializeComponent();
            //_openGLControl.InitializeLifetimeService();

            if (_fullscreen)
            {
                FormBorderStyle = FormBorderStyle.None;
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                ClientSize = new Size(1280, 720); 

            }
 

        }

        void GameLoop(double elapsedTime)
        {
            _system.Update(elapsedTime);
            _system.Render();
            _openGLControl.SwapBuffers();
        }

        void Setup2DGraphics(double width, double height)
        {
            double halfWidth = width / 2;
            double halfHeight = height / 2;
            
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity();
            GL.Ortho(-halfWidth, halfWidth, -halfHeight, halfHeight, -100, 100);
            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadIdentity();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void _openGLControl_Load(object sender, EventArgs e)
        {
            _loaded = true;
            Setup2DGraphics(this.ClientSize.Width, this.ClientSize.Height);
            _textureManager.LoadTexture("face", "face.bmp");
            _textureManager.LoadTexture("face_alpha", "face_alpha.tif"); 

            _system.AddState("splash", new SplashScreenState(_system)); 
            _system.AddState("title_menu", new TitleMenuState(_system));
            _system.AddState("sprite_test", new DrawSpriteState(_textureManager));
            _system.AddState("sprite_class_test", new TestSpriteClassState(_textureManager)); 

            _system.ChangeState("sprite_class_test");
           
        }

        private void _openGLControl_Resize(object sender, EventArgs e)
        {
            if (!_loaded)
                return; 
        }

        private void _openGLControl_Paint(object sender, PaintEventArgs e)
        {
            if (!_loaded) // Play nice
                return;

            //GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            //_openGLControl.SwapBuffers();
      
        }

        protected override void OnClientSizeChanged(EventArgs e)
        {
            base.OnClientSizeChanged(e);
            _openGLControl.Width = this.ClientSize.Width;
            _openGLControl.Height = this.ClientSize.Height;
            if (_loaded)
            {
                Setup2DGraphics(this.ClientSize.Width, this.ClientSize.Height);
            }
           
        }
    }
}
