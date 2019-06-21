using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIInventory : MonoBehaviour
{
    [SerializeField]
    private SlotPanel[] slotpanels;
    public void AddItemToUI(Item item)
    {
        foreach (SlotPanel sp in slotpanels)
        {
            if (sp.ContainsEmptySlot())
            {
                sp.AddNewItem(item);
                break;
            }
        }
    }
}
