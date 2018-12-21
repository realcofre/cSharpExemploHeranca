namespace ExemploHeranca
{

    public class Pessoa
    {
        private string nome;
        private int idade;
        private Endereco endereco;

        public Pessoa(){}

        public Pessoa(string nome, int idade, Endereco endereco)
        {
            this.nome = nome;
            this.idade = idade;
            this.endereco = endereco;
            
        }

        public string Nome
        {
            get; set;
        }

        public int Idade 
        {
            get; set;
        }

        public Endereco _Endereco
        {
            get{return endereco;}
            set{endereco = value;}
        }

    }
}