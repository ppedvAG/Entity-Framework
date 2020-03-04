using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EfModelFirst
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Model1Container context = new Model1Container();
        private void button1_Click(object sender, EventArgs e)
        {
            var abt1 = new Abteilung() { Bezeichnung = "Steine" };
            var abt2 = new Abteilung() { Bezeichnung = "Holz" };

            for (int i = 0; i < 100; i++)
            {
                var m = new Mitarbeiter()
                {
                    Name = $"Fred #{i:000}",
                    GebDatum = DateTime.Now.AddDays(i * 348),
                    Beruf = "Macht dinge"
                };

                if (i % 2 == 0)
                    m.Abteilung.Add(abt1);
                if (i % 3 == 0)
                    m.Abteilung.Add(abt2);

                context.PersonSet.Add(m);
            }

            context.SaveChanges();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = context.PersonSet.ToList();
        }
    }
}
