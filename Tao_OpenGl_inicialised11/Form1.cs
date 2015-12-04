using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tao.OpenGl;
using Tao.FreeGlut;
using Tao.Platform.Windows;

namespace Tao_OpenGl_inicialised11
{
    public partial class Form1 : Form
    {
        float DeltaAngleForAllCube = 45; // угол поворота кубика (сейчас не используется ) 
        float DeltaAngleForCubeRotation = 90; // угол поворота раней кубика 

        float SelectAlphaColor = 0.6f; //Алтфа цвет выделелния 
        float NormalAlphaColor = 1.0f; // альфа нормального цвета 

        bool StartGame = false; // начата ли игра 
        bool PauseGame = false;  //  стоил ти игра на пайзе 

        double TempX;
        double TempY;
        double OldMousePosX;
        double OldMousePosY;

        int MouseStartPositionX = 0;
        int MouseStartPositionY = 0;

        double MouseDeltaX = 0;
        double MouseDeltaY = 0;



        RotationStruct RotationVectorValue; // для поаорота кубика 
        RotationStruct[] RotationVectorForCubes = new RotationStruct[28]; //для сохранения поворотов кубиков для переручиваниея 
        TimeStruct TimeForRecords;
        SCube[, ,] StructCube = new SCube[3, 3, 3]; // потому что с 0 

        public struct RotationStruct // структура поворота 
        {
            public float RotationAngleX;
            public float RotationAngleY;
            public float RotationAngleZ;

        }

        public struct TimeStruct  // структура времени 
        {
            public int MinuteTime;
            public int SecondsTime;
            public int MilleSecondsTime;

        }
        public struct SCube
        {
            public int IntNameCube;
            public float AlphaColor;
        }


        int[][] VariationOFSelectedCybeMidle = { // хранилище возможных вборов середин для их переворотов * не используется 
            new int[] {1,1,0}, //front
            new int[] {1,2,1}, //top 
            new int[] {2,1,1}, //right
            new int[] {0,1,1}, //left
            new int[] {1,0,1}, //down
            new int[] {1,1,2}  //bot
    };

        float[][] COlorHande =   { // укаатель цветов

            new float [] {1,0,0}, //красный 0
            new float [] {0,1,0}, // зеленый 1
            new float [] {0,0,1} ,// синий 2
            new float [] {1,1,1}, //Белый 3
            new float [] {1,1,0} , //желтый 4
            new float [] {1,0.5f,0} ,  //оранджеый 5
            new float [] {0,0,0}  , //черный 6
          //  new float [] {1.0f,0.5f,0.5f}   //тест 7
          };


        public Form1() // первичная инициализация 
        {

            InitializeComponent();
            AnT.InitializeContexts();

        }

        private void Form1_Load(object sender, EventArgs e) // инициальзация 
        {
            Glut.glutInit();
            Glut.glutInitDisplayMode(Glut.GLUT_RGB | Glut.GLUT_DOUBLE | Glut.GLUT_DEPTH);
            Gl.glClearColor(0.5f, 1, 1, 1);
            Gl.glViewport(5, 5, AnT.Width, AnT.Height);

            Gl.glMatrixMode(Gl.GL_PROJECTION);
            Gl.glLoadIdentity();
            Glu.gluPerspective(45, (float)AnT.Width / (float)AnT.Height, 0.1, 200);
            Gl.glMatrixMode(Gl.GL_MODELVIEW);
            Gl.glLoadIdentity();

            Gl.glEnable(Gl.GL_DEPTH_TEST);
            Gl.glEnable(Gl.GL_LINE_SMOOTH);

            Gl.glEnable(Gl.GL_BLEND);
            Gl.glBlendFunc(Gl.GL_SRC_ALPHA, Gl.GL_ONE_MINUS_SRC_ALPHA);

          //  Gl.glEnable(Gl.GL_LIGHTING);
           // Gl.glEnable(Gl.GL_LIGHT0);
            FirstSettingUp();

        }
        private void FirstSettingUp()
        {
            RotationVectorValue.RotationAngleY = 0;
            RotationVectorValue.RotationAngleX = 0;

            for (int i = 1; i < 27; i++)
            {

                RotationVectorForCubes[i].RotationAngleX = 0;
                RotationVectorForCubes[i].RotationAngleY = 0;
                RotationVectorForCubes[i].RotationAngleZ = 0;

            };
            int SelectIntName = 0;

            for (int Z = 0; Z < 3; Z++)
                for (int X = 0; X < 3; X++)
                    for (int Y = 0; Y < 3; Y++)
                    {
                        StructCube[X, Y, Z].IntNameCube = SelectIntName += 1;
                        StructCube[X, Y, Z].AlphaColor = NormalAlphaColor;
                    }


            SelectedCube.X = 2;
            SelectedCube.Y = 2;
            SelectedCube.Z = 1;

            PanelMenu.Left = AnT.Width + 10;
        } // первичная настройка параметров 

        public void RotationForCube(int CubeIntName)//поворот кубика для поворота грани 
        {
            Gl.glRotated(RotationVectorForCubes[CubeIntName].RotationAngleX, 1, 0, 0);
            Gl.glRotated(RotationVectorForCubes[CubeIntName].RotationAngleY, 0, 1, 0);
            Gl.glRotated(RotationVectorForCubes[CubeIntName].RotationAngleZ, 0, 0, 1);

        }

        public void WriteCube(float[] CFront, float[] CRight, float[] CLeft, float[] CTop, float[] CDown, float[] CBot, float AlphaSelect)
        {
            Gl.glEnable(Gl.GL_LINE_STIPPLE);

            Gl.glBegin(Gl.GL_QUADS); //front
            Gl.glColor4f(CFront[0], CFront[1], CFront[2], AlphaSelect);
            Gl.glVertex3d(0, 0, 0);
            Gl.glVertex3d(1, 0, 0);
            Gl.glVertex3d(1, 1, 0);
            Gl.glVertex3d(0, 1, 0);
            Gl.glEnd();


            Gl.glBegin(Gl.GL_QUADS); //top
            Gl.glColor4f(CTop[0], CTop[1], CTop[2], AlphaSelect);
            Gl.glVertex3d(0, 1, 0);
            Gl.glVertex3d(0, 1, 1);
            Gl.glVertex3d(1, 1, 1);
            Gl.glVertex3d(1, 1, 0);
            Gl.glEnd();


            Gl.glBegin(Gl.GL_QUADS); // Right
            Gl.glColor4f(CRight[0], CRight[1], CRight[2], AlphaSelect);
            Gl.glVertex3d(1, 0, 0);
            Gl.glVertex3d(1, 0, 1);
            Gl.glVertex3d(1, 1, 1);
            Gl.glVertex3d(1, 1, 0);
            Gl.glEnd();


            Gl.glBegin(Gl.GL_QUADS); // down
            Gl.glColor4f(CDown[0], CDown[1], CDown[2], AlphaSelect);
            Gl.glVertex3d(0, 0, 0);
            Gl.glVertex3d(1, 0, 0);
            Gl.glVertex3d(1, 0, 1);
            Gl.glVertex3d(0, 0, 1);
            Gl.glEnd();


            Gl.glBegin(Gl.GL_QUADS);//left
            Gl.glColor4f(CLeft[0], CLeft[1], CLeft[2], AlphaSelect);
            Gl.glVertex3d(0, 0, 0);
            Gl.glVertex3d(0, 1, 0);
            Gl.glVertex3d(0, 1, 1);
            Gl.glVertex3d(0, 0, 1);
            Gl.glEnd();


            Gl.glBegin(Gl.GL_QUADS); //bot
            Gl.glColor4f(CBot[0], CBot[1], CBot[2], AlphaSelect);
            Gl.glVertex3d(0, 0, 1);
            Gl.glVertex3d(0, 1, 1);
            Gl.glVertex3d(1, 1, 1);
            Gl.glVertex3d(1, 0, 1);
            Gl.glEnd();


            Gl.glDisable(Gl.GL_LINE_STIPPLE);
        } //рисование одного кубика 

        public void WriteCubeRub()
        {
            //красный 0
            //зеленый 1
            //синий 2
            //Белый 3
            //желтый 4
            //оранджеый 5
            //черный 6
            // front right left top down bot 
            //--------------------------------------------------// z=-1 +
            Gl.glPushMatrix();
            Gl.glPushMatrix();
            RotationForCube(1);
            Gl.glTranslated(-1, -1, -1);

            WriteCube(COlorHande[2], COlorHande[6], COlorHande[0], COlorHande[6], COlorHande[3], COlorHande[6], 1);
            WriteSoidCub();
            Gl.glPopMatrix();

            Gl.glPushMatrix();
            RotationForCube(2);
            Gl.glTranslated(-1, 0, -1);
            WriteCube(COlorHande[2], COlorHande[6], COlorHande[0], COlorHande[6], COlorHande[6], COlorHande[6], 1);
            WriteSoidCub();
            Gl.glPopMatrix();

            Gl.glTranslated(0, 0, 0);
            Gl.glPushMatrix();
            RotationForCube(3);
            Gl.glTranslated(-1, 1, -1);
            WriteCube(COlorHande[2], COlorHande[6], COlorHande[0], COlorHande[4], COlorHande[6], COlorHande[6], 1);
            WriteSoidCub();
            Gl.glPopMatrix();

            //--------------------------------------------------//z=-1 + 

            Gl.glPushMatrix();
            RotationForCube(4);
            Gl.glTranslated(0, -1, -1);
            WriteCube(COlorHande[2], COlorHande[6], COlorHande[6], COlorHande[6], COlorHande[3], COlorHande[6], 1);
            WriteSoidCub();
            Gl.glPopMatrix();

            Gl.glPushMatrix();
            RotationForCube(5);
            Gl.glTranslated(0, 0, -1);//5//Серединка //110
            WriteCube(COlorHande[2], COlorHande[6], COlorHande[6], COlorHande[6], COlorHande[6], COlorHande[6], StructCube[1, 1, 0].AlphaColor);
            WriteSoidCub();
            Gl.glPopMatrix();

            Gl.glPushMatrix();
            RotationForCube(6);
            Gl.glTranslated(0, 1, -1);
            WriteCube(COlorHande[2], COlorHande[6], COlorHande[6], COlorHande[4], COlorHande[6], COlorHande[6], 1);
            WriteSoidCub();
            Gl.glPopMatrix();
            //--------------------------------------------------//z=-1 +
            Gl.glPushMatrix();
            RotationForCube(7);
            Gl.glTranslated(1, -1, -1);
            WriteCube(COlorHande[2], COlorHande[5], COlorHande[6], COlorHande[6], COlorHande[3], COlorHande[6], 1);
            WriteSoidCub();
            Gl.glPopMatrix();

            Gl.glPushMatrix();
            RotationForCube(8);
            Gl.glTranslated(1, 0, -1);
            WriteCube(COlorHande[2], COlorHande[5], COlorHande[6], COlorHande[6], COlorHande[6], COlorHande[6], 1);
            WriteSoidCub();
            Gl.glPopMatrix();

            Gl.glPushMatrix();
            RotationForCube(9);
            Gl.glTranslated(1, 1, -1);
            WriteCube(COlorHande[2], COlorHande[5], COlorHande[6], COlorHande[4], COlorHande[6], COlorHande[6], 1);
            WriteSoidCub();
            Gl.glPopMatrix();

            //--------------------------------------------------//z=0 +
            Gl.glPushMatrix();
            RotationForCube(10);
            Gl.glTranslated(-1, -1, 0);
            WriteCube(COlorHande[6], COlorHande[6], COlorHande[0], COlorHande[6], COlorHande[3], COlorHande[6], 1);
            WriteSoidCub();
            Gl.glPopMatrix();

            Gl.glPushMatrix();
            RotationForCube(11);
            Gl.glTranslated(-1, 0, 0);
            //середина......................... 000
            WriteCube(COlorHande[6], COlorHande[6], COlorHande[0], COlorHande[6], COlorHande[6], COlorHande[6], StructCube[0, 1, 1].AlphaColor);
            WriteSoidCub();
            Gl.glPopMatrix();

            Gl.glPushMatrix();
            RotationForCube(12);
            Gl.glTranslated(-1, 1, 0);
            WriteCube(COlorHande[6], COlorHande[6], COlorHande[0], COlorHande[4], COlorHande[6], COlorHande[6], 1);
            WriteSoidCub();
            Gl.glPopMatrix();
            //--------------------------------------------------//z=0 +
            Gl.glPushMatrix();
            RotationForCube(13);
            Gl.glTranslated(0, -1, 0); // середина
            WriteCube(COlorHande[6], COlorHande[6], COlorHande[6], COlorHande[6], COlorHande[3], COlorHande[6], StructCube[1, 0, 1].AlphaColor);
            WriteSoidCub();
            Gl.glPopMatrix();

            Gl.glPushMatrix();
            RotationForCube(14);
            Gl.glTranslated(0, 0, 0);
            WriteCube(COlorHande[6], COlorHande[6], COlorHande[6], COlorHande[6], COlorHande[6], COlorHande[6], 1); //нулевой  
            WriteSoidCub();
            Gl.glPopMatrix();

            Gl.glPushMatrix();
            RotationForCube(15);
            Gl.glTranslated(0, 1, 0);
            // середина
            WriteCube(COlorHande[6], COlorHande[6], COlorHande[6], COlorHande[4], COlorHande[6], COlorHande[6], StructCube[1, 2, 1].AlphaColor);
            WriteSoidCub();
            Gl.glPopMatrix();
            //--------------------------------------------------//z=0 +
            Gl.glPushMatrix();
            RotationForCube(16);
            Gl.glTranslated(1, -1, 0);
            WriteCube(COlorHande[6], COlorHande[5], COlorHande[6], COlorHande[6], COlorHande[3], COlorHande[6], 1);
            WriteSoidCub();
            Gl.glPopMatrix();

            Gl.glPushMatrix();
            RotationForCube(17);
            Gl.glTranslated(1, 0, 0);
            //Середина!!!!
            WriteCube(COlorHande[6], COlorHande[5], COlorHande[6], COlorHande[6], COlorHande[6], COlorHande[6], StructCube[2, 1, 1].AlphaColor);
            WriteSoidCub();
            Gl.glPopMatrix();

            Gl.glPushMatrix();
            RotationForCube(18);
            Gl.glTranslated(1, 1, 0);
            WriteCube(COlorHande[6], COlorHande[5], COlorHande[6], COlorHande[4], COlorHande[6], COlorHande[6], 1);
            WriteSoidCub();
            Gl.glPopMatrix();


            //--------------------------------------------------//z=1 +
            Gl.glPushMatrix();
            RotationForCube(19);
            Gl.glTranslated(-1, -1, 1);
            WriteCube(COlorHande[6], COlorHande[6], COlorHande[0], COlorHande[6], COlorHande[3], COlorHande[1], 1);
            WriteSoidCub();
            Gl.glPopMatrix();

            Gl.glPushMatrix();
            RotationForCube(20);
            Gl.glTranslated(-1, 0, 1);
            WriteCube(COlorHande[6], COlorHande[6], COlorHande[0], COlorHande[6], COlorHande[6], COlorHande[1], 1);
            WriteSoidCub();
            Gl.glPopMatrix();

            Gl.glPushMatrix();
            RotationForCube(21);
            Gl.glTranslated(-1, 1, 1);
            WriteCube(COlorHande[6], COlorHande[6], COlorHande[0], COlorHande[4], COlorHande[6], COlorHande[1], 1);
            WriteSoidCub();
            Gl.glPopMatrix();
            //--------------------------------------------------//z=1 - 
            Gl.glPushMatrix();
            RotationForCube(22);
            Gl.glTranslated(0, -1, 1);
            WriteCube(COlorHande[6], COlorHande[6], COlorHande[6], COlorHande[6], COlorHande[3], COlorHande[1], 1); ;
            WriteSoidCub();
            Gl.glPopMatrix();

            Gl.glPushMatrix();
            RotationForCube(23);
            Gl.glTranslated(0, 0, 1);
            // тут что то не то Середина !!
            WriteCube(COlorHande[6], COlorHande[6], COlorHande[6], COlorHande[6], COlorHande[6], COlorHande[1], StructCube[1, 1, 2].AlphaColor);
            WriteSoidCub();
            Gl.glPopMatrix();

            Gl.glPushMatrix();
            RotationForCube(24);
            Gl.glTranslated(0, 1, 1);
            WriteCube(COlorHande[6], COlorHande[6], COlorHande[6], COlorHande[4], COlorHande[6], COlorHande[1], 1);
            WriteSoidCub();
            Gl.glPopMatrix();
            //--------------------------------------------------//z=1
            Gl.glPushMatrix();
            RotationForCube(25);
            Gl.glTranslated(1, -1, 1);
            WriteCube(COlorHande[6], COlorHande[5], COlorHande[6], COlorHande[6], COlorHande[3], COlorHande[1], 1);
            WriteSoidCub();
            Gl.glPopMatrix();

            Gl.glPushMatrix();
            RotationForCube(26);
            Gl.glTranslated(1, 0, 1);
            WriteCube(COlorHande[6], COlorHande[5], COlorHande[6], COlorHande[6], COlorHande[6], COlorHande[1], 1);
            WriteSoidCub();
            Gl.glPopMatrix();

            Gl.glPushMatrix();
            RotationForCube(27);
            Gl.glTranslated(1, 1, 1);
            WriteCube(COlorHande[6], COlorHande[5], COlorHande[6], COlorHande[4], COlorHande[6], COlorHande[1], 1);
            WriteSoidCub();
            Gl.glPopMatrix();
            //--------------------------------------------------//z=1


            // Gl.glPopMatrix();
        } // рисование кубика-рубика

        public void WriteSoidCub()
        {
            Gl.glPolygonMode(Gl.GL_FRONT_AND_BACK, Gl.GL_LINE);
            Gl.glLineWidth(7);
            WriteCube(COlorHande[6], COlorHande[6], COlorHande[6], COlorHande[6], COlorHande[6], COlorHande[6], 1);
            Gl.glPolygonMode(Gl.GL_FRONT_AND_BACK, Gl.GL_FILL);



        } // рисоване граней кубика

        private void button1_Click(object sender, EventArgs e) // основная работа 
        {
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);

            Gl.glLoadIdentity();
            Gl.glPushMatrix();
            Glu.gluLookAt(10, 0, 0, -10, 0, 0, 0, 1, 0);

            Gl.glTranslated(0.5f, 0.5f, 0.5f);
            Gl.glRotated(MouseDeltaX, 0, -1, 0);
            Gl.glRotated(MouseDeltaY, 1, 0, 0);
            Gl.glTranslated(-0.5f, -0.5f, -0.5f);
            // Gl.glRotated(Math.Sqrt(MouseDeltaX*MouseDeltaX+MouseDeltaY*MouseDeltaY), 0, 0, 1);

            WriteCubeRub();

            Gl.glPopMatrix();
            Gl.glFlush();

            AnT.Invalidate();

        }

        void AnimationOpenMenu(object sender, EventArgs e)
        {

            if (PanelMenu.Left >= AnT.Width - PanelMenu.Width)
            {
                PanelMenu.Left -= 10;
            }
            else
            {
                RenderAnimation.Enabled = false;
                RenderAnimation.Tick += EventHandler;

            }


        } // анимация для открывания "меню "

        void AnimationCloseMenu(object sender, EventArgs e)
        {
            if (PanelMenu.Location.X <= AnT.Width + PanelMenu.Width + 10)
            {

                PanelMenu.Left += 10;
                //RenderAnimation.Enabled = true;
            }
            else
            {
                RenderAnimation.Enabled = false;
                RenderAnimation.Tick += EventHandler;

            }
        }// анимация для закрывания "меню "

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
            LabelMenu.Visible = false;
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
            LabelMenu.Visible = true;
            RenderAnimation.Enabled = true;
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

        private void AnT_MouseCaptureChanged(object sender, EventArgs e)
        {

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
            if (TimeForRecords.MilleSecondsTime >= 100)
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


                TimeLabel.Visible = true;
                RecTimer.Enabled = true;
                StartGame = true;
            }
        }

        private int[] ConvertIntNameToMass(int IntName)
        {
            int[] ResultMass = new int[3];

            for (int Z = 0; Z < 3; Z++)
                for (int X = 0; X < 3; X++)
                    for (int Y = 0; Y < 3; Y++)
                    {
                        if (StructCube[X, Y, Z].IntNameCube == IntName)
                        {
                            ResultMass[0] = X;
                            ResultMass[1] = Y;
                            ResultMass[2] = Z;
                            break;
                        }

                    }
            return ResultMass;

        } //конвертация из IntNameCube в Его номера в масииве

        struct SSelectCube
        {
            public int X;
            public int Y;
            public int Z;
        };
        SSelectCube SelectedCube;
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
                         d       {
                                    SelectedCube.Y += 1;
                                    SelectedCube.Z = 3;
                                }
                               
                            }
                        }
                        break;
                    }

                case Keys.D: // test
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
                    }
                    label1.Text = (Convert.ToString(SelectedCube.X) + Convert.ToString(SelectedCube.Y) + Convert.ToString(SelectedCube.Z));
                   
                    StructCube[1, 1, 0].AlphaColor = NormalAlphaColor;
                    StructCube[1, 2, 1].AlphaColor = NormalAlphaColor;
                    StructCube[2, 1, 1].AlphaColor = NormalAlphaColor;
                    StructCube[0, 1, 1].AlphaColor = NormalAlphaColor;
                    StructCube[1, 0, 1].AlphaColor = NormalAlphaColor;
                    StructCube[1, 1, 2].AlphaColor = NormalAlphaColor;
                   

                    StructCube[SelectedCube.X - 1, SelectedCube.Y - 1, SelectedCube.Z - 1].AlphaColor = SelectAlphaColor;
            }


        }
    }



