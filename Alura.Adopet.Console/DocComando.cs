﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Adopet.Console
{
    [AttributeUsage(AttributeTargets.Class)]
    internal class DocComando : System.Attribute
    {
        public DocComando(string documentacao, string instrucao)
        {
            Documentacao = documentacao;
            Instrucao = instrucao;
        }
        public string Instrucao { get; }
        public string Documentacao { get; }
    }
}
