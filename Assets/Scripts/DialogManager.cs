using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogManager : MonoBehaviour
{
    private TextMeshProUGUI dialogueText;

    //public Animator animator;

    private Queue<string> sentences;

    // Use this for initialization
    void Start()
    {
        dialogueText = this.gameObject.GetComponent<TextMeshProUGUI>();
        sentences = new Queue<string>();
        sentences.Enqueue("Press 'Spacebar' to Start");
        StartDialogue();
    }

    public void StartDialogue()
    {
        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        if (sentences.Count == 0)
        {
            return;
        }

        string sentence = sentences.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
    }

    IEnumerator TypeSentence(string sentence)
    {
        dialogueText.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            dialogueText.text += letter;
            yield return new WaitForSeconds(0.1f);
        }
    }
}
