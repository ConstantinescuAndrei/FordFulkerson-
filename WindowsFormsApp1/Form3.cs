using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "     În matematică și mai specific în teoria grafurilor, un graf este o structură care corespunde unui grup de obiecte, în care unele \n" +
                " perechi de obiecte sunt într-un anumit sens legate reciproc. Obiectele corespund unor abstracții matematice numite într-un graf noduri/vârfuri \n" +
                "(numite și puncte) și fiecare legătură dintre perechile de obiecte asociate se numește muchie (numită și arc sau linie, prin care este și\n" +
                " reprezentată). De obicei, un graf este reprezentat în formă schematică ca un set/grup de puncte pentru noduri, iar aceste sunt unite două\n" +
                " câte două de linii sau curbe pentru muchii. Grafurile reprezintă unul dintre obiectele de studiu în matematica discretă.\n\n\n" +
                "     Muchiile pot fi orientate/ directe sau neorientate/ nedirecte.De exemplu, dacă nodurile reprezintă persoane la o petrecere și există o \n" +
                "muchie între două astfel de persoane dacă ele-și fac cu mâna - își agită mâinile, atunci acest graf este neorientat/ nedirectat, deoarece \n" +
                "orice persoană A poate să agite mâinile spre o persoană B numai dacă B, de asemenea, face cu mâna spre A. În schimb, dacă orice muchie/ linie\n" +
                " de la o persoană A la o persoană B corespunde admirației față de B a lui A, atunci acest grafic este orientat / directat, deoarece admirația\n" +
                " dintre A și B nu este neapărat reciprocă. Forma anterioară a grafului este denumită graf neorientat/ nedirectat, iar muchiile sunt numite \n" +
                "muchii / linii neorientate / nedirecționate / nedirectate, în timp ce ultimul tip de graf este numit grafic orientat / directat și muchiile \n" +
                "sunt numite muchii orientate/ directate / direcționate.";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "     În matematică și informatică, teoria grafurilor studiază proprietățile grafurilor. Un graf este o mulțime de obiecte (numite noduri)\n" +
                " legate între ele printr-o mulțime de muchii cărora le pot fi atribuite direcții (în acest caz, se spune că graful este orientat). Un graf poate\n" +
                " fi reprezentat geometric ca o mulțime de puncte legate între ele prin linii (de obicei curbe).\n\n\n" +
                "     Dezvoltarea teoriei grafurilor a pornit de la probleme legate de jocuri și amuzamente matematice menite a testa ingeniozitatea. Acestea au atras \n" +
                "atenția unor matematicieni experimentați ca Euler, Hamilton, Cayley, Birkhoff iar cu trecerea anilor teoria grafuriolor a devenit un domeniu bogat\n" +
                " in rezultate și de o surprinzătoare varietate și aplicabilitate.";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "     Algoritmul Ford-Fulkerson este unul din algoritmii cei mai simpli care rezolvă problema “Debitului maxim”. Constă în identificarea succesivă\n" +
                " a unor drumuri de creștere până în momentul în care nu mai există nici un astfel de drum. '\n\n\n" +
                "     După identificarea unui drum de creștere se determină valoarea acestuia, iar aceasta se scade din costurile fiecărui arc(i, j) de pe drumul\n" +
                "respectiv și se adună la costurile arcelor corespunzătoare de forma(j, i).De asemenea, valoarea respectivă se adună la fluxul maxim determinat\n " +
                "până în momentul respectiv.\n\n\n" +
                "     Datorită faptului că un drum de creștere conține arce care au costuri pozitive, valoarea sa va fi întotdeauna un număr pozitiv. Ca urmare, \n" +
                "pentru fiecare drum de creștere determinat, valoarea fluxului va crește cu cel puțin o unitate.Datorită faptului că avem capacități finite,\n" +
                " fluxul maxim este un număr finit. Din aceste motive suntem siguri că, mai devreme sau mai târziu, algoritmul se va încheia.";
        }

    }
}
