using UnityEngine;

public class ItemTester : MonoBehaviour
{
    private Inventory bag;

    //public GameObject invPrefab;
    public Inventory invPrefab;

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
            bag = Instantiate(invPrefab);
            //bag = 
            Debug.LogWarning("Bag was null, we created one");
        }

        // Add items to it 
        //bag.Pickup

        // Print the list of items. 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
