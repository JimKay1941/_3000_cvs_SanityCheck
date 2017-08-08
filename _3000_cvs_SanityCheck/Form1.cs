using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3000_cvs_SanityCheck
{
    public partial class Form1 : Form
    {
        private readonly OpenFileDialog _chooseInputFileDialog = new OpenFileDialog();
        private FileStream _reading;
        private StreamReader _inputLine;
        private string InputLine;

        public Form1()
        {
            InitializeComponent();
            _chooseInputFileDialog.FileOk += OnInputFileDialogOk;
        }

        private void OnInputFileDialogOk(object sender, CancelEventArgs e)
        {
            textInputFile.Text = _chooseInputFileDialog.FileName;
            if (textInputFile.Text == "")
            {
                textStatus.Text = "No input file specified";
                return;
            }

           
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            _inputLine?.Close();
            Close();
        }

        private void btnChooseInput_Click(object sender, EventArgs e)
        {
            _chooseInputFileDialog.ShowDialog();
        }

        private void buttonProcess_Click(object sender, EventArgs e)
        {
            _reading?.Close();

            _reading = new FileStream(textInputFile.Text, FileMode.Open, FileAccess.Read, FileShare.None);
            _inputLine = new StreamReader(_reading);

            textStatus.Text = "";

            if (_inputLine == null)
            {
                if (textInputFile.Text == "")
                {
                    textStatus.Text = "No input file specified";
                    return;
                }
                
                _reading = new FileStream(textInputFile.Text, FileMode.Open, FileAccess.Read, FileShare.None);
                _inputLine = new StreamReader(_reading);
            }

            InputLine = _inputLine.ReadLine();
            if (InputLine.Substring(0, 5) == "FEseq")
            {
                InputLine = _inputLine.ReadLine();
            }

            if (checkRestart.Checked)
            {
                DoRestart();
            }

            while (_inputLine != null)
            {
                Queue<string> oneCharacter = new Queue<string>();

                while (InputLine.Substring(0, 4) == textCharacterNo.Text)
                {
                    if (InputLine.Substring(0, 4) == "1364")
                    {
                        ;
                    }
                    oneCharacter.Enqueue(InputLine);
                    InputLine = _inputLine.ReadLine();
                }

                if (textCharacterNo.Text == "3000")
                {
                    textStatus.Text = "Processing complete!";
                    return;
                }
                int current;
                var currentResult = int.TryParse(textCharacterNo.Text, out current);

                if (!currentResult)
                {
                    textStatus.Text = "Something is wrong with item: " + textCharacterNo.Text;
                    return;
                }

                int next;
                var nextResult = int.TryParse(InputLine.Substring(0, 4), out next);

                if (!nextResult)
                {
                    textStatus.Text = "Something is wrong with the item AFTER: " + textCharacterNo.Text;
                    return;
                }

                if (next != current + 1)
                {
                    textStatus.Text = "Item AFTER: " + textCharacterNo.Text + " is out of sequence";
                    return;
                }

                var item = "00";

                var good = false;
                while (oneCharacter.Count > 0)
                {
                    good = false;
                    var oneEntry = oneCharacter.Dequeue();
                    if (item == "00" && oneEntry.Substring(4, 2) == "01")
                    {
                        item = "01";
                        good = true;
                        continue;
                    }
                    if (item == "01" && oneEntry.Substring(4, 2) == "02")
                    {
                        item = "02";
                        good = true;
                        continue;
                    }
                    if (item == "01" && oneEntry.Substring(4, 2) == "50")
                    {
                        item = "50";
                        good = true;
                        continue;
                    }
                    if (item == "02" && oneEntry.Substring(4, 2) == "03")
                    {
                        item = "03";
                        good = true;
                        continue;
                    }
                    if (item == "02" && oneEntry.Substring(4, 2) == "50")
                    {
                        item = "50";
                        good = true;
                        continue;
                    }
                    if (item == "03" && oneEntry.Substring(4, 2) == "04")
                    {
                        item = "04";
                        good = true;
                        continue;
                    }
                    if (item == "03" && oneEntry.Substring(4, 2) == "50")
                    {
                        item = "50";
                        good = true;
                        continue;
                    }
                    if (item == "04" && oneEntry.Substring(4, 2) == "05")
                    {
                        item = "05";
                        good = true;
                        continue;
                    }
                    if (item == "04" && oneEntry.Substring(4, 2) == "50")
                    {
                        item = "50";
                        good = true;
                        continue;
                    }
                    if (item == "05" && oneEntry.Substring(4, 2) == "50")
                    {
                        item = "50";
                        good = true;
                        continue;
                    }
                    if (item == "50" && oneEntry.Substring(4, 2) == "51")
                    {
                        item = "51";
                        good = true;
                        continue;
                    }
                    if (item == "51" && oneEntry.Substring(4, 2) == "52")
                    {
                        item = "52";
                        good = true;
                        continue;
                    }
                    if (item == "52" && oneEntry.Substring(4, 2) == "53")
                    {
                        item = "53";
                        good = true;
                        continue;
                    }
                    if (item == "53" && oneEntry.Substring(4, 2) == "54")
                    {
                        item = "54";
                        good = true;
                        continue;
                    }
                    if (item == "55" && oneEntry.Substring(4, 2) == "56")
                    {
                        item = "56";
                        good = true;
                    }

                    if (!good)
                    {
                        textStatus.Text = "Something is wrong with character: " + textCharacterNo.Text;
                        return;
                    }
                }

                textCharacterNo.Text = InputLine.Substring(0, 4);
            }

        }

        void DoRestart()
        {
            while (_inputLine != null)
            {
                if (InputLine.Substring(0, 4) == textCharacterNo.Text) return;

                InputLine = _inputLine.ReadLine();
            }
        }
    }
}
