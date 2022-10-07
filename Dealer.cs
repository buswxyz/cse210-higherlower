class Dealer{
   Random rnd = new Random();

   public int selectCard(){

        int x = 51;
        int card = rnd.Next(0, x);
        x = x - 1;
        
        return card;
   }
}