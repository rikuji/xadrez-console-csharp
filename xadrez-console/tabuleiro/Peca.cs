﻿using System;
using System.Collections.Generic;
using System.Text;

namespace xadrez_console.tabuleiro
{
    class Peca
    {
        public Pocicao posicao { get; set; }
        public Cor cor { get; protected set; }
        public int qteMovimentos { get; protected set; }
        public Tabuleiro tab { get; protected set; }

        public Peca(Pocicao posicao,Tabuleiro tab, Cor cor)
        {
            this.posicao = posicao;
            this.tab = tab;
            this.cor = cor;
            this.qteMovimentos = 0;
        }
    }
}
