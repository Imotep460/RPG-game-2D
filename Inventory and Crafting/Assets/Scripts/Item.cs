using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item
{
    public int id;
    public string title;
    public string description;
    public Sprite icon;
    public Dictionary<string, int> stats = new Dictionary<string, int>();
    public int itemValue;

    
    public Item(int id, string title, string description, Dictionary<string, int> stats, int itemValue)
    {
        this.id = id;
        this.title = title;
        this.description = description;
        this.icon = Resources.Load<Sprite>("items/" + title);
        this.stats = stats;
        this.itemValue = itemValue;
    }

    public Item(Item item)
    {
        this.id = item.id;
        this.title = item.title;
        this.description = item.description;
        this.icon = item.icon;
        this.stats = item.stats;
        this.itemValue = item.itemValue;
    }
}
