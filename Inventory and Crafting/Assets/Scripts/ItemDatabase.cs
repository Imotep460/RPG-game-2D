using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDatabase : MonoBehaviour
{
    public List<Item> items = new List<Item>();

    void Awake()
    {
        BuildItemDatabase();
    }

    public Item GetItem(int id)
    {
        return items.Find(item => item.id == id);
    }

    public Item GetItem(string title)
    {
        return items.Find(item => item.title == title);
    }

    void BuildItemDatabase()
    {
        items = new List<Item>()
        {
            new Item(1, "Diamond Axe", "Diamonds magically grafted onto an iron axe, extremly shard. Due to the magical infusion of diamonds into the moleculer structure of the iron the diamond axe is extremly durable.", 
            new Dictionary<string, int> {
                { "Power:", 20 },
                { "Defence", 20},
            }, 2500),
            new Item(2, "Uncut Diamond", "Pure, sometimes cloudy, but always just taken out of the ground, thus their true value is still hidden, just waiting for a skilled craftsman to bring the true treassure to the surface.",
            new Dictionary<string, int> {
            }, 1200),
            new Item(3, "Iron Axe", "A standard iron axe, handles better than a bronze axe but rusts over time.",
            new Dictionary<string, int> {
                { "Power:", 10 },
                { "Defence", 10},
            }, 800),
        };
    }
}
