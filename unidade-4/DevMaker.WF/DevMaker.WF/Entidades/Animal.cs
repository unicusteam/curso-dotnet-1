namespace DevMaker.WF.Entidades
{
    public class Animal
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public Especie Especie { get; set; }

        public Animal()
        { }

        public Animal(string nome, int idade, Especie especie)
        {
            Nome = nome;
            Idade = idade;
            Especie = especie;
        }
    }
}
