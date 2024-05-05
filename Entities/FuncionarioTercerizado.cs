using System;
namespace PagamentoFuncionairo;
public class FuncionarioTercerizado : Funcionario
{
    public double CobrancaAdicional { get; private set;}
    public FuncionarioTercerizado(){}
    public FuncionarioTercerizado(string nome, int horas, int valorPorHora, double cobrancaAdicional) : base(nome, horas, valorPorHora)
    {
        CobrancaAdicional = cobrancaAdicional;
    }
    
    public void setValorDaCobrancaAdicional(double cobrancaAdicional)
    {
        CobrancaAdicional = cobrancaAdicional;
    }   
   
    public override double Pagamento(){
        return (ValorPorHora*Horas)*1.1;
    }

    public override string ToString(){
        return base.ToString();
    }
}