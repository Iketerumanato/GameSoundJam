using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSystem : MonoBehaviour
{
    public void GotoTitle()
    {
        SceneManager.LoadScene("Title");
    }

    public void GotoStartMovie()
    {
        SceneManager.LoadScene("StartMovie");
    }

    public void GotoInGame()
    {
        SceneManager.LoadScene("GameMain");
    }

    public void GotoGameOver()
    {
        SceneManager.LoadScene("GameOver");
    }

    public void GotoClearMovie()
    {
        SceneManager.LoadScene("GameClear");
    }
}