using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechPizzaWF.Model
{


public class Pedido {

            private int id;
            //lista de item de uma venda
            private List<ItemDoPedido> itensDoPedido;
            private int status;

            //método que adiciona itens a uma venda
            public void addItemDoPedido(ItemDoPedido novoItem)
            {
                if (this.itensDoPedido == null)
                {
                    this.itensDoPedido = new List<ItemDoPedido>();
                }
                itensDoPedido.Add(novoItem);
            }

            //calcula o total para a venda atual
            public double calcularTotalDaVenda()
            {
                double total = 0;
                foreach (ItemDoPedido item in itensDoPedido)
                {
                    total += item.getTotalItem();
                }
                return total;
            }

            public int getId()
            {
                return id;
            }

            public void setId(int id)
            {
                this.id = id;
            }

            public List<ItemDoPedido> getItensDoPedido()
            {
                return itensDoPedido;
            }

            public void setItensDoPedido(List<ItemDoPedido> itensDoPedido)
            {
                this.itensDoPedido = itensDoPedido;
            }

            public int getStatus()
            {
                return status;
            }

            public void setStatus(int status)
            {
                this.status = status;
            }

    }

}
