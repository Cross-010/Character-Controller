using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public bool gameEnded = false;
    public GameObject Victory;

    void Start()
    {
        if (Victory != null)
        {
            Victory.SetActive(false);
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.V))
        {
            WinGame();
        }
    }

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

    public void Tutorial()
    {
        Debug.Log("Tutorial!");
        SceneManager.LoadScene("Tutorial");
    }

    public void FightTutorial()
    {
        Debug.Log("Fight Tutorial!");
        SceneManager.LoadScene("FightTutorial");
    }

    public void WinGame()
    {
        gameEnded = true;

        if (Victory != null)
        {
            Victory.SetActive(true);
            Debug.Log("Victory screen is shown.");
        }
        else
        {
            Debug.LogWarning("Victory GameObject is not assigned in the Inspector!");
        }
    }
}
