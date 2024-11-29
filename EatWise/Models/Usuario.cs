namespace EatWise.Models
{
    public class Usuario
    {
        public Guid UsuarioId { get; set; }
        public string Nome { get; set; }
        public DateOnly DataNascimento { get; set; }
        public string Email { get; set; }
        public string Altura { get; set; }
        public decimal Peso { get; set; }
        public string Telefone { get; set; }
        public string? Tipo { get; set; }
        public string CPF { get; set; }
        public string CalcularIMC()
        {
            if (decimal.TryParse(Altura, out decimal altura) && Peso > 0 && altura > 0)
            {
                // Calcular IMC: peso / (altura * altura)
                decimal imc = Peso / (altura * altura);

                // Classificação do IMC
                if (imc < 18.5m)
                {
                    return "Baixo Peso";
                }
                else if (imc >= 18.5m && imc < 24.9m)
                {
                    return "Normal";
                }
                else if (imc >= 25m && imc < 29.9m)
                {
                    return "Sobrepeso";
                }
                else if (imc >= 30m && imc < 34.9m)
                {
                    return "Obesidade Grau I";
                }
                else if (imc >= 35m && imc < 39.9m)
                {
                    return "Obesidade Grau II";
                }
                else
                {
                    return "Obesidade Grau III";
                }
            }
            return "Dados inválidos";
        }


        public string CalcularIMCDetalhado()
        {
            if (decimal.TryParse(Altura, out decimal altura) && Peso > 0 && altura > 0)
            {
                decimal imc = Peso / (altura * altura);

                string categoria = "";
                string sugestaoCalorias = "";

                // Classificação do IMC e sugestão de calorias
                if (imc < 18.5m)
                {
                    categoria = "Baixo Peso";
                    sugestaoCalorias = "Sugestão: Aumente sua ingestão calórica para ganhar peso. Aproximadamente 2500-3000 calorias por dia.";
                }
                else if (imc >= 18.5m && imc < 24.9m)
                {
                    categoria = "Normal";
                    sugestaoCalorias = "Sugestão: Mantenha sua ingestão calórica atual. Aproximadamente 2000-2500 calorias por dia, dependendo do seu nível de atividade.";
                }
                else if (imc >= 25m && imc < 29.9m)
                {
                    categoria = "Sobrepeso";
                    sugestaoCalorias = "Sugestão: Reduza a ingestão calórica para perder peso. Aproximadamente 1800-2200 calorias por dia.";
                }
                else if (imc >= 30m && imc < 34.9m)
                {
                    categoria = "Obesidade Grau I";
                    sugestaoCalorias = "Sugestão: Reduza a ingestão calórica e adote uma dieta balanceada. Aproximadamente 1500-2000 calorias por dia.";
                }
                else if (imc >= 35m && imc < 39.9m)
                {
                    categoria = "Obesidade Grau II";
                    sugestaoCalorias = "Sugestão: Consulte um nutricionista para um plano alimentar personalizado. Aproximadamente 1500-1800 calorias por dia.";
                }
                else
                {
                    categoria = "Obesidade Grau III";
                    sugestaoCalorias = "Sugestão: Procure um médico para acompanhamento e adote um plano alimentar controlado. Aproximadamente 1200-1500 calorias por dia.";
                }

                return $"{categoria} - {sugestaoCalorias}";
            }
            return "Dados inválidos";
        }
        public int Idade
        {
            get
            {
                var today = DateOnly.FromDateTime(DateTime.Today);
                var idade = today.Year - DataNascimento.Year;

                if (DataNascimento > today.AddYears(-idade))
                    idade--;

                return idade;
            }
        }

        public string FaixaEtaria
        {
            get
            {
                if (Idade >= 0 && Idade <= 12) return "Criança";
                if (Idade >= 13 && Idade <= 17) return "Adolescente";
                if (Idade >= 18 && Idade <= 59) return "Adulto";
                return "Idoso";
            }
        }
    }
}