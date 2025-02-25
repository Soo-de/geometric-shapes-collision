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
    internal class square
    {
		private int x;
		private int y;
		private int SquareW;
		private int SquareH;
        private int MovementX;
        private int MovementY;


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
			get { return SquareH; }
			set { SquareH = value; }
		}


		public int W
		{
			get { return SquareW; }
			set { SquareW = value; }
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
        public square()//constructor for first values
        {
            this.X = 270;
			this.Y = 220;
			this.W = 100;
			this.H = 100;
			this.MoveX = 3;
			this.MoveY = 3;
        }
        public square(int x,int y, int w, int h,int mx,int my)
        {
			this.X = x;
			this.Y = y;
			this.W = w;
			this.H = h;
			this.MoveX= mx;
			this.MoveY= my;
        }
		
    }
}
