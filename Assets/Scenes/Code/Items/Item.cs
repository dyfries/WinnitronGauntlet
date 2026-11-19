using UnityEngine;

public class Item : MonoBehaviour
{
    [SerializeField]
    protected string itemName = "DefaultName";

    [SerializeField]
    protected string itemDescription = "Default Description Blah Blah Blah";
    
    [SerializeField]
    protected float weight = 0f; // KG
    
    [SerializeField]
    protected int value = 1;

    // Destroy 
    // Maybe trigger events. 

    // Subtypes 
    // Consumables
    // Armor/Weapons
    // 

    public void Initialize() {
        itemName = "New Generated Item";
        itemDescription = "Random Description";
    }

    public void Initialize(string newName, string newDesc) {
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
