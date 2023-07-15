using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LogicScript : MonoBehaviour
{
    public int PlayerScore;
    public Text ScoreText;
    public Text HighScoreText;
    public GameObject GameOverScreen;
    public AudioSource ScoreIncrease;
    public AudioSource DeathSound;


    private void Start()
    {
        HighScoreText.text = $"High Score: {PlayerPrefs.GetInt("highScore")}";
    }
    public void AddScore(int scoreToAdd)
    {
        PlayerScore += scoreToAdd;
        ScoreText.text = $"Score: {PlayerScore}";
        ScoreIncrease.Play();
    }

    public void GameOver()
    {
        SetHighScore();
        GameOverScreen.SetActive(true);
        DeathSound.Play();
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void SetHighScore()
    {
        if (PlayerScore > PlayerPrefs.GetInt("highScore"))
        {
            PlayerPrefs.SetInt("highScore", PlayerScore);
        }

        HighScoreText.text = $"High Score: {PlayerPrefs.GetInt("highScore")}";
    }
}
