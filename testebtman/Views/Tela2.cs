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
    public partial class Tela2 : Form
    {
        OperationForms OperationForm;
        private Button[] ListButtons;
        private Button[] ListMecher;
        private Form _parent;

        public Tela2(Form parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        private void Tela2_Load(object sender, EventArgs e)
        {            
            ListMecher = new Button[] {btn7, btn3, btn2, btn5, btn1 };
            OperationForm = new OperationForms(lblRestante, 13, ListMecher, _parent);
            //remover essas operações da form!!!!!!
            label1.Location = new Point((this.Size.Width / 2) - (this.panel1.Size.Width / 2), (this.Size.Height / 2) - (this.panel1.Size.Height / 2 + 80));//Posiciona "Restante"
            lblRestante.Location = new Point((this.Size.Width / 2) - (this.panel1.Size.Width / 2 - 220), (this.Size.Height / 2) - (this.panel1.Size.Height / 2 + 80));//Posiciona contador
            panel1.Location = new Point((this.Size.Width / 2) - (this.panel1.Size.Width / 2), (this.Size.Height / 2) - (this.panel1.Size.Height / 2));//centralizar panel
            ListButtons = new Button[] { btn2, btn7, btn1, btnOculto, btn5, btn4, btn3, btn8, btn6 };
            OperationForm.insertEmb(ListButtons);//Operação de inserção
            ListButtons = new Button[] { btnOculto, btn5, btn1, btn8, btn2, btn4, btn7, btn3, btn6 };
            OperationForm.insertCorrect(ListButtons);//Operação de inserção
        }

        private void btn1_Click_1(object sender, EventArgs e)
        {
            OperationForm.Operation(btn1, btnOculto, ListButtons, panel1, lblRestante);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            OperationForm.Operation(btn2, btnOculto, ListButtons, panel1, lblRestante);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            OperationForm.Operation(btn3, btnOculto, ListButtons, panel1, lblRestante);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            OperationForm.Operation(btn5, btnOculto, ListButtons, panel1, lblRestante);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            OperationForm.Operation(btn6, btnOculto, ListButtons, panel1, lblRestante);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            OperationForm.Operation(btn4, btnOculto, ListButtons, panel1, lblRestante);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            OperationForm.Operation(btn7, btnOculto, ListButtons, panel1, lblRestante);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            OperationForm.Operation(btn8, btnOculto, ListButtons, panel1, lblRestante);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
