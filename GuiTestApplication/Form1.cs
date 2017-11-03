using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookServiceRequester.Util.XML;
using BookServiceRequester.Model.XML;
using BookServiceRequester.Model.JSON;
using BookServiceRequester.Util.JSON;

namespace GuiTestApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            Task<ArrayOfAuthor> task = Task.Run(() => TestXML());
            ArrayOfAuthor al = await task;
            this.textBox1.Text = al.Author[al.Author.Count-1].Name;
        }

        private ArrayOfAuthor TestXML()
        {
         BookServiceUtilXML bookservice = new BookServiceUtilXML("bookserviceaseece.azurewebsites.net", "", "api");
            //Test Author metoder
            ArrayOfAuthor alist = bookservice.GetAuthors();
                     
            return alist;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            BookServiceUtilJSON bookservice = new BookServiceUtilJSON("bookserviceaseece.azurewebsites.net", "", "api");
            //Test Author metoder
            AuthorsList alist = bookservice.GetAuthors();
            this.textBox1.Text = alist.Authors[alist.Authors.Count-1 ].Name;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
