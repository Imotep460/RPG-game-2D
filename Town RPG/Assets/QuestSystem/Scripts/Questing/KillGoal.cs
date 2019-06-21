using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace QuestSystem
{
    public class KillGoal : Goal
    {
        public int enemyID;

        public KillGoal(int amountNeeded, int enemyID, Quest quest)
        {
            currentCount = 0;
            countNeeded = amountNeeded;
            completed = false;
            this.quest = quest;
            this.enemyID = enemyID;
            EventController.OnEnemyDied += EnemyKilled;
        }

        void EnemyKilled(int enemyID)
        {
            if (this.enemyID == enemyID)
            {
                Increment(1);
                //check if the increment completed the goal.
                if (this.completed)
                {
                    EventController.OnEnemyDied -= EnemyKilled;
                }
            }
        }
    }
}
