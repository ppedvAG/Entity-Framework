using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;
using ppedv.Finex.Logic;
using ppedv.Finex.Model;

namespace ppedv.Finex.UI.WinForms
{
    public partial class MedikamentenView : MetroUserControl
    {
        Core core = new Core();
        BindingSource mediBs = new BindingSource();
        BindingList<Medikament> mediList = new BindingList<Medikament>();

        public MedikamentenView()
        {
            InitializeComponent();
            metroGrid1.DataSource = mediBs;
            mediBs.DataSource = mediList;

            metroTextBox1.DataBindings.Add(nameof(MetroTextBox.Text), mediBs, nameof(Medikament.Name), true, DataSourceUpdateMode.OnPropertyChanged);
            metroTextBox2.DataBindings.Add(nameof(MetroTextBox.Text), mediBs, nameof(Medikament.Nummer), true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            mediList.Clear();

            core.Repository.Query<Medikament>().ToList().ForEach(x => mediList.Add(x));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            core.Repository.SaveChanges();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var newMedi = new Medikament() { Name = "NEU" };
            core.Repository.Add(newMedi);
            mediList.Add(newMedi);
            mediBs.Position = mediBs.IndexOf(newMedi);
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
