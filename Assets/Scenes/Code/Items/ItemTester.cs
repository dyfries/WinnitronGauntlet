using UnityEngine;

public class ItemTester : MonoBehaviour
{
    private Inventory bag;

    //public GameObject invPrefab;
    public Inventory inventoryPrefab;
    public Item itemPrefab;
    public ConsumableItem consumablePrefab;

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

        

        // NOT accessible in Item. 
        // newItem.Initialize("a", "b", 1f, 10, 99);

        // Add items to it 
        bag.PickupItem(newItem);

        newItem = CreateItem();
        newItem.Initialize("Ax", "Ax of +1");
        bag.PickupItem(newItem);

        newItem = CreateItem();
        newItem.Initialize("Sword", "Sword +6", 5f, 17);
        bag.PickupItem(newItem);

        // Consumable as an Item
        newItem = CreateConsumableAsItem();
        bag.PickupItem(newItem);

        // Consumable as an ConsumableItem
        ConsumableItem ci = CreateConsumableAsConsumableItem();
        bag.PickupItem(ci);

        //  Consumable as an Item with Casting
        newItem = CreateConsumableAsItem();
        if (ci is ConsumableItem consumableItem) {
            consumableItem.Initialize("a", "b", 1f, 5, 77);
            bag.PickupItem(consumableItem);
        }
        

        //  Consumable as an Item with Casting #2 
        newItem = CreateConsumableAsItem();
        ConsumableItem newCI = (ConsumableItem)newItem;
        newCI.Initialize("c", "d", 1f, 10, 55);
        bag.PickupItem(newCI);

        bag.PrintEntireInventory();

        // Print the list of items. 
    }

    public Item CreateItem() {
        Item newItem = Instantiate(itemPrefab);
        newItem.Initialize();
        return newItem;
    }

    public Item CreateConsumableAsItem() {
        ConsumableItem newItem = Instantiate(consumablePrefab);
        //newItem.numOfUses = 10;
        // New Initialize method with additional count. 
        newItem.Initialize("Consumable Potion", "Magic", 99);
        return newItem;
    }

    public ConsumableItem CreateConsumableAsConsumableItem() {
        ConsumableItem newItem = Instantiate(consumablePrefab);
        //newItem.numOfUses = 10;
        // New Initialize method with additional count. 
        newItem.Initialize("Consumable Potion", "Ax Throwing", 77);
        return newItem;
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
