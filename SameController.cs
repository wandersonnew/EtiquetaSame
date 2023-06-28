using System.Data;
using System.Drawing.Printing;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace EtiquetaSame
{
    internal class SameController
    {
        public List<string> dados = new List<string>();
        public DataTable BuscarDados(string matricula)
        {
            string oradb = "Data Source=10.10.10.250:1521/orcl;User Id=sistema;Password=sistema;";

            using (OracleConnection conn = new OracleConnection(oradb))
            {
                using (OracleCommand cmd = conn.CreateCommand())
                {
                    try
                    {
                        conn.Open();
                        cmd.Connection = conn;
                        cmd.CommandText = @"SELECT
	                        'SAME INTERNAÇÃO' TITULO
                            ,CONCAT('PACIENTE: ', CONCAT(SA.CD_PACIENTE, CONCAT(' - ', PA.NM_PACIENTE) ) ) PACIENTE
                            ,CONCAT('MATRIC. DO SAME: ', SA.NR_MATRICULA_SAME) MATSAME
                            ,CONCAT('ARMÁRIO: ', AR.DS_ARMARIO_SAME) ARMARIO
                            ,CONCAT('SALA: ', SALA.DS_SALA_SAME) SALA
                            ,CONCAT('LINHA: ', SA.DS_LINHA) LINHA
                            ,CONCAT('COLUNA: ', SA.DS_COLUNA) COLUNA
                        FROM DBAMV.SAME SA
                        LEFT JOIN DBAMV.PACIENTE PA
                        ON PA.CD_PACIENTE = SA.CD_PACIENTE
                        LEFT JOIN DBAMV.ARMARIO_SAME AR
                        ON AR.CD_ARMARIO_SAME = SA.CD_ARMARIO_SAME
                        LEFT JOIN SALA_SAME SALA
                        ON SALA.CD_SALA_SAME = AR.CD_SALA_SAME
                        WHERE SA.CD_PACIENTE = :matricula
                        AND AR.DS_ARMARIO_SAME IS NOT NULL";
                        cmd.Parameters.Add("matricula", matricula);
                        cmd.CommandType = CommandType.Text;
                        OracleDataReader dr = cmd.ExecuteReader();
                        // dr.Read();

                        // Crie um objeto DataTable para armazenar os dados.
                        DataTable dataTable = new DataTable();

                        // Adicione as colunas ao DataTable.
                        for (int i = 0; i < dr.FieldCount; i++)
                        {
                            dataTable.Columns.Add(dr.GetName(i));
                        }

                        // Adicione as linhas ao DataTable.
                        while (dr.Read())
                        {
                            DataRow row = dataTable.NewRow();
                            for (int i = 0; i < dr.FieldCount; i++)
                            {
                                row[i] = dr[i];
                            }
                            dataTable.Rows.Add(row);
                        }

                        return dataTable;

                        conn.Dispose();
                        conn.Close();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Ocorreu um erro: " + e.Message);
                        return null;
                    }
                }
            }
        }

        public void setList(List<string> list)
        {
            this.dados = list;
        }

        public List<string> getList() { 
            return this.dados; 
        }

        public void ImprimirDados(List<string> dados, string impressora)
        {
            PrintDocument pd = new PrintDocument();
            pd.PrinterSettings = new PrinterSettings();
            pd.PrinterSettings.PrinterName = impressora;
            pd.PrintPage += new PrintPageEventHandler((sender, ev) => PrintPage(sender, ev, dados));
            pd.DefaultPageSettings.Margins = new Margins(0, 0, 0, 0);
            pd.DefaultPageSettings.PaperSize = new PaperSize("Custom", 550, 150);
            pd.Print();
        }

        private void PrintPage(object sender, PrintPageEventArgs ev, List<string> dados)
        {
            Font fonte = new Font("Arial", 10);
            SolidBrush pincel = new SolidBrush(Color.Black);
            float lineHeight = fonte.GetHeight(ev.Graphics);
            float yPos = ev.MarginBounds.Top;
            /*Pen pen = new Pen(Color.Black, 1);
            Rectangle borderRect = new Rectangle(ev.MarginBounds.Left, ev.MarginBounds.Top, ev.MarginBounds.Width, ev.MarginBounds.Height);
            ev.Graphics.DrawRectangle(pen, borderRect);*/


            foreach (string dado in dados)
            {
                ev.Graphics.DrawString(dado, fonte, pincel, ev.MarginBounds.Left, yPos, new StringFormat());
                yPos += lineHeight;
            }
        }
    }
}
