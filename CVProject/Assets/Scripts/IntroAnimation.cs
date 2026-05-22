using UnityEngine;

public class IntroAnimation : MonoBehaviour
{
    public float speed = 2f;

    void Start()
    {
        transform.localScale = Vector3.zero;
    }

    void Update()
    {
        transform.localScale = Vector3.Lerp(
            transform.localScale,
            Vector3.one,
            Time.deltaTime * speed
        );
    }
}
