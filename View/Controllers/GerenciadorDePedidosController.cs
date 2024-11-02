using View.Formularios;

namespace View.Controllers
{
    public class GerenciadorDePedidosController
    {
        private readonly GerenciadorDePedidosView _gerenciadorDePedidosView;

        public GerenciadorDePedidosController(GerenciadorDePedidosView view)
        {
            _gerenciadorDePedidosView = view;

            _gerenciadorDePedidosView.btnNovoPedido.Click += BtnNovoPedido_Click;
            _gerenciadorDePedidosView.btnEditarPedido.Click += BtnEditarPedido_Click;
        }

        private void BtnEditarPedido_Click(object? sender, EventArgs e)
        {
            EditarPedidoView editarPedidoView = new EditarPedidoView();

            EditarPedidoController editarPedidoController = new EditarPedidoController(editarPedidoView);

            editarPedidoView.ShowDialog();
        }

        private void BtnNovoPedido_Click(object? sender, EventArgs e)
        {
            EditarPedidoView editarPedidoView = new EditarPedidoView();

            EditarPedidoController editarPedidoController = new EditarPedidoController(editarPedidoView);

            editarPedidoView.ShowDialog();
        }
    }
}
