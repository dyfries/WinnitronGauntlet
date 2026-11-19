using NUnit.Framework;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Inventory : MonoBehaviour
{
    // Non Generic. 
   // private List list = new List();

   // Generic
    private List<Item> allItems = new List<Item>();

    public bool DEBUG_MODE = true;

    public void PickupItem(Item newItem) {
        allItems.Add(newItem);

        if (DEBUG_MODE) {
            // Print the item: 
            Debug.Log("Added to bag: " + gameObject.name + newItem.ToString());
        }
    }

    public void PrintEntireInventory() {
        Debug.Log("Printing the whole inventory");

        /*
        int j = 0;
        while (j < allItems.Count) {
            Debug.Log(allItems[j].ToString());
            j++;
        }
        */

        for (int i = 0; i < allItems.Count; i++) {
            Debug.Log(allItems[i].ToString());
        }

        /* Same as above basically. 
        foreach (Item item in allItems) {
            Debug.Log(item.ToString());
        }
        */
    }
}
