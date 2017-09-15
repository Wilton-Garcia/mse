using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MSE___Meu_Site_Executavel
{
    public partial class MSE : Form
    {
        public MSE()
        {
            InitializeComponent();
        }
        string url;
        private void btn_addURL_Click(object sender, EventArgs e)
        {
            if (txb_url.Text != "")
            {
                url = txb_url.Text;
                txb_url.Clear();
                lbx_URLadds.Items.Add(url);
            }
            else
            {
                MessageBox.Show("Você não pode deixar o campo de URL vazio");
            }
            
        }

        private void btn_removerDaLbx_Click(object sender, EventArgs e)
        {
            ListBox.SelectedObjectCollection selecionados = new ListBox.SelectedObjectCollection(lbx_URLadds);
            for (int i = selecionados.Count - 1; i >= 0; i--)
            {
                lbx_URLadds.Items.Remove(selecionados[i]);
            }
        }

        private void btn_geraExe_Click(object sender, EventArgs e)
        {
            string nome = "site_executavel.cs";
            string nome_compilador = "Compilar.bat";
            StreamWriter impressora = new StreamWriter(nome);
            impressora.WriteLine("using System;");
            impressora.WriteLine("namespace Codigo_para_compilar {");
            impressora.WriteLine("class program {");
            impressora.WriteLine("public static void Main(String[] Args){");
            foreach (var item in lbx_URLadds.Items)
            {
                impressora.WriteLine("System.Diagnostics.Process.Start( \""+item+"\");");
            }
            impressora.WriteLine("}}}");
            impressora.Close();
            StreamWriter geraCompilador = new StreamWriter(nome_compilador);
            geraCompilador.WriteLine(@"C:\Windows\Microsoft.NET\Framework\v4.0.30319\csc.exe site_executavel.cs");
            geraCompilador.Close();
            System.Diagnostics.Process.Start("compilar.bat");
            lbx_URLadds.Items.Clear();
            MessageBox.Show("Aguarde um instante o executavel está sendo gerado");
            System.IO.File.Delete(nome);
            System.IO.File.Delete(nome_compilador);
            MessageBox.Show("O executavel foi gerado com sucesso");
           

        }

        private void programdorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            programador formi = new programador();
            {
                formi.Show();
            }
        }

        private void sobreOProgramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sobre_o_programa formi = new Sobre_o_programa();
            formi.Show();
        }

      
    }
}
