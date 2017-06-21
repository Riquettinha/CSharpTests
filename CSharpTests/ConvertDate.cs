using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace CSharpTests
{
    public partial class ConvertDate : Form
    {
        public ConvertDate()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            try
            {
                var date = tbOriginalDate.Text;
                var dateConvert = Convert.ToDateTime(date);

                var dateParse1 = DateTime.Parse(date);
                var dateParse2 = DateTime.Parse(date, new CultureInfo("pt-BR"));
                var dateParse3 = DateTime.Parse(date, new CultureInfo("pt-BR"), DateTimeStyles.None);

                var dateParseExact1 = DateTime.ParseExact(date, "dd/MM/yyyy", new CultureInfo("pt-BR"));
                var dateParseExact2 = DateTime.ParseExact(date, "dd/MM/yyyy", new CultureInfo("pt-BR"),
                    DateTimeStyles.None);

                DateTime dateTryParse1, dateTryParse2;
                DateTime.TryParse(date, out dateTryParse1);
                DateTime.TryParse(date, new CultureInfo("pt-BR"), DateTimeStyles.None, out dateTryParse2);

                DateTime dateTryParseExact1;
                DateTime.TryParseExact(date, "dd/MM/yyyy", new CultureInfo("pt-BR"), DateTimeStyles.None,
                    out dateTryParseExact1);

                tbResult1.Text = dateConvert.ToString("dd/MM/yyyy");
                tbResult2.Text = dateParse1.ToString("dd/MM/yyyy");
                tbResult3.Text = dateParse2.ToString("dd/MM/yyyy");
                tbResult4.Text = dateParse3.ToString("dd/MM/yyyy");
                tbResult5.Text = dateParseExact1.ToString("dd/MM/yyyy");
                tbResult6.Text = dateParseExact2.ToString("dd/MM/yyyy");
                tbResult7.Text = dateTryParse1.ToString("dd/MM/yyyy");
                tbResult8.Text = dateTryParse2.ToString("dd/MM/yyyy");
                tbResult9.Text = dateTryParseExact1.ToString("dd/MM/yyyy");
            }
            catch (Exception)
            {
                MessageBox.Show(Parent, @"A data não está no formato válido: dd/mm/aaaa", @"Atenção!");
            }
        }

        private void ConvertDate_Load(object sender, EventArgs e)
        {
            Left = (Parent.ClientRectangle.Width - Width - 90) / 2;
            Top = (Parent.ClientRectangle.Height - Height - 50) / 2;
        }

        private void ConvertDate_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.Black, 1),
                                     DisplayRectangle.X, DisplayRectangle.Y, DisplayRectangle.Width-1, DisplayRectangle.Height-1);
        }
    }
}
