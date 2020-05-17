using CardGameWF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectCardHip
{
    public partial class Form1 : Form
    {
        Card activeCard;
        Game game;
        Player mover;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            game = new Game(new GraphicCardSet(pnlTable), new GraphicCardSet(pnlDeck, 36),
                          new Player("Bob", new GraphicCardSet(pnlPlayer1)), new Player("Tom", new GraphicCardSet(pnlPlayer2)));

            foreach (var card in game.Deck.Cards)
            {
                PictureBox cardPictureBox = ((GraphicCard)card).Pb;
                cardPictureBox.DoubleClick += CardPictureBox_DoubleClick;
                cardPictureBox.Click += CardPictureBox_Click;
            }

            game.ShowMessage = ShowMessage;
            game.MarkActivePlayer = MarkPlayer;

            game.Deal();
        }


        private void CardPictureBox_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            SetActiveCard(pictureBox);
        }

        private void CardPictureBox_DoubleClick(object sender, EventArgs e)
        {
            if (activeCard != null)
            {
                game.Move(mover, activeCard);
            }
        }

        private void ShowMessage(string message)
        {
            lblMessage.Text = message;
        }

        private void MarkPlayer(Player activePlayer)
        {
            foreach (var player in game.Players)
            {
                if (player == activePlayer)
                    foreach (var card in player.PlayerCards.Cards)
                    {
                        GraphicCard graphicCard = (GraphicCard)card;
                        graphicCard.Opened = true;
                    }
                else
                    foreach (var card in player.PlayerCards.Cards)
                    {
                        GraphicCard graphicCard = (GraphicCard)card;
                        graphicCard.Opened = false;
                    }

            }
            game.Refresh();

        }



        private void SetActiveCard(PictureBox pictureBox)
        {
            foreach (var player in game.Players)
            {
                foreach (var card in player.PlayerCards.Cards)
                {
                    if (((GraphicCard)card).Pb == pictureBox)
                    {
                        if (card == activeCard)
                        {
                            activeCard = null;
                            pictureBox.Top -= 10;
                            mover = null;
                        }
                        else
                        {
                            activeCard = card;
                            pictureBox.Top += 10;
                            mover = player;
                        }


                        return;
                    }
                }
            }
        }

        private void pnlTable_Click(object sender, EventArgs e)
        {
            if (activeCard != null && mover != null)
                game.Move(mover, activeCard);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pnlTable_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlPlayer1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlDeck_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlDeck_Click(object sender, EventArgs e)
        {
            //if ( )
            //{

            //}
        }
    }
}
