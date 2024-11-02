using View.Formularios;

namespace View.Controllers
{
    public class MenuController
    {

        private readonly MenuView _menuView;

        public MenuController(MenuView view)
        {
            _menuView = view;

            _menuView.btnGerenciadorDePedidos.Click += NextFormulario;
        }

        private void NextFormulario(object sender, EventArgs e)
        {
            GerenciadorDePedidosView gerenciadorView = new GerenciadorDePedidosView();

            GerenciadorDePedidosController gerenciadorController = new GerenciadorDePedidosController(gerenciadorView);

            gerenciadorView.Show();
        }
    }
}
