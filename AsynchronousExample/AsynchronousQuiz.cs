using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsynchronousExample
{
    public partial class AsynchronousQuiz : Form
    {
        public AsynchronousQuiz()
        {
            InitializeComponent();
        }
         async Task  DownloadAsync(string uri)
        {

            var client = new WebClient();
            string path = @"D:\Stackoverflow.html";
            string stackoverflow = await client.DownloadStringTaskAsync(uri);
            System.IO.File.WriteAllText($"{path}", stackoverflow);
            System.Diagnostics.Process.Start(path);

        }
      

        private void Start_Click(object sender, EventArgs e)
        {
            Task asynccaller = Task.Run(() => DownloadAsync("https://stackoverflow.com/questions/13240915/converting-a-webclient-method-to-async-await"));

        }
    }
}
