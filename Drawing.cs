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
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NDP_2._ODEV
{
    public partial class Drawing : Form
    {

        public Drawing()
        {
            InitializeComponent();
        }
       
        private void button_return2_Click(object sender, EventArgs e)
        {
            MainPage mainPage = new MainPage();
            mainPage.Show();
            this.Hide();
        }/*To return Main Page*/

        public void button_Point_Click(object sender, EventArgs e)
        {
            /*Clear the page */
            stage_Drawing.Refresh();

            /*Drawing */
            SolidBrush filling = new SolidBrush(Color.DarkSeaGreen);
            Graphics drawing = stage_Drawing.CreateGraphics();
            drawing.FillEllipse(filling, new RectangleF(188, 162, 10, 10));

        }/*To draw point*/

        private void button_Square_Click(object sender, EventArgs e)
        {
            /*To clear the stage*/
            stage_Drawing.Refresh();

            /*To drawing the square*/
            SolidBrush filling = new SolidBrush(Color.DarkSeaGreen);
            Graphics drawing = stage_Drawing.CreateGraphics();
            drawing.FillRectangle(filling, new RectangleF(140, 117, 100, 100));

        }/*To draw square*/
        private void button_Rectangle_Click(object sender, EventArgs e)
        {
            /*To clear the page*/
            stage_Drawing.Refresh();

            /*To draw the rectangle*/
            SolidBrush filling = new SolidBrush(Color.DarkSeaGreen);
            Graphics drawing = stage_Drawing.CreateGraphics();
            drawing.FillRectangle(filling, new RectangleF(93, 117, 200, 100));


        }/*To draw rectangle*/

        private void button_3dRectangle_Click(object sender, EventArgs e)
        {
            /*To clear the page*/
            stage_Drawing.Refresh();

            /*To draw the 3d rectangle*/

            SolidBrush filling = new SolidBrush(Color.DarkSeaGreen);//for front rectangle 
            SolidBrush filling2 = new SolidBrush(Color.MediumSeaGreen);//for back rectangle
            Pen line = new Pen(Color.DarkSeaGreen, 2);//to connect rectangles
            Graphics drawing = stage_Drawing.CreateGraphics();
            drawing.FillRectangle(filling2, new RectangleF(150, 100, 100, 75));//back rectangle
            drawing.FillRectangle(filling, new RectangleF(100, 150, 100, 75));//front rectangle
            drawing.DrawLine(line, 100, 150, 150, 100);//connection 1
            drawing.DrawLine(line, 200, 225, 250, 175);//connection 2
            drawing.DrawLine(line, 200, 150, 250, 100);//connection 3

        }/*To draw 3d rectangle*/

        private void button_Circle_Click(object sender, EventArgs e)
        {
            /*To clear the page*/
            stage_Drawing.Refresh();

            /*To draw the circle*/
            Pen line = new Pen(Color.DarkSeaGreen, 3);
            Graphics drawing = stage_Drawing.CreateGraphics();
            drawing.DrawEllipse(line, new RectangleF(140, 117, 100, 100));

        }/*To draw circle*/

        private void button_Sphere_Click(object sender, EventArgs e)
        {
            /*To clear the stage*/
            stage_Drawing.Refresh();

            /*To draw the sphere*/
            SolidBrush filling = new SolidBrush(Color.DarkSeaGreen);
            Graphics drawing = stage_Drawing.CreateGraphics();
            drawing.FillEllipse(filling, new RectangleF(140, 117, 100, 100));


        }/*To draw sphere*/

        private void button_Cylinder_Click(object sender, EventArgs e)
        {
            /*To clear the stage*/
            stage_Drawing.Refresh();

            /*To draw the cylinder*/

            SolidBrush filling = new SolidBrush(Color.DarkSeaGreen);//For upper ellipse
            SolidBrush filling2 = new SolidBrush(Color.MediumSeaGreen);//Foe bottom ellipse
            Pen line = new Pen(Color.DarkSeaGreen, 3);//to connect ellipses
            Graphics drawing = stage_Drawing.CreateGraphics();
            drawing.FillEllipse(filling2, new RectangleF(140, 210, 100, 25));//bottom ellipse
            drawing.DrawLine(line, 140, 110, 140, 225);//connection 1
            drawing.DrawLine(line, 240, 110, 240, 225);//connection 2
            drawing.FillEllipse(filling, new RectangleF(140, 100, 100, 25));//upper ellipes
        }/*To draw cylinder*/

        private void button_Surface_Click(object sender, EventArgs e)
        {
            /*To clear the stage*/
            stage_Drawing.Refresh();

            /*To draw the surface*/
            Pen line = new Pen(Color.DarkSeaGreen, 3);
            SolidBrush filling = new SolidBrush(Color.DarkSeaGreen);
            Graphics drawing = stage_Drawing.CreateGraphics();
            Point[] points = { new Point(150, 160), new Point(250, 160), new Point(200, 200), new Point(100, 200) };//determine 4 points to draw
            drawing.FillPolygon(filling, points);

        }/*To draw surface*/
    }
}
