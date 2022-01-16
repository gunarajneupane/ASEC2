using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PLEApp
{
    public partial class Form1 : Form
    {
        Bitmap drawBoard;                                         //output bitmap image
        Bitmap cursorBoard;                                        //cursor pointer bitmap image
        Canvas displayCanvas;                                   //canvas for drawing on output bitmap image
        Parse parser;                                           //Parses the command line
        StringBuilder errorList;                                //Stores the list of errors while parsing
        public Form1()
        {
            InitializeComponent();
            drawBoard = new Bitmap(740, 400);
            cursorBoard = new Bitmap(740, 400);
            //initializes the canvas objects
            displayCanvas = new Canvas(Graphics.FromImage(drawBoard));
            //transparentCanvas = new Canvas(Graphics.FromImage(cursorBoard));

            errorList = new StringBuilder();
            drawCursor();
        }

        //draws the cursor pointer on the transparentcanvas
        public void drawCursor()
        {
            Graphics g = Graphics.FromImage(cursorBoard);
            g.Clear(Color.Transparent);
            g.FillEllipse(new SolidBrush(Color.BlueViolet), displayCanvas.x-5, displayCanvas.y-5, 10, 10);
        }

        //when enter is pressed on single command
        private void singleCommand_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                String cmd = singleCommand.Text.Trim().ToLower();
                if (cmd.Equals("run"))
                    run(true);
                else
                    run(false);
            }

        }

        //when run button is clicked
        private void runBtn_Click(object sender, EventArgs e)
        {
            String cmd = singleCommand.Text.Trim().ToLower();
            errorList = new StringBuilder();
            if (cmd.Equals("run"))
                run(true);
            else
                run(false);
        }


        public void run(bool cmdRun)
        {
            errorBox.Text = "";
            errorList = new StringBuilder();
            parser = new Parse();
            parser.parseCommand(singleCommand,displayCanvas,errorList);
            if (!multiCommand.Text.Equals("") && cmdRun)                   //if multi command line has text
            {
                parser.parseCommand(multiCommand, displayCanvas, errorList);
                
            }
            drawCursor();
            displayError();
            Refresh();
        }

        //refreshes the form and output screen
        public void refreshForm()
        {
            displayError();
            drawCursor();
        }

        //display errors caught while parsing
        public void displayError()
        {
            if(!errorList.ToString().Equals(""))
            {
                errorBox.Text = errorList.ToString();
            }
            errorList.Clear();
        }

        //paint event of the output picture box
        private void outputDisplay_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawImageUnscaled(drawBoard, 0,0);
            g.DrawImageUnscaled(cursorBoard, 0,0);
        }


        /// <summary>
        /// This private method saves a program written in the Program Box to D: drive
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">The event that is triggered when the menu item is clicked </param>
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                myStream = saveFileDialog1.OpenFile();
                

                using (StreamWriter writer = new StreamWriter(myStream))
                {
                    writer.Write(multiCommand.Text);
                }
                myStream.Close();
            }

        }

        /// <summary>
        /// This private method opens a File Dialog box and prompts user to choose a program text file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">The event that is triggered when the menu item is clicked</param>
        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            String line = "";
            openFileDialog.Filter = "Text files (.txt)| *.txt";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFileDialog.FileName);

                while (line != null)
                {
                    line = sr.ReadLine();
                    if (line == null) break;
                    multiCommand.Text += line;

                    multiCommand.AppendText(Environment.NewLine);
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new form2().show;
        }

        private void syntaxbtn_Click(object sender, EventArgs e)
        {
            String cmd = singleCommand.Text.Trim().ToLower();
            errorList = new StringBuilder();
            bool cmdRun = cmd.Equals("run");
            errorBox.Text = "";
            errorList = new StringBuilder();
            parser = new Parse();
            parser.parseCommand(singleCommand, displayCanvas, errorList);
            if (!multiCommand.Text.Equals("") && cmdRun)                   //if multi command line has text
            {
                parser.parseCommand(multiCommand, new Canvas(), errorList);

            }
            drawCursor();
            displayError();
            Refresh();
        }
    }
}
