using System.Collections;
using UnityEngine;

public class UIFader : MonoBehaviour
{
    private CanvasGroup canvasGroup;
    private Coroutine currentCoroutine;

    void Awake()
    {
        canvasGroup = GetComponent<CanvasGroup>();
    }

    public void FadeIn(float duration = 0.5f)
    {
        if (currentCoroutine != null) StopCoroutine(currentCoroutine);
        gameObject.SetActive(true);
        currentCoroutine = StartCoroutine(FadeRoutine(0f, 1f, duration));
    }

    public void FadeOut(float duration = 0.5f)
    {
        if(currentCoroutine != null) StopCoroutine(currentCoroutine);
        currentCoroutine = StartCoroutine(FadeRoutine(canvasGroup.alpha, 0f, duration));
    }

    private IEnumerator FadeRoutine(float startAlpha, float targetAlpha, float duration)
    {
        float time = 0;
        canvasGroup.alpha = startAlpha;

        while (time < duration)
        {
            time += Time.deltaTime;
            canvasGroup.alpha = Mathf.Lerp(startAlpha, targetAlpha, time / duration);
            yield return null;
        }

        canvasGroup.alpha = targetAlpha;
        if (targetAlpha == 0f) gameObject.SetActive(false);
    }
}
