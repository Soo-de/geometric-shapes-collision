//***********************************************************************************************************************
//**                                                                                                                   **
//**                                     SAKARYA ÜNİVERSİTESİ                                                          **
//**                          BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ                                                **
//**                                BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ                                                     **
//**                                                                                                                   **
//**                                  ÖDEV NUMARASI..: 2                                                               **
//**                                  ÖĞRENCİ ADI.....: SUDE ANDURMAN                                                  **
//**                                  ÖĞRENCİ NUMARASI: b231210005                                                     **
//**                                  DERS GRUBU......: B                                                              **
//**                                                                                                                   ** 
//**                                                                                                                   **  
//**            Amaç: Bazı geometrik şekilleri çizdirip bunların çarpışma kontrolünü gerçekleştirmek                   **
//**                                                                                                                   **
//**                                                                                                                   **  
//**                                                                                                                   **
//***********************************************************************************************************************


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NDP_2._ODEV
{
    public partial class CollisionTest : Form
    {
        public CollisionTest()
        {
            InitializeComponent();
            /*Tried to stop shapes' glitching but could not achieve */
            this.SetStyle(
                ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint, true
                );
            this.UpdateStyles();
        }
       
        private void button_return1_Click(object sender, EventArgs e)
        {
            MainPage mainPage = new MainPage();
            mainPage.Show();
            this.Hide();
        } /*Returning to main page*/

        /*Creating object*/
        MyPoint myPoint = new MyPoint();

        square mySquare = new square();

        Rectangle myRectangle = new Rectangle();
        Rectangle myRectangle2 = new Rectangle();

        Circle myCircle = new Circle();
        Circle myCircle2= new Circle();

        Sphere mySphere = new Sphere();
        Sphere mySphere2 = new Sphere();

        Surface mySurface = new Surface();

        private void timer_Move_Tick(object sender, EventArgs e)
        {
           
            if (comboBox_Decision.SelectedIndex == 0)
            {
                text_CollisionControl.Text = "";//clear the label
                Graphics shape1 = stage_Collision.CreateGraphics();
                shape1.Clear(stage_Collision.BackColor);//clear the stage for the moving effect
                shape1.FillEllipse(Brushes.DarkSeaGreen, myPoint.X, myPoint.Y, myPoint.W, myPoint.H);//draw point
                shape1.FillRectangle(Brushes.DarkSeaGreen, mySquare.X, mySquare.Y, mySquare.W, mySquare.H);//draw square

                /*for point's movement*/
                myPoint.X += myPoint.MoveX;//moving X
                if (myPoint.X < 0 || myPoint.X + myPoint.W > stage_Collision.Width)//to control whether the shape stay in the stage
                {
                    myPoint.MoveX = -myPoint.MoveX;
                    myPoint.X += myPoint.MoveX;
                }
                myPoint.Y += myPoint.MoveY;//moving Y
                if (myPoint.Y < 0 || myPoint.Y + myPoint.W > stage_Collision.Height)//to control whether the shape stay in the stage
                {
                    myPoint.MoveY = -myPoint.MoveY;
                    myPoint.Y += myPoint.MoveY;
                }

                /*for square's movement*/
                mySquare.X += mySquare.MoveX;//moving X
                if (mySquare.X < 0 || mySquare.X + mySquare.W > stage_Collision.Width)//to control whether the shape stay in the stage
                {
                    mySquare.MoveX = -mySquare.MoveX;
                    mySquare.X += mySquare.MoveX;
                }
                mySquare.Y += mySquare.MoveY;//moving Y
                if (mySquare.Y < 0 || mySquare.Y + mySquare.W > stage_Collision.Height)//to control whether the shape stay in the stage
                {
                    mySquare.MoveY = -mySquare.MoveY;
                    mySquare.Y += mySquare.MoveY;
                }

                /*Checking if the collision happened*/
                if (CollisionControls.Point_Square(myPoint, mySquare))
                {
                    text_CollisionControl.Text = "Çarpışma Gerçekleşti";//if happened, changing label's text
                }

            } //POINT & SQUARE COLLISION
            else if (comboBox_Decision.SelectedIndex == 1)
            {
                text_CollisionControl.Text = "";//clear the label
                Graphics shape1 = stage_Collision.CreateGraphics();
                shape1.Clear(stage_Collision.BackColor);//clear the stage for moving effect
                shape1.FillRectangle(Brushes.DarkSeaGreen, myRectangle.X,myRectangle.Y,myRectangle.W,myRectangle.H);//draw rectangle
                shape1.FillEllipse(Brushes.DarkSeaGreen, myPoint.X, myPoint.Y, myPoint.W, myPoint.H);//draw point

                /*for point's movement*/
                myPoint.X += myPoint.MoveX;// moving X
                if (myPoint.X < 0 || myPoint.X + myPoint.W > stage_Collision.Width)//to control whether the shape stay in the stage
                {
                    myPoint.MoveX = -myPoint.MoveX;
                    myPoint.X += myPoint.MoveX;
                }
                myPoint.Y += myPoint.MoveY;// moving Y
                if (myPoint.Y < 0 || myPoint.Y + myPoint.W > stage_Collision.Height)//to control whether the shape stay in the stage
                {
                    myPoint.MoveY = -myPoint.MoveY;
                    myPoint.Y += myPoint.MoveY;
                }

                /*for rectangle's movement*/
                myRectangle.X += myRectangle.MoveX;// moving X
                if (myRectangle.X < 0 || myRectangle.X + myRectangle.W > stage_Collision.Width)//to control whether the shape stay in the stage
                {
                    myRectangle.MoveX = -myRectangle.MoveX;
                    myRectangle.X += myRectangle.MoveX;
                }
                myRectangle.Y += myRectangle.MoveY;// moving Y
                if (myRectangle.Y < 0 || myRectangle.Y + myRectangle.H > stage_Collision.Height)//to control whether the shape stay in the stage
                {
                    myRectangle.MoveY = -myRectangle.MoveY;
                    myRectangle.Y += myRectangle.MoveY;
                }

                /*Checking if the collision happened*/
                if (CollisionControls.Point_Rectangle(myPoint, myRectangle))
                {
                    text_CollisionControl.Text = "Çarpışma Gerçekleşti";  //if happened, changing label's text        
                }

            }//POINT & RECTANGLE COLLISION
            else if (comboBox_Decision.SelectedIndex == 2) 
            {
                text_CollisionControl.Text = "";//clear the label
                Graphics shape1 = stage_Collision.CreateGraphics();
                Pen line = new Pen(Color.DarkSeaGreen, 3);
                shape1.Clear(stage_Collision.BackColor);//clear the stage for moving effect
                shape1.FillEllipse(Brushes.DarkSeaGreen, myPoint.X, myPoint.Y, myPoint.W, myPoint.H);//draw point
                shape1.DrawEllipse(line, myCircle.X,myCircle.Y,myCircle.W,myCircle.H);//draw circle

                /*for point's movement*/
                myPoint.X += myPoint.MoveX;//moving X
                if (myPoint.X < 0 || myPoint.X + myPoint.W > stage_Collision.Width)//to control whether the shape stay in the stage
                {
                    myPoint.MoveX = -myPoint.MoveX;
                    myPoint.X += myPoint.MoveX;
                }
                myPoint.Y += myPoint.MoveY;//moving Y
                if (myPoint.Y < 0 || myPoint.Y + myPoint.W > stage_Collision.Height)//to control whether the shape stay in the stage
                {
                    myPoint.MoveY = -myPoint.MoveY;
                    myPoint.Y += myPoint.MoveY;
                }

                /*for point's movement*/
                myCircle.X += myCircle.MoveX;//moving X
                if (myCircle.X < 0 || myCircle.X + myCircle.W > stage_Collision.Width)//to control whether the shape stay in the stage
                {
                    myCircle.MoveX = -myCircle.MoveX;
                    myCircle.X += myCircle.MoveX;
                }
                myCircle.Y += myCircle.MoveY;//moving Y
                if (myCircle.Y < 0 || myCircle.Y + myCircle.W > stage_Collision.Height)//to control whether the shape stay in the stage
                {
                    myCircle.MoveY = -myCircle.MoveY;
                    myCircle.Y += myCircle.MoveY;
                }

                /*Checking if the collision happened*/
                if (CollisionControls.Point_Circle(myPoint, myCircle))
                {
                    text_CollisionControl.Text = "Çarpışma Gerçekleşti";//if happened, changing label's text
                }            
            }//POINT & CIRCLE COLLISION
            else if (comboBox_Decision.SelectedIndex == 3) 
            {
                text_CollisionControl.Text = "";//clear the label
                Graphics shape1 = stage_Collision.CreateGraphics();
                shape1.Clear(stage_Collision.BackColor);//clear the stage for moving effect
                shape1.FillEllipse(Brushes.DarkSeaGreen, myPoint.X, myPoint.Y, myPoint.W, myPoint.H);//draw point
                shape1.FillEllipse(Brushes.DarkSeaGreen, mySphere.X,mySphere.Y,mySphere.W,mySphere.H);//draw sphere

                /*for point's movement*/
                myPoint.X += myPoint.MoveX;//moving X
                if (myPoint.X < 0 || myPoint.X + myPoint.W > stage_Collision.Width)//to control whether the shape stay in the stage
                {
                    myPoint.MoveX = -myPoint.MoveX;
                    myPoint.X += myPoint.MoveX;
                }
                myPoint.Y += myPoint.MoveY;//moving Y
                if (myPoint.Y < 0 || myPoint.Y + myPoint.W > stage_Collision.Height)//to control whether the shape stay in the stage
                {
                    myPoint.MoveY = -myPoint.MoveY;
                    myPoint.Y += myPoint.MoveY;
                }

                /*for sphere's movement*/
                mySphere.X += mySphere.MoveX;//moving X
                if (mySphere.X < 0 || mySphere.X + mySphere.W > stage_Collision.Width)//to control whether the shape stay in the stage
                {
                    mySphere.MoveX = -mySphere.MoveX;
                    mySphere.X += mySphere.MoveX;
                }
                mySphere.Y += mySphere.MoveY;//moving Y
                if (mySphere.Y < 0 || mySphere.Y + mySphere.W > stage_Collision.Height)//to control whether the shape stay in the stage
                {
                    mySphere.MoveY = -mySphere.MoveY;
                    mySphere.Y += mySphere.MoveY;
                }

                /*Checking if the collision happened*/
                if (CollisionControls.Point_Sphere(myPoint, mySphere))
                {
                    text_CollisionControl.Text = "Çarpışma Gerçekleşti";//if happened, changing label's text
                }
            }//POINT & SPHERE COLLISION
            else if (comboBox_Decision.SelectedIndex == 4) 
            {
                text_CollisionControl.Text = "";//clear the label
                Graphics shape1 = stage_Collision.CreateGraphics();
                shape1.Clear(stage_Collision.BackColor);//clear the stage for moving effect
            }//POINT & CYLINDER COLLISION
            else if (comboBox_Decision.SelectedIndex == 5) 
            {
                text_CollisionControl.Text = "";//clear the label
                Graphics shape1 = stage_Collision.CreateGraphics();
                shape1.Clear(stage_Collision.BackColor);//clear the stage for moving effect
                shape1.FillRectangle(Brushes.DarkSeaGreen, myRectangle.X, myRectangle.Y, myRectangle.W, myRectangle.H);//draw rectangle
                shape1.FillRectangle(Brushes.DarkSeaGreen, myRectangle2.X - 160, myRectangle2.Y - 200, myRectangle2.W, myRectangle2.H);//draw second rectangle 
                
                /*for first rectangle's movement*/
                myRectangle.X += myRectangle.MoveX;//moving X
                if (myRectangle.X < 0 || myRectangle.X + myRectangle.W > stage_Collision.Width)//to control whether the shape stay in the stage
                {
                    myRectangle.MoveX = -myRectangle.MoveX;
                    myRectangle.X += myRectangle.MoveX;
                }
                myRectangle.Y += myRectangle.MoveY;//moving Y
                if (myRectangle.Y < 0 || myRectangle.Y + myRectangle.H > stage_Collision.Height)//to control whether the shape stay in the stage
                {
                    myRectangle.MoveY = -myRectangle.MoveY;
                    myRectangle.Y += myRectangle.MoveY;
                }

                /*for second rectangle's movement*/
                myRectangle2.X += myRectangle2.MoveX;//move X
                if (myRectangle2.X-160 < 0 || myRectangle2.X-160 + myRectangle2.W > stage_Collision.Width)//to control whether the shape stay in the stage
                {
                    myRectangle2.MoveX = -myRectangle2.MoveX;
                    myRectangle2.X += myRectangle2.MoveX;
                }
                myRectangle2.Y += myRectangle2.MoveY;//move Y
                if (myRectangle2.Y-200 < 0 || myRectangle2.Y-200 + myRectangle2.H > stage_Collision.Height)//to control whether the shape stay in the stage
                {
                    myRectangle2.MoveY = -myRectangle2.MoveY;
                    myRectangle2.Y += myRectangle2.MoveY;
                }

                /*Checking if the collision happened*/
                if (CollisionControls.Rectangle_Rectangle(myRectangle, myRectangle2))
                {
                    text_CollisionControl.Text = "Çarpışma Gerçekleşti";//if happened, changing label's text
                }
           
            }//RECTANGLE & RECTANGLE COLLISION
            else if (comboBox_Decision.SelectedIndex == 6)
            {
                text_CollisionControl.Text = "";//clear the label
                Graphics shape1 = stage_Collision.CreateGraphics();
                Pen line = new Pen(Color.DarkSeaGreen, 3);
                shape1.Clear(stage_Collision.BackColor);//clear the stage for moving effect
                shape1.FillRectangle(Brushes.DarkSeaGreen, myRectangle2.X-160, myRectangle2.Y-200, myRectangle2.W, myRectangle2.H);//draw rectangle
                shape1.DrawEllipse(line, myCircle.X, myCircle.Y, myCircle.W, myCircle.H);//draw circle

                /*for rectangle's movement*/
                myRectangle2.X += myRectangle2.MoveX;//moving X
                if (myRectangle2.X-160 < 0 || myRectangle2.X-160 + myRectangle2.W > stage_Collision.Width)//to control whether the shape stay in the stage
                {
                    myRectangle2.MoveX = -myRectangle2.MoveX;
                    myRectangle2.X += myRectangle2.MoveX;
                }
                myRectangle2.Y += myRectangle2.MoveY;//moving Y
                if (myRectangle2.Y-200 < 0 || myRectangle2.Y-200 + myRectangle2.H > stage_Collision.Height)//to control whether the shape stay in the stage
                {
                    myRectangle2.MoveY = -myRectangle2.MoveY;
                    myRectangle2.Y += myRectangle2.MoveY;
                }

                /*for circle's movement*/
                myCircle.X += myCircle.MoveX;//moving X
                if (myCircle.X < 0 || myCircle.X + myCircle.W > stage_Collision.Width)//to control whether the shape stay in the stage
                {
                    myCircle.MoveX = -myCircle.MoveX;
                    myCircle.X += myCircle.MoveX;
                }
                myCircle.Y += myCircle.MoveY;//moving Y
                if (myCircle.Y < 0 || myCircle.Y + myCircle.W > stage_Collision.Height)//to control whether the shape stay in the stage
                {
                    myCircle.MoveY = -myCircle.MoveY;
                    myCircle.Y += myCircle.MoveY;
                }

                /*Checking if the collision happened*/
                if (CollisionControls.Rectangle_Circle(myRectangle2, myCircle))
                {
                    text_CollisionControl.Text = "Çarpışma Gerçekleşti";//if happened, changing label's text
                }
            }//RECTANGLE & CIRCLE COLLISION
            else if (comboBox_Decision.SelectedIndex == 7) 
            {
                text_CollisionControl.Text = "";//clear the label
                Graphics shape1 = stage_Collision.CreateGraphics();
                Pen line = new Pen(Color.DarkSeaGreen, 3);
                shape1.Clear(stage_Collision.BackColor);//clear the stage for moving effect
                shape1.DrawEllipse(line, myCircle.X, myCircle.Y, myCircle.W, myCircle.H);//draw circle
                shape1.DrawEllipse(line, myCircle2.X-160, myCircle2.Y-200, myCircle2.W, myCircle2.H);//draw second circle

                /*for first circle's movement*/
                myCircle.X += myCircle.MoveX;//moving X
                if (myCircle.X < 0 || myCircle.X + myCircle.W > stage_Collision.Width)//to control whether the shape stay in the stage
                {
                    myCircle.MoveX = -myCircle.MoveX;
                    myCircle.X += myCircle.MoveX;
                }
                myCircle.Y += myCircle.MoveY;//moving Y
                if (myCircle.Y < 0 || myCircle.Y + myCircle.W > stage_Collision.Height)//to control whether the shape stay in the stage
                {
                    myCircle.MoveY = -myCircle.MoveY;
                    myCircle.Y += myCircle.MoveY;
                }

                /*for second circle's movement*/
                myCircle2.X += myCircle2.MoveX;//moving X
                if (myCircle2.X-160 < 0 || myCircle2.X-160 + myCircle2.W > stage_Collision.Width)//to control whether the shape stay in the stage
                {
                    myCircle2.MoveX = -myCircle2.MoveX;
                    myCircle2.X += myCircle2.MoveX;
                }
                myCircle2.Y += myCircle2.MoveY;//moving Y
                if (myCircle2.Y-200 < 0 || myCircle2.Y-200 + myCircle2.W > stage_Collision.Height)//to control whether the shape stay in the stage
                {
                    myCircle2.MoveY = -myCircle2.MoveY;
                    myCircle2.Y += myCircle2.MoveY;
                }

                /*Checking if the collision happened*/
                if (CollisionControls.Circle_Circle(myCircle, myCircle2))
                {
                    text_CollisionControl.Text = "Çarpışma Gerçekleşti";//if happened, changing label's text
                }

            }//CIRCLE & CIRCLE COLLISION
            else if (comboBox_Decision.SelectedIndex == 8) 
            {
                text_CollisionControl.Text = "";//clear the label
                Graphics shape1 = stage_Collision.CreateGraphics();
                shape1.Clear(stage_Collision.BackColor);//clear the stage for moving effect
            }//CYLINDER & CYLINDER COLLISION
            else if (comboBox_Decision.SelectedIndex == 9) 
            {
                text_CollisionControl.Text = "";//clear the label
                Graphics shape1 = stage_Collision.CreateGraphics();
                shape1.Clear(stage_Collision.BackColor);//clear the stage for moving effect
                shape1.FillRectangle(Brushes.DarkSeaGreen, myRectangle2.X - 160, myRectangle2.Y - 200, myRectangle2.W, myRectangle2.H);//draw rectangle
                shape1.FillEllipse(Brushes.DarkSeaGreen, mySphere.X, mySphere.Y, mySphere.W, mySphere.H);//draw sphere

                /*for rectangle's movement */
                myRectangle2.X += myRectangle2.MoveX;//moving X
                if (myRectangle2.X - 160 < 0 || myRectangle2.X - 160 + myRectangle2.W > stage_Collision.Width)//to control whether the shape stay in the stage
                {
                    myRectangle2.MoveX = -myRectangle2.MoveX;
                    myRectangle2.X += myRectangle2.MoveX;
                }
                myRectangle2.Y += myRectangle2.MoveY;//moving Y
                if (myRectangle2.Y - 200 < 0 || myRectangle2.Y - 200 + myRectangle2.H > stage_Collision.Height)//to control whether the shape stay in the stage
                {
                    myRectangle2.MoveY = -myRectangle2.MoveY;
                    myRectangle2.Y += myRectangle2.MoveY;
                }

                /*for sphere's movement*/
                mySphere.X += mySphere.MoveX;//moving X
                if (mySphere.X < 0 || mySphere.X + mySphere.W > stage_Collision.Width)//to control whether the shape stay in the stage
                {
                    mySphere.MoveX = -mySphere.MoveX;
                    mySphere.X += mySphere.MoveX;
                }
                mySphere.Y += mySphere.MoveY;//moving Y
                if (mySphere.Y < 0 || mySphere.Y + mySphere.W > stage_Collision.Height)//to control whether the shape stay in the stage
                {
                    mySphere.MoveY = -mySphere.MoveY;
                    mySphere.Y += mySphere.MoveY;
                }

                /*Checking if the collision happened*/
                if (CollisionControls.Sphere_Rectangle(mySphere,myRectangle2))
                {
                    text_CollisionControl.Text = "Çarpışma Gerçekleşti";//if happened, changing label's text
                }
            }//SPHERE & RECTANGLE COLLISION
            else if (comboBox_Decision.SelectedIndex == 10) 
            {
                text_CollisionControl.Text = "";//clear the label
                Graphics shape1 = stage_Collision.CreateGraphics();
                shape1.Clear(stage_Collision.BackColor);//clear the stage for moving effect
                shape1.FillEllipse(Brushes.DarkSeaGreen, mySphere.X, mySphere.Y, mySphere.W, mySphere.H);//draw sphere
                shape1.FillEllipse(Brushes.DarkSeaGreen, mySphere2.X-160, mySphere2.Y-200, mySphere2.W, mySphere2.H);//draw second sphere

                /*for first sphere's movement*/
                mySphere.X += mySphere.MoveX;//moving X
                if (mySphere.X < 0 || mySphere.X + mySphere.W > stage_Collision.Width)//to control whether the shape stay in the stage
                {
                    mySphere.MoveX = -mySphere.MoveX;
                    mySphere.X += mySphere.MoveX;
                }
                mySphere.Y += mySphere.MoveY;//moving Y
                if (mySphere.Y < 0 || mySphere.Y + mySphere.W > stage_Collision.Height)//to control whether the shape stay in the stage
                {
                    mySphere.MoveY = -mySphere.MoveY;
                    mySphere.Y += mySphere.MoveY;
                }

                /*for second sphere's movement*/
                mySphere2.X += mySphere2.MoveX;//moving X
                if (mySphere2.X-160 < 0 || mySphere2.X-160 + mySphere2.W > stage_Collision.Width)//to control whether the shape stay in the stage
                {
                    mySphere2.MoveX = -mySphere2.MoveX;
                    mySphere2.X += mySphere2.MoveX;
                }
                mySphere2.Y += mySphere2.MoveY;//moving Y
                if (mySphere2.Y-200 < 0 || mySphere2.Y-200 + mySphere2.W > stage_Collision.Height)//to control whether the shape stay in the stage
                {
                    mySphere2.MoveY = -mySphere2.MoveY;
                    mySphere2.Y += mySphere2.MoveY;
                }

                /*Checking if the collision happened*/
                if (CollisionControls.Sphere_Sphere(mySphere, mySphere2))
                {
                    text_CollisionControl.Text = "Çarpışma Gerçekleşti";//if happened, changing label's text
                }

            }//SPHERE & SPHERE COLLISION
            else if (comboBox_Decision.SelectedIndex == 11)
            {
                text_CollisionControl.Text = "";//clear the label
                Graphics shape1 = stage_Collision.CreateGraphics();
                shape1.Clear(stage_Collision.BackColor);//clear the stage for moving effect
            }//SPHERE & CYLINDER COLLISION
            else if (comboBox_Decision.SelectedIndex == 12) 
            {
                text_CollisionControl.Text = "";//clear the label
                Graphics shape1 = stage_Collision.CreateGraphics();
                shape1.Clear(stage_Collision.BackColor);//clear the stage for moving effect
                Point[] points = { new Point(mySurface.UpLX,mySurface.UpLY), new Point(mySurface.UpRX, mySurface.UpRY), new Point(mySurface.BotRX, mySurface.BotRY), new Point(mySurface.BotLX, mySurface.BotLY) };//determine 4 points to draw
                shape1.FillPolygon(Brushes.DarkSeaGreen, points);//draw surface
                shape1.FillEllipse(Brushes.DarkSeaGreen, mySphere.X, mySphere.Y, mySphere.W, mySphere.H);//draw sphere

                /*for sphere's movement*/
                mySphere.X += mySphere.MoveX;//moving X
                if (mySphere.X < 0 || mySphere.X + mySphere.W > stage_Collision.Width)//to control whether the shape stay in the stage
                {
                    mySphere.MoveX = -mySphere.MoveX;
                    mySphere.X += mySphere.MoveX;
                }
                mySphere.Y += mySphere.MoveY;//moving Y
                if (mySphere.Y < 0 || mySphere.Y + mySphere.W > stage_Collision.Height)//to control whether the shape stay in the stage
                {
                    mySphere.MoveY = -mySphere.MoveY;
                    mySphere.Y += mySphere.MoveY;
                }

                /*for surface's movement*/
                mySurface.UpLX += mySurface.MoveX;//moving top
                mySurface.UpLY += mySurface.MoveX;
                mySurface.UpRY += mySurface.MoveX;
                mySurface.UpRX += mySurface.MoveX;
                if (mySurface.UpLX < 0 || mySurface.UpRX> stage_Collision.Width)//to control whether the shape stay in the stage
                {
                    mySurface.MoveX = -mySurface.MoveX;

                    mySurface.UpLX += mySurface.MoveX;
                    mySurface.UpLY += mySurface.MoveX;
                    mySurface.UpRY += mySurface.MoveX;
                    mySurface.UpRX += mySurface.MoveX;
                }
                mySurface.BotRY += mySurface.MoveY;//moving bottom
                mySurface.BotRX += mySurface.MoveY;
                mySurface.BotLX += mySurface.MoveY;
                mySurface.BotLY += mySurface.MoveY;
                if (mySurface.BotLY < 0|| mySurface.BotLY>stage_Collision.Width || mySurface.UpRY-mySurface.BotRY > stage_Collision.Height || mySurface.UpLY - mySurface.BotLY > stage_Collision.Height)//to control whether the shape stay in the stage
                {
                    mySurface.MoveY = -mySurface.MoveY;

                    mySurface.BotRY += mySurface.MoveY;
                    mySurface.BotRX += mySurface.MoveY;
                    mySurface.BotLX += mySurface.MoveY;
                    mySurface.BotLY += mySurface.MoveY;
                }

                /*Checking if the collision happened*/
                if (CollisionControls.Surface_Sphere(mySurface,mySphere))
                {
                    text_CollisionControl.Text = "Çarpışma Gerçekleşti";//if happened, changing label's text
                }

            }//SURFACE & SPHERE
            else if (comboBox_Decision.SelectedIndex == 13) 
            {
                text_CollisionControl.Text = "";//clear the label
                Graphics shape1 = stage_Collision.CreateGraphics();
                shape1.Clear(stage_Collision.BackColor);//clear the stage for moving effect
                Point[] points = { new Point(mySurface.UpLX, mySurface.UpLY), new Point(mySurface.UpRX, mySurface.UpRY), new Point(mySurface.BotRX, mySurface.BotRY), new Point(mySurface.BotLX, mySurface.BotLY) };//determine 4 points to draw
                shape1.FillPolygon(Brushes.DarkSeaGreen, points);//draw surface
                shape1.FillRectangle(Brushes.DarkSeaGreen, mySquare.X, mySquare.Y, mySquare.W, mySquare.H);//draw square

                /*for square's movement*/
                mySquare.X += mySquare.MoveX;//moving X
                if (mySquare.X < 0 || mySquare.X + mySquare.W > stage_Collision.Width)//to control whether the shape stay in the stage
                {
                    mySquare.MoveX = -mySquare.MoveX;
                    mySquare.X += mySquare.MoveX;
                }
                mySquare.Y += mySquare.MoveY;//moving Y
                if (mySquare.Y < 0 || mySquare.Y + mySquare.W > stage_Collision.Height)//to control whether the shape stay in the stage
                {
                    mySquare.MoveY = -mySquare.MoveY;
                    mySquare.Y += mySquare.MoveY;
                }

                /*for surface's movement*/
                mySurface.UpLX += mySurface.MoveX;//moving top
                mySurface.UpLY += mySurface.MoveX;
                mySurface.UpRY += mySurface.MoveX;
                mySurface.UpRX += mySurface.MoveX;
                if (mySurface.UpLX < 0 || mySurface.UpRX > stage_Collision.Width)//to control whether the shape stay in the stage
                {
                    mySurface.MoveX = -mySurface.MoveX;

                    mySurface.UpLX += mySurface.MoveX;
                    mySurface.UpLY += mySurface.MoveX;
                    mySurface.UpRY += mySurface.MoveX;
                    mySurface.UpRX += mySurface.MoveX;
                }
                mySurface.BotRY += mySurface.MoveY;//moving bottom
                mySurface.BotRX += mySurface.MoveY;
                mySurface.BotLX += mySurface.MoveY;
                mySurface.BotLY += mySurface.MoveY;
                if (mySurface.BotLY < 0 || mySurface.BotLY > stage_Collision.Width || mySurface.UpRY - mySurface.BotRY > stage_Collision.Height || mySurface.UpLY - mySurface.BotLY > stage_Collision.Height)//to control whether the shape stay in the stage
                {
                    mySurface.MoveY = -mySurface.MoveY;

                    mySurface.BotRY += mySurface.MoveY;
                    mySurface.BotRX += mySurface.MoveY;
                    mySurface.BotLX += mySurface.MoveY;
                    mySurface.BotLY += mySurface.MoveY;
                }

                /*Checking if the collision happened*/
                if (CollisionControls.Surface_Square(mySurface, mySquare))
                {
                    text_CollisionControl.Text = "Çarpışma Gerçekleşti";//if happened, changing label's text
                }

            }//SURFACE & SQUARE
            else if (comboBox_Decision.SelectedIndex == 14) 
            {
                text_CollisionControl.Text = "";//clear the label
                Graphics shape1 = stage_Collision.CreateGraphics();
                shape1.Clear(stage_Collision.BackColor);//clear the stage for moving effect
                Point[] points = { new Point(mySurface.UpLX, mySurface.UpLY), new Point(mySurface.UpRX, mySurface.UpRY), new Point(mySurface.BotRX, mySurface.BotRY), new Point(mySurface.BotLX, mySurface.BotLY) };//determine 4 points to draw
                shape1.FillPolygon(Brushes.DarkSeaGreen, points);//draw surface
                shape1.FillRectangle(Brushes.DarkSeaGreen, myRectangle.X, myRectangle.Y, myRectangle.W, myRectangle.H);

                /*for rectangle's movement*/
                myRectangle.X += myRectangle.MoveX;// moving X
                if (myRectangle.X < 0 || myRectangle.X + myRectangle.W > stage_Collision.Width)//to control whether the shape stay in the stage
                {
                    myRectangle.MoveX = -myRectangle.MoveX;
                    myRectangle.X += myRectangle.MoveX;
                }
                myRectangle.Y += myRectangle.MoveY;// moving Y
                if (myRectangle.Y < 0 || myRectangle.Y + myRectangle.H > stage_Collision.Height)//to control whether the shape stay in the stage
                {
                    myRectangle.MoveY = -myRectangle.MoveY;
                    myRectangle.Y += myRectangle.MoveY;
                }

                /*for surface's movement*/
                mySurface.UpLX += mySurface.MoveX;//moving top
                mySurface.UpLY += mySurface.MoveX;
                mySurface.UpRY += mySurface.MoveX;
                mySurface.UpRX += mySurface.MoveX;
                if (mySurface.UpLX < 0 || mySurface.UpRX > stage_Collision.Width)//to control whether the shape stay in the stage
                {
                    mySurface.MoveX = -mySurface.MoveX;

                    mySurface.UpLX += mySurface.MoveX;
                    mySurface.UpLY += mySurface.MoveX;
                    mySurface.UpRY += mySurface.MoveX;
                    mySurface.UpRX += mySurface.MoveX;
                }
                mySurface.BotRY += mySurface.MoveY;//moving bottom
                mySurface.BotRX += mySurface.MoveY;
                mySurface.BotLX += mySurface.MoveY;
                mySurface.BotLY += mySurface.MoveY;
                if (mySurface.BotLY < 0 || mySurface.BotLY > stage_Collision.Width || mySurface.UpRY - mySurface.BotRY > stage_Collision.Height || mySurface.UpLY - mySurface.BotLY > stage_Collision.Height)//to control whether the shape stay in the stage
                {
                    mySurface.MoveY = -mySurface.MoveY;

                    mySurface.BotRY += mySurface.MoveY;
                    mySurface.BotRX += mySurface.MoveY;
                    mySurface.BotLX += mySurface.MoveY;
                    mySurface.BotLY += mySurface.MoveY;
                }

                /*Checking if the collision happened*/
                if (CollisionControls.Surface_Rectangle(mySurface, myRectangle))
                {
                    text_CollisionControl.Text = "Çarpışma Gerçekleşti";//if happened, changing label's text
                }

            }//SURFACE & RECTANGLE
            else 
            {
                text_CollisionControl.Text = "";//clear the label
                Graphics shape1 = stage_Collision.CreateGraphics();
                shape1.Clear(stage_Collision.BackColor);//clear the stage for moving effect
            }//3D_RECTANGLE & 3D_RECTANGLE



        }

    }
}
