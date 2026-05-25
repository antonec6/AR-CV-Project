using UnityEngine;
using TMPro;
using System.Collections;

public class BootSequence : MonoBehaviour
{
    public TMP_Text bootText;
    public GameObject[] uiElements;
    public AudioController audioController;

    IEnumerator Start()
    {
        audioController.PlayStartup();
        foreach (GameObject obj in uiElements)
        {
            obj.SetActive(false);
        }
        
        bootText.text = "> Scanning portrait...";
        yield return new WaitForSeconds(1.5f);

        bootText.text = "> Identity confirmed";
        yield return new WaitForSeconds(1.2f);

        
        bootText.text = "> Loading AR portfolio...";
        yield return new WaitForSeconds(1.5f);

        
        bootText.text = "> Initialzing project...";
        yield return new WaitForSeconds(1.2f);

        bootText.text = "> System ready";

        yield return new WaitForSeconds(1f);

        // activating elements progressively
        foreach (GameObject obj in uiElements)
        {
            obj.SetActive(true);
            yield return new WaitForSeconds(0.3f);
        }

        bootText.gameObject.SetActive(false);
    }
}
