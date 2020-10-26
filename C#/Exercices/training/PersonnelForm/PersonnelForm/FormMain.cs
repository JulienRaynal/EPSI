using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PersonnelLibrary;

namespace PersonnelForm
{
    public partial class FormMain : Form
    {
        Entreprise entreprise = new Entreprise();
        public FormMain()
        {
            Services service1 = new Services(1, "Production");
            Services service2 = new Services(2, "Comptabilité");
            Services service3 = new Services(3, "Direction");

            entreprise.AjouterPersonne(new Employe(1, "DUPONT", "Charles", Personnel.Gender.male, new DateTime(1998, 04, 12), 1500, service1, 14));
            entreprise.AjouterPersonne(new Employe(2, "KERBAN", "Henry", Personnel.Gender.female, new DateTime(1981, 09, 24), 1500, service1, 7));
            entreprise.AjouterPersonne(new Employe(3, "CHAMPOT", "Paul", Personnel.Gender.male, new DateTime(1981, 03, 17), 1500, service1, 6));
            entreprise.AjouterPersonne(new Cadre(4, "JOULIE", "Alexandre", Personnel.Gender.female, new DateTime(1987, 11, 21), 2100, service2, 100));
            entreprise.AjouterPersonne(new Cadre(5, "MITAUT", "Marcel", Personnel.Gender.female, new DateTime(1972, 10, 06), 6000, service3, 2000));

            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            dvgPersonnel.DataSource = entreprise.ListPersonnel;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
