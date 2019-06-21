using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace QuestSystem
{
    public class Quest : MonoBehaviour
    {
        public string questName;
        public string questDescription;
        public Goal goal;
        public bool completed;
        public List<string> itemRewards;

        public virtual void Complete()
        {
            Debug.Log("Quest Completed");
            EventController.QuestCompleted(this);
            GrantReward();
        }

        public void GrantReward()
        {
            Debug.Log("Turning in quest......... granting reward.");
            foreach (string item in itemRewards)
            {
                Debug.Log("Rewarded with: " + item);
            }
            Destroy(this);
        }
    }
}