using UnityEngine;

public class HologramAnimation : MonoBehaviour
{
    [Header("Float Settings")]
    public float amplitude = 0.03f;
    public float frequency = 1.2f;

    [Header("Intro Animation")]
    public float introSpeed = 3f;

    private Vector3 startPos;
    private Vector3 targetScale;

    void Start()
    {
        startPos = transform.localPosition;

        // save intended scale
        targetScale = transform.localScale;

        // start invisible
        transform.localScale = Vector3.zero;
    }

    void Update()
    {
        // smooth scale-in animation
        transform.localScale = Vector3.Lerp(
            transform.localScale,
            targetScale,
            Time.deltaTime * introSpeed
        );

        // floating motion
        Vector3 tempPos = startPos;
        tempPos.y += Mathf.Sin(Time.time * Mathf.PI * frequency) * amplitude;

        transform.localPosition = tempPos;
    }
}
