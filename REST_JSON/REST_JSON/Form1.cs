using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace REST_JSON
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var web = new HttpClient();



            var json = await web.GetStringAsync("https://www.googleapis.com/books/v1/volumes?q=hund");


            BookResult result = JsonConvert.DeserializeObject<BookResult>(json);
            this.result = result;
            dataGridView1.DataSource = result.items.Select(x => x.volumeInfo).ToList();

        }

        BookResult result;
        private void button2_Click(object sender, EventArgs e)
        {
            using (var sw = new StreamWriter("books.xml"))
            {
                var serial = new XmlSerializer(typeof(BookResult));
                serial.Serialize(sw, result);
            }
        }
    }
}
