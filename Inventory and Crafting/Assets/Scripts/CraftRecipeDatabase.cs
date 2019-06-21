using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class CraftRecipeDatabase : MonoBehaviour
{
    public List<CraftRecipe> recipes = new List<CraftRecipe>();
    private ItemDatabase itemDatabase;

    private void Awake()
    {
        itemDatabase = GetComponent<ItemDatabase>();
        BuildCraftRecipeDatabase();
    }

    public Item CheckRecipe(int[] recipe)
    {
        foreach (CraftRecipe craftRecipe in recipes)
        {
            // Place required item(s) in whatever order/slots you want
            if (craftRecipe.requiredItems.OrderBy(i => i).SequenceEqual(recipe.OrderBy(i => i)))
            {
                return itemDatabase.GetItem(craftRecipe.itemToCraft);
            }
            //// Place required item(s) in the specific order as listed in the crafting recipe.
            //if (craftRecipe.requiredItems.SequenceEqual(recipe))
            //{
            //    return itemDatabase.GetItem(craftRecipe.itemToCraft);
            //}
        }
        return null;

    }

    void BuildCraftRecipeDatabase()
    {
        recipes = new List<CraftRecipe>()
        {
            new CraftRecipe(1,
            new int[]
            {
                3, 0, 0,
                0, 2, 0,
                0, 0, 0
            }),
            new CraftRecipe(2,
            new int[]
            {
                3, 0, 0,
                0, 3, 0,
                0, 0, 3
            }),
            new CraftRecipe(3,
            new int[]
            {
                2, 0, 2,
                0, 3, 0,
                0, 0, 3
            }),
        };
    }
}
