using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    [SerializeField] List<ItemSlot> slots = new List<ItemSlot>();

    //Call this function when you want to add an item to the inventory
    public bool AddItem(Sprite itemSprite, GameObject itemObject, string itemName)
    {
        foreach (ItemSlot slot in slots)
        {
            if (!slot.IsOccupied)
            {
                slot.SetupSlotItem(itemSprite, itemObject, itemName);
                return true;
            }
        }

        Debug.Log("Inventory is full!");
        return false;
    }

    //Call this function when you want to remove an item from the inventory
    public bool RemoveItem(GameObject itemObject)
    {
        foreach (ItemSlot slot in slots)
        {
            if (slot.IsOccupied && slot.StoredItem == itemObject)
            {
                slot.ClearSlot();
                return true;
            }
        }

        Debug.Log("Item not found in inventory!");
        return false;
    }
}
