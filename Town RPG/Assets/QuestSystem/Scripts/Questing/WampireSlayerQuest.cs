using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using QuestSystem;

public class WampireSlayerQuest : Quest
{
    private void Awake()
    {
        slug = "WampireSlayerQuest";
        questName = "Wampire Slayer";
        questDescription = "Slay some wampires.";
        itemRewards = new List<string> { "Burnt Salmon", "Rusty Chains", "Wampire dust" };
        goal = new KillGoal(5, 0, this);
    }

    public override void Complete()
    {
        base.Complete();
    }
}