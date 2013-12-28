using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace molarmasscalc
{
    public partial class Form1 : Form
    {

        List<string> elementsnamefile = new List<string>();
        List<double> elementsmassfile = new List<double>();

        public Form1()
        {
            InitializeComponent();
            realtimecheckbox.Checked = true;
        }

        private void calculatebutton_Click(object sender, EventArgs e)
        {
            basic();
            formulabox.Focus();
        }

        private void basic()
        {
            String formula = formulabox.Text;
            char[] formulachars = formula.ToCharArray();
            int formulacharslength = formulachars.Length;
            int numofelements = 0; //how many elements the user entered
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            for (int x = 0; x < formulacharslength; x++) //goes through each character
            {
                String currentelement = "";
                if (char.IsUpper(formulachars[x]))//if the character is a capital letter
                {
                    currentelement = formulachars[x] + "";
                    try
                    {
                        if (char.IsLower(formulachars[x + 1]))//if the one after it is a lower case letter
                        {
                            currentelement += formulachars[x + 1];
                            x++;//so that it doesn't check the lower case character again
                        }
                    }
                    catch (Exception) { }
                    numofelements++;//increases how many elements are present. this can be used to make the string array of all of the elements. there is probably an easier way to do this but w/e
                    //add an if integer statement here or maybe inside the try/catch ~~~ nvm already put it in the next void
                }
            }
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            // MessageBox.Show(numofelements + "");
            string[] elementlist = new string[numofelements];//holds each element
            int[] elementsubscript = new int[numofelements];//holds the subscript~~~~~
            int v = 0;
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            for (int x = 0; x < formulacharslength; x++) //goes through each character
            {
                String currentelement = "";
                if (char.IsUpper(formulachars[x]))//if the character is a capital letter
                {
                    currentelement = formulachars[x] + "";
                    try
                    {
                        if (char.IsLower(formulachars[x + 1]))//if the one after it is a lower case letter
                        {
                            currentelement += formulachars[x + 1];
                            x++;//so that it doesn't check the lower case character again
                        }
                    }
                    catch (Exception) { }
                    try
                    {
                        if (char.IsNumber(formulachars[x + 1]))//if there is a number after it
                        {
                            elementsubscript[v] = Convert.ToInt32(new string(formulachars[x + 1], 1));
                            x++;//so that it doesnt check the character (number) again
                            ////<multi-digit subscript support>
                            try//NEEDED FOR THIS OR ELSE THE PROGRAM WILL PASS THROUGH THE REST OF THE CODE WITHOUT CARE
                            {
                                while (char.IsNumber(formulachars[x + 1]))//while the next char is still a number
                                {
                                    elementsubscript[v] = (elementsubscript[v] * 10) + Convert.ToInt32(new string(formulachars[x + 1], 1));//multiply current number by ten and add the new one. this is to achieve an easier way of putting the DIGITS next to each other instead of using chars
                                    x++;//so that it doesnt check the character (number) again
                                }
                            }
                            catch (Exception) { }
                            /////</multi-digit subscript support>
                        }
                        else
                        {
                            elementsubscript[v] = 1;
                        }
                    }
                    catch (Exception)
                    {
                        try
                        {
                            elementsubscript[v] = 1;
                        }
                        catch (Exception) { }
                    }
                }
                try
                {
                    elementlist[v] = currentelement;
                    // MessageBox.Show(elementlist[v]);
                    // MessageBox.Show(elementsubscript[v] + "");
                }
                catch (Exception)
                {
                    // MessageBox.Show("An error has occured in the processing of the information given. Please try again.", "ERR: elementlist[v] || elementsubscript[v]");
                }
                v++;
            }
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            double molarmassprog = 0;
            for (int x = 0; x < numofelements; x++)
            {
                for (int gh = 0; gh < 112; gh++)
                {
                    if (elementlist[x].Equals(elementsnamefile[gh]))
                    {
                        molarmassprog += (elementsmassfile[gh] * elementsubscript[x]);
                    }
                }
            }
            finalmassbox.TabStop = true;
            finalmassbox.Text = molarmassprog + "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formulabox.Text = "";
            finalmassbox.Text = "";
            finalmassbox.TabStop = false;
            formulabox.Focus();
        }

        private void formulabox_TextChanged(object sender, EventArgs e)
        {
            if (realtimecheckbox.Checked)
            {
                basic();
            }
        }

        private void closebutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void realtimecheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (realtimecheckbox.Checked)
            {
                basic();
            }
        }

        private void instructionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void creditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Assembly assembly = Assembly.GetExecutingAssembly();
            StreamReader sr = new StreamReader(assembly.GetManifestResourceStream("molarmasscalc.listofelementnames.txt"));
            string line;
            if (sr.Peek() != -1)
            {
                while ((line = sr.ReadLine()) != null)
                {
                    elementsnamefile.Add(line);
                }
            }
            StreamReader sr1 = new StreamReader(assembly.GetManifestResourceStream("molarmasscalc.listofelementmasses.txt"));
            if (sr1.Peek() != -1)
            {
                while ((line = sr1.ReadLine()) != null)
                {
                    elementsmassfile.Add(Convert.ToDouble(line));
                }
            }

            sr.Close();
            sr1.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Grams2Moles g2m = new Grams2Moles(formulabox.Text, realtimecheckbox.Checked);
            g2m.Show();
            formulabox.Select();
        }

        private void gramsMolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Grams2Moles g2m = new Grams2Moles(formulabox.Text, realtimecheckbox.Checked);
            g2m.Show();
            formulabox.Select();
        }

        private void calculateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            basic();
            formulabox.Select();
        }

        private void copyToClipboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(finalmassbox.Text);
        }
    }
}