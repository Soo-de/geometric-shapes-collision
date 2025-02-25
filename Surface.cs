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
    internal class Surface
    {
		private int x1;
		private int x2;
		private int x3;
		private int x4;
		private int y1;
		private int y2;
		private int y3;
		private int y4;
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

		public int BotLY
		{
			get { return y4; }
			set { y4 = value; }
		}


		public int BotRY
		{
			get { return y3; }
			set { y3 = value; }
		}

		public int UpRY
		{
			get { return y2; }
			set { y2 = value; }
		}

		public int UpLY
		{
			get { return y1; }
			set { y1 = value; }
		}

		public int BotLX
		{
			get { return x4; }
			set { x4 = value; }
		}


		public int BotRX
		{
			get { return x3; }
			set { x3 = value; }
		}

		public int UpRX
		{
			get { return x2; }
			set { x2 = value; }
		}

		public int UpLX
		{
			get { return x1; }
			set { x1 = value; }
		}

        public Surface()//constructor for first values
        {
            UpLX = 50;
			UpRX = 150;
			BotRX = 100;
			BotLX = 0;
            UpLY = 0;
			UpRY = 0;
			BotRY = 50;
			BotLY = 50;
			MoveX = 3;
			MoveY=3;
        }
        public Surface(int ulx,int urx,int brx,int blx,int uly,int ury, int bry, int bly,int mx,int my)
        {
            UpLX = ulx;
            UpRX = urx;
            BotRX = brx;
            BotLX = blx;
            UpLY = uly;
            UpRY = ury;
            BotRY = bry;
            BotLY = bly;
			MoveX = mx;
			MoveY = my;
        }
    }
}
