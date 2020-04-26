using System;

namespace Model
{
    public class Atendimento
    {
        public Cliente Cliente { get; set; }
        public Carro Carro { get; set; }
        public DateTime Data { get; set; }
    }
}