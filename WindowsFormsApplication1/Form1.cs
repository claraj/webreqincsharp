using Newtonsoft.Json;
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

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// 
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            

            WebRequest request = WebRequest.Create("http://rhymebrain.com/talk?function=getRhymes&word=hello");
            WebResponse resp = request.GetResponse();
            Console.Write(resp);

            Stream data = resp.GetResponseStream();

            StreamReader reader = new StreamReader(data);

            string jsonwehope = reader.ReadToEnd();


            Console.Write(jsonwehope);

 
            resp.Close();

    

            /*
     
            string oneWord = "{\"word\":\"cocksure\",\"freq\":15,\"score\":156,\"flags\":\"b\",\"syllables\":\"2\"}";

            Brain brainOneWord = JsonConvert.DeserializeObject<Brain>(oneWord);

            Console.Write(brainOneWord);
            Console.Write("How many syllables? " + brainOneWord.syllables);

    */



            //string listOfWords = "[{\"word\":\"cocksure\",\"freq\":15,\"score\":156,\"flags\":\"b\",\"syllables\":\"2\"},{\"word\":\"hello\",\"freq\":56,\"score\":67,\"flags\":\"b\",\"syllables\":\"2\"}]";

            List<Brain> brainList = JsonConvert.DeserializeObject<List<Brain>>(jsonwehope);


            for (int x = 0; x < brainList.Count; x++)
            {
                Console.Write("Brain object " + x);
                Console.WriteLine(brainList[x]);
            }
          

            //Console.Write(brainList);
//            Console.Write("How many syllables? " + brainOneWord.syllables);



        }
    }
}
