using System;
using System.Windows.Forms;
using FC.Simbra.Apresentacao.Gerencial;
using FC.Simbra.Aplicacao.Common;

namespace FC.Simbra.Apresentacao
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Configurar o NHibernate
            ConfigurarAplicacao.ConfigurarNHibernate();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
