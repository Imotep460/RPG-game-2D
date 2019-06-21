using QuestSystem;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WampireSlayerQuest : Quest
{
    private void Awake()
    {
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