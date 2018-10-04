using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Xml;


namespace VWorks_Plate_Format
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bnTest_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog
            {
                FileName = "format",
                Filter = "XML|*.xml",
                InitialDirectory = @"C:\VWorks Workspace\VWorks\Hit Picking\Format Files"
            };
            string headerLines = @"<?xml version='1.0' encoding='ASCII' ?>
                <Velocity11 file='V11PipettingFormatFile' md5sum='a34f0169acdca2a5fb0e67c75a2c7214' version='v1.0.0' >
	            <DeviceType Type='Bravo' />
	            <CherryFormat >
		        <SourcePlate Labware='96 Matrix open reservoir movable' />
		        <DestinationPlate Labware='96 Eppendorf Twin.tec PCR' />
		        <Operation Type='CherryPicking' >
			    <SourcePlate NumberOfWell='96' />
			    <DestinationPlate NumberOfWell='96' />
			    <UnselectedWells >";

            string fullPlate = @"<Well Column='2' Row='1' />
				<Well Column='2' Row='2' />
				<Well Column='2' Row='3' />
				<Well Column='2' Row='4' />
				<Well Column='2' Row='5' />
				<Well Column='2' Row='6' />
				<Well Column='2' Row='7' />
				<Well Column='2' Row='8' />
				<Well Column='3' Row='1' />
				<Well Column='3' Row='2' />
				<Well Column='3' Row='3' />
				<Well Column='3' Row='4' />
				<Well Column='3' Row='5' />
				<Well Column='3' Row='6' />
				<Well Column='3' Row='7' />
				<Well Column='3' Row='8' />
				<Well Column='4' Row='1' />
				<Well Column='4' Row='2' />
				<Well Column='4' Row='3' />
				<Well Column='4' Row='4' />
				<Well Column='4' Row='5' />
				<Well Column='4' Row='6' />
				<Well Column='4' Row='7' />
				<Well Column='4' Row='8' />
				<Well Column='5' Row='1' />
				<Well Column='5' Row='2' />
				<Well Column='5' Row='3' />
				<Well Column='5' Row='4' />
				<Well Column='5' Row='5' />
				<Well Column='5' Row='6' />
				<Well Column='5' Row='7' />
				<Well Column='5' Row='8' />
				<Well Column='6' Row='1' />
				<Well Column='6' Row='2' />
				<Well Column='6' Row='3' />
				<Well Column='6' Row='4' />
				<Well Column='6' Row='5' />
				<Well Column='6' Row='6' />
				<Well Column='6' Row='7' />
				<Well Column='6' Row='8' />
				<Well Column='7' Row='1' />
				<Well Column='7' Row='2' />
				<Well Column='7' Row='3' />
				<Well Column='7' Row='4' />
				<Well Column='7' Row='5' />
				<Well Column='7' Row='6' />
				<Well Column='7' Row='7' />
				<Well Column='7' Row='8' />
				<Well Column='8' Row='1' />
				<Well Column='8' Row='2' />
				<Well Column='8' Row='3' />
				<Well Column='8' Row='4' />
				<Well Column='8' Row='5' />
				<Well Column='8' Row='6' />
				<Well Column='8' Row='7' />
				<Well Column='8' Row='8' />
				<Well Column='9' Row='1' />
				<Well Column='9' Row='2' />
				<Well Column='9' Row='3' />
				<Well Column='9' Row='4' />
				<Well Column='9' Row='5' />
				<Well Column='9' Row='6' />
				<Well Column='9' Row='7' />
				<Well Column='9' Row='8' />
				<Well Column='10' Row='1' />
				<Well Column='10' Row='2' />
				<Well Column='10' Row='3' />
				<Well Column='10' Row='4' />
				<Well Column='10' Row='5' />
				<Well Column='10' Row='6' />
				<Well Column='10' Row='7' />
				<Well Column='10' Row='8' />
				<Well Column='11' Row='1' />
				<Well Column='11' Row='2' />
				<Well Column='11' Row='3' />
				<Well Column='11' Row='4' />
				<Well Column='11' Row='5' />
				<Well Column='11' Row='6' />
				<Well Column='11' Row='7' />
				<Well Column='11' Row='8' />
				<Well Column='12' Row='1' />
				<Well Column='12' Row='2' />
				<Well Column='12' Row='3' />
				<Well Column='12' Row='4' />
				<Well Column='12' Row='5' />
				<Well Column='12' Row='6' />
				<Well Column='12' Row='7' />
				<Well Column='12' Row = '8' />";

            string footerLines=@"</UnselectedWells>
			    <Dispense Type='ColumnWise' />
			    <Replication Number='1' />
			    <DilutionSeries Operation='No' >
				<Transfer Constant='No' Volume='2.5' />
			    </DilutionSeries>
		        </Operation>
		        <Format Description='' />
	            </CherryFormat>
                </Velocity11>";

                  string sFile = "";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                sFile = saveFileDialog1.FileName;
                Debug.Print(sFile);
                File.WriteAllText(sFile, headerLines+ fullPlate+ footerLines);
            }
        }

        private void cmdSelectFormatFile_Click(object sender, EventArgs e)
        {
            string fileName = null;

            using (OpenFileDialog openFileDialog1 = new OpenFileDialog())
            {
                openFileDialog1.InitialDirectory = "C:\\VWorks Workspace\\VWorks\\Hit Picking\\Format Files";
                openFileDialog1.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*";
                openFileDialog1.FilterIndex = 2;
                openFileDialog1.RestoreDirectory = true;

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    fileName = openFileDialog1.FileName;
                }
            }

            if (fileName != null)
            {
                //Do something with the file, for example read text from it
                /*string text = File.ReadAllText(fileName);
                Debug.Write(text);*/

                Debug.Print(fileName);
                XmlReaderSettings settings = new XmlReaderSettings();
                settings.DtdProcessing = DtdProcessing.Parse;
                XmlReader reader = XmlReader.Create(fileName, settings);

                reader.MoveToContent();
                // Parse the file and display each of the nodes.
                while (reader.Read())
                {
                    switch (reader.NodeType)
                    {
                        case XmlNodeType.Element:
                            Debug.Print("<{0}>", reader.Name);
                            break;
                        case XmlNodeType.Text:
                            Debug.Print(reader.Value);
                            break;
                        case XmlNodeType.CDATA:
                            Debug.Print("<![CDATA[{0}]]>", reader.Value);
                            break;
                        case XmlNodeType.ProcessingInstruction:
                            Debug.Print("<?{0} {1}?>", reader.Name, reader.Value);
                            break;
                        case XmlNodeType.Comment:
                            Debug.Print("<!--{0}-->", reader.Value);
                            break;
                        case XmlNodeType.XmlDeclaration:
                            Debug.Print("<?xml version='1.0'?>");
                            break;
                        case XmlNodeType.Document:
                            break;
                        case XmlNodeType.DocumentType:
                            Debug.Print("<!DOCTYPE {0} [{1}]", reader.Name, reader.Value);
                            break;
                        case XmlNodeType.EntityReference:
                            Debug.Print(reader.Name);
                            break;
                        case XmlNodeType.EndElement:
                            Debug.Print("</{0}>", reader.Name);
                            break;
                    }
                }

            }
        }

        private void cmdSelectSampleFile_Click(object sender, EventArgs e)
        {
            string fileName = null;

            using (OpenFileDialog openFileDialog1 = new OpenFileDialog())
            {
                openFileDialog1.InitialDirectory = "C:\\Worklists";
                openFileDialog1.Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*";
                openFileDialog1.FilterIndex = 2;
                openFileDialog1.RestoreDirectory = true;

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    fileName = openFileDialog1.FileName;
                }
            }

            if (fileName != null)
            {
                //Do something with the file, for example read text from it
                string sample = "";
                string[] text = File.ReadAllLines(fileName);
                foreach(string line in text)
                {
                    string[] words = line.Split(',');
                    //Debug.Print(words[1]);
                    char row = Convert.ToChar(words[1].Substring(0, 1).ToUpper());
                    int iRow = Convert.ToUInt16(row)- Convert.ToUInt16('A')+1;
                    //Debug.Print(row.ToString());
                    //Debug.Print(iRow.ToString());
                    //Debug.Print(words[1].Substring(0, 1))
                    sample= "<Well Column='" + words[1].Substring(1)+ "' Row='" + iRow.ToString()+ "' />";
                    Debug.WriteLine(sample);
                    //Debug.Print(iRow.ToString());
                }
                //Debug.Write(text);
            }
        }
    }
}
