using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        List<Discipline> serializeListScore = new List<Discipline>();
        List<Discipline> serializeListType = new List<Discipline>();
        Discipline discipline;
        List<Discipline> disciplines;
        List<Book> books;
        public Form1()
        {
            books = new List<Book>();
            disciplines = new List<Discipline>();
            InitializeComponent();
        }
        private void DisciplineName_Enter(object sender, EventArgs e)
        {
            if (DisciplineName.Text == "Название дисциплины")
                DisciplineName.Text = "";
        }
        private void LecturesCount_ValueChanged(object sender, EventArgs e)
        {
            LecturesCountValue.Text = LecturesCount.Value.ToString();
        }

        private void LabsCount_ValueChanged(object sender, EventArgs e)
        {
            LabsCountValue.Text = LabsCount.Value.ToString();
        }

        private void SNP_Enter(object sender, EventArgs e)
        {
            if (SNP.Text == "Ф.И.О.")
                SNP.Text = "";
        }
        private void Pulpit_Enter(object sender, EventArgs e)
        {
            if (Pulpit.Text == "Кафедра")
                Pulpit.Text = "";
        }
        private void BookName_Enter(object sender, EventArgs e)
        {
            if (BookName.Text == "Название")
                BookName.Text = "";
        }
        private void Author_Enter(object sender, EventArgs e)
        {
            if (Author.Text == "Автор")
                Author.Text = "";
        }
        private void Add_Click(object sender, EventArgs e)
        {
            if (Author.Text == "" || Author.Text == "Автор" ||
                BookName.Text == "" || BookName.Text == "Название")
                MessageBox.Show("Укажите книгу корректно");
            else
            {
                Book book = new Book(Author.Text, BookName.Text, CreationDate.Value.Date);
                books.Add(book);
                BookList.Items.Add(book.ToString());
            }
        }
        private void AddAll_Click(object sender, EventArgs e)
        {
            bool flag = false;
            foreach (CheckBox x in Controls.OfType<CheckBox>())
                if (x.Checked)
                {
                    flag = true;
                    break;
                }
            foreach (RadioButton x in ControlPanel.Controls.OfType<RadioButton>())
                if (x.Checked)
                {
                    flag = true;
                    break;
                }
            foreach (TextBox x in Controls.OfType<TextBox>())
                if (x.Text == "")
                {
                    flag = false;
                    break;
                }
            int buf;
            if (!flag ||
                DisciplineName.Text == "Название дисциплины" ||
                SemestrValue.Text == "" ||
                !int.TryParse(SemestrValue.Text, out buf) ||
                SNP.Text == "Ф.И.О" ||
                Pulpit.Text == "Кафедра" ||
                books.Count == 0 || LecturesCountValue.Text == "" ||
                LabsCountValue.Text == "" ||
                int.Parse(SemestrValue.Text) >= 3)
                MessageBox.Show("Некорректно введены данные");
            else
            {
                discipline = new Discipline(DisciplineName.Text,
                int.Parse(SemestrValue.Text), (int)CourseValue.Value,
                new Spec(SpecializationPOIT.Checked, SpecializationPOIBMS.Checked,
                SpecializationISIT.Checked, SpecializationDEVI.Checked),
                LecturesCount.Value, LabsCount.Value, ((exam.Checked) ? PassType.Exam : PassType.Test),
                new Lector(SNP.Text, Pulpit.Text, (int)NumberAudit.Value, (int)CorpusAydit.Value), books);

                try
                {
                    DataContractJsonSerializer Serializer = new DataContractJsonSerializer(typeof(List<Discipline>));
                    using (FileStream File = new FileStream("Serialize.json", FileMode.Open))
                    {
                        disciplines = (List<Discipline>)Serializer.ReadObject(File);
                    }
                }
                catch { }
                disciplines.Add(discipline);
                DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(List<Discipline>));
                using (FileStream file = new FileStream("Serialize.json", FileMode.OpenOrCreate))
                {
                    serializer.WriteObject(file, disciplines);
                }
                disciplines.Clear();
                BookList.Items.Clear();
                books.Clear();
            }
        }
        private void Output_Click(object sender, EventArgs e)
        {
            try
            {
                DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(List<Discipline>));
                using (FileStream file = new FileStream("Serialize.json", FileMode.Open))
                {
                    disciplines = (List<Discipline>)serializer.ReadObject(file);
                    OutputList.Nodes.Clear();
                    foreach (Discipline x in disciplines)
                        OutputList.Nodes.Add(x.TakeElementTree());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void SNP_KeyPress(object sender, KeyPressEventArgs e)
        {
            ErrorProvider error = new ErrorProvider();
            e.Handled = Char.IsDigit(e.KeyChar);

            if (Char.IsDigit(e.KeyChar))
                error.SetError(SNP, "ФИО не может содежать цифр");
            else
                error.SetError(SNP, "");
        }

        private void Example1_Click(object sender, EventArgs e)
        {
            DisciplineName.Text = "Объекто-ориентиованной программирование";
            SemestrValue.Text = "1";
            CourseValue.Value = 2;
            SpecializationPOIT.Checked = true;
            SpecializationPOIBMS.Checked = true;
            LecturesCount.Value = 20;
            LabsCount.Value = 30;
            exam.Checked = true;
            SNP.Text = "Пацей Н.В.";
            Pulpit.Text = "Программной инженерии";
            NumberAudit.Value = 200;
            CorpusAydit.Value = 3;
            books.Add(new Book("Пацей Н.В. Пустовалова Н.Н", "	Основы алгоритмизации и программирования", DateTime.Parse("01.05.2014")));
            BookList.Items.Add("Пацей Н.В. Пустовалова Н.Н  \"Основы алгоритмизации и программирования\" 01.05.2014"); 
            books.Add(new Book("Пацей Н.В.", "Объектно-ориентированное программирование", DateTime.Parse("15.07.2012")));
            BookList.Items.Add("Пацей Н.В. \"Объектно-ориентированное программирование\" 15.07.2012");
        }
    }
}
