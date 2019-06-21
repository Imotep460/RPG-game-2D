using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace QuestSystem
{
    public class CollectionGoal : Goal
    {
        public int itemID;

        public CollectionGoal(int amountNeeded, int itemID, Quest quest)
        {
            currentCount = 0;
            countNeeded = amountNeeded;
            completed = false;
            this.quest = quest;
            this.itemID = itemID;
            EventController.OnItemFound += ItemFound;
        }

        void ItemFound(int itemID)
        {
            if (this.itemID == itemID)
            {
                Increment(1);
                //check if the increment completed the goal.
                if (this.completed)
                {
                    EventController.OnItemFound -= ItemFound;
                }
            }
        }
    }
}
