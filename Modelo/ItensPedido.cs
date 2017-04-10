using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechPizzaWF.Model
{
        public class ItemDoPedido {
            
            private int id;
            private int quantidade;
            //associa um produto
            private Pizza produto;
            
            //calcula o total de itens
            public double getTotalItem(){
                return this.quantidade * produto.getPreco();
            }

            public int getId() {
                return id;
            }

            public void setId(int id) {
                this.id = id;
            }

            public int getQuantidade() {
                return quantidade;
            }

            public void setQuantidade(int quantidade) {
                this.quantidade = quantidade;
            }

            public Pizza getProduto() {
                return produto;
            }

            public void setProduto(Pizza produto) {
                this.produto = produto;
            }

            public ItemDoPedido(int id, int quantidade, Pizza produto) {
                this.id = id;
                this.quantidade = quantidade;
                this.produto = produto;
            }

            public ItemDoPedido() {
            }
            
            
        }

    }

