using System.Collections.Generic;

namespace Model
{
    public class Garagem
    {
        public int Id { get; set; }
        public string CNPJ { get; set; }
        public List<Carro> carros { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
    }
}