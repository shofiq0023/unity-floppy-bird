using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public TextMeshProUGUI textMesh;
    public GameObject gameOverScreen;
    private int score;
    public bool stop = false;

    public void addScore(int n)
    {
        score += n;
        textMesh.text = score.ToString();
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);
        stop = true;
    }

    public void quitGame()
    {
        Application.Quit();
    }
}
