using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        List<Person> persons = new List<Person>();
        Person selectedPerson;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string name = textBox1.Text;
            Person p = new Person() { Name = name };
            persons.Add(p);
            listBox1.ItemsSource = null;
            listBox1.ItemsSource = persons;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            selectedPerson = (Person)listBox1.SelectedItem;
            string race = textBox2.Text;
            int age = int.Parse(textBox3.Text);

            if (selectedPerson == null)
            {
                MessageBox.Show("Ingen person vald");
            }
            else
            {
                if (comboBox1.Text == "Dog")
                {
                    Dog d = new Dog() { Race = race, Age = age };
                    selectedPerson.AddAnimal(d);
                }
                listBox2.ItemsSource = null;
                listBox2.ItemsSource = selectedPerson.animals;
            }
        }

        private void listBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (listBox1.SelectedItem == null)
            {
                listBox2.ItemsSource = null;
            }
            else
            {
                selectedPerson = (Person)listBox1.SelectedItem;
                listBox2.ItemsSource = null;
                listBox2.ItemsSource = selectedPerson.animals;
            }
        }
    }
}
