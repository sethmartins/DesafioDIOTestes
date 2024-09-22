using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioDIOTestes.Console.Interfaces;

public interface IOperacoesBasicas
{
    float Soma(float x,float y);
    float Subtracao(float x, float y);
    float Multiplicacao(float x, float y);
    float Divisao(float x, float y);
    float Modulo(float x, float y);
}
