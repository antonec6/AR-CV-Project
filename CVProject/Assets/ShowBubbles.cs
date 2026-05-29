/* using UnityEngine;

public class ShowBubbles : MonoBehaviour
{
    public RectTransform introductionBubble;
    public RectTransform profileBubble;
    public RectTransform contactBubble;
    public RectTransform skillsBubble;
    public RectTransform languagesBubble;
    public RectTransform hobbiesBubble;
    public RectTransform educationBubble;

    // Esta función apaga absolutamente todos los bocadillos
    public void hideEverything()
    {
        if (introductionBubble != null) introductionBubble.gameObject.SetActive(false);
        if (profileBubble != null) profileBubble.gameObject.SetActive(false);
        if (contactBubble != null) contactBubble.gameObject.SetActive(false);
        if (skillsBubble != null) skillsBubble.gameObject.SetActive(false);
        if (languagesBubble != null) languagesBubble.gameObject.SetActive(false);
        if (hobbiesBubble != null) hobbiesBubble.gameObject.SetActive(false);
        if (educationBubble != null) educationBubble.gameObject.SetActive(false);
    }

    public void showIntroductionBubble()
    {
        hideEverything();
        if (introductionBubble != null) introductionBubble.gameObject.SetActive(true);
    }

    public void showProfileBubble()
    {
        hideEverything();
        if (profileBubble != null) profileBubble.gameObject.SetActive(true);
    }

    public void showContactBubble()
    {
        hideEverything();
        if (contactBubble != null) contactBubble.gameObject.SetActive(true);
    }

    public void showSkillsBubble()
    {
        hideEverything();
        if (skillsBubble != null) skillsBubble.gameObject.SetActive(true);
    }

    public void showLanguagesBubble()
    {
        hideEverything();
        if (languagesBubble != null) languagesBubble.gameObject.SetActive(true);
    }

    public void showHobbiesBubble()
    {
        hideEverything();
        if (hobbiesBubble != null) hobbiesBubble.gameObject.SetActive(true);
    }

    public void showEducationBubble()
    {
        hideEverything();
        if (educationBubble != null) educationBubble.gameObject.SetActive(true);
    }
} */

using UnityEngine;

public class ShowBubbles : MonoBehaviour
{
    public GameObject introductionBubble;
    public GameObject profileBubble;
    public GameObject contactBubble;
    public GameObject skillsBubble;
    public GameObject languagesBubble;
    public GameObject hobbiesBubble;
    public GameObject educationBubble;

    public Animator Animator;

    // Esta función apaga absolutamente todos los bocadillos
    public void hideEverything()
    {
        if (introductionBubble != null) introductionBubble.SetActive(false);
        if (profileBubble != null) profileBubble.SetActive(false);
        if (contactBubble != null) contactBubble.SetActive(false);
        if (skillsBubble != null) skillsBubble.SetActive(false);
        if (languagesBubble != null) languagesBubble.SetActive(false);
        if (hobbiesBubble != null) hobbiesBubble.SetActive(false);
        if (educationBubble != null) educationBubble.SetActive(false);
    }

    public void showProfileBubble()
    {
        hideEverything();
        if (profileBubble != null) profileBubble.SetActive(true);
        if (Animator != null) Animator.Play("Backflip");
    }

    public void showContactBubble()
    {
        hideEverything();
        if (contactBubble != null) contactBubble.SetActive(true);
        if (Animator != null) Animator.Play("Talking");
    }

    public void showSkillsBubble()
    {
        hideEverything();
        if (skillsBubble != null) skillsBubble.SetActive(true);
        if (Animator != null) Animator.Play("Typing");
    }

    public void showLanguagesBubble()
    {
        hideEverything();
        if (languagesBubble != null) languagesBubble.SetActive(true);
        // if (Animator != null) Animator.Play("Nombre_Animacion_Languages");
    }

    public void showHobbiesBubble()
    {
        hideEverything();
        if (hobbiesBubble != null) hobbiesBubble.SetActive(true);
        if (Animator != null) Animator.Play("Dribble");
    }

    public void showEducationBubble()
    {
        hideEverything();
        if (educationBubble != null) educationBubble.SetActive(true);
        if (Animator != null) Animator.Play("Writing");
    }
}
