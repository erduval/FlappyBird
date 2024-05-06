using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameOverBehaviour : MonoBehaviour
{

    public TMP_Text ScoreText;

    public void Setup(int score)
    {
        gameObject.SetActive(true);
        ScoreText.text = $"Score: {score}";
    }

    public void RetryButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void MenuButton()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
