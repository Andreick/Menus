using UnityEngine;
using UnityEngine.SceneManagement;

public class SettingsButtons : MonoBehaviour
{
    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
