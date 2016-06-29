using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System.Data;
using System.Collections;

namespace ProjetoEDA2015
{
    class Jogo
    {
        public Button[] butonsMecher;
        //public Button[] ButonsMecher { get; set; }
        public int Restante;

        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tela1));
        
        public bool VerificaListas(Node list, Node rightList)
        {
            for (int i = 0; i < 9; i++)
            {
                if (!(list.Info.Text == rightList.Info.Text))//verifica se os textos dos botões são iguais
                    return false;
                list = list.Next;
                rightList = rightList.Next;
            }
            return true;
        }
        //troca os botões de lugar no form
        public void Trocar(Button btn, Button oculto, List list, Label l)
        {
            Point btnPoint = new Point(btn.Location.X, btn.Location.Y);
            Point ocultoPoint = new Point(oculto.Location.X, oculto.Location.Y);
            Point auxPoint = new Point();

            //distancia x e y entre os botões
            auxPoint.X = btnPoint.X - ocultoPoint.X;
            auxPoint.Y = btnPoint.Y - ocultoPoint.Y;

            auxPoint.X = auxPoint.X < 0 ? auxPoint.X * -1 : auxPoint.X;//Line if condições
            auxPoint.Y = auxPoint.Y < 0 ? auxPoint.Y * -1 : auxPoint.Y;//Line if condições

            if(auxPoint.X == 0 && auxPoint.Y > 0)
            {//verifica se o objeto se move em y
                if(auxPoint.Y <= btn.Size.Height)
                {//verifica se com essa distancia é possivel mover
                    btn.Location = ocultoPoint;
                    oculto.Location = btnPoint;
                    list.Troca(btn);
                    Restante--;
                    l.Text = Restante.ToString();
                }
            }
            else if (auxPoint.X > 0 && auxPoint.Y == 0)
            {//verifica se o objeto se move em x
                if (auxPoint.X <= btn.Size.Width)
                {//verifica se com essa distancia é possivel mover
                    btn.Location = ocultoPoint;
                    oculto.Location = btnPoint;
                    list.Troca(btn);
                    Restante--;
                    l.Text = Restante.ToString();
                }
            }
        }
        //fazer esse método -------- 
        //
        //verifica se as listas são iguais
        //ArrayList ListaBackgroundRight = new ArrayList();//Insere todas as background que formarão a imagem se a posição da ListFinal for igual a posição da ListCerta
        //ArrayList ListaBackground = new ArrayList();//Insere todas as background para serem usadas caso a ListFinal seja diferente da ListCerta
        //Guardar todas background como objetos no array e logo dar um set nos background dos buttons quando necessário
        //System.Drawing.Bitmap b = new Bitmap("meu arquivo");
        //button1.BackgroundImage = b;
        //
        public void TrocaImagem(Button B, List list, List rightList)//Muda esta lógica -> para lógica dos Arrays
        {
            string t;

            if ((t = B.Text.Substring(1, B.Text.Length - 1)) == "c")
                if (!(buscaPos(B, list.firstNode) == buscaPos(B, rightList.firstNode)))
                {
                    B.Text = B.Text.Replace('c', 'e');
                    foreach (Button item in butonsMecher)
                    {
                        if (item.Text.Contains("1e"))
                            item.BackgroundImage = ProjetoEDA2015.Properties.Resources.BTN1;
                        if (item.Text.Contains("2e"))
                            item.BackgroundImage = ProjetoEDA2015.Properties.Resources.BTN2;
                        if (item.Text.Contains("3e"))
                            item.BackgroundImage = ProjetoEDA2015.Properties.Resources.BTN3;
                        if (item.Text.Contains("4e"))
                            item.BackgroundImage = ProjetoEDA2015.Properties.Resources.BTN4;
                        if (item.Text.Contains("5e"))
                            item.BackgroundImage = ProjetoEDA2015.Properties.Resources.BTN5;
                        if (item.Text.Contains("6e"))
                            item.BackgroundImage = ProjetoEDA2015.Properties.Resources.BTN6;
                        if (item.Text.Contains("7e"))
                            item.BackgroundImage = ProjetoEDA2015.Properties.Resources.BTN1;
                        if (item.Text.Contains("8e"))
                            item.BackgroundImage = ProjetoEDA2015.Properties.Resources.BTN2;
                    }
                    //trocar as imagens
                }
            if (buscaPos(B, list.firstNode) == buscaPos(B, rightList.firstNode))
            {
                B.Text = B.Text.Replace('e', 'c');
                foreach (Button item in butonsMecher)
                {
                    if (item.Text.Contains("1c"))
                        item.BackgroundImage = ProjetoEDA2015.Properties.Resources.BTN1ok;
                    if (item.Text.Contains("2c"))
                        item.BackgroundImage = ProjetoEDA2015.Properties.Resources.BTN2ok;
                    if (item.Text.Contains("3c"))
                        item.BackgroundImage = ProjetoEDA2015.Properties.Resources.BTN3ok;
                    if (item.Text.Contains("4c"))
                        item.BackgroundImage = ProjetoEDA2015.Properties.Resources.BTN4ok;
                    if (item.Text.Contains("5c"))
                        item.BackgroundImage = ProjetoEDA2015.Properties.Resources.BTN5ok;
                    if (item.Text.Contains("6c"))
                        item.BackgroundImage = ProjetoEDA2015.Properties.Resources.BTN6ok;
                    if (item.Text.Contains("7c"))
                        item.BackgroundImage = ProjetoEDA2015.Properties.Resources.BTN1ok;
                    if (item.Text.Contains("8c"))
                        item.BackgroundImage = ProjetoEDA2015.Properties.Resources.BTN2ok;
                }
                //trocar as imgens
            }
        }//faz a troca da imagem por uma imagem com a cor do caminho diferente
        
        //refazer a finalgame, pois essa abaixo é apenas para teste
        public void FinalGame()
        {
            Final formfinal = new Final();
            formfinal.ShowDialog();
        }
        public void FinalGameOver()
        {
            FinalGameOver formfinal = new FinalGameOver();
            formfinal.ShowDialog();
        }
        public int buscaPos(Button btn, Node buttons)
        {
            Node p = new Node();

            p = buttons;
            for (int i = 0; i < 9; i++)
            {
                if (p.Info.Text == btn.Text)
                    return i;
                p = p.Next;
            }
            return 0;
        }//busca um nó e retorna a posição -- ok
    }
}
