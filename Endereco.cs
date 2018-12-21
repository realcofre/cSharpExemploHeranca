namespace ExemploHeranca
{
    public class Endereco
    {
        private string logradouro;
        private string numero;
        private string complemento;
        

        public Endereco(){}

        public Endereco(string logradouro, string numero, string complemento)
        {
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;        
        }

        public string Logradouro
        {
            get;set;
        }

        public string Numero
        {
            get; set;
        }

        public string Complemento 
        {
            get; set;
        }

    }
}