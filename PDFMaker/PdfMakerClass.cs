using System;
using System.IO;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.Remoting.Messaging;

namespace PDFMaker
{


    /// <summary>
    /// Класс для создания PDF-документов.
    /// </summary>
    public class PdfMakerClass
    {
        //Имя файла PDF
        public string _pdfFileName;

        // Булеан для подверждения праверки сохранения фала
        bool _isSaved =false;


        /// <summary>
        /// Инициализтрует новйы экземпляр класса <see cref="PdfMakerClass"/> c указанным 
        /// </summary>
        /// <param name="pdfFileName">Имя файла PDF, который будет создан</param>
        public PdfMakerClass(string pdfFileName) { this._pdfFileName = pdfFileName; }



        /// <summary>
        /// Создает PDF-документ с указанным заголовком и содержимым.
        /// </summary>
        /// <param name="pdfTitle">Заголовок PDF-документа.</param>
        /// <param name="pdfContent">Содержимое PDF-документа.</param>
        public void CreatePDF(string pdfTitle, string pdfContent)
        {


            // Проверка существования файла и запрос на перезапись
            string filePath = PdfPath();
            if (File.Exists(filePath))
            {
                DialogResult result = MessageBox.Show(
                    "Файл уже существует. Хотите его перезаписать ,",
                    "Подтверждение",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.Yes) { File.Create(filePath).Close(); MessageBox.Show("Фвйл перезаписан."); } else { return; }
            }


            PdfDocument document = new PdfDocument(); // Создание нового PDF-документа
            document.Info.Title = pdfTitle;

            PdfPage pageContent = document.AddPage();
            XGraphics gfx = XGraphics.FromPdfPage(pageContent);
            XFont font = new XFont("Verdana", 20);



            // Заполнение страницы содержимым
            gfx.DrawString(pdfContent, font, XBrushes.Black,
                new XRect(0, 0, pageContent.Width, pageContent.Height), XStringFormats.Center);


            document.Save(filePath);// Сохранение документа
            document.Close(); // закрытие документа

            this._isSaved = true;
        }


        /// <summary>
        /// Получает путь к создаваемому PDF-файлу на рабочем столе.
        /// </summary>
        /// <returns>Путь к файлу PDF.</returns>
        public string PdfPath()
        {
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), this._pdfFileName);
            return path;
        }


        /// <summary>
        /// Подтверждает когда файл успешно сохранен.
        /// </summary>
        /// <returns>true Если файл был сохранен, иначе false</returns>
        public bool isSaved () { return this._isSaved; }



        /// <summary>
        /// Получает дату создания PDF-файла.
        /// </summary>
        /// <returns>Дата и время создания файла.</returns>
        public DateTime DateOfCreation() 
        {
            string filePath = PdfPath();
            FileInfo fi = new FileInfo(filePath);

            return fi.CreationTime;
        }
    }
}
