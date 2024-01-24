using suave.Models;

namespace suave.Repositories.Interfaces
{
    public interface IPedidoRepository
    {
        void CriarPedido(Pedido pedido);
    }
}