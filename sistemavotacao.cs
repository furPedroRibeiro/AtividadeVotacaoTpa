using System;
public class Program
{
    public static void Main()
    {
        string pedroVitor="Pedro Vitor Garcia Moura", rafaelRudink="Rafael Rudink de Campos", pedroLuis="Pedro Luis de Alencar Ribeiro";
        int votoPedro=0, votoRafa=0, votoLuis=0;
        int x, y, x2=0;
        int repeat1=0, repeat2=1;
        string confirmed="";
        while(repeat2==1 || repeat2==2){
            Console.Clear();
        Console.WriteLine(" Olá meu querido eleitor, bem vindo ao nosso sistema de votação ;) \n\n Escolha com sabedoria, e escolha bem!! \n\n Vamos lá? \n\n O que você deseja fazer? \n 1- Votar \n 2- Ver quantidade de votos \n 3- Sair do programa ;-;");
        y=int.Parse(Console.ReadLine());
			switch(y){
            case 1:
                repeat1=1;
                break;
            case 2:
                Console.Clear();
                Console.WriteLine("Quantidade de votos: \n\n Pedro Vitor Garcia Moura: "+votoPedro+"\n Rafael Rudink de Campos: "+votoRafa+"\n Pedro Luis de Alencar Ribeiro: "+votoLuis);
                Console.WriteLine("\nPara voltar, pressione 1");
                repeat2=int.Parse(Console.ReadLine());
                break;
            case 3:
                repeat2=0;
                Console.Clear();
                Console.WriteLine("Até a próxima eleição!! ;)");
                break;  
            default:
                Console.WriteLine("Opção inválida !!!!");
                break;
        	}
		}
	}
}
