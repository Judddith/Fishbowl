namespace Fishbowl
{
    public Asset[] assets;

    public class Asset() {

        string name;
        string model;
        int amount;
        int id;
        string type;
        bool unlocked;

        public Asset(string name_, string model_, int amount_, string type_) {
            this.name = name_;
            this.model = model_;
            this.amount = amount_;
            this.id = GetNextID();
            this.type = type_;
            unlocked = false;
            
        }

        public void idleAnimation(string animation) {
            //Hier soll eine Idle Anmation für die Assets abgespielt werden.
        }

        public void place() {
            //Hier kommt die Funktion rein, um ein Asset in der Fishbowl abzulegen
            assets.add(this);
        }
    }
}