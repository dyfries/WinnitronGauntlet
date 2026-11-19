using UnityEngine;

public class ConsumableItem : Item {

    // How many uses
    public int numOfUses;

    // Weight is calculated

    public override float CalcWeight() {
        return weight * numOfUses;
    }

    public override void Initialize(string newName, string newDesc) {
        base.Initialize(newName, newDesc);
        numOfUses = 1;
    }

    // New Initialize method with additional count. 
    public void Initialize(string newName, string newDesc, int newNumOfUses) {
        base.Initialize(newName, newDesc);
        numOfUses = newNumOfUses;
    }

    // New Initialize method with additional count. 
    public void Initialize(string newName, string newDesc, float newWeight, int newValue, int newNumOfUses) {
        base.Initialize(newName, newDesc, newWeight, newValue);
        numOfUses = newNumOfUses;  
    }

    public override string ToString() {
        return base.ToString() + " Has Uses: " + numOfUses;
    }
}
