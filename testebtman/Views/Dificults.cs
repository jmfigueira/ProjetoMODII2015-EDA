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
    public partial class Dificults : Form
    {
        private Form tela;

        public Dificults()
        {
            InitializeComponent();
        }

        private void btnIniciante_Click(object sender, EventArgs e)
        {
            tela = new Tela3(this);
            this.Hide();
            tela.Show();
        }

        private void btnInter_Click(object sender, EventArgs e)
        {
            tela = new Tela1(this);
            this.Hide();
            tela.Show();
        }

        private void btnNinja_Click(object sender, EventArgs e)
        {
            tela = new Tela2(this);
            this.Hide();
            tela.Show();
        }

        public void EndGame()
        {
            this.Hide();
        }
    }
}
