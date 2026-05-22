using UnityEngine;

public class PulseEffect : MonoBehaviour
{
    float timer;

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        float scale = 1 + Mathf.Sin(timer * 2) * 0.05f;
        transform.localScale = new Vector3(scale, scale, scale);
    }
}
