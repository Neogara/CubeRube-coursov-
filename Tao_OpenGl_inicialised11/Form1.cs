using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


using Tao.OpenGl;
using Tao.FreeGlut;
using Tao.Platform.Windows;

using System.Xml;



namespace Tao_OpenGl_inicialised11
{
    
    public partial class Form1 : Form
    {
        public class RecType
        {
            public RecType(String _Name, Time _RecTime)
            {
                Name = _Name;
                RecMin = _RecTime.MinuteTime;
                RecSec = _RecTime.SecondsTime;
                RecMilleSec = _RecTime.MilleSecondsTime;

            }
            public RecType(String _Name, int _RecMin, int _RecSec, int _RecMilleSec)
            {
                Name = _Name;
                RecMin = _RecMin;
                RecSec = RecSec;
                RecMilleSec = _RecMilleSec;

            }
            public RecType()
            {
                Name = "No name";
                RecMin = 0;
                RecSec = 0;
                RecMilleSec = 0;
            }

            public String Name;
            public int RecMin;
            public int RecSec;
            public int RecMilleSec;

        }
        public class ClassCube
        {
            public int IntName { get; set; }
            public double RotationAngleX { get; set; }
            public double RotationAngleY { get; set; }
            public double RotationAngleZ { get; set; }
            public float AlphaColor { get; set; }
            public float[] Vertex { get; set; }
            public float[][] ColorCube { get; set; }

            public ClassCube(int _IntName, float AngleX, float AngleY, float AngleZ, float _AlphaColor)
            {
                IntName = _IntName;
                RotationAngleX = AngleX;
                RotationAngleY = AngleY;
                RotationAngleZ = AngleZ;
                AlphaColor = _AlphaColor;
                Vertex = new float[4];
                ColorCube = new float[7][];
            }
            public ClassCube()
            {

            }
            public void SetRotation(float AngleX, float AngleY, float AngleZ)
            {
                RotationAngleX = AngleX;
                RotationAngleY = AngleY;
                RotationAngleZ = AngleZ;
            }
            public void SetObjectCube(float X, float Y, float Z, float[] Color1, float[] Color2, float[] Color3, float[] Color4, float[] Color5, float[] Color6, float _AlphaColor)
            {
                Vertex[1] = X;
                Vertex[2] = Y;
                Vertex[3] = Z;

                ColorCube[1] = Color1;
                ColorCube[2] = Color2;
                ColorCube[3] = Color3;
                ColorCube[4] = Color4;
                ColorCube[5] = Color5;
                ColorCube[6] = Color6;
                AlphaColor = _AlphaColor;

                RotationAngleX = 0;
                RotationAngleY = 0;
                RotationAngleZ = 0;
            }
            public void WriteCube()
            {
                Gl.glEnable(Gl.GL_LINE_STIPPLE);

                Gl.glBegin(Gl.GL_QUADS); //front

                Gl.glColor4f(ColorCube[1][0], ColorCube[1][1], ColorCube[1][2], 1);
                Gl.glVertex3d(0, 0, 0);
                Gl.glVertex3d(1, 0, 0);
                Gl.glVertex3d(1, 1, 0);
                Gl.glVertex3d(0, 1, 0);
                Gl.glEnd();

                Gl.glBegin(Gl.GL_QUADS); //top
                Gl.glColor4f(ColorCube[4][0], ColorCube[4][1], ColorCube[4][2], 1);
                Gl.glVertex3d(0, 1, 0);
                Gl.glVertex3d(0, 1, 1);
                Gl.glVertex3d(1, 1, 1);
                Gl.glVertex3d(1, 1, 0);
                Gl.glEnd();

                Gl.glBegin(Gl.GL_QUADS); // Right
                Gl.glColor4f(ColorCube[2][0], ColorCube[2][1], ColorCube[2][2], 1);
                Gl.glVertex3d(1, 0, 0);
                Gl.glVertex3d(1, 0, 1);
                Gl.glVertex3d(1, 1, 1);
                Gl.glVertex3d(1, 1, 0);
                Gl.glEnd();

                Gl.glBegin(Gl.GL_QUADS); // down
                Gl.glColor4f(ColorCube[5][0], ColorCube[5][1], ColorCube[5][2], 1);
                Gl.glVertex3d(0, 0, 0);
                Gl.glVertex3d(1, 0, 0);
                Gl.glVertex3d(1, 0, 1);
                Gl.glVertex3d(0, 0, 1);
                Gl.glEnd();

                Gl.glBegin(Gl.GL_QUADS);//left
                Gl.glColor4f(ColorCube[3][0], ColorCube[3][1], ColorCube[3][2], 1);
                Gl.glVertex3d(0, 0, 0);
                Gl.glVertex3d(0, 1, 0);
                Gl.glVertex3d(0, 1, 1);
                Gl.glVertex3d(0, 0, 1);
                Gl.glEnd();

                Gl.glBegin(Gl.GL_QUADS); //bot
                Gl.glColor4f(ColorCube[6][0], ColorCube[6][1], ColorCube[6][2], 1);
                Gl.glVertex3d(0, 0, 1);
                Gl.glVertex3d(0, 1, 1);
                Gl.glVertex3d(1, 1, 1);
                Gl.glVertex3d(1, 0, 1);
                Gl.glEnd();

                Gl.glDisable(Gl.GL_LINE_STIPPLE);
            } //рисование одного кубика 
            public void WriteSoidCub()
            {
                Gl.glPolygonMode(Gl.GL_FRONT_AND_BACK, Gl.GL_LINE);
                Gl.glLineWidth(7);
                Gl.glColor3f(0, 0, 0);
                Gl.glBegin(Gl.GL_QUADS); //front
                Gl.glVertex3d(0, 0, 0);
                Gl.glVertex3d(1, 0, 0);
                Gl.glVertex3d(1, 1, 0);
                Gl.glVertex3d(0, 1, 0);
                Gl.glEnd();


                Gl.glBegin(Gl.GL_QUADS); //top
                Gl.glVertex3d(0, 1, 0);
                Gl.glVertex3d(0, 1, 1);
                Gl.glVertex3d(1, 1, 1);
                Gl.glVertex3d(1, 1, 0);
                Gl.glEnd();


                Gl.glBegin(Gl.GL_QUADS); // Right
                Gl.glVertex3d(1, 0, 0);
                Gl.glVertex3d(1, 0, 1);
                Gl.glVertex3d(1, 1, 1);
                Gl.glVertex3d(1, 1, 0);
                Gl.glEnd();


                Gl.glBegin(Gl.GL_QUADS); // down
                Gl.glVertex3d(0, 0, 0);
                Gl.glVertex3d(1, 0, 0);
                Gl.glVertex3d(1, 0, 1);
                Gl.glVertex3d(0, 0, 1);
                Gl.glEnd();


                Gl.glBegin(Gl.GL_QUADS);//left
                Gl.glVertex3d(0, 0, 0);
                Gl.glVertex3d(0, 1, 0);
                Gl.glVertex3d(0, 1, 1);
                Gl.glVertex3d(0, 0, 1);
                Gl.glEnd();


                Gl.glBegin(Gl.GL_QUADS); //bot
                Gl.glVertex3d(0, 0, 1);
                Gl.glVertex3d(0, 1, 1);
                Gl.glVertex3d(1, 1, 1);
                Gl.glVertex3d(1, 0, 1);
                Gl.glEnd();
                Gl.glPolygonMode(Gl.GL_FRONT_AND_BACK, Gl.GL_FILL);



            } // рисоване граней кубика
            public void DrawCube()
            {
                WriteCube();
                WriteSoidCub();
            }
        }
        public class CameraClass
        {
            float AngleX;
            float AngleY;

            public CameraClass(float RotationAngleX, float RotationAngleY)
            {
                AngleX = RotationAngleX;
                AngleY = RotationAngleY;
            }

        }
        public class Time  // структура времени 
        {

            public Time()
            {
                MilleSecondsTime = 0;
                SecondsTime = 0;
                MinuteTime = 0;
            }
            public int MinuteTime { get; set; }
            public int SecondsTime { get; set; }
            public int MilleSecondsTime { get; set; }

        }

        string NameDataFolder ="Data";
        string NameRecordFolder ="Record";
        string NameRecFile = "Records.Xml";
        string PatchExeFile = Directory.GetCurrentDirectory();
        string NameSettingFolder = "Setting";
        string NameSettigFile = "Setting.Xml";

        float DeltaAngleForAllCube = 45; // угол поворота кубика (сейчас не используется ) 
        float DeltaAngleForCubeRotation = 90; // угол поворота раней кубика 
        float SelectAlphaColor = 0.6f; //Алтфа цвет выделелния 
        float NormalAlphaColor = 1.0f; // альфа нормального цвета 
        bool StartGame = false; // начата ли игра 
        bool PauseGame = false;  //  стоил ти игра на пайзе 
        bool EndGame = false; // если кубик собран
        double TempX;
        double TempY;
        double OldMousePosX;
        double OldMousePosY;
        int MouseStartPositionX = 0;
        int MouseStartPositionY = 0;
        double MouseDeltaX = 0;
        double MouseDeltaY = 0;
        int SizeCube = 10; // началный размер куба
        Color ColorWorld; //Цвет мира и интерфейса
        public ClassCube[, ,] Cube = new ClassCube[3, 3, 3];
        public RecType[] Records = new RecType[10];
        Time TimeForRecords = new Time();
        struct SSelectCube
        {
            public int X;
            public int Y;
            public int Z;
        };
        SSelectCube SelectedCube;
        int[][] VariationOFSelectedCybeMidle = { // хранилище возможных вборов середин для их переворотов * не используется 
            new int[] {2,2,1}, //front
            new int[] {2,3,1}, //top 
            new int[] {3,2,2}, //right
            new int[] {1,2,2}, //left
            new int[] {2,1,2}, //down
            new int[] {2,2,3}  //bot
    };

        float[][] COlorHande =   { // укаатель цветов
            new float [] {1,0,0}, //красный 0
            new float [] {0,1,0}, // зеленый 1
            new float [] {0,0,1} ,// синий 2
            new float [] {1,1,1}, //Белый 3
            new float [] {1,1,0} , //желтый 4
            new float [] {1,0.5f,0} ,  //оранджеый 5
            new float [] {0,0,0}  , //черный 6
          };

        public Form1() // первичная инициализация 
        {

            InitializeComponent();
            OpenGlControl.InitializeContexts();

        }
        private void Form1_Load(object sender, EventArgs e) // инициальзация 
        {
            Glut.glutInit();
            Glut.glutInitDisplayMode(Glut.GLUT_RGB | Glut.GLUT_DOUBLE | Glut.GLUT_DEPTH);

            Gl.glClearColor(0, 0, 1, 1);

            Gl.glViewport(5, 5, OpenGlControl.Width, OpenGlControl.Height);

            Gl.glMatrixMode(Gl.GL_PROJECTION);
            Gl.glLoadIdentity();
            Glu.gluPerspective(45, (float)OpenGlControl.Width / (float)OpenGlControl.Height, 0.1, 200);
            Gl.glMatrixMode(Gl.GL_MODELVIEW);
            Gl.glLoadIdentity();

            Gl.glEnable(Gl.GL_DEPTH_TEST);
            Gl.glEnable(Gl.GL_LINE_SMOOTH);

            Gl.glEnable(Gl.GL_BLEND);
            Gl.glBlendFunc(Gl.GL_SRC_ALPHA, Gl.GL_ONE_MINUS_SRC_ALPHA);

            //Gl.glEnable(Gl.GL_LIGHTING);
            // Gl.glEnable(Gl.GL_LIGHT1);



            if (!Directory.Exists(PatchExeFile + "//" + NameDataFolder + "//" + NameSettingFolder))
            {
                Directory.CreateDirectory(PatchExeFile + "//" + NameDataFolder + "//" + NameSettingFolder);
            }

            if (!Directory.Exists(PatchExeFile + "//" +  NameDataFolder + "//" + NameRecordFolder))
            {
                Directory.CreateDirectory(PatchExeFile + "//" + NameDataFolder + "//" + NameRecordFolder);
            }

             FirstSettingUp();
             SecondSettingUp();
           

        }
        private void FirstSettingUp()
        {
            CameraClass Camera = new CameraClass(0, 0);
            int SelectIntName = 1;
            for (int Z = 0; Z < 3; Z++)
                for (int X = 0; X < 3; X++)
                    for (int Y = 0; Y < 3; Y++)
                    {
                        Cube[X, Y, Z] = new ClassCube(SelectIntName, 0, 0, 0, NormalAlphaColor);
                        SelectIntName += 1;
                    }
            SelectedCube.X = 2;
            SelectedCube.Y = 2;
            SelectedCube.Z = 1;
            Cube[SelectedCube.X - 1, SelectedCube.Y - 1, SelectedCube.Z - 1].AlphaColor = SelectAlphaColor;
            Gl.glClearColor(0, 0.5f, 1, 1);
            PanelMenu.Left = OpenGlControl.Width + 10;
            LoadRecordFileXml();
        }// первичная настройка параметров 
        public void SecondSettingUp()
        {
            Cube[0, 0, 0].SetObjectCube(-1, -1, -1, COlorHande[2], COlorHande[6], COlorHande[0], COlorHande[6], COlorHande[3], COlorHande[6], Cube[0, 0, 0].AlphaColor);
            Cube[0, 1, 0].SetObjectCube(-1, 0, -1, COlorHande[2], COlorHande[6], COlorHande[0], COlorHande[6], COlorHande[6], COlorHande[6], Cube[0, 1, 0].AlphaColor);
            Cube[0, 2, 0].SetObjectCube(-1, 1, -1, COlorHande[2], COlorHande[6], COlorHande[0], COlorHande[4], COlorHande[6], COlorHande[6], Cube[0, 2, 0].AlphaColor);

            Cube[1, 0, 0].SetObjectCube(0, -1, -1, COlorHande[2], COlorHande[6], COlorHande[6], COlorHande[6], COlorHande[3], COlorHande[6], Cube[1, 0, 0].AlphaColor);
            Cube[1, 1, 0].SetObjectCube(0, 0, -1, COlorHande[2], COlorHande[6], COlorHande[6], COlorHande[6], COlorHande[6], COlorHande[6], Cube[1, 1, 0].AlphaColor);
            Cube[1, 2, 0].SetObjectCube(0, 1, -1, COlorHande[2], COlorHande[6], COlorHande[6], COlorHande[4], COlorHande[6], COlorHande[6], Cube[1, 2, 0].AlphaColor);

            Cube[2, 0, 0].SetObjectCube(1, -1, -1, COlorHande[2], COlorHande[5], COlorHande[6], COlorHande[6], COlorHande[3], COlorHande[6], Cube[2, 0, 0].AlphaColor);
            Cube[2, 1, 0].SetObjectCube(1, 0, -1, COlorHande[2], COlorHande[5], COlorHande[6], COlorHande[6], COlorHande[6], COlorHande[6], Cube[2, 1, 0].AlphaColor);
            Cube[2, 2, 0].SetObjectCube(1, 1, -1, COlorHande[2], COlorHande[5], COlorHande[6], COlorHande[4], COlorHande[6], COlorHande[6], Cube[2, 2, 0].AlphaColor);
            //

            Cube[0, 0, 1].SetObjectCube(-1, -1, 0, COlorHande[6], COlorHande[6], COlorHande[0], COlorHande[6], COlorHande[3], COlorHande[6], Cube[0, 0, 1].AlphaColor);
            Cube[0, 1, 1].SetObjectCube(-1, 0, 0, COlorHande[6], COlorHande[6], COlorHande[0], COlorHande[6], COlorHande[6], COlorHande[6], Cube[0, 1, 1].AlphaColor);
            Cube[0, 2, 1].SetObjectCube(-1, 1, 0, COlorHande[6], COlorHande[6], COlorHande[0], COlorHande[4], COlorHande[6], COlorHande[6], Cube[0, 2, 1].AlphaColor);

            Cube[1, 0, 1].SetObjectCube(0, -1, 0, COlorHande[6], COlorHande[6], COlorHande[6], COlorHande[6], COlorHande[3], COlorHande[6], Cube[1, 0, 1].AlphaColor);
            Cube[1, 1, 1].SetObjectCube(0, 0, 0, COlorHande[6], COlorHande[6], COlorHande[6], COlorHande[6], COlorHande[6], COlorHande[6], Cube[1, 1, 1].AlphaColor);
            Cube[1, 2, 1].SetObjectCube(0, 1, 0, COlorHande[6], COlorHande[6], COlorHande[6], COlorHande[4], COlorHande[6], COlorHande[6], Cube[1, 2, 1].AlphaColor);

            Cube[2, 0, 1].SetObjectCube(1, -1, 0, COlorHande[6], COlorHande[5], COlorHande[6], COlorHande[6], COlorHande[3], COlorHande[6], Cube[2, 0, 1].AlphaColor);
            Cube[2, 1, 1].SetObjectCube(1, 0, 0, COlorHande[6], COlorHande[5], COlorHande[6], COlorHande[6], COlorHande[6], COlorHande[6], Cube[2, 1, 1].AlphaColor);
            Cube[2, 2, 1].SetObjectCube(1, 1, 0, COlorHande[6], COlorHande[5], COlorHande[6], COlorHande[4], COlorHande[6], COlorHande[6], Cube[2, 2, 1].AlphaColor);

            Cube[0, 0, 2].SetObjectCube(-1, -1, 1, COlorHande[6], COlorHande[6], COlorHande[0], COlorHande[6], COlorHande[3], COlorHande[1], Cube[0, 0, 2].AlphaColor);
            Cube[0, 1, 2].SetObjectCube(-1, 0, 1, COlorHande[6], COlorHande[6], COlorHande[0], COlorHande[6], COlorHande[6], COlorHande[1], Cube[0, 1, 2].AlphaColor);
            Cube[0, 2, 2].SetObjectCube(-1, 1, 1, COlorHande[6], COlorHande[6], COlorHande[0], COlorHande[4], COlorHande[6], COlorHande[1], Cube[0, 2, 2].AlphaColor);

            Cube[1, 0, 2].SetObjectCube(0, -1, 1, COlorHande[6], COlorHande[6], COlorHande[6], COlorHande[6], COlorHande[3], COlorHande[1], Cube[1, 0, 2].AlphaColor);
            Cube[1, 1, 2].SetObjectCube(0, 0, 1, COlorHande[6], COlorHande[6], COlorHande[6], COlorHande[6], COlorHande[6], COlorHande[1], Cube[1, 1, 2].AlphaColor);
            Cube[1, 2, 2].SetObjectCube(0, 1, 1, COlorHande[6], COlorHande[6], COlorHande[6], COlorHande[4], COlorHande[6], COlorHande[1], Cube[1, 2, 2].AlphaColor);

            Cube[2, 0, 2].SetObjectCube(1, -1, 1, COlorHande[6], COlorHande[5], COlorHande[6], COlorHande[6], COlorHande[3], COlorHande[1], Cube[2, 0, 2].AlphaColor);
            Cube[2, 1, 2].SetObjectCube(1, 0, 1, COlorHande[6], COlorHande[5], COlorHande[6], COlorHande[6], COlorHande[6], COlorHande[1], Cube[2, 1, 2].AlphaColor);
            Cube[2, 2, 2].SetObjectCube(1, 1, 1, COlorHande[6], COlorHande[5], COlorHande[6], COlorHande[4], COlorHande[6], COlorHande[1], Cube[2, 2, 2].AlphaColor);




        }
        public void WriteCubeRub()
        {
            for (int Z = 0; Z < 3; Z++)
                for (int X = 0; X < 3; X++)
                    for (int Y = 0; Y < 3; Y++)
                    {
                        Gl.glPushMatrix();
                        Gl.glTranslatef(X - 1, Y - 1, Z - 1);
                        Gl.glRotated(Cube[X, Y, Z].RotationAngleX, 1, 0, 0);
                        Gl.glRotated(Cube[X, Y, Z].RotationAngleY, 0, 1, 0);
                        Gl.glRotated(Cube[X, Y, Z].RotationAngleZ, 0, 0, 1);

                        Cube[X, Y, Z].DrawCube();
                        Gl.glPopMatrix();
                    }
        } // рисование кубика-рубика
        private void button1_Click(object sender, EventArgs e) // основная работа 
        {
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);

            Gl.glLoadIdentity();
            Gl.glPushMatrix();
            Glu.gluLookAt(SizeCube, 1, 0, -10, 0, 0, 0, 1, 0);

            Gl.glTranslated(0.5f, 0.5f, 0.5f);
            Gl.glRotated(MouseDeltaX, 0, -1, 0);
            Gl.glRotated(MouseDeltaY, 1, 0, 0);
            Gl.glTranslated(-0.5f, -0.5f, -0.5f);

            WriteCubeRub();

            Gl.glPopMatrix();
            Gl.glFlush();
            OpenGlControl.Invalidate();
        }
        private void AnimationOpenMenu(object sender, EventArgs e)
        {

            if (PanelMenu.Left >= OpenGlControl.Width - PanelMenu.Width)
            {
                PanelMenu.Left -= 10;
            }
            else
            {
                RenderAnimation.Enabled = false;
                RenderAnimation.Tick += EventHandler;

            }


        } // анимация для открывания "меню "
        private void AnimationCloseMenu(object sender, EventArgs e)
        {
            if (PanelMenu.Location.X <= OpenGlControl.Width + PanelMenu.Width + 10)
            {

                PanelMenu.Left += 10;
                //RenderAnimation.Enabled = true;
            }
            else
            {
                RenderAnimation.Enabled = false;
                RenderAnimation.Tick += EventHandler;

            }
        }// анимация для закрывания "меню ;
        private void EventHandler(object sender, EventArgs e)
        {
            // throw new NotImplementedException();
        } // заглушка 
        private void timer1_Tick(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        } // вызов перерисовки 
        private void button2_Click_1(object sender, EventArgs e)
        {
            RenderTimer.Enabled = !(RenderTimer.Enabled);
        }
        private void label1_MouseEnter(object sender, EventArgs e)
        {
            RenderAnimation.Tick += AnimationOpenMenu;
            MenuLabel.Visible = false;
            RenderAnimation.Enabled = true;
            if (StartGame == true)
            {
                RecTimer.Enabled = false;
                PauseLabel.Visible = true;
                PauseGame = true;
            }
            PanelMenu.Focus();

        }
        private void panel1_Leave(object sender, EventArgs e)
        {
            RenderAnimation.Tick += AnimationCloseMenu;
            MenuLabel.Visible = true;
            RenderAnimation.Enabled = true;
            RecordsPanel.Visible = false;
            if (PauseGame == true)
            {
                RecTimer.Enabled = true;
                PauseLabel.Visible = false;
                PauseGame = false;
                
            }

        }
        private void Exitbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void AnT_MouseMove(object sender, MouseEventArgs e)
        {

            switch (e.Button)
            {
                case MouseButtons.Left:
                    {


                        TempX = (OldMousePosX - e.Location.X);
                        TempY = (OldMousePosY - e.Location.Y);

                        OldMousePosX = e.Location.X;
                        OldMousePosY = e.Location.Y;
                        if ((TempX != 0) || (TempY != 0))
                        {
                            MouseDeltaX += 1.5 * TempX / Math.Sqrt(TempX * TempX + TempY * TempY);
                            MouseDeltaY += 1.5 * TempY / Math.Sqrt(TempX * TempX + TempY * TempY);
                        }


                        break;
                    }
                case MouseButtons.None:
                    {


                        break;
                    }


            }
        }
        private void AnT_MouseDown(object sender, MouseEventArgs e)
        {

            OldMousePosX = MouseStartPositionX;
            OldMousePosY = MouseStartPositionY;

            MouseStartPositionX = e.Location.X;
            MouseStartPositionY = e.Location.Y;
        }
        private void RecTimer_Tick(object sender, EventArgs e)// пофиксить синхрониацию 
        {
            TimeForRecords.MilleSecondsTime += 1;
            if (TimeForRecords.MilleSecondsTime >= 10)
            {
                TimeForRecords.MilleSecondsTime = 0;
                TimeForRecords.SecondsTime += 1;
                if (TimeForRecords.SecondsTime >= 60)
                {
                    TimeForRecords.SecondsTime = 0;
                    TimeForRecords.MinuteTime += 1;
                }
            }
            TimeLabel.Text = Convert.ToString(TimeForRecords.MinuteTime + ":" + TimeForRecords.SecondsTime + ":" + TimeForRecords.MilleSecondsTime);
        }
        private void NewGameButton_Click(object sender, EventArgs e)
        {
            if (StartGame == true)
            {
                RecTimer.Enabled = false;
                switch (MessageBox.Show("Вы Действительнохотите начать заного ? ", "Внимание!", MessageBoxButtons.YesNo))
                {
                    case (System.Windows.Forms.DialogResult.Yes):
                        {
                            //процедура сбрасывания кубика 
                            StartGame = true;
                            TimeForRecords.MilleSecondsTime = 0;
                            TimeForRecords.SecondsTime = 0;
                            TimeForRecords.MinuteTime = 0;
                            RecTimer.Enabled = true;
                            break;

                        }
                    case (System.Windows.Forms.DialogResult.No):
                        {
                            StartGame = false;
                            TimeForRecords.MilleSecondsTime = 0;
                            TimeForRecords.SecondsTime = 0;
                            TimeForRecords.MinuteTime = 0;
                            RecTimer.Enabled = false;
                            TimeLabel.Text = Convert.ToString(TimeForRecords.MinuteTime + ":" + TimeForRecords.SecondsTime + ":" + TimeForRecords.MilleSecondsTime);
                            TimeLabel.Visible = false;
                            break;


                        };
                };
            } 

            else
            {
                // RenderAnimation.Enabled = true;
                // RenderAnimation.Tick += AnimationCloseMenu;

                ShaflCube();
                TimeLabel.Visible = true;
                RecTimer.Enabled = true;
                StartGame = true;
            }
        }
        private void AnT_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    {
                        if (SelectedCube.Y == 2)
                        {
                            {
                                if (SelectedCube.Z == 1)
                                {
                                    SelectedCube.Y += 1;
                                    SelectedCube.Z = 2;
                                }
                                else
                                {
                                    if (SelectedCube.Z == 3)
                                    {
                                        SelectedCube.Y -= 1;
                                        SelectedCube.Z = 2;
                                    }
                                    else
                                    {
                                        if (SelectedCube.Z == 2)
                                        {
                                            if ((SelectedCube.X == 1) || (SelectedCube.X == 3))
                                            {
                                                { SelectedCube.Y += 1; SelectedCube.Z = 2; SelectedCube.X = 2; }
                                            }

                                        }
                                    }
                                }
                            }
                        }
                        else
                        {
                            if (SelectedCube.Y == 3)
                            {
                                SelectedCube.Y -= 1;
                                SelectedCube.Z = 3;
                            }
                            else
                            {
                                if (SelectedCube.Y == 1)
                                {
                                    SelectedCube.Y += 1;
                                    SelectedCube.Z = 1;
                                }
                            }
                        }
                        break;
                    }
                case Keys.S:
                    {
                        if (SelectedCube.Y == 2)
                        {
                            {
                                if (SelectedCube.Z == 1)
                                {
                                    SelectedCube.Y -= 1;
                                    SelectedCube.Z = 2;
                                }
                                else
                                {
                                    if (SelectedCube.Z == 3)
                                    {
                                        SelectedCube.Y += 1;
                                        SelectedCube.Z = 2;
                                    }
                                    else
                                    {
                                        if (SelectedCube.Z == 2)
                                        {
                                            if ((SelectedCube.X == 1) || (SelectedCube.X == 3))
                                            {
                                                SelectedCube.X = 2;
                                                SelectedCube.Y -= 1;
                                                SelectedCube.Z = 2;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        else
                        {
                            if (SelectedCube.Y == 3)
                            {
                                SelectedCube.Y -= 1;
                                SelectedCube.Z = 1;
                            }
                            else
                            {
                                if (SelectedCube.Y == 1)
                                {
                                    SelectedCube.Y += 1;
                                    SelectedCube.Z = 3;
                                }

                            }
                        }
                        break;
                    }

                case Keys.D:
                    {
                        if (SelectedCube.X == 1)
                        {
                            SelectedCube.X += 1;
                            SelectedCube.Z = 3;
                        }
                        else
                        {
                            if (SelectedCube.X == 2)
                            {
                                if (SelectedCube.Z == 1)
                                {
                                    SelectedCube.X -= 1;
                                    SelectedCube.Z = 2;
                                }
                                else
                                {
                                    if (SelectedCube.Z == 3)
                                    {
                                        SelectedCube.X += 1;
                                        SelectedCube.Z = 2;
                                    }
                                    else
                                    {
                                        if (SelectedCube.Z == 2)
                                        {
                                            if ((SelectedCube.Y == 3) || (SelectedCube.Y == 1))
                                            {
                                                SelectedCube.Y = 2;
                                                SelectedCube.Z = 2;
                                                SelectedCube.X -= 1;
                                            }
                                        }
                                    }

                                }
                            }
                            else
                            {
                                if (SelectedCube.X == 3)
                                {
                                    SelectedCube.X -= 1;
                                    SelectedCube.Z = 1;
                                }
                            }
                        }

                        break;
                    }
                case Keys.A:
                    {
                        if (SelectedCube.X == 1)
                        { 
                            SelectedCube.X += 1;
                            SelectedCube.Z = 1;
                        }
                        else
                        {
                            if (SelectedCube.X == 2)
                            {
                                if (SelectedCube.Z == 1)
                                {
                                    SelectedCube.X += 1;
                                    SelectedCube.Z = 2;
                                }
                                else
                                {
                                    if (SelectedCube.Z == 3)
                                    {
                                        SelectedCube.X -= 1;
                                        SelectedCube.Z = 2;
                                    }
                                    else
                                    {
                                        if (SelectedCube.Z == 2)
                                        {
                                            if ((SelectedCube.Y == 1) || (SelectedCube.Y == 3))
                                            {
                                                SelectedCube.Y = 2;
                                                SelectedCube.Z = 2;
                                                SelectedCube.X += 1;
                                            }
                                        }
                                    }
                                }
                            }
                            else
                            {
                                if (SelectedCube.X == 3)
                                {
                                    SelectedCube.X -= 1;
                                    SelectedCube.Z = 3;
                                }
                            }
                        }
                        break;
                    }
                case Keys.Space: // переворот 
                    {
                        FlipSide(SelectedCube.X, SelectedCube.Y, SelectedCube.Z);
                        int SelectIntName = 1;
                        for (int Z = 0; Z < 3; Z++)
                            for (int X = 0; X < 3; X++)
                                for (int Y = 0; Y < 3; Y++)
                                {
                                    if (Cube[X, Y, Z].IntName == SelectIntName)
                                    {
                                        SelectIntName += 1;
                                        EndGame = true;
                                    }
                                    else
                                    {
                                        EndGame = false;
                                        break;
                                    }
                                    if ((EndGame == true) && (StartGame == true))
                                    {
                                        GameIsOver();
                                    }
                                }
                        break;
                    }
            }
            Cube[1, 1, 0].AlphaColor = NormalAlphaColor;
            Cube[1, 2, 1].AlphaColor = NormalAlphaColor;
            Cube[2, 1, 1].AlphaColor = NormalAlphaColor;
            Cube[0, 1, 1].AlphaColor = NormalAlphaColor;
            Cube[1, 0, 1].AlphaColor = NormalAlphaColor;
            Cube[1, 1, 2].AlphaColor = NormalAlphaColor;
            Cube[SelectedCube.X - 1, SelectedCube.Y - 1, SelectedCube.Z - 1].AlphaColor = SelectAlphaColor;
        }
        private void FlipSide(int X, int Y, int Z)
        {
            if ((X == 2) & (Y == 2) & (Z == 1))//1,1,0
            {
                SwapArrCube(ref Cube[0, 0, 0], ref Cube[0, 2, 0]);
                SwapArrCube(ref Cube[0, 0, 0], ref Cube[2, 2, 0]);
                SwapArrCube(ref Cube[0, 0, 0], ref Cube[2, 0, 0]);

                SwapArrCube(ref Cube[0, 1, 0], ref Cube[1, 2, 0]);
                SwapArrCube(ref Cube[0, 1, 0], ref Cube[2, 1, 0]);
                SwapArrCube(ref Cube[0, 1, 0], ref Cube[1, 0, 0]);

                //Cube[0, 0, 0].RotationAngleZ += 90;
                //Cube[1, 0, 0].RotationAngleZ += 90;
                //Cube[2, 0, 0].RotationAngleZ += 90;

                //Cube[0, 1, 0].RotationAngleZ += 90;
                //Cube[1, 1, 0].RotationAngleZ += 90;
                //Cube[2, 1, 0].RotationAngleZ += 90;

                //Cube[0, 2, 0].RotationAngleZ += 90;
                //Cube[1, 2, 0].RotationAngleZ += 90;
                //Cube[2, 2, 0].RotationAngleZ += 90;
            }
            else
            {
                if ((X == 2) & (Y == 3) & (Z == 2))//1,2,1
                {
                    SwapArrCube(ref Cube[0, 2, 0], ref Cube[0, 2, 2]);
                    SwapArrCube(ref Cube[0, 2, 0], ref Cube[2, 2, 2]);
                    SwapArrCube(ref Cube[0, 2, 0], ref Cube[2, 2, 0]);

                    SwapArrCube(ref Cube[0, 2, 1], ref Cube[1, 2, 2]);
                    SwapArrCube(ref Cube[0, 2, 1], ref Cube[2, 2, 1]);
                    SwapArrCube(ref Cube[0, 2, 1], ref Cube[1, 2, 0]);

                    //Cube[0, 2, 0].RotationAngleY += 90;
                    //Cube[1, 2, 0].RotationAngleY += 90;
                    //Cube[2, 2, 0].RotationAngleY += 90;

                    //Cube[0, 2, 1].RotationAngleY += 90;
                    //Cube[1, 2, 1].RotationAngleY += 90;
                    //Cube[2, 2, 1].RotationAngleY += 90;

                    //Cube[0, 2, 2].RotationAngleY += 90;
                    //Cube[1, 2, 2].RotationAngleY += 90;
                    //Cube[2, 2, 2].RotationAngleY += 90;


                }
                else
                {
                    if ((X == 3) & (Y == 2) & (Z == 2))//2,1,1
                    {
                        SwapArrCube(ref Cube[2, 0, 0], ref Cube[2, 2, 0]);
                        SwapArrCube(ref Cube[2, 0, 0], ref Cube[2, 2, 2]);
                        SwapArrCube(ref Cube[2, 0, 0], ref Cube[2, 0, 2]);

                        SwapArrCube(ref Cube[2, 1, 0], ref Cube[2, 2, 1]);
                        SwapArrCube(ref Cube[2, 1, 0], ref Cube[2, 1, 2]);
                        SwapArrCube(ref Cube[2, 1, 0], ref Cube[2, 0, 1]);
                    }
                    else
                    {
                        if ((X == 1) & (Y == 2) & (Z == 2))//0,1,1
                        {
                            SwapArrCube(ref Cube[0, 0, 0], ref Cube[0, 2, 0]);
                            SwapArrCube(ref Cube[0, 0, 0], ref Cube[0, 2, 2]);
                            SwapArrCube(ref Cube[0, 0, 0], ref Cube[0, 0, 2]);

                            SwapArrCube(ref Cube[0, 1, 0], ref Cube[0, 2, 1]);
                            SwapArrCube(ref Cube[0, 1, 0], ref Cube[0, 1, 2]);
                            SwapArrCube(ref Cube[0, 1, 0], ref Cube[0, 0, 1]);
                        }
                        else
                        {
                            if ((X == 2) & (Y == 1) & (Z == 2))//1,0,1
                            {
                                SwapArrCube(ref Cube[0, 0, 0], ref Cube[2, 0, 0]);
                                SwapArrCube(ref Cube[0, 0, 0], ref Cube[2, 0, 2]);
                                SwapArrCube(ref Cube[0, 0, 0], ref Cube[0, 0, 2]);

                                SwapArrCube(ref Cube[1, 0, 0], ref Cube[2, 0, 1]);
                                SwapArrCube(ref Cube[1, 0, 0], ref Cube[1, 0, 2]);
                                SwapArrCube(ref Cube[1, 0, 0], ref Cube[0, 0, 1]);
                            }
                            else
                            {
                                if ((X == 2) & (Y == 2) & (Z == 3))//1,1,2
                                {
                                    SwapArrCube(ref Cube[0, 0, 2], ref Cube[0, 2, 2]);
                                    SwapArrCube(ref Cube[0, 0, 2], ref Cube[2, 2, 2]);
                                    SwapArrCube(ref Cube[0, 0, 2], ref Cube[2, 0, 2]);

                                    SwapArrCube(ref Cube[0, 1, 2], ref Cube[1, 2, 2]);
                                    SwapArrCube(ref Cube[0, 1, 2], ref Cube[2, 1, 2]);
                                    SwapArrCube(ref Cube[0, 1, 2], ref Cube[1, 0, 2]);
                                }
                            }
                        }
                    }
                }
            }

        }
        private void GameIsOver()
        {
            RecTimer.Enabled = false;
            MessageBox.Show("Поздравляю, Вы собрали кубик за - " + TimeForRecords.MinuteTime + "Мин " + TimeForRecords.SecondsTime + "Сек " + TimeForRecords.MilleSecondsTime + "МСек", "Внимание!");
            StartGame = false;
            EndGame = false;

            for (int i = 0; i <= 9; i++)
            {
                if (Records[i].RecMin >=TimeForRecords.MinuteTime)
                {
                    if (Records[i].RecSec >=TimeForRecords.SecondsTime)
                    {
                        if(Records[i].RecMilleSec>=TimeForRecords.MilleSecondsTime)
                        {
                            listBox1.SelectedIndex = i;
                            listBox1.Enabled = false;
                            RecordsPanel.Visible = true;
                            RecordSavePanel.Visible = true;
                            RecordsPanel.Focus(); 
                            break;
                        }
                    }
               }
            }
        }     
        private void SwapArrCube(ref ClassCube First, ref ClassCube Second)
        {
            ClassCube Temp = new ClassCube();
            Temp = First;
            First = Second;
            Second = Temp;
      
        }
        private void button3_Click(object sender, EventArgs e)
        {
            SettingsPanel.Visible = true;
            SettingsPanel.Focus();
        }
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            SizeCube = trackBar1.Value;
        }
        private void label3_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();

            ColorLabel.BackColor = colorDialog1.Color;
            ColorWorld = colorDialog1.Color;
            Gl.glClearColor(ColorWorld.R, ColorWorld.G, ColorWorld.B, ColorWorld.A);

            PanelMenu.BackColor = ColorWorld;
            NewGameButton.BackColor = ColorWorld;
            SettingsButton.BackColor = ColorWorld;
            RecordButton.BackColor = ColorWorld;
            ExitButton.BackColor = ColorWorld;
            SettingsPanel.BackColor = ColorWorld;
            MenuLabel.BackColor = ColorWorld;
            TimeLabel.BackColor = ColorWorld;


        }
        private void SettingsPanel_Leave(object sender, EventArgs e)
        {
            SettingsPanel.Visible = false;
        }
        private void RecordButton_Click(object sender, EventArgs e)
        {
            RecordsPanel.Visible = true;
            PauseGame = true;
            RecTimer.Enabled = false;
            RecordsPanel.Focus();
            
        }
        private void SaveRecordFileXml() // Сохранение Рекордов в XML c MSDN
        {
            System.Xml.Serialization.XmlSerializer writer = new System.Xml.Serialization.XmlSerializer(
            Records.GetType());

            System.IO.StreamWriter file = new System.IO.StreamWriter(PatchExeFile + "//" + NameDataFolder + "//" + NameRecordFolder + "//" + NameRecFile);
                writer.Serialize(file, Records);
                file.Close();
        }
        private void LoadRecordFileXml() //запись Рекордов в XML c MSDN
        {
            System.Xml.Serialization.XmlSerializer reader = new System.Xml.Serialization.XmlSerializer(Records.GetType());
            System.IO.StreamReader file = new System.IO.StreamReader(PatchExeFile + "//" + NameDataFolder + "//" + NameRecordFolder +"//" + NameRecFile);
            Records = (RecType[])reader.Deserialize(file);
            RewrireRecordsTables();
        }
        private void RewrireRecordsTables()
        {
            listBox1.Items.Clear();
            for (int i = 0; i <= 9; i++)
            {   
                    listBox1.Items.Add(Records[i].Name + '(' + Records[i].RecMin + ':' + Records[i].RecSec + ':' + Records[i].RecMilleSec + ')');   
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            Records[listBox1.SelectedIndex] = new RecType(NewNameRecordText.Text,TimeForRecords);
            RecordSavePanel.Visible = false;
            listBox1.Enabled = true;
            RewrireRecordsTables();

         }
        private void ShaflCube()
        {
            Random Randomiser = new Random();
            int CountFlips =Randomiser.Next(15, 100) ;
            int SideFlip;
            for (int i = 1; i <= CountFlips; i++)
            {
               SideFlip = Randomiser.Next(0, 5);
               int x = VariationOFSelectedCybeMidle[SideFlip][0];
               int y = VariationOFSelectedCybeMidle[SideFlip][1];
               int z = VariationOFSelectedCybeMidle[SideFlip][2];
                FlipSide( VariationOFSelectedCybeMidle[SideFlip][0],VariationOFSelectedCybeMidle[SideFlip][1],VariationOFSelectedCybeMidle[SideFlip][2]);
            }
        }
    }

}




