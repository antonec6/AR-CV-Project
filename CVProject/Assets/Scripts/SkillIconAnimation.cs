using UnityEngine;
using System.Collections;

public class SkillIconAnimation : MonoBehaviour
{
   public float floatAmount = 0.01f;
   public float floatSpeed = 2f;
   public float appearDelay = 0f;

   private Vector3 startPos;
   private Vector3 targetScale;

   IEnumerator Start()
    {
        startPos = transform.localPosition;
        targetScale = transform.localScale;

        transform.localScale = Vector3.zero;

        yield return new WaitForSeconds(appearDelay);

        while (Vector3.Distance(transform.localScale, targetScale) > 0.01f)
        {
            transform.localScale = Vector3.Lerp(
                transform.localScale,
                targetScale,
                Time.deltaTime * 5f
            );

            yield return null;
        }
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = startPos;
        pos.y += Mathf.Sin(Time.time * floatSpeed) * floatAmount;

        transform.localPosition = pos;
    }
}
