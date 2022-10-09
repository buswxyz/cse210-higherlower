class Deck{
    public List<string> cards = new List<string>();
    public List<string> createDeck(List<string> cards){

        for (int i = 1; i <= 13;){
            cards.Add(i.ToString());
            cards.Add(i.ToString());
            cards.Add(i.ToString());
            cards.Add(i.ToString());
            i = i+1;
        }

        return cards;
    }
}