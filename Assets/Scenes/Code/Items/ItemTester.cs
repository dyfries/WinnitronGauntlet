using UnityEngine;

public class ItemTester : MonoBehaviour
{
    private Inventory bag;

    //public GameObject invPrefab;
    public Inventory inventoryPrefab;
    public Item itemPrefab;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Make sure inventory exists
        if(bag == null) {
            // Spawn and then cast. 
            /*
            GameObject bagGeneric = Instantiate(invPrefab);
            bag = bagGeneric.GetComponent<Inventory>();
            */
            bag = Instantiate(inventoryPrefab);
            //bag = 
            Debug.LogWarning("Bag was null, we created one");
        }

        Item newItem = CreateItem();

        // Add items to it 
        bag.PickupItem(newItem);

        newItem = CreateItem();
        newItem.Initialize("Ax", "Ax of +1");
        bag.PickupItem(newItem);

        newItem = CreateItem();
        newItem.Initialize("Sword", "Sword +6", 5f, 17);
        bag.PickupItem(newItem);

        bag.PrintEntireInventory();

        // Print the list of items. 
    }

    public Item CreateItem() {
        Item newItem = Instantiate(itemPrefab);
        newItem.Initialize();
        return newItem;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
