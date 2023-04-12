using Kenta_Projeto.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kenta_Projeto.Domain
{
    public class Pedido
    {
        public int Quantidade { get; private set; }
        public DateTime Data { get; private set; }
        public int Numero { get; private set; }
        public Pedido(int quantidade, DateTime data, int numero) 
        { 
            Quantidade = quantidade;
            Data = data;
            Numero = numero;
        }
        public double DescontoPedido(double valor, TipoCliente tipoCliente)
        {
            double valorFinal = 0;
            switch (tipoCliente)
            {
                case TipoCliente.Especial:
                    valorFinal = CalculoDesconto(valor,50);
                    break;
                case TipoCliente.Associado:
                    valorFinal = CalculoDesconto(valor,20);
                    break;
                case TipoCliente.VIP:
                    valorFinal = CalculoDesconto(valor, 70);
                    break;
                case TipoCliente.Comum:
                    valorFinal = valor;
                    break;
            }       
            return valorFinal;
        }

        public double CalculoDesconto(double valor, double desconto)
        {
            return valor - desconto;
        }
    }



}
