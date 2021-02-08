using UnityEngine;

public class TransitionMenu : MonoBehaviour
{
    public void goToMenu(GameObject menu)
    {
        this.gameObject.SetActive(false);
        menu.SetActive(true);
    }
}
