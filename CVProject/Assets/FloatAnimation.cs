using UnityEngine;

public class FloatAnimation : MonoBehaviour
{
    public float amplitude = 0.03f;
    public float frequency = 1.2f;

    private Vector3 startPos;

    void Start() => startPos = transform.localPosition;
    void Update()
    {
        Vector3 tempPos = startPos;
        tempPos.y += Mathf.Sin(Time.time * Mathf.PI * frequency) * amplitude;
        transform.localPosition = tempPos;
    }
}
