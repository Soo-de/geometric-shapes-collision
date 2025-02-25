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
    internal class Sphere
    {
        private int x;
        private int y;
        private int z;
        private int SphereW;
        private int SphereH;
        private int SphereZ;
        private int MovementX;
        private int MovementY;
        

        public int Z
        {
            get { return z; }
            set { z = value; }
        }

        public int T
        {
            get { return SphereZ; }
            set { SphereZ = value; }
        }


        public int MoveY
        {
            get { return MovementY; }
            set { MovementY = value; }
        }


        public int MoveX
        {
            get { return MovementX; }
            set { MovementX = value; }
        }


        public int H
        {
            get { return SphereH; }
            set { SphereH = value; }
        }
        public int W
        {
            get { return SphereW; }
            set { SphereW = value; }
        }

        public int Y
        {
            get { return y; }
            set { y = value; }
        }
        public int X
        {
            get { return x; }
            set { x = value; }
        }
        public Sphere()//constructor for first values
        {
            this.X = 270;
            this.Y = 220;
            this.Z = 0;
            this.W = 100;
            this.H = 100;
            this.T = 100;
            this.MoveX = 3;
            this.MoveY = 3;
        }
        public Sphere(int x, int y, int w, int h, int mx, int my,int z,int t)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
            this.W = w;
            this.H = h;
            this.T = t;
            this.MoveX = mx;
            this.MoveY = my;
        }
    }
}
