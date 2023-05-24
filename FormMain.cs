using Microsoft.VisualBasic.Devices;
using System.Diagnostics;
using System.Reflection;

// Store an occupation with name and salary
readonly struct Occupation
{
    // Attributes
    public readonly string Name;
    public readonly string Salary;

    // Constructor
    public Occupation(string Name, string Salary)
    {
        this.Name = Name;
        this.Salary = Salary;
    }
}

namespace PeopleGenerator
{
    public partial class FormMain : Form
    {
        // Attributes
        readonly Random Random = new();
        readonly List<string> MaleNames = new();
        readonly List<string> FemaleNames = new();

        readonly List<string> Surnames = new();
        readonly List<Occupation> Occupations = new();

        string TemporaryName = "None";

        // Contructor
        public FormMain()
        {
            InitializeComponent();
            InitializeData();
        }

        private void InitializeData()
        {
            // Add male names
            MaleNames.Add("Arthur");
            MaleNames.Add("Ducth");
            MaleNames.Add("Michael");
            MaleNames.Add("Franklin");
            MaleNames.Add("Trevor");
            MaleNames.Add("Steve");
            MaleNames.Add("John");
            MaleNames.Add("Paul");
            MaleNames.Add("Dave");
            MaleNames.Add("Ethan");
            MaleNames.Add("Chris");
            MaleNames.Add("Julius");
            MaleNames.Add("Sean");
            MaleNames.Add("Matthew");
            MaleNames.Add("Charlie");
            MaleNames.Add("Dean");
            MaleNames.Add("Samuel");
            MaleNames.Add("Jason");
            MaleNames.Add("Jakson");

            // Add female names
            FemaleNames.Add("Ada");
            FemaleNames.Add("Claire");
            FemaleNames.Add("Lara");
            FemaleNames.Add("Laura");
            FemaleNames.Add("Mary");
            FemaleNames.Add("Hellena");
            FemaleNames.Add("Sophia");
            FemaleNames.Add("Abigail");
            FemaleNames.Add("Molly");
            FemaleNames.Add("Olivia");
            FemaleNames.Add("Isla");
            FemaleNames.Add("Mia");
            FemaleNames.Add("Lily");
            FemaleNames.Add("Isabela");
            FemaleNames.Add("Amelia");
            FemaleNames.Add("Ava");
            FemaleNames.Add("Emily");
            FemaleNames.Add("Grace");
            FemaleNames.Add("Lucy");
            FemaleNames.Add("Freya");
            FemaleNames.Add("Amber");
            FemaleNames.Add("Bonnie");
            FemaleNames.Add("Beatrice");
            FemaleNames.Add("Saldina");
            FemaleNames.Add("Florence");
            FemaleNames.Add("Martha");
            FemaleNames.Add("Darcie");
            FemaleNames.Add("Nancy");
            FemaleNames.Add("Arabella");
            FemaleNames.Add("Saskia");
            FemaleNames.Add("Rosanna");
            FemaleNames.Add("Anna");
            FemaleNames.Add("Maryam");
            FemaleNames.Add("Dolly");
            FemaleNames.Add("Hettie");
            FemaleNames.Add("Libby");
            FemaleNames.Add("Sadie");
            FemaleNames.Add("Katherine");
            FemaleNames.Add("Adele");
            FemaleNames.Add("Connery");
            FemaleNames.Add("Aila");
            FemaleNames.Add("Mirren");
            FemaleNames.Add("Gwen");
            FemaleNames.Add("Ella");
            FemaleNames.Add("Ivy");
            FemaleNames.Add("Rosie");
            FemaleNames.Add("Rose");
            FemaleNames.Add("Megan");
            FemaleNames.Add("Mia");
            FemaleNames.Add("Merryn");
            FemaleNames.Add("Sabrina");
            FemaleNames.Add("Bristol");
            FemaleNames.Add("Kenza");
            FemaleNames.Add("Kezia");
            FemaleNames.Add("Serana");
            FemaleNames.Add("Jane");
            FemaleNames.Add("Victoria");
            FemaleNames.Add("Diana");
            FemaleNames.Add("Elizabeth");
            FemaleNames.Add("Margaret");

            // Add surnames
            Surnames.Add("Scott");
            Surnames.Add("Burton");
            Surnames.Add("Adams");
            Surnames.Add("Harris");
            Surnames.Add("Wilson");
            Surnames.Add("Baker");
            Surnames.Add("Payne");
            Surnames.Add("Walker");
            Surnames.Add("Owen");
            Surnames.Add("Holmes");
            Surnames.Add("Lewis");
            Surnames.Add("Robinson");
            Surnames.Add("Allen");
            Surnames.Add("Jones");
            Surnames.Add("Foster");
            Surnames.Add("Matthews");
            Surnames.Add("White");
            Surnames.Add("Stevens");
            Surnames.Add("Griffiths");
            Surnames.Add("Evans");
            Surnames.Add("Young");
            Surnames.Add("Corbyn");
            Surnames.Add("Smith");
            Surnames.Add("Evans");
            Surnames.Add("Jenkins");
            Surnames.Add("Green");
            Surnames.Add("Hughes");
            Surnames.Add("Taylor");
            Surnames.Add("Hall");
            Surnames.Add("Anderson");
            Surnames.Add("Armstrong");
            Surnames.Add("Bell");
            Surnames.Add("Cox");
            Surnames.Add("Cartex");
            Surnames.Add("Cole");
            Surnames.Add("Collins");
            Surnames.Add("Atkinson");
            Surnames.Add("Dawson");
            Surnames.Add("Bailey");
            Surnames.Add("Ball");
            Surnames.Add("Dixon");
            Surnames.Add("Edwards");
            Surnames.Add("Browns");
            Surnames.Add("Clarke");
            Surnames.Add("Yates");
            Surnames.Add("Zelly");
            Surnames.Add("Zouch");
            Surnames.Add("Fisher");
            Surnames.Add("Ford");
            Surnames.Add("Fletcher");
            Surnames.Add("Fox");
            Surnames.Add("Gibson");
            Surnames.Add("Graham");
            Surnames.Add("Grant");
            Surnames.Add("Gray");
            Surnames.Add("Sallow");
            Surnames.Add("Fernsby");
            Surnames.Add("Villin");
            Surnames.Add("Miracle");
            Surnames.Add("Dankworth");
            Surnames.Add("Relish");
            Surnames.Add("Palmer");
            Surnames.Add("Parker");
            Surnames.Add("Quintrell");
            Surnames.Add("Quill");
            Surnames.Add("Stewart");
            Surnames.Add("Turner");
            Surnames.Add("Walsh");
            Surnames.Add("Cooper");
            Surnames.Add("Morris");
            Surnames.Add("Harrison");
            Surnames.Add("Morgan");
            Surnames.Add("Watson");
            Surnames.Add("Campbell");
            Surnames.Add("Ainsworth");
            Surnames.Add("Eaton");
            Surnames.Add("Elton");
            Surnames.Add("Camden");
            Surnames.Add("Browning");
            Surnames.Add("Garfield");
            Surnames.Add("Dalton");
            Surnames.Add("Cobain");
            Surnames.Add("Duke");
            Surnames.Add("Bobellon");
            Surnames.Add("Carmichael");
            Surnames.Add("Granger");
            Surnames.Add("Kennedy");
            Surnames.Add("Lawrence");
            Surnames.Add("Halifax");
            Surnames.Add("Lloyd");
            Surnames.Add("Osborne");
            Surnames.Add("Marshall");

            // Add occupations
            Occupations.Add(new Occupation("Architect", "46,883.21"));
            Occupations.Add(new Occupation("Baker", "25,506.46"));
            Occupations.Add(new Occupation("Cleaner", "21,860.13"));
            Occupations.Add(new Occupation("Dentist", "97,002.82"));
            Occupations.Add(new Occupation("Doctor", "121,308.79"));
        }

        private string RandomName(bool Male)
        {
            // Return a random name
            return (Male) ? MaleNames.ElementAt(Random.Next(0, MaleNames.Count)) : FemaleNames.ElementAt(Random.Next(0, FemaleNames.Count));
        }

        private string RandomSurname()
        {
            // Store a random surname
            string Surname = Surnames.ElementAt(Random.Next(0, Surnames.Count));

            // Store the last surname choused
            if (TemporaryName != "None")
                Surnames.Add(TemporaryName);

            // Store surname in a local variable and delete it from surname list
            TemporaryName = Surname;
            Surnames.RemoveAt(Surnames.IndexOf(Surname));
            return Surname;
        }

        private Occupation RandomOccupation()
        {
            // Return a random occupation with a salary linked
            return Occupations.ElementAt(Random.Next(0, Occupations.Count));
        }

        private void Btn_Generate_Click(object sender, EventArgs e)
        {
            // Choose between male and female and randomize a complete name
            Txt_Name.Text = RandomName(Rdo_Male.Checked) + " " + RandomSurname() + " " + RandomSurname();

            // Calculates age and anniversary
            short Age = (short)Random.Next(18, 60);
            Txt_Age.Text = Convert.ToString(Age);
            Txt_Anniversary.Text = Convert.ToString(Random.Next(1, 28)) + "/" + Convert.ToString(Random.Next(1, 12)) + "/" + Convert.ToString(DateTime.Now.Year - Age);

            // Choose between single and married 
            Txt_MaritalStatus.Text = (Random.Next(0, 9) <= 4) ? "Single" : "Married";

            // Randomize an occupation and get its salary per year
            Occupation OccupationCache = RandomOccupation();
            Txt_Occupation.Text = OccupationCache.Name;
            Txt_Income.Text = "£ " + OccupationCache.Salary;
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Show warning message box
            DialogResult Result = MessageBox.Show("Do you really want to close the application?",
                "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            // Verify if user want to close the window
            e.Cancel = (Result == DialogResult.No);
        }
    }
}