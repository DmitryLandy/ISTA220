/*
 * Name: Dmitry Landy
 * File: lab10-cards.cs
 * Date: 2/11/2021
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Cards
{

    enum Suit { Clubs, Diamonds, Hearts, Spades }
    enum Value { Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Queen, King, Ace }
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public const int NumHands = 4;
        private Pack pack = null;
        private Hand[] hands = new Hand[NumHands];

        public MainPage()
        {
            this.InitializeComponent();
        }

        private void dealClick(object sender, RoutedEventArgs e)
        {
            try
            {
                pack = new Pack();

                for (int handNum = 0; handNum < NumHands; handNum++)
                {
                    hands[handNum] = new Hand();

                    for (int numCards = 0; numCards < Hand.HandSize; numCards++)
                    {
                        PlayingCard cardDealt = pack.DealCardFromPack();
                        hands[handNum].AddCardToHand(cardDealt);
                    }
                }

                north.Text = hands[0].ToString();
                south.Text = hands[1].ToString();
                east.Text = hands[2].ToString();
                west.Text = hands[3].ToString();

            }
            catch (Exception ex)
            {
                MessageDialog msg = new MessageDialog(ex.Message, "Error");
                msg.ShowAsync();
            }
        }
    }


    class Hand
    {
        public const int HandSize = 13; //symbolic cosntant
        private PlayingCard[] cards = new PlayingCard[HandSize]; //array for hand
        private int playingCardCount = 0;

        public void AddCardToHand(PlayingCard cardDealt)
        {
            if (playingCardCount >= HandSize)
            {
                throw new ArgumentException("Too many cards");
            }
            cards[playingCardCount] = cardDealt;
            playingCardCount++;
        }

        public override string ToString()
        {
            string result = "";
            foreach (PlayingCard card in cards)
            {
                result += $"{card.ToString()}\n";
            }

            return result;
        }
    }


    class PlayingCard
    {
        private readonly Suit suit; //enum
        private readonly Value value; //enum

        //constructor
        public PlayingCard(Suit s, Value v)
        {
            suit = s;
            value = v;
        }

        public override string ToString()
        {
            string result = $"{value} of {suit}";
            return result;
        }

        public Suit CardSuit()
        {
            return suit;
        }

        public Value CardValue()
        {
            return value;
        }
    }

    class Pack
    {
        public const int NumSuits = 4; //symbolic constant
        public const int CardsPerSuit = 13; //symbolic constant
        private PlayingCard[,] cardPack; //multi-dimensional array
        private Random randomCardSelector = new Random();

        public Pack()
        {
            cardPack = new PlayingCard[NumSuits, CardsPerSuit];
            //suit.clubs = 0, suits.spades = 3
            for (Suit suit = Suit.Clubs; suit <= Suit.Spades; suit++)
            {
                for (Value value = Value.Two; value <= Value.Ace; value++)
                {
                    //finding the location in the array and assigns it a playing card object
                    cardPack[(int)suit, (int)value] = new PlayingCard(suit, value);
                }
            }
        }

        public PlayingCard DealCardFromPack()
        {
            Suit suit = (Suit)randomCardSelector.Next(NumSuits);
            while (IsSuitEmpty(suit))
            {
                suit = (Suit)randomCardSelector.Next(NumSuits);
            }

            Value value = (Value)randomCardSelector.Next(CardsPerSuit);

            //checks if card has been dealt, if it has generates another card.
            while (IsCardAlreadyDealt(suit, value))
            {
                value = (Value)randomCardSelector.Next(CardsPerSuit);
            }

            //creates a card and updates the cardpack array with a null value
            PlayingCard card = cardPack[(int)suit, (int)value];
            cardPack[(int)suit, (int)value] = null;

            return card;
        }

        private bool IsSuitEmpty(Suit suit)
        {
            bool result = true;

            for (Value value = Value.Two; value <= Value.Ace; value++)
            {
                if (!IsCardAlreadyDealt(suit, value))
                {
                    result = false;
                    break;
                }
            }

            return result;
        }

        private bool IsCardAlreadyDealt(Suit suit, Value value)
        {
            return (cardPack[(int)suit, (int)value] == null);
        }
    }
}
