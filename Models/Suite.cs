namespace DesafioProjetoHospedagem.Models
{
    public class Suite
    {
        public Suite(string tipoSuite, int capacidade, decimal valorDiaria)
        {
            if (string.IsNullOrWhiteSpace(tipoSuite))
                throw new ArgumentException("Tipo da suíte deve ser informado.", nameof(tipoSuite));
            if (capacidade <= 0)
                throw new ArgumentException("Capacidade deve ser maior que zero.", nameof(capacidade));
            if (valorDiaria < 0)
                throw new ArgumentException("Valor da diária não pode ser negativo.", nameof(valorDiaria));

            TipoSuite = tipoSuite;
            Capacidade = capacidade;
            ValorDiaria = valorDiaria;
        }

        public string TipoSuite { get; set; }
        public int Capacidade { get; set; }
        public decimal ValorDiaria { get; set; }
    }
}
