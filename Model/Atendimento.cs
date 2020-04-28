using System;

namespace Model
{
    public class Atendimento
    {
        public int Id { get; set; }
        public Cliente Cliente { get; set; }
        public Carro Carro { get; set; }
        public DateTime Data { get; set; }
        public string nomeCliente { get; set; }
        public string nomeCarro { get; set; }
    }
}