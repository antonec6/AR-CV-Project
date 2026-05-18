using UnityEngine;

public class OpenLinks : MonoBehaviour
{
    public void OpenMail()
    {
        Application.OpenURL("https://outlook.cloud.microsoft/mail/0/?deeplink=mail%2F0%2F");
    }
    public void OpenGitHub()
    {
        Application.OpenURL("https://github.com/mtaseva");
    }
}
