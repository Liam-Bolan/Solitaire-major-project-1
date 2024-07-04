using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Solitaire_major_project
{
    public partial class SolitaireGame : Form
    {
        List<Card> CardsOnScreen = new List<Card>();
        List<acebox> aceboxes = new List<acebox>();
        public SolitaireGame()
        {
            InitializeComponent();
        }
        

        private void SolitaireGame_Load(object sender, EventArgs e)
        {
            
            deck deck = new deck();
            deck.Shuffle();

            boxdeck boxdeck = new boxdeck();
            
            
            for (int i = 7; i > 0; i--)
            {
         
                Card c = deck.Draw();
                if (i == 7) { c.flip(); }
                c.Location = new Point(975, 300 + 10 * i);
                c.Parent = this;

            }
            for(int i = 6; i > 0; i--)
            {
                Card c = deck.Draw();
                if (i == 6) { c.flip(); }
                c.Location = new Point(825, 300 + 10 * i);
                c.Parent = this;
            }
            for (int i = 5; i > 0; i--)
            {
                Card c = deck.Draw();
                if (i == 5) { c.flip(); }
                c.Location = new Point(675, 300 + 10 * i);
                c.Parent = this;
            }
            for (int i = 4; i > 0; i--)
            {
                Card c = deck.Draw();
                if (i == 4) { c.flip(); }
                c.Location = new Point(525, 300 + 10 * i);
                c.Parent = this;
            }
            for (int i = 3; i > 0; i--)
            {
                Card c = deck.Draw();
                if (i == 3) { c.flip(); }
                c.Location = new Point(375, 300 + 10 * i);
                c.Parent = this;
            }
            for (int i = 2; i > 0; i--)
            {
                Card c = deck.Draw();
                if (i == 2) { c.flip(); }
                c.Location = new Point(225, 300 + 10 * i);
                c.Parent = this;
            }
            for (int i = 1; i > 0; i--)
            {
                Card c = deck.Draw();
                if (i == 1) { c.flip(); }
                c.Location = new Point(75, 300 + 10 * i);
                c.Parent = this;
            }
            
            for(int i = 0; i < 4; i++)
            { 
                acebox a = new acebox();
                
                a.Location = new Point(75+20 * i,50);
                a.Parent = this;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
