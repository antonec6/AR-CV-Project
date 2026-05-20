using UnityEngine;

public class AvatarAnimation : MonoBehaviour
{
    public Animator animator;
    // public GameObject speechBubble;

    void Start()
    {
        // speechBubble.SetActive(false);
    }

    // Llamado por Vuforia cuando detecta la imagen
    public void OnTargetFound()
    {
        animator.enabled = true;

        // StartCoroutine(ShowBubble());
    }

    /*System.Collections.IEnumerator ShowBubble()
    {
        yield return new WaitForSeconds(2f);
        speechBubble.SetActive(true);
    }*/
}
