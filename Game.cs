﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGameWF
{
    class Game
    {
        public CardSet Table { get; }
        public List<Player> Players { get; }
        public CardSet Deck { get; }
        public Player ActivePlayer { get; set; }

        public Action<Player> MarkActivePlayer;
        public Action<string> ShowMessage;

        public Game(CardSet table, CardSet deck, params Player[] players)
        {
            Table = table;
            Players = new List<Player>(players);
            Deck = deck;
            ActivePlayer = players[0];
        }

        public void Move(Player mover, Card card)
        {
            if (mover != ActivePlayer) return;

            if (mover.PlayerCards.Cards.IndexOf(card) == -1) return;

            Table.Add(mover.PlayerCards.Pull(card));
            ActivePlayer = NextPlayer(ActivePlayer);
            MarkActivePlayer(ActivePlayer);
            Refresh();
        }
        public void Attack(CardFigure figure , CardSuit suit , Card card)
        {
            //if (card.Figure == )
            //{
            //    Deck.Card = card;
            //    Player.Cards.Cards.Remove(card);
            //}
        }
        public void Refresh()
        {
            foreach (var item in Players)
            {
                item.PlayerCards.Show();
            }
            Table.Show();
        }

        private Player NextPlayer(Player player)
        {
            if (player == Players[Players.Count - 1]) return Players[0];

            return Players[Players.IndexOf(player) + 1];
        }

        private Player PreviousPlayer(Player player)
        {
            if (player == Players[0]) return Players[Players.Count - 1];

            return Players[Players.IndexOf(player) - 1];
        }

        public void Deal()
        {
            Deck.Mix();
            foreach (var item in Players)
            {
                item.PlayerCards.Add(Deck.Deal(3));
            }
            Refresh();
        }
        public void GameOver()
        {
            foreach (var item in Players)
            {
                if (item.PlayerCards.Cards.Count != 0)
                    ShowMessage(item.Name + "loose");
            }
        }

        public void HangUp()
        {
            Table.Cards.Clear();
            Refresh();
        }
    }
}
