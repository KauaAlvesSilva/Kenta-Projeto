// See https://aka.ms/new-console-template for more information
using Kenta_Projeto.Domain;
using Kenta_Projeto.Enum;


public class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Projeto Kauã Alves Silva");
        int quantidade = 0;
        int numero = 0;
        double resultado = 0;
        double num1 = 0;
       // Item item = new Item();
       // Comparator compara = new Comparator();

       //var teste =  compara.Compare(item, item);

        //Console.WriteLine($"Seu resultado é: {teste}");

        Console.WriteLine("Digite a quantidade!");
        quantidade = Convert.ToInt32(Console.ReadLine());        
        
        Console.WriteLine("Digite o número!");
        numero = Convert.ToInt32(Console.ReadLine());

        Pedido pedidos = new Pedido(quantidade, DateTime.Now, numero);   
     

        Console.WriteLine("Digite um valor!");
        num1 = Convert.ToDouble(Console.ReadLine());


        Console.WriteLine("Selecione o tipo de cliente:");
        Console.WriteLine("\ta - Comum");
        Console.WriteLine("\ts - Especial");
        Console.WriteLine("\tm - Associado");
        Console.WriteLine("\td - VIP");
        Console.Write("Sua opção?");

        // Use a switch statement to do the math.
        switch (Console.ReadLine())
        {
            case "a":
                resultado = pedidos.DescontoPedido(valor: num1, tipoCliente: TipoCliente.Comum);
                break;
            case "s":
                resultado = pedidos.DescontoPedido(valor: num1, tipoCliente: TipoCliente.Especial);

                break;
            case "m":
                resultado = pedidos.DescontoPedido(valor: num1, tipoCliente: TipoCliente.Associado);
                break;
            case "d":
                resultado = pedidos.DescontoPedido(valor: num1, tipoCliente: TipoCliente.VIP);
                break;
        }

        Console.WriteLine($"Seu resultado é: {resultado}");


        //Console.Write("Aperte enter para fechar o aplicativo");
        //Console.ReadKey();
    }
}