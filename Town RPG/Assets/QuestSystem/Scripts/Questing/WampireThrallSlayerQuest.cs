using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using QuestSystem;


public class WampireThrallSlayerQuest : Quest
{
    private void Awake()
    {
        slug = "WampireThrallSlayerQuest";
        questName = "Kill Wampire Thralls";
        questDescription = "Wampires have allies. teach these allies that not only wampires can die.";
        itemRewards = new List<string> { "Burnt Salmon", "Rusty Chains" };
        goal = new KillGoal(10, 1, this);
    }

    public override void Complete()
    {
        base.Complete();
    }
}