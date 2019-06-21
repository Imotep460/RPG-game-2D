using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace QuestSystem
{
    public class QuestGiver : MonoBehaviour
    {
        [SerializeField]
        private string questName;

        private QuestController questController;
        private Quest quest;

        private void Start()
        {
            questController = FindObjectOfType<QuestController>();
            EventController.OnQuestCompleted += Completed;
        }

        public void GiveQuest()
        {
            quest = questController.AssignQuest(questName);
            //Change color of the "give quest" button
            GetComponent<UnityEngine.UI.Button>().image.color = Color.green;
            GetComponent<UnityEngine.UI.Button>().interactable = false;
        }

        public void Completed(Quest quest)
        {
            //make sure a quest is assigned and that the quest assigned is THIS quest
            if (this.quest != null && quest == this.quest)
            {
                GetComponent<UnityEngine.UI.Button>().interactable = false;
            }
        }
    }
}