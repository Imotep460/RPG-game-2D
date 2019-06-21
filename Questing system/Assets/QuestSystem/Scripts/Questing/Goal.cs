using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace QuestSystem
{
    public class Goal
    {
        public int countNeeded;
        public int currentCount;
        public bool completed;
        public Quest quest;

        public void Increment(int amount)
        {
            currentCount = Mathf.Min(currentCount + 1, countNeeded);
            if (currentCount >= countNeeded && !completed)
            {
                this.completed = true;
                Debug.Log("Goal completed!");
                quest.Complete();
            }
            EventController.QuestProgressChanged(quest);
        }
    }
}
