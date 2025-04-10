using System.Threading.Channels;

namespace Clube_Da_Leitura_2025
{
   public  class TelaAmigo
    {
        public Amigo[] amigos = new Amigo[100];
        public int contadoramigos = 0;


        public void CadastrarAmigo()
       {

            Console.WriteLine("informe o nome do amigo ");
            string nome = Console.ReadLine();

            Console.WriteLine("Informe o nome do responsável pelo amigo");
            string responsalvel = Console.ReadLine();

            Console.WriteLine("Informe o Numero de telefone ");
            string numeroTelefone = Console.ReadLine();

            Amigo Novoamigo = new Amigo(nome, responsalvel, numeroTelefone);

            amigos[contadoramigos++] = Novoamigo;

        }

    }
}
