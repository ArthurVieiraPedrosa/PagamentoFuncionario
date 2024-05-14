using System;

namespace PagamentoFuncionairo.Entites
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public int Horas { get; private set; }
        public double ValorPorHora { get; private set; }
        public Funcionario() { }
        public Funcionario(string nome, int horas, double valorPorHora)
        {
            Nome = nome;
            Horas = horas;
            ValorPorHora = valorPorHora;
        }

        public void setNome(string nome)
        {
            Nome = nome;
        }
        public void setHoras(int horas)
        {
            Horas = horas;
        }
        public void setValorPorHora(int valorPorHora)
        {
            ValorPorHora = valorPorHora;
        }

        public virtual double Pagamento()
        {
            return ValorPorHora * Horas;
        }


        public override string ToString()
        {
            return base.ToString();
        }
    }

}

