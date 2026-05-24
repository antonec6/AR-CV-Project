using UnityEngine;

public class LinkHandler : MonoBehaviour
{
    public GameObject fullCVDisplay; 
    public GameObject skillsPanel; // New slot for your Skills UI

    public void OpenLinkedIn() => Application.OpenURL("https://www.linkedin.com/in/meryem-nobatova-095459410"); 
    public void OpenGitHub() => Application.OpenURL("https://github.com/Meryemmmn");

    public void ToggleFullCV()
    {
        if (fullCVDisplay != null) fullCVDisplay.SetActive(!fullCVDisplay.activeSelf);
    }

    public void ToggleSkills()
    {
        if (skillsPanel != null)
        {
            skillsPanel.SetActive(!skillsPanel.activeSelf);
            // Bonus: If you want the Full CV to close when Skills opens:
            if (fullCVDisplay != null) fullCVDisplay.SetActive(false);
        }
    }
}