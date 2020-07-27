using GameTOP.Interface;

namespace GameTOP.Lib
{
    public class Jogador : iJogador
    {
        public readonly string _Nome;
 
        public Jogador(string nome = "Ronaldo")
        {
            _Nome = nome;
        }

        public void Chuta()
        {
            System.Console.WriteLine($"{_Nome} Está Chutando!");
        }

        public void Corre()
        {
            System.Console.WriteLine($"{_Nome} Está Correndo!");
        }

        public void Passe()
        {
            System.Console.WriteLine($"{_Nome} Está Passando!");
        }
    }
}