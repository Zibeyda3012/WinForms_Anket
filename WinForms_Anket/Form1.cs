using System.IO;
using System.Text.Json;
using WinForms_Anket.Models;

namespace WinForms_Anket
{
    public partial class Form1 : Form
    {
        public List<Person> persons = new List<Person>();
        public List<Person> myList;

        private bool isLoadBtn_Clicked = false;
        private bool isChangeBtn_Clicked = false;

        string currentFilePath { get; set; }

        public Form1()
        {
            InitializeComponent();
            myList = new List<Person>();

        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            string name = "", surname = "", phone = "", email = "";
            DateTime date = DateTime.Now;

            if (NameBox.Text is not null)
                name = NameBox.Text;

            if (SurnameBox.Text is not null)
                surname = SurnameBox.Text;

            if (PhoneBox.Text is not null)
                phone = PhoneBox.Text;

            if (EmailBox.Text is not null)
                email = EmailBox.Text;

            if (dateTimePicker1.Text is not null)
                date = dateTimePicker1.Value;

            Person newPerson = new Person(name, surname, phone, email, date);
            persons.Add(newPerson);
            listBox1.DataSource = null;
            listBox1.DataSource = persons;
            NameBox.Text = "";
            SurnameBox.Text = "";
            PhoneBox.Text = "";
            EmailBox.Text = "";
            dateTimePicker1.Value = DateTime.Now;
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            if (isChangeBtn_Clicked)
            {
                JsonSerializerOptions options = new JsonSerializerOptions();
                options.WriteIndented = true;

                var JsonList1 = JsonSerializer.Serialize(persons, options);
                File.WriteAllText(currentFilePath, JsonList1);

                isChangeBtn_Clicked = false;
                isLoadBtn_Clicked = false;  
            }
            else
            {

                string path = "../../../JsonFiles/" + FileNameBox.Text + ".json";

                JsonSerializerOptions options = new JsonSerializerOptions();
                options.WriteIndented = true;

                if (File.Exists(path))
                {
                    var jsonString = File.ReadAllText(path);
                    myList = JsonSerializer.Deserialize<List<Person>>(jsonString)!;

                    if (myList == null)
                    {
                        var JsonList1 = JsonSerializer.Serialize(persons, options);
                        File.WriteAllText(path, JsonList1);
                    }
                    else
                    {
                        List<Person> newList = new List<Person>();
                        newList.AddRange(myList);
                        newList.AddRange(persons);
                        var JsonList1 = JsonSerializer.Serialize(newList, options);
                        File.WriteAllText(path, JsonList1);

                    }

                }
                else
                {
                    var JsonList1 = JsonSerializer.Serialize(persons, options);
                    File.WriteAllText(path, JsonList1);
                }

            }

            persons = new();
            myList = new();
            listBox1.DataSource = null;
            listBox1.DataSource = persons;
            FileNameBox.Text = "";
        }

        private void Load_btn_Click(object sender, EventArgs e)
        {
            string path = "../../../JsonFiles/" + FileNameBox.Text + ".json";
            if (File.Exists(path))
            {
                var jsonString = File.ReadAllText(path);
                persons = JsonSerializer.Deserialize<List<Person>>(jsonString)!;

                currentFilePath = path;

            }
            isLoadBtn_Clicked = true;
            listBox1.DataSource = null;
            listBox1.DataSource = persons;


        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (isLoadBtn_Clicked)
            {
                var currentUser = listBox1.SelectedItem as Person;
                NameBox.Text = currentUser.Name;
                SurnameBox.Text = currentUser.Surname;
                EmailBox.Text = currentUser.Email;
                PhoneBox.Text = currentUser.PhoneNumber;
                dateTimePicker1.Value = currentUser.Birthday;
                change_btn.Visible = true;
            }


        }

        private void change_btn_Click(object sender, EventArgs e)
        {

            var selectedUser = listBox1.SelectedItem as Person;

            selectedUser.Name = NameBox.Text;
            selectedUser.Surname = SurnameBox.Text;
            selectedUser.Email = EmailBox.Text;
            selectedUser.PhoneNumber = PhoneBox.Text;
            selectedUser.Birthday = dateTimePicker1.Value;

            listBox1.SelectedIndex = 0;
            isChangeBtn_Clicked = true;
            listBox1.DataSource = null;
            listBox1.DataSource = persons;

        }
    }
}
