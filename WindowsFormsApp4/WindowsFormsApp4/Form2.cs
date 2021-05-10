using System;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form2 : Form
    {
        private Person _person = new Person();

        private bool isEditing = false;

        public Form2()
        {
            InitializeComponent();
        }

        public Form2(Person person)
        {
            InitializeComponent();

            this.isEditing = true;

            this._person = person;

            this.textBox_Name.Text = this._person.Name;
            this.textBox_Age.Text = this._person.Age.ToString();
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            if (!isEditing)
            {
                this.SendDataToDatabase(this.ReceiveDataFromTextBoxes());
            }
            else
            {
                this.SendEditedDataToDatabase(this.ReceiveDataFromTextBoxes());
            }

            this.Close();
        }

        private Person ReceiveDataFromTextBoxes()
        {
            Person newPerson = new Person();

            newPerson.Name = this.textBox_Name.Text;
            newPerson.Age = int.Parse(this.textBox_Age.Text);

            return newPerson;
        }

        private void SendDataToDatabase(Person person)
        {
            PersonRepository repository = new PersonRepository();

            repository.Insert(person);
        }

        private void SendEditedDataToDatabase(Person person)
        {
            PersonRepository repository = new PersonRepository();

            repository.Update(person);
        }
    }
}
