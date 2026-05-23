using System.Collections;
using UnityEngine;

public class ProjectLinkOpener : MonoBehaviour
{
    [Header("Project Repositories")]
    public string dynamicRepoURL;

    [Header("Assistant Reaction")]
    public GameObject robotKyle;

    private bool isSpinning = false;

    public void OpenSpecificRepo()
    {
        Application.OpenURL(dynamicRepoURL);
        Debug.Log("Launching GitHub Repo: " + dynamicRepoURL);
    }

    public void TriggerRobotReaction()
    {
        if(robotKyle != null && !isSpinning)
        {
            StartCoroutine(SmoothSpinAnimation(0.6f));
        }
    }

    private IEnumerator SmoothSpinAnimation(float duration)
    {
        isSpinning = true;
        float elapsedTime = 0f;

        Quaternion startRotation = robotKyle.transform.localRotation;

        while (elapsedTime < duration)
        {
            elapsedTime += Time.deltaTime;
            float progress = elapsedTime / duration;
            float currentAngle = progress * 360f;
            robotKyle.transform.localRotation = startRotation * Quaternion.Euler(0, currentAngle, 0);
            
            yield return null;
        }

        robotKyle.transform.localRotation = startRotation;
        isSpinning = false;
    }
}
