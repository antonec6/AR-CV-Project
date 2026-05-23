using UnityEngine;

public class ProjectLinkOpener : MonoBehaviour
{
    [Header("Project Repositories")]
    public string dynamicRepoURL;

    public void OpenSpecificRepo()
    {
        Application.OpenURL(dynamicRepoURL);
        Debug.Log("Launching GitHub Repo: " + dynamicRepoURL);
    }
}
