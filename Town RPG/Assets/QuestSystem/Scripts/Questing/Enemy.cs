using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace QuestSystem
{
    public class Enemy : MonoBehaviour
    {
        private int enemyID;
        // Start is called before the first frame update
        void Start()
        {
            enemyID = 0;
        }

        public void Die()
        {
            EventController.EnemyDied(enemyID);
        }
    }
}
