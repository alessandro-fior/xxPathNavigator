using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using System.Xml.XPath;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        XmlDocument XMLDoc = new XmlDocument();
       

        public Form1()
        {
            InitializeComponent();
        }

        private void open_Click_1(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                openFileDialog1.Title = "Open XML Document";
                openFileDialog1.Filter = "XML File |*.xml";
                DialogResult result = openFileDialog1.ShowDialog();
                String file = "";


                if (result == DialogResult.OK)
                {

                    file = openFileDialog1.FileName;
                    XMLfile.Text = openFileDialog1.FileName;
                    LoadXml(file);


                }

                XMLDoc.Load(file);
                var allElements = XMLDoc.SelectNodes("//*");
                comboBox1.Items.Clear();

                XmlDocument mDocument = new XmlDocument();
                XmlNode mCurrentNode;

                mDocument.Load(openFileDialog1.FileName);
                mCurrentNode = mDocument.DocumentElement;

                XmlNodeList nodeList = mCurrentNode.SelectNodes("*");

                comboBox1.Items.Clear();

                int counter = 0;
                foreach (XmlNode testnode in nodeList)
                {
                    counter += 1;
                    XmlNode siblingNode = testnode.FirstChild.NextSibling;

                    if (counter == 1)
                    {
                        comboBox1.Items.Add("/"+testnode.ParentNode.Name + "/" + testnode.Name);
                        comboBox1.Items.Add("/"+testnode.ParentNode.Name + "/" + testnode.Name + "/" + testnode.FirstChild.Name);

                        while (siblingNode != null)
                        {
                            comboBox1.Items.Add("/"+testnode.ParentNode.Name + "/" + testnode.Name + "/" + siblingNode.Name);
                            siblingNode = siblingNode.NextSibling;
                        }
                    }



                    foreach (XmlNode Node in allElements)
                    {
                        string xPath = GetXPathToNode(Node);
                        comboBox1.Items.Add(xPath);
                    }
                }

            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show("Plese select a valid file");
            }

            catch (Exception ex)
            {
                throw ex;
            }

            

        }

        

        public string GetXPathToNode(XmlNode node)
        {
            if (node.NodeType == XmlNodeType.Attribute)
            {
                     
                return String.Format("{0}/@{1}", GetXPathToNode(((XmlAttribute)node).OwnerElement), node.Name);
            }
            if (node.ParentNode == null)
            {
                
                return "";
            }

            
            int indexInParent = 1;
            XmlNode siblingNode = node.PreviousSibling;
      
            while (siblingNode != null)
            {
               
                if (siblingNode.Name == node.Name)
                {
                    indexInParent++;
                }
                siblingNode = siblingNode.PreviousSibling;
            }
                   
            return String.Format("{0}/{1}[{2}]", GetXPathToNode(node.ParentNode), node.Name, indexInParent);
        }


        private void LoadXml(string FILE_NAME)
        {
            if (!File.Exists(FILE_NAME))
            {
                Console.WriteLine("{0} does not exist.", FILE_NAME);
                return;
            }
            StreamReader sr = File.OpenText(FILE_NAME);
            String input;

            input = sr.ReadToEnd();
            sr.Close();
            originalXML.Text = input;
           
        }


        private void submit_Click(object sender, EventArgs e)
        {
            try
            {
                String temp = originalXML.Text;

                string xpathcommand = xpathinput.Text;

                XmlDocument doc = new XmlDocument();

                doc.LoadXml(temp);

                XmlNode root = doc.DocumentElement;

                XmlNamespaceManager nsmgr = new XmlNamespaceManager(doc.NameTable);
                nsmgr.AddNamespace("Employees", "urn:Employees");

                XmlNodeList node2 = root.SelectNodes(xpathcommand, nsmgr);
                String test = "";
                foreach (XmlNode titleNode in node2)
                {
                    test = test + titleNode.OuterXml + "\n";
                    outputbox.Text = (test);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter a valid query "+ ex);
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            try
            {
                XPathDocument document = new XPathDocument(XMLfile.Text);
                string queryString = comboBox1.SelectedItem.ToString();

                XPathNavigator navigator = document.CreateNavigator();
                XPathNodeIterator nodes2 = navigator.Select(queryString);
                outputbox.Text = String.Empty;
                while (nodes2.MoveNext())
                {
                    outputbox.Text = (outputbox.Text + nodes2.Current.OuterXml);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        static public string FormatXml(String xml)
        {
            var doc = new XmlDocument();
            doc.LoadXml(xml);

            var settings = new XmlWriterSettings
            {
                Indent = true,
                IndentChars = "\t",
                NewLineChars = Environment.NewLine,
                NewLineHandling = NewLineHandling.Replace,
                
            };

            using (var ms = new MemoryStream())
            using (var writer = XmlWriter.Create(ms, settings))
            {
                doc.Save(writer);                               
                return Encoding.UTF8.GetString(ms.ToArray());
            }
        }

        
    }
}


