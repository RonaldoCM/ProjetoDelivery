
using Microsoft.VisualBasic.Logging;
using View.Controllers;
using View.Formularios;

namespace View
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Cria a View
            LogInView view = new LogInView();

            // Cria o Controller e vincula � View
            LogInController controller = new LogInController(view);

            // Executa a aplica��o
            Application.Run(view);


            // Se o login foi bem-sucedido e o formul�rio MenuView foi chamado
            if (view.DialogResult == DialogResult.OK)
            {
                MenuView menu = new MenuView();
                Application.Run(menu);  // Inicia o novo formul�rio como o principal
            }

        }
    }
}