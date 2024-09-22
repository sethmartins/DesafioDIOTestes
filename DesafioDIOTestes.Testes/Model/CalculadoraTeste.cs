using DesafioDIOTestes.Console.Interfaces;
using DesafioDIOTestes.Console.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioDIOTestes.Testes.Model;

public class CalculadoraTeste
{
    private readonly IOperacoesBasicas operacoes;
    public CalculadoraTeste()
    {
        this.operacoes = new Calculadora();
    }
    [Fact]
    public void SomarTeste()
    {
        //arrange
        float a = 4; 
        float b = 5;
        
        //Act
        float c = this.operacoes.Soma(a, b);
        float x = 9;
        //Assert
        Assert.Equal(x, c);
    }
    [Fact]
    public void SubtracaoTeste()
    {
        //arrange
        float a = 4;
        float b = 5;

        //Act
        float c = this.operacoes.Subtracao(a, b);
        float x = -1;
        //Assert
        Assert.Equal(x, c);
    }
    [Fact]
    public void MultiplicacaoTeste()
    {
        //arrange
        float a = 4;
        float b = 5;

        //Act
        float c = this.operacoes.Multiplicacao(a, b);
        float x = 20;
        //Assert
        Assert.Equal(x, c);
    }
    [Fact]
    public void DivisaoTeste()
    {
        //arrange
        float a = 18;
        float b = 2;

        //Act
        float c = this.operacoes.Divisao(a, b);
        float x = 9;
        //Assert
        Assert.Equal(x, c);
    }
    [Fact]
    public void DivisaoZeroTeste()
    {
        //arrange
        float a = 18;
        float b = 0;

        //Act
        float c = this.operacoes.Divisao(a, b);
        float x = 0;
        //Assert
        Assert.Equal(x, c);
    }
    [Fact]
    public void ModuloTeste()
    {
        //arrange
        float a = 20;
        float b = 10;

        //Act
        float c = this.operacoes.Modulo(a, b);
        float x = 0;
        //Assert
        Assert.Equal(x, c);
    }
}
