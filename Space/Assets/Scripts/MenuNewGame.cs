using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuNewGame : MonoBehaviour
{
    public void Playgame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }
    public void Comic()
    {
        SceneManager.LoadScene(7);
    }

    public void menu()
    {
        SceneManager.LoadScene(0);
    }



    public void QuitGame()
    {
        Debug.Log("QuitGame!");
        Application.Quit();
    }

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Backspace))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        }
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            SceneManager.LoadScene(0);
        }
    }
}
