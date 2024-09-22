using DesafioDIOTestes.Console.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioDIOTestes.Console.Model;

public class Calculadora : IOperacoesBasicas
{
    public float Divisao(float x, float y)
    {
        return x / y;
    }

    public float Modulo(float x, float y)
    {
        return x % y;
    }

    public float Multiplicacao(float x, float y)
    {
        return (x * y);
    }

    public float Soma(float x, float y)
    {
        return x + y;
    }

    public float Subtracao(float x, float y)
    {
        return x - y;
    }
}
