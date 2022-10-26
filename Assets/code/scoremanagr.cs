using UnityEngine;
using UnityEngine.UI;
public class scoremanagr : MonoBehaviour
{
    Text scoreText;
    int currentScore;
    // Start is called before the first frame update
    void Start()
    {
        scoreText = GetComponent<Text>();
   
    }
     public void addpoint()
    {
        currentScore++;
        scoreText.text = currentScore.ToString();
    }

}

