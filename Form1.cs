//***********************************************************************************************************************
//**                                                                                                                   **
//**                                     SAKARYA �N�VERS�TES�                                                          **
//**                          B�LG�SAYAR VE B�L���M B�L�MLER� FAK�LTES�                                                **
//**                                B�LG�SAYAR M�HEND�SL��� B�L�M�                                                     **
//**                                                                                                                   **
//**                                  �DEV NUMARASI..: 2                                                               **
//**                                  ��RENC� ADI.....: SUDE ANDURMAN                                                  **
//**                                  ��RENC� NUMARASI: b231210005                                                     **
//**                                  DERS GRUBU......: B                                                              **
//**                                                                                                                   ** 
//**                                                                                                                   **  
//**            Ama�: Baz� geometrik �ekilleri �izdirip bunlar�n �arp��ma kontrol�n� ger�ekle�tirmek                   **
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
