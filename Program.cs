class HigherLower{
    static Deck deck = new Deck();
    static Dealer dealer = new Dealer();

    static void Main(string[] args){

        int score = 300;
        List<string> cardList = deck.createDeck(deck.cards);
        int previousCard = 7;
        while(score != 0 && cardList.Count != 0){
            int selectedCard = dealer.selectCard();
            Console.WriteLine($"The current card is {previousCard}. Will the next card be HIGHER or LOWER?:");
            string? playerAnswer = Console.ReadLine();
            if (playerAnswer == "HIGHER"){
                if (previousCard >= selectedCard){
                    score = score + 100;
                    Console.WriteLine($"The card you drew was {selectedCard} which is higher than {previousCard} meaning you get 100 points, setting your total to {score}!");
                } 
                else{
                    score = score - 75;
                    Console.WriteLine($"The card you drew was {selectedCard} which is lower than {previousCard} meaning you lose 75 points, setting your total to {score}!");
                }
            }
            if (playerAnswer == "LOWER"){
                if (previousCard <= selectedCard){
                    score = score + 100;
                    Console.WriteLine($"The card you drew was {selectedCard} which is lower than {previousCard} meaning you get 100 points, setting your total to {score}!");
                } 
                else{
                    score = score - 75;
                    Console.WriteLine($"The card you drew was {selectedCard} which is higher than {previousCard} meaning you lose 75 points, setting your total to {score}!");
                }
            }
            else{
                Console.WriteLine("That was not a valid answer please either write HIGHER or LOWER");
            }
            cardList.RemoveAt(selectedCard);
               
        }

        if(score <= 0){
            Console.WriteLine("Your score has reached 0, the game has now ended.");
        }
        
        if(cardList.Count == 0){
            Console.WriteLine($"The deck is now out of cards, your final score is {score}.");
        }
    }

}