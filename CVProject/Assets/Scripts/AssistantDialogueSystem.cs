using UnityEngine;
using TMPro;
using System.Collections;

public class AssistantDialogueSystem : MonoBehaviour
{
    public TMP_Text dialogueText;
    Coroutine currentRoutine;

    public void ShowMessage(string message)
    {
        if (currentRoutine != null)
        {
            StopCoroutine(currentRoutine);
        }

        currentRoutine = StartCoroutine(DisplayMessage(message));
    }

    IEnumerator DisplayMessage(string message)
    {
        dialogueText.gameObject.SetActive(true);
        dialogueText.text = "";

        foreach (char c in message)
        {
            dialogueText.text += c;
            yield return new WaitForSeconds(0.03f);
        }

        yield return new WaitForSeconds(2f);

        dialogueText.gameObject.SetActive(false);
    }
}
