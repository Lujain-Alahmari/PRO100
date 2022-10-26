using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameOverManagr : MonoBehaviour
{
   [SerializeField] GameObject gameoverscreen;
    [SerializeField] Text currentScore;
    [SerializeField] Text finalScore;

    public void SetGameOver()
    {
        gameoverscreen.SetActive(true);

        finalScore.text = currentScore.text;

        currentScore.gameObject.SetActive(false);

        Time.timeScale = 0;
    }

    public void RestartGame()
    {
        Time.timeScale = 1;

        SceneManager.LoadScene(2);
    }
    
        
    }

