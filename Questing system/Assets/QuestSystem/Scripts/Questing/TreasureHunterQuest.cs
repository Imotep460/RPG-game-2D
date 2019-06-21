using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using QuestSystem;

public class TreasureHunterQuest : Quest
{
    private void Awake()
    {
        questName = "Treasure Hunter ";
        questDescription = "The Wampires and their supjects stole treasure from the village, bring the valuables back were they belong.";
        itemRewards = new List<string> { "500 Gold" };
        goal = new CollectionGoal(7, 0, this);
    }

    public override void Complete()
    {
        base.Complete();
    }
}