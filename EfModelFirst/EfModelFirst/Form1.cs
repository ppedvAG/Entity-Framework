using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace EfModelFirst
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            dataGridView1.CellFormatting += DataGridView1_CellFormatting;
            dataGridView1.DoubleClick += DataGridView1_DoubleClick;
        }

        private void DataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.DataBoundItem is Mitarbeiter m)
            {
                //context.Entry(m).State = EntityState.Added;
                //context.PersonSet.Add(m);

                //context.Entry(m).State = EntityState.Modified;

                context.Entry(m).State = EntityState.Deleted;

                //context.Entry(m).CurrentValues.SetValues(context.Entry(m).OriginalValues);

                EntityState state = context.Entry(m).State;
                MessageBox.Show($"({state}) {m.Name} [{string.Join(", ", m.Abteilung.Select(x => x.Bezeichnung))}]");
            }

        }

        private void DataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value is Kunde k)
                e.Value = $"{k.Name}";
            else if (e.Value is IEnumerable<Abteilung> abts)
                e.Value = string.Join(", ", abts.Select(x => x.Bezeichnung));
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
         //  dataGridView1.AutoGenerateColumns = false;
         //
         //  var col = new DataGridViewTextBoxColumn();
         //  col.DataPropertyName = "Name";
         //  dataGridView1.Columns.Add(col);


            dataGridView1.DataSource = context.PersonSet.OfType<Mitarbeiter>()
                                              //       .Include(x => x.Abteilung).Include(x => x.Kunde)
                                              .Where(x => x.Name.StartsWith("F") && x.GebDatum.Month < 20)
                                              .ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            context.SaveChanges();
        }
    }
}
