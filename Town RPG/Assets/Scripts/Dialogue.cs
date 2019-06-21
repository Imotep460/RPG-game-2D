using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialogue : MonoBehaviour
{
    [SerializeField]
    private UnityEngine.UI.Text dialogueText;
    [SerializeField]
    private GameObject dialoguePanel;
    private string[] dialogue;
    private int dialogueIndex;

    //Starts the dialogue.
    public void StartDialogue(string[] dialogue)
    {
        this.dialogue = dialogue;
        dialoguePanel.SetActive(true);
        dialogueText.text = dialogue[0];
        dialogueText.text = dialogue[dialogueIndex];
    }

    //Next line in the dialogue system
    public void NextLine()
    {
        dialogueIndex = Mathf.Min(dialogueIndex + 1, dialogue.Length);
        if (dialogueIndex >= this.dialogue.Length)
        {
            ResetDialogue();
        }
        else
        {
            dialogueText.text = dialogue[dialogueIndex];
        }
    }

    //Previous line in the dialogue system
    public void PreviousLine()
    {
        if (dialogueIndex == 0)
        {
            return;
        }
        dialogueIndex = Mathf.Max(dialogueIndex - 1, 0);
        dialogueText.text = dialogue[dialogueIndex];
    }

    //Reset everything
    public void ResetDialogue()
    {
        dialogue = null;
        dialogueText.text = "";
        dialoguePanel.SetActive(false);
        dialogueIndex = 0;
    }
}
