using Delivery.Controllers;
using Delivery.Formularios;

namespace Delivery
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
           // ApplicationConfiguration.Initialize();
           // Application.Run(new PessoaView());


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Cria a View
            PessoaView view = new PessoaView();

            // Cria o Controller e vincula à View
            PessoaController controller = new PessoaController(view);

            // Executa a aplicação
            Application.Run(view);


        }
    }
}