using System;

using System.Data;
using System.Windows.Forms;

namespace PDFMaker
{


    /// <summary>
    /// Класс для управления данными PDF-документов и их отображением в элементе управления DataGridView.
    /// </summary>
    public class PdfData
    {

        public DataTable _table; // Таблица данных, содержащая информацию о PDF-документах.
        public DataGridView _pdfGridView; // Элемент управления DataGridView для отображения данных PDF-документов.



        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="PdfData"/> с указанной таблицей данных и элементом управления DataGridView.
        /// </summary>
        /// <param name="table">Таблица данных, содержащая информацию о PDF-документах.</param>
        /// <param name="pdfGridView">Элемент управления DataGridView для отображения данных.</param>
        public PdfData(DataTable table,DataGridView pdfGridView)
        {
            this._table = table;
            this._pdfGridView = pdfGridView;
        }



        /// <summary>
        /// Инициализирует таблицу данных с необходимыми столбцами для хранения информации о PDF-документах.
        /// </summary>
        public void InitializeDataTable()
        {
            this._table = new DataTable();

            //Добавление столбцов в таблицу
            this._table.Columns.Add("File Name", typeof(string));
            this._table.Columns.Add("Date of creation", typeof(DateTime));
            this._table.Columns.Add("File Path", typeof(string));

            
            this._pdfGridView.DataSource = this._table.DefaultView; // Установка источника данных для элемента управления DataGridView
        }



        /// <summary>
        ///  Обновляет данные в таблице и элементе управления DataGridView с информацией о новом PDF-документе.
        /// </summary>
        /// <param name="pdfFileName">Имя файла PDF</param>
        /// <param name="dateOfCeation">Дата создания PDF-документа.</param>
        /// <param name="pdfFilePath">Путь к файлу PDF.</param>
        public void UpdateDataGrid(string pdfFileName, DateTime dateOfCeation, string pdfFilePath)
        {

            // Формирование строки с данными
            string line = $"{pdfFileName}|{dateOfCeation}|{pdfFilePath}"; 
            string[] splitLine = line.Split('|');

            this._table.Rows.Add(splitLine);//  Добавление новой строки в таблицу


            // Обновление источника данных и перерисовка элемента управления
            _pdfGridView.DataSource = this._table.DefaultView;
            _pdfGridView.Refresh();
        }

    }
}
