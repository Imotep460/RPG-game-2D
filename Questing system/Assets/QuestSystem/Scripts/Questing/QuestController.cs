using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace QuestSystem
{
    public class QuestController : MonoBehaviour
    {
        public List<Quest> assignedQuests = new List<Quest>();

        [SerializeField]
        private QuestUIItem questUIItem;
        [SerializeField]
        private Transform questUIParent;


        private QuestDatabase questDatabase;

        private void Start()
        {
            questDatabase = GetComponent<QuestDatabase>();
        }
        public Quest AssignQuest(string questName)
        {
            //check to make sure the quest is not assigned twice in a row, or assigned while it is already active
            if (assignedQuests.Find(quest => quest.questName == questName))
            {
                Debug.Log("Quest is already assigned please complete it!");
                return null;
            }

            //create a component from a name (a script name)
            Quest questToAdd = (Quest)gameObject.AddComponent(System.Type.GetType(questName));
            //assign the quest to the assignedQuests list
            assignedQuests.Add(questToAdd);
            //Add quest to questDatabase
            questDatabase.AddQuest(questToAdd);

            //Instantiate the UI item
            QuestUIItem questUI = Instantiate(questUIItem, questUIParent);
            //setup data for the UI item.
            questUI.Setup(questToAdd);
            //return the quest being added so the "Quest giver" has a reference to the quest that was just created.
            return questToAdd;
        }
    }
}