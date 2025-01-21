using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UP_FireStation
{
    public partial class exercise1 : Form
    {
        public exercise1()
        {
            InitializeComponent();
            InitializeDataSet();
            LoadTablesToComboBox();
        }

        private DataSet dataSet;
        private DataView dataView;

        private void InitializeDataSet()
        {
            dataSet = new DataSet("MyDataSet");

            // Создаем таблицу "Users"
            DataTable usersTable = new DataTable("Users");
            usersTable.Columns.Add("Id", typeof(int));
            usersTable.Columns.Add("Name", typeof(string));
            usersTable.Columns.Add("BirthDate", typeof(DateTime));
            dataSet.Tables.Add(usersTable);

            // Заполняем "Users" данными
            usersTable.Rows.Add(1, "Иван", new DateTime(1990, 5, 15));
            usersTable.Rows.Add(2, "Мария", new DateTime(1995, 10, 20));
            usersTable.Rows.Add(3, "Петр", new DateTime(1988, 3, 10));

            // Создаем таблицу "Orders"
            DataTable ordersTable = new DataTable("Orders");
            ordersTable.Columns.Add("OrderId", typeof(int));
            ordersTable.Columns.Add("ProductName", typeof(string));
            ordersTable.Columns.Add("OrderDate", typeof(DateTime));
            dataSet.Tables.Add(ordersTable);

            // Заполняем "Orders" данными
            ordersTable.Rows.Add(101, "Ноутбук", new DateTime(2023, 1, 5));
            ordersTable.Rows.Add(102, "Мышь", new DateTime(2023, 2, 12));
            ordersTable.Rows.Add(103, "Клавиатура", new DateTime(2023, 3, 20));
        }


        private void LoadTablesToComboBox()
        {
            // Заполняем ComboBox названиями таблиц
            comboBox1.Items.AddRange(dataSet.Tables.Cast<DataTable>().Select(table => table.TableName).ToArray());
            comboBox1.SelectedIndex = 0; // Выбираем первую таблицу по умолчанию

            // Вызываем метод для загрузки данных в DataGridView при загрузке формы
            LoadDataView(dataSet.Tables[comboBox1.SelectedIndex]);
        }

        private void LoadDataView(DataTable table)
        {
            // Создаем DataView для выбранной таблицы
            dataView = new DataView(table);
            // Привязываем DataGridView к DataView
            dataGridView1.DataSource = dataView;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDataView(dataSet.Tables[comboBox1.SelectedIndex]);

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = dateTimePicker1.Value;

            DataTable currentTable = dataSet.Tables[comboBox1.SelectedIndex];

            foreach (DataRow row in currentTable.Rows)
            {
                foreach (DataColumn column in currentTable.Columns)
                {
                    if (column.DataType == typeof(DateTime))
                    {
                        row[column] = selectedDate; // Меняем все даты в таблице
                    }
                }
            }
            // Обновляем DataView, чтобы изменения отобразились
            LoadDataView(currentTable);
        }

        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Получаем имя столбца, по которому щелкнули
            string columnName = dataGridView1.Columns[e.ColumnIndex].Name;

            // Переключаем порядок сортировки (ASC->DESC и обратно)
            if (dataView.Sort == $"{columnName} ASC")
            {
                dataView.Sort = $"{columnName} DESC";
            }
            else
            {
                dataView.Sort = $"{columnName} ASC";
            }
        }
    }
}
