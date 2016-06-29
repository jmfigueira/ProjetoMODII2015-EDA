using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace ProjetoEDA2015
{
    class List //lista duplamente ligada circular
    {
        private Node list;

        public Node firstNode { get { return list; } }//retorna o primeiro nó

        public Node buscaNode(Button btn)
        {
            Node p = new Node();

            p = list;
            for (int i = 0; i < 9; i++)
            {
                if (p.Info.Text == btn.Text)
                    return p;
                p = p.Next;
            }
            return null;
        }//busco um nó na lista -- ok

        public Node buscaNodeOculto()
        {
            Node p = new Node();

            p = list;
            for (int i = 0; i < 9; i++)
            {
                if (p.Info.Text == "oculto")
                    return p;
                p = p.Next;
            }
            return null;
        }//busco o nó oculto na lista -- ok


        public void Insert(Button btn)
        {
            Node p = new Node();
            p.Info = btn;

            if (list == null)
            {//insere o primeiro nó
                list = p;
                list.Next = list;
                list.Prior = list;
            }
            else
            {//insere os demais nós
                p.Prior = list;
                p.Next = list.Next;
                list.Next.Prior = p;
                list.Next = p;
                list = p;
            }
        }//insere um nó -- ok
        public void TrocaEsquerda(Node prear, Node oc, Node ocfront, Node p)
        {
            prear.Next = oc;
            ocfront.Prior = p;
            p.Prior = oc;
            oc.Next = p;
            p.Next = ocfront;
            oc.Prior = prear;
        }//troca de lugar se p estiver a esquerda do nó oculto -- ok

        public void TrocaDireita(Node ocrear, Node oc, Node pfront, Node p)
        {
            ocrear.Next = p;
            pfront.Prior = oc;
            oc.Prior = p;
            p.Next = oc;
            oc.Next = pfront;
            p.Prior = ocrear;
        }//troca de lugar se p estiver a direita do nó oculto -- ok

        public void TrocaLadoLado(Node ocrear, Node prear, Node oc, Node pfront, Node ocfront, Node p)
        {
            prear.Next = oc;
            ocrear.Next = p;
            pfront.Prior = oc;
            ocfront.Prior = p;
            p.Prior = ocrear;
            oc.Prior = prear;
            p.Next = ocfront;
            oc.Next = pfront;
        }//troca de lugar se os nós nao estiverem lado a lado -- ok

        //da para melhorar isso ---
        public void Troca(Button btn)
        {//arrumar
            Node[] ListNodes = { buscaNode(btn), buscaNodeOculto(), buscaNode(btn).Prior, buscaNodeOculto().Prior, buscaNode(btn).Next, buscaNodeOculto().Next };

            //verifica se algum nó é o list
            if (ListNodes[0] == list)
                list = ListNodes[1];
            else if (ListNodes[1] == list)
                list = ListNodes[0];
            if (ListNodes[0].Next == ListNodes[1])
                TrocaEsquerda(ListNodes[2], ListNodes[1], ListNodes[5], ListNodes[0]);
            else
            {
                if (ListNodes[0].Prior == ListNodes[1])
                    TrocaDireita(ListNodes[3], ListNodes[1], ListNodes[4], ListNodes[0]);
                else
                    TrocaLadoLado(ListNodes[3], ListNodes[2], ListNodes[1], ListNodes[4], ListNodes[5], ListNodes[0]);
            }//fim da verificação se um nó é o list
        }//troca de posicão o nó oculto com outro nó -- REVISAR
    }
}
