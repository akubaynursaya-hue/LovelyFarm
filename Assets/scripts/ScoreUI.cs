using UnityEngine;
using TMPro;  

public class ScoreUI : MonoBehaviour
{
    public static ScoreUI Instance;

    public static int Score = 0;

    [Header("Score Texts (TMP)")]
    public TMP_Text inGameScoreText;  
    public TMP_Text winScoreText;    
    public TMP_Text loseScoreText;  

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        Score = 0;
        UpdateScoreText();
    }

    public void UpdateScoreText()
    {
        if (inGameScoreText != null)
            inGameScoreText.text = Score.ToString();

        if (winScoreText != null)
            winScoreText.text = Score.ToString();

        if (loseScoreText != null)
            loseScoreText.text = Score.ToString();
    }
}
