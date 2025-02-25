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
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDP_2._ODEV
{
    internal static class CollisionControls
    {
        public static bool Point_Square(MyPoint p1,square s1)
        {
            int sX = s1.X + s1.W / 2;//square's width
            int sY= s1.Y + s1.H / 2;//square's height

            /*To calculate distance between square and point*/
            float d = (float)Math.Sqrt(Math.Pow((p1.X - sX), 2) + Math.Pow((p1.Y - sY), 2));

            /*Collision control*/
            if (s1.W/2+p1.W/2>(int)d)
                return true;
            else
                return false;
        }/*POINT AND SQUARE CONTROL*/

        public static bool Point_Rectangle(MyPoint p1,Rectangle r1) 
        {
            int rX = r1.X + r1.W / 2;//rectangle's width
            int rY = r1.Y + r1.H / 2;//rectengle's height

            /*To calculate distance between rectangle and point*/
            float d = (float)Math.Sqrt(Math.Pow((p1.X - rX), 2) + Math.Pow((p1.Y - rY), 2));

            /*Collision control*/
            if (r1.W / 2 + p1.W / 2 > (int)d) 
                return true;
            else
                return false;
        }/*POINT AND RECTANGLE CONTROL*/

        public static bool Point_Circle(MyPoint p1,Circle c1) 
        {
            /*calculating circle's  width and height + calculating distance between circle and point*/
            float d = (float)Math.Sqrt(Math.Pow(((c1.X+c1.W/2) - p1.X), 2) + Math.Pow(((c1.Y+c1.H) - p1.Y), 2));

            /*Colision control*/
            if((c1.W/2+ p1.W/2) >(int) d) 
                return true;
            else 
                return false;
        }/*POINT AND CIRCLE CONTROL*/

        public static bool Point_Sphere(MyPoint p1,Sphere s1) 
        {
            /*calculating sphere's  width and height + calculating distance between sphere and point*/
            float d = (float)Math.Sqrt(Math.Pow(((s1.X + s1.W / 2) - p1.X), 2) + Math.Pow(((s1.Y + s1.H) - p1.Y), 2));

            /*Collision control*/
            if ((s1.W / 2 + p1.W / 2) > (int)d)
                return true;
            else
                return false;
        }/*POINT AND SPHERE CONTROL*/

        public static bool Rectangle_Rectangle(Rectangle r1, Rectangle r2)
        {
            int r1X = r1.X + r1.W / 2;//for rectangle's width
            int r1Y = r1.Y + r1.H / 2;//for rectangle's height
            int r2X = r2.X-160 + r2.W / 2;//for rectangle2's width
            int r2Y = r2.Y-200 + r2.H / 2;//for rectangle2's height

            /*Collision control*/
            if (Math.Abs(r1X - r2X) < (r1.W / 2 + r2.W / 2) && Math.Abs(r1Y - r2Y) < (r1.H / 2 + r2.H / 2))
                return true;
            else 
                return false;
        }/*RECTANGLE AND RECTANGLE CONTROL*/

        public static bool Rectangle_Circle(Rectangle r1, Circle c1) 
        {
            int rX = r1.X-160 + r1.W / 2;//for rectangle's width
            int rY = r1.Y-200 + r1.H / 2;//for rectangle's height
            int cX = c1.X + c1.W / 2;//to determine circle's widht
            int cY = c1.Y + c1.H / 2;//to determine circle's height

            /*calculate distance between ractangle and circle*/
            float d = (float)Math.Sqrt(Math.Pow((cX - rX), 2) + Math.Pow((cY - rY), 2));

            /*Collision control*/
            if (r1.W / 2 + c1.W / 2 > (int)d)
                return true;
            else
                return false;
        }/*RECTANGLE AND CIRCLE CONTROL*/
        
        public static bool Circle_Circle(Circle c1, Circle c2)
        {
            /*calculate distance between circles' and calculate their width and height*/
            float d = (float)Math.Sqrt(Math.Pow(((c1.X + c1.W / 2) - (c2.X-160 + c2.W / 2)), 2) + Math.Pow(((c1.Y + c1.H) - (c2.Y-200 + c2.H)), 2));

            /*Collision control*/
            if ((c1.W / 2 + c2.W / 2) > (int)d)
                return true;
            else
                return false;
        }/*CIRCLE AND CIRCLE CONTROL*/

        public static bool Sphere_Rectangle(Sphere s1, Rectangle r1)
        {
            int rX = r1.X - 160 + r1.W / 2;//for ractangle's width
            int rY = r1.Y - 200 + r1.H / 2;// for rectangle's height
            int sX = s1.X + s1.W / 2;//for sphere's widht
            int sY = s1.Y + s1.H / 2;//for sphere's height

            /*calculate distance between sphere and rectangle*/
            float d = (float)Math.Sqrt(Math.Pow((sX - rX), 2) + Math.Pow((sY - rY), 2));

            /*Collision control*/
            if (r1.W / 2 + s1.W / 2 > (int)d)
                return true;
            else
                return false;

        }/*SPHERE AND RECTANGLE CONTROL*/

        public static bool Sphere_Sphere(Sphere s1, Sphere s2)
        {
            int sX = s1.X + s1.W / 2;//for sphere's width
            int sY = s1.Y + s1.H / 2;//for sphere's height
            int s2X = s2.X - 160 + s2.W / 2;//for sphere2's width
            int s2Y = s2.Y - 160 + s2.H / 2;//for sphere2's height

            /*calculate distance between speheres'*/
            float d = (float)Math.Sqrt(Math.Pow((sX - s2X), 2) + Math.Pow((sY - s2Y), 2));

            /*Collision test*/
            if ((s1.W / 2 + s2.W / 2) > (int)d)
                return true;
            else
                return false;
        }/*SPHERE AND SPHERE CONTROL*/

        public static bool Surface_Sphere(Surface s1, Sphere s2)
        {
            int s2X = s2.X + s2.W / 2;//for sphere's width
            int s2Y = s2.Y + s2.H / 2;//for sphere's height
            int sX = s1.UpRX - s1.UpLX / 2;//for surface's width
            int sY = s1.BotRX + s1.BotLX / 2;//for surface's height

            /*calculate distance between sphere and surface*/
            float d = (float)Math.Sqrt(Math.Pow((sX - s2X), 2) + Math.Pow((sY - s2Y), 2));

            /*Collision control*/
            if (sX / 2 + s2.W / 2 > (int)d)
                return true;
            else
                return false;
        }

        public static bool Surface_Square(Surface s1, square s2)
        {
            int sX = s1.UpRX - s1.UpLX / 2;//for surface's width
            int sY = s1.BotRX + s1.BotLX / 2;//for surface's height
            int s2X = s2.X + s2.W / 2;//square's width
            int s2Y = s2.Y + s2.H / 2;//square's height

            /*Collision control*/
            if (Math.Abs(sX - s2X) < (Math.Abs(s1.UpRX-s1.UpLX) / 2 + s2.W / 2) && Math.Abs(sY - s2Y) < (Math.Abs(s1.BotRX - s1.BotLX) + s2.H / 2))
                return true;
            else
                return false;
        }

        public static bool Surface_Rectangle(Surface s1, Rectangle r1) 
        {
            int sX = s1.UpRX - s1.UpLX / 2;//for surface's width
            int sY = s1.BotRX + s1.BotLX / 2;//for surface's height
            int r1X = r1.X + r1.W / 2;//rectangle's width
            int r1Y = r1.Y + r1.H / 2;//rectengle's height

            /*Collision control*/
            if (Math.Abs(r1X - sX) < (r1.W / 2 + sX / 2) && Math.Abs(r1Y - sY) < (r1.H / 2 + sY / 2))
                return true;
            else
                return false;
        }
    }
}
