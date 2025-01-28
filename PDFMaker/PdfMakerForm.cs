using System;
using System.Data;
using System.Windows.Forms;

namespace PDFMaker
{


    /// <summary>
    /// Форма для создания PDF-документов и управления их данными.
    /// </summary>
    public partial class PdfMakerForm : Form
    {

        private DataTable table; // Таблица данных, содержащая информацию о созданных PDF-документах.
        private PdfData dataDocument; // Объект для управления данными PDF-документов.


        public PdfMakerForm()
        {
            InitializeComponent();
        }


        private void PDFMakerForm_Load(object sender, EventArgs e)
        {
            this.dataDocument = new PdfData(table, PdfDocument_dataGridView);
            dataDocument.InitializeDataTable();
        }



        private void PdfContent_textBox_TextChanged(object sender, EventArgs e)
        {
            PdfContent_label.Text = PdfContent_textBox.Text;
        }

        private void Print_button_Click(object sender, EventArgs e)
        {
            // Проверка на наличие обязательной информации
            if (string.IsNullOrWhiteSpace(PdfTitle_textBox.Text) || string.IsNullOrWhiteSpace(PdfFileName_textBox.Text))
            {
                MessageBox.Show("Задайте информацию о название файла и его титул "); return;
            }


            string pdfFileName = this.PdfFileName_textBox.Text + ".pdf"; // Создание имени файла PDF
            PdfMakerClass pdfDocument = new PdfMakerClass(pdfFileName);
            pdfDocument.CreatePDF(PdfTitle_textBox.Text, PdfContent_textBox.Text);// Создание PDF-документа

            if (pdfDocument.isSaved()) {
                this.dataDocument.UpdateDataGrid(pdfFileName, pdfDocument.DateOfCreation(), pdfDocument.PdfPath()); //Обновление данных в таблице
            }
        }
    }
}
