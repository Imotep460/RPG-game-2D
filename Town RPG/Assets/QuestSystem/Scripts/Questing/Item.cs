using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace QuestSystem
{
    public class Item : MonoBehaviour
    {
        private int itemID;

        private void Start()
        {
            itemID = 0;
        }

        public void GiveItem()
        {
            EventController.ItemFound(itemID);
        }
    }
}