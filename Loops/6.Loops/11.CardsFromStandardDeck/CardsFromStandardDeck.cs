/*Write a program that prints all possible cards from a standard deck of 52 cards (without jokers). 
 The cards should be printed with their English names. Use nested for loops and switch-case.*/
using System;

class CardsFromStandardDeck
{
    static void Main()
    {
        char[] paintOfCardsSymbols = new char[4];//Paints with symbols
        paintOfCardsSymbols[0] = (char)3;//Hearts
        paintOfCardsSymbols[1] = (char)4;//Diamonds
        paintOfCardsSymbols[2] = (char)5;//Clubs
        paintOfCardsSymbols[3] = (char)6;//Spades;

        string[] paintOfCards = new string[4];//Paints with words
        paintOfCards[0] = "hearts";
        paintOfCards[1] = "diamonds";
        paintOfCards[2] = "clubs";
        paintOfCards[3] = "spades";

        int counter = 1;

        string[] typeOfCards = new string[13];//Ths massive will contain the type of cards(2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K, A)
        typeOfCards[0] = "2";
        typeOfCards[1] = "3";
        typeOfCards[2] = "4";
        typeOfCards[3] = "5";
        typeOfCards[4] = "6";
        typeOfCards[5] = "7";
        typeOfCards[6] = "8";
        typeOfCards[7] = "9";
        typeOfCards[8] = "10";
        typeOfCards[9] = "Jack";
        typeOfCards[10] = "Queen";
        typeOfCards[11] = "King";
        typeOfCards[12] = "Ace";

        for (int i = 0; i < 13; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                Console.Write("{0} -> ", counter);
                Console.Write(typeOfCards[i] + " " + paintOfCardsSymbols[j] + " ");
                counter++;//This variable will be increasing to show the each number of 52 cards
                Console.Write("(");
                Console.Write(typeOfCards[i] + " of " + paintOfCards[j]);
                Console.WriteLine(")");
            }
        }
    }
}

