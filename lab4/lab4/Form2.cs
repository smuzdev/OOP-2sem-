using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4
{
    public partial class Form2 : Form
    {
        private List<Car> collection;

        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.ShowDialog();
            //this.Hide();
        }

        // Заполнение коллекции
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.Clear();
                int count;
                if (textBox1.Text == "" || (count = Convert.ToInt32(textBox1.Text)) == 0)
                {
                    MessageBox.Show("коллекция пуста");
                    this.collection = null;
                }
                else
                {
                    collection = new List<Car>(count);
                    for (int i = 0; i < count; i++)
                    {
                        Car car = new Car();
                        collection.Add(car);
                    }
                    foreach (Car c in collection)
                    {
                        listBox1.Items.Add(c.brand + " , " + c.year + " год, ");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        // Сортировка по возрастанию
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                listBox2.Items.Clear();
                if (collection == null || collection.Count == 0)
                {
                    MessageBox.Show("коллекция пуста");
                }
                else
                {
                    collection.Sort();
                    foreach (Car c in collection)
                    {
                        listBox2.Items.Add(c.brand + " , " + c.year + " год ");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        // Сортировка по убыванию
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                listBox2.Items.Clear();
                if (collection == null || collection.Count == 0)
                {
                    MessageBox.Show("коллекция пуста");
                }
                else
                {
                    Car st = new Car();
                    collection.Sort(0, collection.Count, st);
                    foreach (Car c in collection)
                    {
                        listBox2.Items.Add(c.brand + " , " + c.year + " год ");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }
        
        // Первый запрос
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                listBox3.Items.Clear();
                if (collection == null || collection.Count == 0)
                {
                    MessageBox.Show("коллекция пуста");
                }
                else
                {
                    var query = from car in collection
                                where car.year > 2000
                                select car;
                    foreach (Car c in query)
                    {
                        listBox3.Items.Add(c.brand + " , " + c.year + " год ");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        // Второй запрос
        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                listBox3.Items.Clear();
                if (collection == null || collection.Count == 0)
                {
                    MessageBox.Show("коллекция пуста");
                }
                else
                {
                    var query = from car in collection
                                where car.year < 2008
                                select car;
                    foreach (Car c in query)
                    {
                        listBox3.Items.Add(c.brand + " , " + c.year + " год ");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        // Третий запрос
        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                listBox3.Items.Clear();
                if (collection == null || collection.Count == 0)
                {
                    MessageBox.Show("коллекция пуста");
                }
                else
                {
                    var query = from car in collection
                                where (car.brand == "Audi")|| (car.brand == "Skoda")
                                select car;
                    
                    foreach (Car c in query)
                    {
                        listBox3.Items.Add(c.brand + " , " + c.year + " год ");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }
    }
}
