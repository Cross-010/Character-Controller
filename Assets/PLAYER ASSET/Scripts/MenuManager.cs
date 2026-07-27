using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public void NewGame()
    {
        Debug.Log("New Game Start!");
        SceneManager.LoadScene("Gameplay");
    }
    public void Quit()
    {
        Debug.Log("Quit!");
        Application.Quit();
    }

    public void Retry()
    {
        Debug.Log("Retry!");
        SceneManager.LoadScene("Gameplay");
    }

    public void BackToMenu()
    {
        Debug.Log("Back to Main Menu!");
        SceneManager.LoadScene("Main Menu");
    }
    public void Credits()
    {
        Debug.Log("Credits Time!");
        SceneManager.LoadScene("Credits");
    }
}
