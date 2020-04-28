namespace Model
{
    public class Carro
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Cor { get; set; }
        public int AnoFabricacao { get; set; }
        public int AnoModelo { get; set; }
        public Motor Motor { get; set; }
        public Garagem Garagem { get; set; }
        public string descricaoMotor { get; set; }
        public string nomeGaragem { get; set; }
    }
}