using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesLoader : MonoBehaviour
{
    public void GameStart()
    {
        SceneManager.LoadScene("Game");
    }

    public void Exit()
    {
        Application.Quit();
        Debug.Log("QUIT!");
    }

    public void ToMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
