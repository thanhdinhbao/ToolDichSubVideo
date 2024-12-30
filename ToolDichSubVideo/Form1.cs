using Google.Cloud.Translation.V2;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using static ToolDichSubVideo.GeminiPrompt;

namespace ToolDichSubVideo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        async void SendGemini(string prompt)
        {
            var options = new RestClientOptions()
            {
            };
            var client = new RestClient(options);
            var request = new RestRequest("https://generativelanguage.googleapis.com/v1beta/models/gemini-1.5-flash:generateContent?key=AIzaSyB9p4Z9X63cdeVQg9T-W3WFKitQULdID5I", Method.Post);
            request.AddHeader("Content-Type", "application/json");

            var root = new Root
            {
                contents = new List<Content>
            {
                new Content
                {
                    parts = new List<Part>
                    {
                        new Part { text = prompt },
                    }
                }

            }
            };

            string body = JsonConvert.SerializeObject(root, Formatting.Indented);
            request.AddStringBody(body, DataFormat.Json);
            RestResponse response = await client.ExecuteAsync(request);
            GeminiRespone.Root json = JsonConvert.DeserializeObject<GeminiRespone.Root>(response.Content);
            txtResult.Text = json.candidates[0].content.parts[0].text.Replace("\n",Environment.NewLine);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "SRT files|*.srt",
                Title = "Chọn file SRT"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog.FileName;
                txtFilePath.Text = selectedFilePath;
            }
        }

        static string ReadSrtFile(string filePath)
        {
            try
            {
                if (File.Exists(filePath))
                {
                    string content = File.ReadAllText(filePath);
                    return content;
                }
                else
                {
                    MessageBox.Show("File không tồn tại.");
                    return string.Empty;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
                return string.Empty;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //SendGemini("Hello");
            string content = ReadSrtFile(txtFilePath.Text);
            SendGemini("Dịch văn bản sang tiếng anh" + content);
        }
    }
}
