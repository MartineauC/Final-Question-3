public static void TestCardSorting()
{
    List<Card> cards = new List<Card>();
    cards.Add(new Card { Rank = "Ace", Suit = "Spades", Value = 11 });
    cards.Add(new Card { Rank = "7", Suit = "Hearts", Value = 7 });
    cards.Add(new Card { Rank = "King", Suit = "Diamonds", Value = 10 });
    cards.Add(new Card { Rank = "2", Suit = "Clubs", Value = 2 });
    cards.Add(new Card { Rank = "10", Suit = "Hearts", Value = 10 });
    cards.Sort();
    foreach (Card card in cards)
    {
        Console.WriteLine($"Rank: {card.Rank}, Suit: {card.Suit}, Value: {card.Value}");
    }
}