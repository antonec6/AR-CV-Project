using UnityEngine;

public class OpenLinks : MonoBehaviour
{
    public void OpenMail()
    {
        Application.OpenURL("mailto:76250120@student.upr.si?subject=Spotted your AR CV!");
        Debug.Log("Opening Email Client");
    }
    public void OpenGitHub()
    {
        Application.OpenURL("https://github.com/mtaseva");
        Debug.Log("Opening GitHub...");
    }
}
