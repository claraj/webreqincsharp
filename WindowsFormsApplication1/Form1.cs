using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Json;


namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WebRequest request = WebRequest.Create("http://rhymebrain.com/talk?function=getRhymes&word=hello");
           WebResponse resp = request.GetResponse();
            Console.Write(resp);

            Stream data = resp.GetResponseStream();

            StreamReader reader = new StreamReader(data);

            string jsonwehope = reader.ReadToEnd();


          //  DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(WebResponse));

          // Deal with JSON somehow?


            Console.Write(jsonwehope);
            resp.Close();

        }
    }
}
