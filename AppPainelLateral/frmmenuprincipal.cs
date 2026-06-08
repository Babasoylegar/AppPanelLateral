using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppPainelLateral
{
    public partial class frmmenuprincipal : Form
    {
        public frmmenuprincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panelprincipal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            Application.Exit(); //sai da aplicação
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private Form formAtivo = null;

        private void AbrirFormNoPainel(Form formFilho)
        {
            // Se já houver um formulário aberto, fecha ele
            if (formAtivo != null)
                formAtivo.Close();

            // Configura o novo formulário para se comportar como um controle interno
            formAtivo = formFilho;
            formFilho.TopLevel = false; //faz o form não se tornar independente como nasce
            formFilho.FormBorderStyle = FormBorderStyle.None; // Remove as bordas padrão de janela
            formFilho.Dock = DockStyle.Fill; // Faz o formulário ocupar todo o painel

            // Adiciona o formulário aos controles do painel e o exibe
            panelconteudo.Controls.Add(formFilho); //Coloca fisicamente o formulário filho dentro da lista de componentes que pertencem ao seu painel.
            panelconteudo.Tag = formFilho; //Apenas uma boa prática. Guarda o formulário na propriedade
            formFilho.BringToFront(); // Força a nova tela a ficar na frente de qualquer outro elemento visual
            formFilho.Show(); //Ativa a renderização visual
        }
        private void btnaluno_Click(object sender, EventArgs e) //abre cada formulário
        {
            ActiveButton(btnaluno);
            AbrirFormNoPainel(new frmaluno());
        }

        private void btnprofessor_Click(object sender, EventArgs e) //
        {
            ActiveButton(btnprofessor);
            AbrirFormNoPainel(new frmprofessor());
        }
        private void btnnota_Click_1(object sender, EventArgs e)
        {
            ActiveButton(btnnota);
            AbrirFormNoPainel(new frmnota());
        }
        private void ActiveButton(Button frmativo)
        {
                foreach (Control ctrl in panelprincipal.Controls) //percorre, um por um, todos os elementos visuais (controles) que estão guardados dentro do seu menu principal
            {                                                     //Cada elemento encontrado na varredura é temporariamente chamado de ctrl dentro das chaves
                ctrl.ForeColor = Color.White; //Altera a cor do texto (ForeColor) de todos os elementos que ele encontrar no menu para Branco
                frmativo.ForeColor = Color.Red; //muda para a cor vermelha ao ativar o botão
            }
        }
    }
}
