using UnityEngine;

public class AudioController : MonoBehaviour
{
    public AudioSource audioSource;

    public AudioClip uiClick;
    public AudioClip startupSound;
    public AudioClip typingSound;

    public void PlayUIClick()
    {
        audioSource.PlayOneShot(uiClick);
    }

    public void PlayStartup()
    {
        audioSource.PlayOneShot(startupSound);
    }

    public void PlayTyping()
    {
        audioSource.PlayOneShot(typingSound);
    }
}
