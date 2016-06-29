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
    public partial class Tela1 : Form
    {
        OperationForms OperationForm;
        private Button[] ListButtons;
        private Button[] ListMecher;
        private Form _parent;

        public Tela1(Form parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        private void Form1_Load(object sender, EventArgs e)//melhorar
        {
            ListMecher = new Button[] { btn5, btn8, btn3, btn1, btn7};
            OperationForm = new OperationForms(lblRestante, 12, ListMecher, _parent);
            //remover essas operações da form!!!!!!
            label1.Location = new Point((this.Size.Width / 2) - (this.panel1.Size.Width / 2), (this.Size.Height / 2) - (this.panel1.Size.Height / 2 + 80));//Posiciona "Restante"
            lblRestante.Location = new Point((this.Size.Width / 2) - (this.panel1.Size.Width / 2 - 220), (this.Size.Height / 2) - (this.panel1.Size.Height / 2 + 80));//Posiciona contador
            panel1.Location = new Point((this.Size.Width / 2) - (this.panel1.Size.Width / 2), (this.Size.Height / 2) - (this.panel1.Size.Height / 2));//centralizar panel
            ListButtons = new Button[] { btnOculto, btn6, btn5, btn1, btn7, btn8, btn4, btn2, btn3 };
            OperationForm.insertEmb(ListButtons);//Operação de inserção
            ListButtons = new Button[] { btn4, btn6, btn5, btn2, btnOculto, btn8, btn1, btn7, btn3 };
            OperationForm.insertCorrect(ListButtons);//Operação de inserção
        }// -- REVISAR

        private void btn1_Click(object sender, EventArgs e)
        {
            OperationForm.Operation(btn1, btnOculto, ListButtons, panel1, lblRestante);
        }// -- ok

        private void btn2_Click(object sender, EventArgs e)
        {
            OperationForm.Operation(btn2, btnOculto, ListButtons, panel1, lblRestante);
        }// -- ok

        private void btn3_Click(object sender, EventArgs e)
        {
           OperationForm.Operation(btn3, btnOculto, ListButtons, panel1, lblRestante);
        }// -- ok

        private void btn4_Click(object sender, EventArgs e)
        {
            OperationForm.Operation(btn4, btnOculto, ListButtons, panel1, lblRestante);
        }// -- ok

        private void btn5_Click(object sender, EventArgs e)
        {
            OperationForm.Operation(btn5, btnOculto, ListButtons, panel1, lblRestante);
        }// -- ok

        private void btn6_Click(object sender, EventArgs e)
        {
            OperationForm.Operation(btn6, btnOculto, ListButtons, panel1, lblRestante);
        }// -- ok

        private void btn7_Click(object sender, EventArgs e)
        {
            OperationForm.Operation(btn7, btnOculto, ListButtons, panel1, lblRestante);
        }// -- ok

        private void btn8_Click(object sender, EventArgs e)
        {
            OperationForm.Operation(btn8, btnOculto, ListButtons, panel1, lblRestante);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }// -- ok
    }
}
