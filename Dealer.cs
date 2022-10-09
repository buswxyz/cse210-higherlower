class Dealer{
   Random rnd = new Random();
   int cardCount = 51;
   public int selectCard(int cardCount){

        int card = rnd.Next(0, cardCount);
        cardCount = cardCount - 1;
        
        return card;
   }
}