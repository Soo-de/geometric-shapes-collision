//***********************************************************************************************************************
//**                                                                                                                   **
//**                                     SAKARYA ÜNÝVERSÝTESÝ                                                          **
//**                          BÝLGÝSAYAR VE BÝLÝÞÝM BÝLÝMLERÝ FAKÜLTESÝ                                                **
//**                                BÝLGÝSAYAR MÜHENDÝSLÝÐÝ BÖLÜMÜ                                                     **
//**                                                                                                                   **
//**                                  ÖDEV NUMARASI..: 2                                                               **
//**                                  ÖÐRENCÝ ADI.....: SUDE ANDURMAN                                                  **
//**                                  ÖÐRENCÝ NUMARASI: b231210005                                                     **
//**                                  DERS GRUBU......: B                                                              **
//**                                                                                                                   ** 
//**                                                                                                                   **  
//**            Amaç: Bazý geometrik þekilleri çizdirip bunlarýn çarpýþma kontrolünü gerçekleþtirmek                   **
//**                                                                                                                   **
//**                                                                                                                   **  
//**                                                                                                                   **
//***********************************************************************************************************************


namespace NDP_2._ODEV
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }
        /*Switching to Collision Test Form*/
        private void Button_Collusion_Click(object sender, EventArgs e)
        {
            CollisionTest collisionTest = new CollisionTest();
            collisionTest.Show();
            this.Hide();
        }
        /*Switching to Drawing Form */
        private void button1_Click(object sender, EventArgs e)
        {
            Drawing drawing = new Drawing();
            drawing.Show();
            this.Hide();

        }
    }
}
