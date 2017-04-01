using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using Rijndael256; //http://2toad.com/Project/Rijndael256

namespace ProjectorControlCryptotool
{
    public partial class Form1 : Form
    {
        XmlDocument projectorDoc = new XmlDocument();

        public Form1()
        {
            InitializeComponent();   
        }

        /// <summary>
        /// On click event for the Browse button. Retrieves an XML file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void xmlFileBrowseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog xmlFileDialog = new OpenFileDialog();

            xmlFileDialog.InitialDirectory = "c:\\";
            xmlFileDialog.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
            xmlFileDialog.FilterIndex = 2;
            xmlFileDialog.RestoreDirectory = true;

            if (xmlFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    String xmlFile = xmlFileDialog.FileName;
                    if (!String.IsNullOrEmpty(xmlFile))
                    {
                        this.xmlFileTextBox.Text = xmlFile;
                        String xmlFileText = File.ReadAllText(xmlFile);
                        projectorDoc.LoadXml(xmlFileText);
                        using (StringReader reader = new StringReader(xmlFileText))
                        {
                            String line;
                            while ((line = reader.ReadLine()) != null)
                            {
                                if (line.Contains("<ip") && line.EndsWith("</ip>"))
                                {
                                    this.xmlNodesListBox.Items.Add(line.TrimStart());
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        /// <summary>
        /// On click event for the Add button. Adds a new node.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addButton_Click(object sender, EventArgs e)
        {
            String computerName = this.computerNameTextBox.Text;
            String projectorIP = this.projectorIPTextBox.Text;
            String newNode;

            if (!String.IsNullOrWhiteSpace(computerName))
            {
                newNode = "<ip pc=\"" + computerName + "\">" + projectorIP + "</ip>";
            }
            else
            {
                newNode = "<ip>" + projectorIP + "</ip>";
            }

            xmlNodesListBox.Items.Add(newNode);
        }

        /// <summary>
        /// On click event for the Remove button. Removes a node.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void removeButton_Click(object sender, EventArgs e)
        {
            this.xmlNodesListBox.Items.Remove(this.xmlNodesListBox.SelectedItem);
        }

        /// <summary>
        /// On click event for the Save button. Saves the file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();

            saveDialog.FileName = "ProjectorIPs.xml";
            saveDialog.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter writer = new StreamWriter(saveDialog.FileName))
                {
                    writer.WriteLine("<?xml version=\"1.0\" encoding=\"utf-8\"?>");
                    writer.WriteLine("<projectors>");
                    foreach (object node in this.xmlNodesListBox.Items)
                    {
                        writer.WriteLine("  " + node.ToString());
                    }
                    writer.WriteLine("</projectors>");
                }
            }
        }

        /// <summary>
        /// Encrypts a node.
        /// </summary>
        /// <param name="node">An unencrypted node</param>
        /// <returns>An encrypted node</returns>
        private String encryptNode(string node)
        {
            // TODO: Not put the key in plaintext here. (It's just for local use right now anyway.)
            String encryptedNode;
            String key = "5Xx7ghbgpcAIQubJh9VOxzsexMK59z";

            encryptedNode = "  <EncryptedData>" + Rijndael.Encrypt(node, key, KeySize.Aes256) + "</EncryptedData>";

            return encryptedNode;
        }

        /// <summary>
        /// On click event for the Save Encrypted button. Saves the file after encrypting all nodes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveEncryptedButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();

            saveDialog.FileName = "SecureProjectors.xml";
            saveDialog.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter writer = new StreamWriter(saveDialog.FileName))
                {
                    writer.WriteLine("<?xml version=\"1.0\" encoding=\"utf-8\"?>");
                    writer.WriteLine("<projectors>");
                    foreach (object node in this.xmlNodesListBox.Items)
                    {
                        writer.WriteLine(encryptNode(node.ToString()));
                    }
                    writer.WriteLine("</projectors>");
                }
            }
        }
    }
}
