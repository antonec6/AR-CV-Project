using UnityEngine;

public class LinkHandler : MonoBehaviour
{
    public GameObject fullCVDisplay;  // your PhotoFrame (CV + photo)
    public GameObject skillsPanel;

    public void OpenLinkedIn() => Application.OpenURL("https://www.linkedin.com/in/meryem-nobatova-095459410");
    public void OpenGitHub() => Application.OpenURL("https://github.com/Meryemmmn");

    public void ToggleFullCV()
    {
        if (fullCVDisplay != null)
        {
            bool opening = !fullCVDisplay.activeSelf;
            fullCVDisplay.SetActive(opening);

            if (opening && skillsPanel != null)
                skillsPanel.SetActive(false);
        }
    }

    public void ToggleSkills()
    {
        if (skillsPanel != null)
        {
            bool opening = !skillsPanel.activeSelf;
            skillsPanel.SetActive(opening);

            if (opening && fullCVDisplay != null)
                fullCVDisplay.SetActive(false);
        }
    }
}