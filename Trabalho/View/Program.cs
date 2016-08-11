using System;
using System.Windows.Forms;



namespace View
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            FrmLogin login = new FrmLogin();
            if (login.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new FrmMenu());
            }
            /*
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            FrmLogin login = new FrmLogin();
            if (login.ShowDialog() == DialogResult.Yes)
            {
                login.Close();
                Application.Run(new FrmMenu());
            }
            else
            {
                MessageBox.Show("Usuário ou senha inválido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
             */
        }
    }
}
