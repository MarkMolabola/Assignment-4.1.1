namespace Assignment_4._1._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Person.CreateData();
            dataGridView1.DataSource = Person.PhoneBook.Values.ToList();
        }

        private void AddPersonbtn_Click(object sender, EventArgs e)
        {
            string firstName = FirstNameBox.Text;
            string lastName = LastNameBox.Text;
            string phoneNumber = PhoneNumberBox.Text;
            string address = AddressBox.Text;
            Person.AddPerson(firstName, lastName, phoneNumber, address);
            dataGridView1.DataSource = Person.PhoneBook.Values.ToList();

        }

        private void RemovePersonbtn_Click(object sender, EventArgs e)
        {
            string fullName = $"{FirstNameRemoveBox.Text}{LastNameRemoveBox.Text}";
            Person.RemovePerson(fullName);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Person.PhoneBook.Values.ToList();

        }

        private void Searchbtn_Click(object sender, EventArgs e)
        {
            string fullName = $"{FirstNameSearchBox.Text}{LastNameSearchBox.Text}";
            if (Person.PhoneBook.TryGetValue(fullName, out Person person))
            {
                MessageBox.Show($"Found: {person.FirstName} {person.LastName}\nPhone: {person.PhoneNumber}\nAddress: {person.Address}");
            }
            else
            {
                MessageBox.Show("Person not found in the phone book.");
            }
        }
    }
}
