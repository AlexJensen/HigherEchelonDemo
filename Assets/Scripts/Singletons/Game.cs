using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game : Singleton<Game>
{
    [SerializeField]
    int registeredInputMax;
    [SerializeField]
    GameObject gameOverPanel;
    private int totalRegisteredInput = 0;

    public int TotalRegisteredInput
    {
        get => totalRegisteredInput; 
        set
        {
            totalRegisteredInput = value;
            if (totalRegisteredInput >= registeredInputMax)
            {
                gameOverPanel.SetActive(true);
            }
        }
    }

    public void Restart()
    {
        SceneManager.LoadScene("Demo");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
