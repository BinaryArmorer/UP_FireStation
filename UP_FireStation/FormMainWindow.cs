using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using static Npgsql.Replication.PgOutput.Messages.RelationMessage;

namespace UP_FireStation
{
    public partial class FormMainWindow : Form
    {
        /*Названия таблиц в базе: firetruck fireman equipment firesquad*/
        public FormMainWindow()
        {
            InitializeComponent();

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            comboBoxChangeTable.SelectedIndex = 2;
            comboBoxChangeMode.SelectedIndex = 0;
        }

        private string connectionString = "Server=localhost; Port=5432; Database=FireStationUP; User ID=postgres; Password=zzxxvwgh;";
        private BindingSource BS_fireman;
        private BindingSource BS_firesquad;
        private BindingSource BS_firetruck;
        private BindingSource BS_equipment;
        private BindingSource BS_SEARCH;
        private string changedTable;



        /*\/Кнопки для очистки полей\/*/
        private void btClearTextBox1_Click(object sender, EventArgs e) => textBoxTableColumn1.Text = "";
        private void btClearTextBox2_Click(object sender, EventArgs e) => textBoxTableColumn2.Text = "";
        private void btClearTextBox3_Click(object sender, EventArgs e) => textBoxTableColumn3.Text = "";
        private void btClearTextBox4_Click(object sender, EventArgs e) => textBoxTableColumn4.Text = "";
        private void btClearTextBox5_Click(object sender, EventArgs e) => textBoxTableColumn5.Text = "";
        private void btClearTextBox6_Click(object sender, EventArgs e) => textBoxTableColumn6.Text = "";
        private void btClearTextBox7_Click(object sender, EventArgs e) => textBoxTableColumn7.Text = "";
        private void btClearTextBox8_Click(object sender, EventArgs e) => textBoxTableColumn8.Text = "";
        private void btClearTextBox9_Click(object sender, EventArgs e) => textBoxTableColumn9.Text = "";
        private void btClearTextBoxDeleteID_Click(object sender, EventArgs e) => textBoxDeleteID.Text = "";
        /*/\Кнопки для очистки полей/\*/
        ///////////////////////////////////////
        /*\/Выбор даты через dateTimePicker\/*/
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            textBoxTableColumn8.Text = Convert.ToString(dateTimePicker1.Value);
        }
        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            textBoxTableColumn9.Text = Convert.ToString(dateTimePicker2.Value);
        }
        /*/\Выбор даты через dateTimePicker/\*/




        /*\/Соединение с базой и подача команд\/*/
        private BindingSource sqlConnectionReader(string nameTable, string mode = "default", string customCommand = "")
        {
            // Открытие соединения
            NpgsqlConnection sqlConnection = new NpgsqlConnection(connectionString); // Создаём объект класса
            NpgsqlCommand command = new NpgsqlCommand(); // Создаём объект класса

            sqlConnection.Open(); // Открываем соединение

            // Исполнение команды SQL
            command.Connection = sqlConnection; // Передаём строку подключения
            command.CommandType = CommandType.Text; // Тип команды (текстовая)

            if (mode == "default")
            {
                command.CommandText = $"SELECT * FROM {nameTable}"; // Сама текстовая команда на языке SQL
            }
            else if (mode == "custom")
            {
                command.CommandText = customCommand;
            }

            // Чтение результата команды
            NpgsqlDataReader dataReader = command.ExecuteReader();
            BindingSource encapsulator = new BindingSource(); // Создаем класс BindingSource

            if (dataReader.HasRows)
            {
                DataTable data = new DataTable(); // Создаём таблицу
                data.Load(dataReader); // Получаем данные и загружаем их в таблицу
                encapsulator.DataSource = data; // Помещаем данные в BindingSource
            }

            // Закрытие команды и соединения
            command.Dispose(); // Закрытие команды
            sqlConnection.Close(); // Закрытие соединения

            return encapsulator;
        }
        private void CommandSQL(string commandSQL)
        {
            // Открытие соединения
            NpgsqlConnection sqlConnection = new NpgsqlConnection(connectionString); // Создаём объект класса
            NpgsqlCommand command = new NpgsqlCommand(); // Создаём объект класса

            sqlConnection.Open(); // Открываем соединение

            command.Connection = sqlConnection; // Передаём строку подключения
            command.CommandType = CommandType.Text; // Тип команды (текстовая)
            command.CommandText = commandSQL; // Сама текстовая команда на языке SQL

            NpgsqlDataReader dataReader = command.ExecuteReader(); // Исполнение команды

            // Закрытие команды и соединения
            command.Dispose(); // Закрытие команды
            sqlConnection.Close(); // Закрытие соединения
        }
        private void UpdateBS()
        {
            BS_fireman = sqlConnectionReader("fireman");
            BS_firesquad = sqlConnectionReader("firesquad");
            BS_firetruck = sqlConnectionReader("firetruck");
            BS_equipment = sqlConnectionReader("equipment");

            changedTable = comboBoxChangeTable.SelectedItem?.ToString();

            if (comboBoxChangeTable.SelectedItem?.ToString() == "Пожарные")
            {
                dataGridView1.DataSource = BS_fireman;
            }
            else if (comboBoxChangeTable.SelectedItem?.ToString() == "Пожарные отряды")
            {
                dataGridView1.DataSource = BS_firesquad;
            }
            else if (comboBoxChangeTable.SelectedItem?.ToString() == "Пожарные машины")
            {
                dataGridView1.DataSource = BS_firetruck;
            }
            else if (comboBoxChangeTable.SelectedItem?.ToString() == "Оборудование")
            {
                dataGridView1.DataSource = BS_equipment;
            }

            dataGridView1.ClearSelection();

            if (comboBoxChangeTable.SelectedItem?.ToString() != changedTable)
            {
                ClearLable();
            }

            ClearTextBox();
        }
        private void btUpdate_Click(object sender, EventArgs e)
        {
            UpdateBS();
        }
        /*/\Соединение с базой и подача команд/\*/



        /*\/Переключение таблиц\/*/
        private void comboBoxChangeTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateBS();
            AutoSetTextBoxValue();
        }
        private void AutoSetTextBoxValue()
        {
            if (comboBoxChangeTable.SelectedItem?.ToString() == "Пожарные отряды")
            {
                SetLableValue(labelTableColumn1, "Идентификатор");
                SetLableValue(labelTableColumn2, "Название");
                SetLableValue(labelTableColumn3, "Статус");
            }
            else if (comboBoxChangeTable.SelectedItem?.ToString() == "Пожарные машины")
            {
                SetLableValue(labelTableColumn1, "Идентификатор");
                SetLableValue(labelTableColumn2, "Идентификатор отряда");
                SetLableValue(labelTableColumn3, "Класс");
                SetLableValue(labelTableColumn4, "Марка");
                SetLableValue(labelTableColumn5, "Модель");
                SetLableValue(labelTableColumn6, "Пробег");
                SetLableValue(labelTableColumn7, "Состояние");
                SetLableValue(labelTableColumn8, "Дата выпуска");
                SetLableValue(labelTableColumn9, "Дата списания");

            }
            else if (comboBoxChangeTable.SelectedItem?.ToString() == "Пожарные")
            {
                SetLableValue(labelTableColumn1, "Идентификатор");
                SetLableValue(labelTableColumn2, "Идентификатор отряда");
                SetLableValue(labelTableColumn3, "Имя");
                SetLableValue(labelTableColumn4, "Фамилия");
                SetLableValue(labelTableColumn5, "Отчество");
                SetLableValue(labelTableColumn8, "Дата рождения");
            }
            else if (comboBoxChangeTable.SelectedItem?.ToString() == "Оборудование")
            {
                SetLableValue(labelTableColumn1, "Идентификатор");
                SetLableValue(labelTableColumn2, "Идентификатор отряда");
                SetLableValue(labelTableColumn3, "Тип");
                SetLableValue(labelTableColumn4, "Состояние");
                SetLableValue(labelTableColumn5, "Количество");
                SetLableValue(labelTableColumn8, "Дата списания");
            }
        }
        private void SetLableValue(Label lable, string lable_value)
        {
            lable.Text = lable_value;
        }
        /*/\Переключение таблиц/\*/



        /*\/Режим управления данными\/*/
        private void comboBoxChangeMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxChangeMode.SelectedItem?.ToString() == "Просмотр")
            {
                ClearLable();
                ClearTextBox();
                textBoxTableColumn1.Visible = true;
                PropertyEnabledAndVisibleButtonsClearTextBox(false);
                PropertyReadOnlyTextBox(true);
                btSearchEntry.Visible = false;
                btDeleteEntry.Visible = false;
                btUpdateEntry.Visible = false;
                btAddEntry.Visible = false;
                labelWatchingMode.Visible = true;
                btClearTextBox1.Visible = false;
                btClearTextBox1.Enabled = false;
                btClearTextBox.Visible = false;
                dateTimePicker1.Enabled = false;
                dateTimePicker2.Enabled = false;
                AutoSetTextBoxValue();
                panelDeleteID.Visible = false; // \/|-Видимость панели удаления по ID 
                panelDeleteID.Enabled = false; // /\|-Активация панели удаления по ID
                btSearchEntryID.Visible = false;
                btSearchEntryID.Enabled = false;
            }
            else if (comboBoxChangeMode.SelectedItem?.ToString() == "Поиск")
            {
                ClearLable();
                ClearTextBox();
                textBoxTableColumn1.Visible = true;
                PropertyEnabledAndVisibleButtonsClearTextBox(true);
                PropertyReadOnlyTextBox(false);
                btSearchEntry.Visible = true;
                labelWatchingMode.Visible = false;
                btDeleteEntry.Visible = false;
                btUpdateEntry.Visible = false;
                btAddEntry.Visible = false;
                btClearTextBox1.Visible = true;
                btClearTextBox1.Enabled = true;
                btClearTextBox.Visible = true;
                dateTimePicker1.Enabled = true;
                dateTimePicker2.Enabled = true;
                AutoSetTextBoxValue();
                panelDeleteID.Visible = false; // \/|-Видимость панели удаления по ID 
                panelDeleteID.Enabled = false; // /\|-Активация панели удаления по ID
                btSearchEntryID.Visible = true;
                btSearchEntryID.Enabled = true;

            }
            else if (comboBoxChangeMode.SelectedItem?.ToString() == "Добавление")
            {
                ClearLable();
                ClearTextBox();
                textBoxTableColumn1.Visible = false;
                PropertyEnabledAndVisibleButtonsClearTextBox(true);
                PropertyReadOnlyTextBox(false, "inversion_one");
                btAddEntry.Visible = true;
                labelWatchingMode.Visible = false;
                btSearchEntry.Visible = false;
                btDeleteEntry.Visible = false;
                btUpdateEntry.Visible = false;
                btClearTextBox1.Visible = false;
                btClearTextBox1.Enabled = false;
                btClearTextBox.Visible = true;
                dateTimePicker1.Enabled = true;
                dateTimePicker2.Enabled = true;
                AutoSetTextBoxValue();
                panelDeleteID.Visible = false; // \/|-Видимость панели удаления по ID 
                panelDeleteID.Enabled = false; // /\|-Активация панели удаления по ID
                btSearchEntryID.Visible = false;
                btSearchEntryID.Enabled = false;
            }
            else if (comboBoxChangeMode.SelectedItem?.ToString() == "Обновление")
            {
                ClearLable();
                ClearTextBox();
                textBoxTableColumn1.Visible = true;
                PropertyEnabledAndVisibleButtonsClearTextBox(true);
                PropertyReadOnlyTextBox(false);
                btUpdateEntry.Visible = true;
                labelWatchingMode.Visible = false;
                btSearchEntry.Visible = false;
                btDeleteEntry.Visible = false;
                btAddEntry.Visible = false;
                btClearTextBox1.Visible = true;
                btClearTextBox1.Enabled = true;
                btClearTextBox.Visible = true;
                dateTimePicker1.Enabled = true;
                dateTimePicker2.Enabled = true;
                AutoSetTextBoxValue();
                panelDeleteID.Visible = false; // \/|-Видимость панели удаления по ID 
                panelDeleteID.Enabled = false; // /\|-Активация панели удаления по ID
                btSearchEntryID.Visible = false;
                btSearchEntryID.Enabled = false;
            }
            else if (comboBoxChangeMode.SelectedItem?.ToString() == "Удаление")
            {
                ClearLable();
                ClearTextBox();
                textBoxTableColumn1.Visible = true;
                PropertyEnabledAndVisibleButtonsClearTextBox(false);
                PropertyReadOnlyTextBox(true);
                btDeleteEntry.Visible = true;
                labelWatchingMode.Visible = false;
                btSearchEntry.Visible = false;
                btUpdateEntry.Visible = false;
                btAddEntry.Visible = false;
                btClearTextBox1.Visible = false;
                btClearTextBox1.Enabled = false;
                btClearTextBox.Visible = false;
                dateTimePicker1.Enabled = false;
                dateTimePicker2.Enabled = false;
                AutoSetTextBoxValue();
                panelDeleteID.Visible = true; // \/|-Видимость панели удаления по ID 
                panelDeleteID.Enabled = true; // /\|-Активация панели удаления по ID
                btSearchEntryID.Visible = false;
                btSearchEntryID.Enabled = false;
            }
        }
        /*/\Режим управления данными/\*/



        /*\/Выбор записи из dataGridView\/*/
        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (comboBoxChangeMode.SelectedItem?.ToString() != "Добавление" && comboBoxChangeMode.SelectedItem?.ToString() != "Удаление по ID")
            {
                try
                {
                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                    if (comboBoxChangeTable.SelectedItem?.ToString() == "Пожарные отряды")
                    {
                        string id_firesquad = selectedRow.Cells[0].Value?.ToString(); // Первый столбец, ?.ToString() на случай если значение null
                        string name = selectedRow.Cells[1].Value?.ToString();
                        string status = selectedRow.Cells[2].Value?.ToString();

                        SetTextBoxValue(textBoxTableColumn1, id_firesquad, labelTableColumn1, "Идентификатор");
                        SetTextBoxValue(textBoxTableColumn2, name, labelTableColumn2, "Название");
                        SetTextBoxValue(textBoxTableColumn3, status, labelTableColumn3, "Статус");
                    }
                    else if (comboBoxChangeTable.SelectedItem?.ToString() == "Пожарные машины")
                    {
                        string id_firetruck = selectedRow.Cells[0].Value?.ToString();
                        string id_firesquad = selectedRow.Cells[1].Value?.ToString();
                        string class_ = selectedRow.Cells[2].Value?.ToString();
                        string stamp = selectedRow.Cells[3].Value?.ToString();
                        string model = selectedRow.Cells[4].Value?.ToString();
                        string mileage = selectedRow.Cells[5].Value?.ToString();
                        string condition = selectedRow.Cells[6].Value?.ToString();
                        string release_date = selectedRow.Cells[7].Value?.ToString();
                        string date_debit = selectedRow.Cells[8].Value?.ToString();

                        SetTextBoxValue(textBoxTableColumn1, id_firetruck, labelTableColumn1, "Идентификатор");
                        SetTextBoxValue(textBoxTableColumn2, id_firesquad, labelTableColumn2, "Идентификатор отряда");
                        SetTextBoxValue(textBoxTableColumn3, class_, labelTableColumn3, "Класс");
                        SetTextBoxValue(textBoxTableColumn4, stamp, labelTableColumn4, "Марка");
                        SetTextBoxValue(textBoxTableColumn5, model, labelTableColumn5, "Модель");
                        SetTextBoxValue(textBoxTableColumn6, mileage, labelTableColumn6, "Пробег");
                        SetTextBoxValue(textBoxTableColumn7, condition, labelTableColumn7, "Состояние");
                        SetTextBoxValue(textBoxTableColumn8, release_date, labelTableColumn8, "Дата выпуска");
                        SetTextBoxValue(textBoxTableColumn9, date_debit, labelTableColumn9, "Дата списания");

                    }
                    else if (comboBoxChangeTable.SelectedItem?.ToString() == "Пожарные")
                    {
                        string id_fireman = selectedRow.Cells[0].Value?.ToString();
                        string id_firesquad = selectedRow.Cells[1].Value?.ToString();
                        string name = selectedRow.Cells[2].Value?.ToString();
                        string secondname = selectedRow.Cells[3].Value?.ToString();
                        string thridname = selectedRow.Cells[4].Value?.ToString();
                        string brithday = selectedRow.Cells[5].Value?.ToString();

                        SetTextBoxValue(textBoxTableColumn1, id_fireman, labelTableColumn1, "Идентификатор");
                        SetTextBoxValue(textBoxTableColumn2, id_firesquad, labelTableColumn2, "Идентификатор отряда");
                        SetTextBoxValue(textBoxTableColumn3, name, labelTableColumn3, "Имя");
                        SetTextBoxValue(textBoxTableColumn4, secondname, labelTableColumn4, "Фамилия");
                        SetTextBoxValue(textBoxTableColumn5, thridname, labelTableColumn5, "Отчество");
                        SetTextBoxValue(textBoxTableColumn8, brithday, labelTableColumn8, "Дата рождения");
                    }
                    else if (comboBoxChangeTable.SelectedItem?.ToString() == "Оборудование")
                    {
                        string id_equipment = selectedRow.Cells[0].Value?.ToString();
                        string id_firesquad = selectedRow.Cells[1].Value?.ToString();
                        string type = selectedRow.Cells[2].Value?.ToString();
                        string condition = selectedRow.Cells[3].Value?.ToString();
                        string count = selectedRow.Cells[4].Value?.ToString();
                        string date_debit = selectedRow.Cells[5].Value?.ToString();

                        SetTextBoxValue(textBoxTableColumn1, id_equipment, labelTableColumn1, "Идентификатор");
                        SetTextBoxValue(textBoxTableColumn2, id_firesquad, labelTableColumn2, "Идентификатор отряда");
                        SetTextBoxValue(textBoxTableColumn3, type, labelTableColumn3, "Тип");
                        SetTextBoxValue(textBoxTableColumn4, condition, labelTableColumn4, "Состояние");
                        SetTextBoxValue(textBoxTableColumn5, count, labelTableColumn5, "Количество");
                        SetTextBoxValue(textBoxTableColumn8, date_debit, labelTableColumn8, "Дата списания");
                    }
                }
                catch (ArgumentOutOfRangeException)
                {
                    Debug.WriteLine("ArgumentOutOfRangeException: Загрузка базы данных!");
                }
            }
            else if (comboBoxChangeMode.SelectedItem?.ToString() == "Удаление по ID")
            {
                try
                {
                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                    string id = selectedRow.Cells[0].Value?.ToString();
                    SetTextBoxValue(textBoxTableColumn1, id, labelTableColumn1, "Идентификатор");
                }
                catch (ArgumentOutOfRangeException)
                {
                    Debug.WriteLine("ArgumentOutOfRangeException: Загрузка базы данных!");
                }
            }

        }
        private void SetTextBoxValue(TextBox textBox, string tb_value, Label lable, string lable_value)
        {
            textBox.Enabled = true;
            textBox.Text = tb_value;
            lable.Text = lable_value;
        }
        /*/\Выбор записи из dataGridView/\*/



        /*\/ОЧИСТКА LABLE и TEXTBOX\/*/
        private void ClearTextBox()
        {
            textBoxTableColumn1.Text = "";
            textBoxTableColumn2.Text = "";
            textBoxTableColumn3.Text = "";
            textBoxTableColumn4.Text = "";
            textBoxTableColumn5.Text = "";
            textBoxTableColumn6.Text = "";
            textBoxTableColumn7.Text = "";
            textBoxTableColumn8.Text = "";
            textBoxTableColumn9.Text = "";
        }
        private void ClearLable()
        {
            labelTableColumn1.Text = "-----";
            labelTableColumn2.Text = "-----";
            labelTableColumn3.Text = "-----";
            labelTableColumn4.Text = "-----";
            labelTableColumn5.Text = "-----";
            labelTableColumn6.Text = "-----";
            labelTableColumn7.Text = "-----";
            labelTableColumn8.Text = "-----";
            labelTableColumn9.Text = "-----";
        }
        private void btClearTextBox_Click(object sender, EventArgs e)
        {
            textBoxTableColumn1.Text = "";
            textBoxTableColumn2.Text = "";
            textBoxTableColumn3.Text = "";
            textBoxTableColumn4.Text = "";
            textBoxTableColumn5.Text = "";
            textBoxTableColumn6.Text = "";
            textBoxTableColumn7.Text = "";
            textBoxTableColumn8.Text = "";
            textBoxTableColumn9.Text = "";
        }
        /*/\ОЧИСТКА LABLE и TEXTBOX/\*/



        /*\/Изменения свойств элементов в форме\/*/
        private void PropertyEnabledAndVisibleButtonsClearTextBox(bool variant)
        {
            if (variant == true)
            {
                btClearTextBox2.Enabled = true;
                btClearTextBox3.Enabled = true;
                btClearTextBox4.Enabled = true;
                btClearTextBox5.Enabled = true;
                btClearTextBox6.Enabled = true;
                btClearTextBox7.Enabled = true;
                btClearTextBox8.Enabled = true;
                btClearTextBox9.Enabled = true;
                btClearTextBox2.Visible = true;
                btClearTextBox3.Visible = true;
                btClearTextBox4.Visible = true;
                btClearTextBox5.Visible = true;
                btClearTextBox6.Visible = true;
                btClearTextBox7.Visible = true;
                btClearTextBox8.Visible = true;
                btClearTextBox9.Visible = true;
            }
            else if (variant == false)
            {
                btClearTextBox2.Enabled = false;
                btClearTextBox3.Enabled = false;
                btClearTextBox4.Enabled = false;
                btClearTextBox5.Enabled = false;
                btClearTextBox6.Enabled = false;
                btClearTextBox7.Enabled = false;
                btClearTextBox8.Enabled = false;
                btClearTextBox9.Enabled = false;
                btClearTextBox2.Visible = false;
                btClearTextBox3.Visible = false;
                btClearTextBox4.Visible = false;
                btClearTextBox5.Visible = false;
                btClearTextBox6.Visible = false;
                btClearTextBox7.Visible = false;
                btClearTextBox8.Visible = false;
                btClearTextBox9.Visible = false;

            }
        }
        private void PropertyReadOnlyTextBox(bool variant, string column1_ = "not_ignore")
        {
            if (variant == true)
            {
                if (column1_ == "inversion_one")
                {
                    textBoxTableColumn1.ReadOnly = false;
                }
                else if (column1_ != "ignore_one")
                {
                    textBoxTableColumn1.ReadOnly = true;
                }

                textBoxTableColumn2.ReadOnly = true;
                textBoxTableColumn3.ReadOnly = true;
                textBoxTableColumn4.ReadOnly = true;
                textBoxTableColumn5.ReadOnly = true;
                textBoxTableColumn6.ReadOnly = true;
                textBoxTableColumn7.ReadOnly = true;
            }
            else if (variant == false)
            {
                if (column1_ == "inversion_one")
                {
                    textBoxTableColumn1.ReadOnly = true;
                }
                else if (column1_ != "ignore_one")
                {
                    textBoxTableColumn1.ReadOnly = false;
                }

                textBoxTableColumn2.ReadOnly = false;
                textBoxTableColumn3.ReadOnly = false;
                textBoxTableColumn4.ReadOnly = false;
                textBoxTableColumn5.ReadOnly = false;
                textBoxTableColumn6.ReadOnly = false;
                textBoxTableColumn7.ReadOnly = false;
            }
        }
        /*/\Изменения свойств элементов в форме/\*/



        /*\/Функции ПОИСКА, ОБНОВЛЕНИЯ, ДОБАВЛЕНИЯ, УДАЛЕНИЯ данных\/*/
        private void btSearchEntry_Click(object sender, EventArgs e)
        {
            string mode = "OrMode";

            try
            {
                void Check(string modeC = "none")
                {
                    if (modeC == "inversion")
                    {
                        if (textBoxTableColumn1.Text == "0")
                        {
                            textBoxTableColumn1.Text = "";
                        }
                        if (textBoxTableColumn2.Text == "0")
                        {
                            textBoxTableColumn2.Text = "";
                        }
                        if (textBoxTableColumn3.Text == "0")
                        {
                            textBoxTableColumn3.Text = "";
                        }
                        if (textBoxTableColumn4.Text == "0")
                        {
                            textBoxTableColumn4.Text = "";
                        }
                        if (textBoxTableColumn5.Text == "0")
                        {
                            textBoxTableColumn5.Text = "";
                        }
                        if (textBoxTableColumn6.Text == "0")
                        {
                            textBoxTableColumn6.Text = "";
                        }
                        if (textBoxTableColumn7.Text == "0")
                        {
                            textBoxTableColumn7.Text = "";
                        }
                        if (textBoxTableColumn8.Text == "01.01.1000")
                        {
                            textBoxTableColumn8.Text = "";
                        }
                        if (textBoxTableColumn9.Text == "01.01.1000")
                        {
                            textBoxTableColumn9.Text = "";
                        }
                    }
                    else
                    {
                        if (textBoxTableColumn1.Text == "")
                        {
                            textBoxTableColumn1.Text = "0";
                        }
                        if (textBoxTableColumn2.Text == "")
                        {
                            textBoxTableColumn2.Text = "0";
                        }
                        if (textBoxTableColumn3.Text == "")
                        {
                            textBoxTableColumn3.Text = "0";
                        }
                        if (textBoxTableColumn4.Text == "")
                        {
                            textBoxTableColumn4.Text = "0";
                        }
                        if (textBoxTableColumn5.Text == "")
                        {
                            textBoxTableColumn5.Text = "0";
                        }
                        if (textBoxTableColumn6.Text == "")
                        {
                            textBoxTableColumn6.Text = "0";
                        }
                        if (textBoxTableColumn7.Text == "")
                        {
                            textBoxTableColumn7.Text = "0";
                        }
                        if (textBoxTableColumn8.Text == "")
                        {
                            textBoxTableColumn8.Text = "01.01.1000";
                        }
                        if (textBoxTableColumn9.Text == "")
                        {
                            textBoxTableColumn9.Text = "01.01.1000";
                        }
                    }
                }
                Check();
                //textBoxRequestSQL.Text = $"SELECT * FROM {selectedTable()} WHERE {selectedColumns(mode)}";
                BS_SEARCH = sqlConnectionReader(selectedTable(), "custom", $"SELECT * FROM {selectedTable()} WHERE {selectedColumns(mode)}");
                dataGridView1.DataSource = BS_SEARCH;
                Check("inversion");

            }
            catch (PostgresException)
            {
                textBoxRequestSQL.Text = $"SELECT * FROM {selectedTable()} WHERE {selectedColumns(mode)}";
                MessageBox.Show("Ошибка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btSearchEntryID_Click(object sender, EventArgs e)
        {
            try
            {
                //textBoxRequestSQL.Text = $"SELECT * FROM {selectedTable()} WHERE {selectedId()}";
                BS_SEARCH = sqlConnectionReader(selectedTable(), "custom", $"SELECT * FROM {selectedTable()} WHERE {selectedId()}");
                dataGridView1.DataSource = BS_SEARCH;
            }
            catch (PostgresException)
            {
                textBoxRequestSQL.Text = $"SELECT * FROM {selectedTable()} WHERE {selectedId()}";
                MessageBox.Show("Ошибка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btAddEntry_Click(object sender, EventArgs e)
        {
            try
            {
                textBoxRequestSQL.Text = $"INSERT INTO {selectedTable()} ({selectedColumns("ColumnNameMode")}) VALUES ({selectedColumns("ColumnValueMode")})";
                CommandSQL($"INSERT INTO {selectedTable()} ({selectedColumns("ColumnNameMode")}) VALUES ({selectedColumns("ColumnValueMode")})");
                UpdateBS();
            }
            catch (PostgresException)
            {
                textBoxRequestSQL.Text = $"INSERT INTO {selectedTable()} ({selectedColumns("ColumnNameMode")}) VALUES ({selectedColumns("ColumnValueMode")})";
                MessageBox.Show("Ошибка заполнения", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btUpdateEntry_Click(object sender, EventArgs e)
        {
            try
            {
                textBoxRequestSQL.Text = $"UPDATE {selectedTable()} SET {selectedColumns()} WHERE {selectedId()}";
                CommandSQL($"UPDATE {selectedTable()} SET {selectedColumns()} WHERE {selectedId()}");
                UpdateBS();
            }
            catch (PostgresException)
            {
                textBoxRequestSQL.Text = $"UPDATE {selectedTable()} SET {selectedColumns()} WHERE {selectedId()}";
                MessageBox.Show("Ошибка заполнения", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btDeleteEntry_Click(object sender, EventArgs e)
        {
            try
            {
                textBoxRequestSQL.Text = $"DELETE FROM {selectedTable()} WHERE {selectedId()}";
                CommandSQL($"DELETE FROM {selectedTable()} WHERE {selectedId()}");
                UpdateBS();
            }
            catch (PostgresException)
            {
                textBoxRequestSQL.Text = $"DELETE FROM {selectedTable()} WHERE {selectedId()}";
                MessageBox.Show("Ошибка заполнения", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btDeleteID_Click(object sender, EventArgs e)
        {
            try
            {
                textBoxRequestSQL.Text = $"DELETE FROM {selectedTable()} WHERE {selectedId("OnlyID")}";
                CommandSQL($"DELETE FROM {selectedTable()} WHERE {selectedId("OnlyID")}");
                UpdateBS();
            }
            catch (PostgresException)
            {
                textBoxRequestSQL.Text = $"DELETE FROM {selectedTable()} WHERE {selectedId("OnlyID")}";
                MessageBox.Show("Вы не ввели ID", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Вспомогательные методы\/
        private string selectedTable()
        {
            if (comboBoxChangeTable.SelectedItem?.ToString() == "Пожарные отряды")
            {
                return "firesquad";
            }
            else if (comboBoxChangeTable.SelectedItem?.ToString() == "Пожарные машины")
            {
                return "firetruck";
            }
            else if (comboBoxChangeTable.SelectedItem?.ToString() == "Пожарные")
            {
                return "fireman";
            }
            else if (comboBoxChangeTable.SelectedItem?.ToString() == "Оборудование")
            {
                return "equipment";
            }
            else
            {
                return "Error";
            }
        }
        private string selectedColumns(string methodMode = "none")
        {
            string separator;

            if (methodMode == "AndMode")
            {
                separator = " AND ";
                methodMode = "none";
            }
            else if (methodMode == "OrMode")
            {
                separator = " OR ";
                methodMode = "none";
            }
            else
            {
                separator = ", ";
            }

            if (methodMode == "none")
            {
                string[] arrayColumnTextBoxes = new string[] { textBoxTableColumn1.Text, textBoxTableColumn2.Text, textBoxTableColumn3.Text, textBoxTableColumn4.Text, textBoxTableColumn5.Text, textBoxTableColumn6.Text, textBoxTableColumn7.Text, textBoxTableColumn8.Text, textBoxTableColumn9.Text };

                if (selectedTable() == "firesquad")
                {
                    string[] arrayColumnDataBase = new string[] { $"\"Название\" = '{arrayColumnTextBoxes[1]}'", $"\"Статус\" = '{arrayColumnTextBoxes[2]}'" };
                    string nameColumns = string.Join(separator, arrayColumnDataBase);
                    return nameColumns;
                }
                else if (selectedTable() == "fireman")
                {
                    string[] arrayColumnDataBase = new string[] { $"\"id_отряда\" = '{arrayColumnTextBoxes[1]}'", $"\"Имя\" = '{arrayColumnTextBoxes[2]}'", $"\"Фамилия\" = '{arrayColumnTextBoxes[3]}'", $"\"Отчество\" = '{arrayColumnTextBoxes[4]}'", $"\"Дата_рождения\" = '{arrayColumnTextBoxes[7]}'" };
                    
                    if (comboBoxChangeMode.SelectedItem?.ToString() == "Поиск")
                    {

                    }
                    else if (arrayColumnTextBoxes[7] == "")
                    {
                        int currentlength = arrayColumnDataBase.Length;
                        Array.Resize(ref arrayColumnDataBase, currentlength - 1);
                    }
                    string nameColumns = string.Join(separator, arrayColumnDataBase);
                    return nameColumns;
                }
                else if (selectedTable() == "firetruck")
                {
                    string[] arrayColumnDataBase = new string[] { $"\"id_отряда\" = '{arrayColumnTextBoxes[1]}'", $"\"Класс\" = '{arrayColumnTextBoxes[2]}'", $"\"Марка\" = '{arrayColumnTextBoxes[3]}'", $"\"Модель\" = '{arrayColumnTextBoxes[4]}'", $"\"Пробег\" = '{arrayColumnTextBoxes[5]}'", $"\"Состояние\" = '{arrayColumnTextBoxes[6]}'", $"\"Дата_выпуска\" = '{arrayColumnTextBoxes[7]}'", $"\"Дата_списания\" = '{arrayColumnTextBoxes[8]}'" };
                    
                    if (comboBoxChangeMode.SelectedItem?.ToString() == "Поиск")
                    {

                    }
                    else if (arrayColumnTextBoxes[7] == "")
                    {
                        int currentlength = arrayColumnDataBase.Length;
                        Array.Resize(ref arrayColumnDataBase, currentlength - 1);
                    }
                    if (comboBoxChangeMode.SelectedItem?.ToString() == "Поиск")
                    {

                    }
                    else if (arrayColumnTextBoxes[8] == "")
                    {
                        int currentlength = arrayColumnDataBase.Length;
                        Array.Resize(ref arrayColumnDataBase, currentlength - 1);
                    }
                    string nameColumns = string.Join(separator, arrayColumnDataBase);
                    return nameColumns;
                }
                else if (selectedTable() == "equipment")
                {
                    string[] arrayColumnDataBase = new string[] { $"\"id_отряда\" = '{arrayColumnTextBoxes[1]}'", $"\"Тип\" = '{arrayColumnTextBoxes[2]}'", $"\"Состояние\" = '{arrayColumnTextBoxes[3]}'", $"\"Количество\" = '{arrayColumnTextBoxes[4]}'", $"\"Дата_списания\" = '{arrayColumnTextBoxes[7]}'" };
                    if (comboBoxChangeMode.SelectedItem?.ToString() == "Поиск")
                    {

                    }
                    else if (arrayColumnTextBoxes[7] == "")
                    {
                        int currentlength = arrayColumnDataBase.Length;
                        Array.Resize(ref arrayColumnDataBase, currentlength - 1);
                    }
                    string nameColumns = string.Join(separator, arrayColumnDataBase);
                    return nameColumns;
                }
                return "Error";
            }
            else if (methodMode == "ColumnNameMode")
            {
                string[] arrayColumnTextBoxes = new string[] { textBoxTableColumn1.Text, textBoxTableColumn2.Text, textBoxTableColumn3.Text, textBoxTableColumn4.Text, textBoxTableColumn5.Text, textBoxTableColumn6.Text, textBoxTableColumn7.Text, textBoxTableColumn8.Text, textBoxTableColumn9.Text };

                if (selectedTable() == "firesquad")
                {
                    string[] arrayColumnDataBase = new string[] { "\"Название\"", "\"Статус\"" };
                    string nameColumns = string.Join(", ", arrayColumnDataBase);
                    return nameColumns;
                }
                else if (selectedTable() == "fireman")
                {
                    string[] arrayColumnDataBase = new string[] { "\"id_отряда\"", "\"Имя\"", "\"Фамилия\"", $"\"Отчество\"", "\"Дата_рождения\"" };
                    if (comboBoxChangeMode.SelectedItem?.ToString() == "Поиск")
                    {

                    }
                    else if (arrayColumnTextBoxes[7] == "")
                    {
                        int currentlength = arrayColumnDataBase.Length;
                        Array.Resize(ref arrayColumnDataBase, currentlength - 1);
                    }
                    string nameColumns = string.Join(", ", arrayColumnDataBase);
                    return nameColumns;
                }
                else if (selectedTable() == "firetruck")
                {
                    string[] arrayColumnDataBase = new string[] { "\"id_отряда\"", "\"Класс\"", "\"Марка\"", "\"Модель\"", "\"Пробег\"", "\"Состояние\"", "\"Дата_выпуска\"", "\"Дата_списания\"" };
                    
                    if (comboBoxChangeMode.SelectedItem?.ToString() == "Поиск")
                    {

                    }
                    else if (arrayColumnTextBoxes[7] == "")
                    {
                        int currentlength = arrayColumnDataBase.Length;
                        Array.Resize(ref arrayColumnDataBase, currentlength - 1);
                    }
                    if (comboBoxChangeMode.SelectedItem?.ToString() == "Поиск")
                    {

                    }
                    else if (arrayColumnTextBoxes[8] == "")
                    {
                        int currentlength = arrayColumnDataBase.Length;
                        Array.Resize(ref arrayColumnDataBase, currentlength - 1);
                    }
                    string nameColumns = string.Join(", ", arrayColumnDataBase);
                    return nameColumns;
                }
                else if (selectedTable() == "equipment")
                {
                    string[] arrayColumnDataBase = new string[] { "\"id_отряда\"", $"\"Тип\"", "\"Состояние\"", "\"Количество\"", "\"Дата_списания\"" };

                    if (comboBoxChangeMode.SelectedItem?.ToString() == "Поиск")
                    {

                    }
                    else if (arrayColumnTextBoxes[7] == "")
                    {
                        int currentlength = arrayColumnDataBase.Length;
                        Array.Resize(ref arrayColumnDataBase, currentlength - 1);
                    }
                    string nameColumns = string.Join(", ", arrayColumnDataBase);
                    return nameColumns;
                }
                return "Error";
            }
            else if (methodMode == "ColumnValueMode")
            {
                string[] arrayColumnTextBoxes = new string[] { textBoxTableColumn1.Text, textBoxTableColumn2.Text, textBoxTableColumn3.Text, textBoxTableColumn4.Text, textBoxTableColumn5.Text, textBoxTableColumn6.Text, textBoxTableColumn7.Text, textBoxTableColumn8.Text, textBoxTableColumn9.Text };

                if (selectedTable() == "firesquad")
                {
                    string[] arrayColumnDataBase = new string[] { $"'{arrayColumnTextBoxes[1]}'", $"'{arrayColumnTextBoxes[2]}'" };
                    string nameColumns = string.Join(", ", arrayColumnDataBase);
                    return nameColumns;
                }
                else if (selectedTable() == "fireman")
                {
                    string[] arrayColumnDataBase = new string[] { $"'{arrayColumnTextBoxes[1]}'", $"'{arrayColumnTextBoxes[2]}'", $"'{arrayColumnTextBoxes[3]}'", $"'{arrayColumnTextBoxes[4]}'", $"'{arrayColumnTextBoxes[7]}'" };

                    if (comboBoxChangeMode.SelectedItem?.ToString() == "Поиск")
                    {

                    }
                    else if (arrayColumnTextBoxes[7] == "")
                    {
                        int currentlength = arrayColumnDataBase.Length;
                        Array.Resize(ref arrayColumnDataBase, currentlength - 1);
                    }
                    string nameColumns = string.Join(", ", arrayColumnDataBase);
                    return nameColumns;
                }
                else if (selectedTable() == "firetruck")
                {
                    string[] arrayColumnDataBase = new string[] { $"'{arrayColumnTextBoxes[1]}'", $"'{arrayColumnTextBoxes[2]}'", $"'{arrayColumnTextBoxes[3]}'", $"'{arrayColumnTextBoxes[4]}'", $"'{arrayColumnTextBoxes[5]}'", $"'{arrayColumnTextBoxes[6]}'", $"'{arrayColumnTextBoxes[7]}'", $"'{arrayColumnTextBoxes[8]}'" };

                    if (comboBoxChangeMode.SelectedItem?.ToString() == "Поиск")
                    {

                    }
                    else if (arrayColumnTextBoxes[7] == "")
                    {
                        int currentlength = arrayColumnDataBase.Length;
                        Array.Resize(ref arrayColumnDataBase, currentlength - 1);
                    }
                    if (comboBoxChangeMode.SelectedItem?.ToString() == "Поиск")
                    {

                    }
                    else if (arrayColumnTextBoxes[8] == "")
                    {
                        int currentlength = arrayColumnDataBase.Length;
                        Array.Resize(ref arrayColumnDataBase, currentlength - 1);
                    }
                    string nameColumns = string.Join(", ", arrayColumnDataBase);
                    return nameColumns;
                }
                else if (selectedTable() == "equipment")
                {
                    string[] arrayColumnDataBase = new string[] { $"\"id_отряда\" = '{arrayColumnTextBoxes[1]}'", $"\"Тип\" = '{arrayColumnTextBoxes[2]}'", $"\"Состояние\" = '{arrayColumnTextBoxes[3]}'", $"\"Количество\" = '{arrayColumnTextBoxes[4]}'", $"\"Дата_списания\" = '{arrayColumnTextBoxes[7]}'" };
                    if (comboBoxChangeMode.SelectedItem?.ToString() == "Поиск")
                    {

                    }
                    else if (arrayColumnTextBoxes[7] == "")
                    {
                        int currentlength = arrayColumnDataBase.Length;
                        Array.Resize(ref arrayColumnDataBase, currentlength - 1);
                    }
                    string nameColumns = string.Join(", ", arrayColumnDataBase);
                    return nameColumns;
                }
                return "Error";
            }
            else
            {
                return "Error";
            }

        }
        private string selectedId(string mode = "default")
        {
            string textBoxMode;

            if (mode == "OnlyID")
            {
                textBoxMode = textBoxDeleteID.Text;
            }
            else
            {
                textBoxMode = textBoxTableColumn1.Text;
            }

            if (selectedTable() == "firesquad")
            {
                return $"id_firesquad = {textBoxMode}";
            }
            else if (selectedTable() == "fireman")
            {
                return $"id_fireman = {textBoxMode}";
            }
            else if (selectedTable() == "firetruck")
            {
                return $"id_firetruck = {textBoxMode}";
            }
            else if (selectedTable() == "equipment")
            {
                return $"id_equipment = {textBoxMode}";
            }
            return "Error";
        }
        /*/\Функции ПОИСКА, ОБНОВЛЕНИЯ, ДОБАВЛЕНИЯ, УДАЛЕНИЯ данных/\*/
    }
}
