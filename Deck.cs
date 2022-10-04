class Deck{
    List<string> cards = new List<string>();
    public List<string> createDeck(List<string> cards){

        for (int i = 1; i <= 13; i++){
            cards.Add(i.ToString());
            cards.Add(i.ToString());
            cards.Add(i.ToString());
            cards.Add(i.ToString());
        }

        return cards;
    }


}