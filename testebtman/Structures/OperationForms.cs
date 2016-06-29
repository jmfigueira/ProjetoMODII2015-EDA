using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoEDA2015
{
    class OperationForms
    {
        private List list = new List();
        private List rightList = new List();
        private Jogo jogo = new Jogo();
        private Form _parent;
        public OperationForms(Label lblRestante, int num, Button[] btns, Form parent)
        {
            jogo.butonsMecher = btns;
            jogo.Restante = num;
            lblRestante.Text = jogo.Restante.ToString();
            _parent = parent;
        }

        public void insertEmb(Button[] ListButtons)
        {
            //inserir os botões embaralhados
            for (int i = 0; i < ListButtons.Length; i++)
                list.Insert(ListButtons[i]);
        }// -- ok
        public void insertCorrect(Button [] ListButtons)
        {
            //inserir os botões em forma ordenada
            for (int i = 0; i < ListButtons.Length; i++)
                rightList.Insert(ListButtons[i]);
        }// -- ok
        public void Operation(Button B, Button BOculto, Button[] ListButton, Panel panel, Label lblRestante)
        {
            //através do objeto jogo que está na classe Jogo, chamamos a função de movimentar(trocar os botões)
            //e as verificações da listaEmb e a listaCorreta
            jogo.Trocar(B, BOculto, list, lblRestante);//troca a peça
            lblRestante.Text = jogo.Restante.ToString();
            jogo.TrocaImagem(B, list, rightList);//troca a imagem do botão, caso o botão atual da listEmb(Que está sendo manipulado) esteja na mesma posição que o botão na listaCorreta
            if (jogo.VerificaListas(list.firstNode, rightList.firstNode) && jogo.Restante == 0)
            {
                jogo.FinalGame();//chama a tela de final(FAZER)
                ((Dificults)_parent).EndGame();
            }
            else if(jogo.Restante == 0)
            {
                jogo.FinalGameOver();
                ((Dificults)_parent).EndGame();
            }       
        }// -- ok
    }
}
