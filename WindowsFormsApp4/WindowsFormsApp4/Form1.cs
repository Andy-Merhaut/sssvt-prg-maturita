using System;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        private PersonRepository _repository = new PersonRepository();

        public Form1()
        {
            InitializeComponent();
            this.dataGridView1.DataSource = this._repository.SelectAll();
        }

        private void button_Add_Click(object sender, System.EventArgs e)
        {
            Form2 form2 = new Form2();
         
            form2.ShowDialog();
        }

        private void button_Delete_Click(object sender, System.EventArgs e)
        {
            var dataGridRowIndex = this.dataGridView1.CurrentRow;

            var databaseIndex = dataGridRowIndex.Cells[0].Value;

            PersonRepository repository = new PersonRepository();

            Person person = repository.SelectById(Convert.ToInt32(databaseIndex));

            repository.Delete(person);

            PersonRepository refreshedRepository = new PersonRepository();

            this.dataGridView1.DataSource = refreshedRepository.SelectAll();
        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            var dataGridRowIndex = this.dataGridView1.CurrentRow;

            var databaseIndex = dataGridRowIndex.Cells[0].Value;

            PersonRepository repository = new PersonRepository();

            Person person = repository.SelectById(Convert.ToInt32(databaseIndex));

            Form2 form2 = new Form2(person);

            form2.ShowDialog();
        }
    }
}
