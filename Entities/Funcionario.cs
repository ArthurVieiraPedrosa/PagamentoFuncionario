using System;
namespace PagamentoFuncionairo;
public class Funcionario
{
    private string _nome;
    public int Horas { get; private set; }
    public int ValorPorHora { get; private set; }
    public Funcionario(){}
    public Funcionario(string nome, int horas, int valorPorHora){
        _nome = nome;
        Horas = horas;
        ValorPorHora = valorPorHora;
    }
    public string Nome
    {
        get { return _nome; }
        set 
        {
            if (value != null && value.Length > 1){
                _nome = value;
            }
        }
    }
    public void setNome(string nome){
        Nome = nome;
    }
    public void setHoras(int horas){
        Horas = horas;
    }
    public void setValorPorHora(int valorPorHora){
        ValorPorHora = valorPorHora;
    }

    public virtual double Pagamento(){
        return ValorPorHora*Horas;
    }


    public override string ToString()
    {
        return base.ToString();
    }
}