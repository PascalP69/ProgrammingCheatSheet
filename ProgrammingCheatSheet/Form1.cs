using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgrammingCheatSheet
{
    public partial class Form1 : Form
    {
        // List deklarieren
        List<int> list = new List<int>();


        // array deklarieren und initialisieren mit den zahlen 1,2,3,4 (index 0,1,2,3)
        int[] numberArray = {1,2,3,4};

        public Form1()
        {
            InitializeComponent();
        }


        // AUFRUFE DER METHODEN

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text;

            // List mit daten füllen; deklariert ist die list als int, also hier einfach zahlen die hinzugefügt werden
            for (int i = 0; i < 10; i++)
            {
                list.Add(i);
            }

        }

        private void btn_SchreibeLinie_Click(object sender, EventArgs e)
        {
            // Einfaches ausführen der Methode
            SchreibeLinie();
        }

        private void btn_SchreibeLinieLaenge_Click(object sender, EventArgs e)
        {
            // Ausführen der MEthode mit übergabe eines Parameters
            // Der Parameter kann auch eine variable oder rechnung etc. sein, solange der datentyp passt (hier int)
            SchreibeLinieLaenge(3);
        }

        private void btn_RechneQuadrat_Click(object sender, EventArgs e)
        {
            // Return wert der in der Methode in das return geschrieben wird ist das, was durch die übergabe ausgerechnet wird
            Console.WriteLine(RechneQuadrat(10));
        }

        private void btn_ZeichneRaute_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = ZeichneRaute(10);
        }

        // DEKLARATION DER METHODEN
        // ----------------------------------
        // OHNE RÜCKGABE, OHNE PARAMETER
        void SchreibeLinie()
        {
            Console.WriteLine("------------------------");
        }

        // OHNE RÜCKGABE, MIT PARAMETER (Mehrere parameter möglich, durch komma getrennt)
        void SchreibeLinieLaenge(int pLaenge)
        {

            for (int j = 0; j < pLaenge; j++)
            {
                for (int i = 0; i < pLaenge; i++)
                {
                    Console.Write("#");
                }
            }
        }

        // Mit Rückgabe, Mit Parameter - parameter wird übergeben und kann verarbeitet werden
        static double RechneQuadrat(double pZahl)
        {
            double result = pZahl * pZahl;
            return result;
        }

        // MIT RÜCKGABE, MIT PARAMETER - als string deklariert, datentyp kann beliebig gesetzt werden und muss für den return wert passen
        static string ZeichneRaute(int pLaenge)
        {
            string myText = "";

            for (int i = 0; i < pLaenge; i++)
            {
                myText = myText + "#";
            }
            return myText;

        }
    }
}
