using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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

        // start is only called once.
        private void Start()
        {
            // in order to make sure that we only ever have 1 QuestController we do a check.
            if (FindObjectsOfType<QuestController>().Length > 1)
            {
                // if there is more than 1 QuestController destroy this specific one.
                Destroy(this.gameObject);
            }
            DontDestroyOnLoad(this.gameObject);
            SceneManager.sceneLoaded += Populate;
            questDatabase = GetComponent<QuestDatabase>();
        }
        public Quest AssignQuest(string questName)
        {
            Quest questToAdd = null;
            //check to make sure the quest is not assigned twice in a row, or assigned while it is already active
            if (FindActiveQuest(questName) == null)
            {
                //create a component from a name (a script name)
                questToAdd = (Quest)gameObject.AddComponent(System.Type.GetType(questName));
                //assign the quest to the assignedQuests list
                assignedQuests.Add(questToAdd);
                //Add quest to questDatabase
                questDatabase.AddQuest(questToAdd);
            }
            else
            {
                questToAdd = (Quest)gameObject.GetComponent(System.Type.GetType(questName));
            }

            //Instantiate the UI item
            QuestUIItem questUI = Instantiate(questUIItem, questUIParent);
            //setup data for the UI item.
            questUI.Setup(questToAdd);
            //return the quest being added so the "Quest giver" has a reference to the quest that was just created.
            return questToAdd;
        }

        public Quest FindActiveQuest(string questSlug)
        {
            return (Quest)GetComponent(System.Type.GetType(questSlug)) as Quest;
        }

        private void Populate(Scene scene, LoadSceneMode sceneMode)
        {
            questUIParent = GameObject.FindGameObjectWithTag("UI/Quest Panel").transform;
            if (assignedQuests.Count > 0)
            {
                for (int i = 0; i < assignedQuests.Count; i++)
                {
                    AssignQuest(assignedQuests[i].slug);
                }
            }
        }
    }
}