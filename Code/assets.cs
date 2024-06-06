namespace Fishbowl
{
    public Asset[] assetsToPlace;

    public Asset[] assetsInBowl;


    public class Asset() {

        string name;
        string model;
        int amount;
        int id;
        string type;
        bool unlocked;
        bool placed;

        public Asset(string name_, string model_, int amount_, string type_) {
            this.name = name_;
            this.model = model_;
            this.amount = amount_;
            this.id = GetNextID();
            this.type = type_;
            this.unlocked = false;
            this.placed = false;
            
        }

        public void idleAnimation(string animation) {
            //Hier soll eine Idle Anmation für die Assets abgespielt werden.
        }

        public void place() {
           
            //Hier kommt die Funktion rein, um ein Asset in der Fishbowl abzulegen
            if(this.unlocked) {
                if(this.placed) {
                    this.placed = true;
                    assetsInBowl.add(this);
                }
                else {
                    continue;
                }
            }
            else {
                //Meldung an User ausgeben, dass Asset noch gesperrt ist
            }
           
        }
    }
}