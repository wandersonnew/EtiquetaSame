using System.Data;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using static System.Windows.Forms.LinkLabel;

namespace EtiquetaSame
{
    public partial class Form1 : Form
    {
        SameController same = new SameController();
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //SameController same = new SameController();
            dataGridViewEtiqueta.DataSource = same.BuscarDados(txtMatricula.Text);
        }

        private void dataGridViewEtiqueta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var titulo = dataGridViewEtiqueta.CurrentRow.Cells[0].Value.ToString();
            var paciente = dataGridViewEtiqueta.CurrentRow.Cells[1].Value.ToString();
            var matsame = dataGridViewEtiqueta.CurrentRow.Cells[2].Value.ToString();
            var armario = dataGridViewEtiqueta.CurrentRow.Cells[3].Value.ToString();
            var sala = dataGridViewEtiqueta.CurrentRow.Cells[4].Value.ToString();
            var linha = dataGridViewEtiqueta.CurrentRow.Cells[5].Value.ToString();
            var coluna = dataGridViewEtiqueta.CurrentRow.Cells[6].Value.ToString();

            List<string> lista = new List<string>();
            lista.Add(titulo);
            lista.Add(paciente);
            lista.Add(matsame);
            lista.Add(armario);
            lista.Add(sala);
            lista.Add(linha);
            lista.Add(coluna);

            //SameController same = new SameController();
            same.setList(lista);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> dados = new List<string>();
            //SameController same = new SameController();
            dados = same.getList();
            same.ImprimirDados(dados, listImpressoras.SelectedItem.ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //listar impressoras no dropdown
            listImpressoras.Items.Clear();

            foreach (var printer in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
            {
                listImpressoras.Items.Add(printer);
            }
        }
    }
}