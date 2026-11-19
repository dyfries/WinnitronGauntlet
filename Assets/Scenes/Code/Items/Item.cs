using UnityEngine;

public class Item : MonoBehaviour
{
    [SerializeField]
    public string itemName = "DefaultName";

    [SerializeField]
    public string itemDescription = "Default Description Blah Blah Blah";
    
    [SerializeField]
    public float weight = 0f; // KG
    
    [SerializeField]
    public int value = 1;

    // Destroy 
    // Maybe trigger events. 

    // Subtypes 

    // Junk - Default Item
    // Consumables - Subclass.
    // Wearable - Subclass that has more subclasses
    //  - Armor - subclass of wearable. 
    //  - Weapons - subclass of wearable. 
    // 

    public virtual float CalcWeight() {
        return weight;
    }

    public void Initialize() {
        itemName = "New Generated Item";
        itemDescription = "Random Description";
    }

    public virtual void Initialize(string newName, string newDesc) {
        itemName = newName;
        itemDescription = newDesc;
    }

    public void Initialize(string newName, string newDesc, float newWeight, int newValue) {
        Initialize(newName, newDesc);
        weight = newWeight;
        value = newValue;
    }

    public override string ToString() {
        return "Name: " + itemName + " Desc: " + itemDescription;
    }


}
