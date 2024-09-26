namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        public decimal precoInicial = 0;
        public decimal precoPorHora = 0;
        public List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            Console.Clear();
            System.Console.WriteLine("-----CADASTRANDO  VEICULOS--------");
            System.Console.WriteLine("");
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placa = Console.ReadLine();
            veiculos.Add(placa);
            System.Console.WriteLine("");
            System.Console.WriteLine("veiculo adicionado com sucesso!");
            System.Console.WriteLine("");
            int opcao = 3;
            while (opcao != 1 && opcao != 2)
            {
                System.Console.WriteLine("Deseja adicionar outro veiculo?");
                System.Console.WriteLine(" 1 ---- Sim");
                System.Console.WriteLine(" 2 ---- Não");
                opcao = Convert.ToInt32(Console.ReadLine());
                if (opcao == 1)
                {
                    AdicionarVeiculo();
                }
                else if (opcao == 2)
                {
                    break;
                }
                else
                {
                    Console.Clear();
                    System.Console.WriteLine("opção invalida!");
                    Thread.Sleep(1000);
                }
            }
        }
        public void RemoverVeiculo()
        {
            Console.Clear();
            System.Console.WriteLine("------REMOVENDO VEICULOS------");
            System.Console.WriteLine("");
            Console.WriteLine("Digite a placa do veículo para remover:");
            string placa = Console.ReadLine();
            System.Console.WriteLine("");

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                int horas = 0;
                System.Console.WriteLine("Veiculo encontrado!");
                System.Console.WriteLine("-----------------------------------------------------------------------");
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                horas = Convert.ToInt32(Console.ReadLine());
                decimal valorTotal = 0;
                valorTotal = precoInicial + precoPorHora * horas;


                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
                veiculos.Remove(placa);
                System.Console.WriteLine("");

            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
                System.Console.WriteLine("");
            }
        }
        public void ListarVeiculos()
        {
            Console.Clear();
            System.Console.WriteLine("------LISTANDO VEICULOS------");
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.Clear();
                Console.WriteLine("Os veículos estacionados são:");
                System.Console.WriteLine("");

                int contador = 1;
                foreach (string listarVeiculo in veiculos)
                {

                    System.Console.WriteLine($" A placa do °{contador} veiculo  é: {listarVeiculo} ");
                    contador++;
                    System.Console.WriteLine("---------------------------------------------------------");
                }
                System.Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
