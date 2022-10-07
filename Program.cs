class HigherLower{
    static Deck deck = new Deck();
    static Dealer dealer = new Dealer();

    static void Main(string[] args){

        int score = 300;
        List<string> cardList = deck.createDeck(deck.cards);
        int previousCard = 7;
        while(score != 0 || cardList.Count != 0){
            int selectedCard = dealer.selectCard();
            Console.WriteLine($"The current card is {previousCard}. Will the next card be HIGHER or LOWER?:");
            string playerAnswer = Console.ReadLine();
            
            cardList.RemoveAt(selectedCard);
        }     

    }

    public bool checkDeckSize(List<string> cardList){

        return true;
    }


}