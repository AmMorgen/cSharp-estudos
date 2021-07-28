using System;

namespace structs
{
    class Program
    {
        struct Personagem
        {
            public string nome;
            public string elemento;
            public int atk;
            public float def;
            public float atkCrit;
            public int ProfElemental;

            public Personagem(string nome, string elemento, int atk, float def, float atkCrit, int ProfElemental)
            {
                this.nome = nome;
                this.elemento = elemento;
                this.atk = atk;
                this.def = def;
                this.atkCrit = atkCrit;
                this.ProfElemental = ProfElemental;
            }

            public void ExibirInfo()
            {
                Console.WriteLine($"Nome: {this.nome}");
                Console.WriteLine($"elemento: {this.elemento}");
                Console.WriteLine($"ataque: {this.atk}");
                Console.WriteLine($"defesa: {this.def}");
                Console.WriteLine($"Ataque Critico: {this.atkCrit}");
                Console.WriteLine($"Prociencia elemental: {this.ProfElemental}");
            }
        }

        static void Main(string[] args)
        {
            Personagem Diluc = new Personagem("cavaleiro negro de monstad", "pyro", 225, 75.2f, 75.7f, 80);
            Personagem Albedo = new Personagem("Alquemista solitario", "Geo", 125, 220.5f, 30.7f, 125);

            Diluc.ExibirInfo();
            Console.WriteLine("============================================");
            Albedo.ExibirInfo();
            Console.ReadLine();
            
        }
    }
}
