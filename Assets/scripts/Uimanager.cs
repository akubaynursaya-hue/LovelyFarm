using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class UImanager : MonoBehaviour
{
    public static UImanager Instance;

    [Header("UI Screens")]
    public GameObject startScreen;
    public GameObject pauseScreen;
    public GameObject winScreen;
    public GameObject loseScreen;

    private bool isGameRunning = false;
    private bool isPaused = false;
    private bool gameOver = false;

    private void Awake()
    {
        
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        ShowStartScreen();
    }

   
    public void ShowStartScreen()
    {
        Time.timeScale = 0f;
        startScreen.SetActive(true);
        pauseScreen.SetActive(false);
        winScreen.SetActive(false);
        loseScreen.SetActive(false);
    }

    public void StartGame()
    {
        startScreen.SetActive(false);
        Time.timeScale = 1f;
        isGameRunning = true;
    }

    
    public void PauseGame()
    {
        if (gameOver || !isGameRunning) return;

        isPaused = true;
        pauseScreen.SetActive(true);
        Time.timeScale = 0f;
    }

    public void ResumeGame()
    {
        isPaused = false;
        pauseScreen.SetActive(false);
        Time.timeScale = 1f;
    }

   
    public void WinGame()
    {
        gameOver = true;
        winScreen.SetActive(true);
        Time.timeScale = 0f;
    }

  
    public void LoseGame()
    {
        gameOver = true;
        Time.timeScale = 1f;   
        StartCoroutine(LoseSequence());
    }

    private IEnumerator LoseSequence()
    {
        
        yield return new WaitForSecondsRealtime(3f);

        loseScreen.SetActive(true);
        Time.timeScale = 0f;
    }

    
    public void Restart()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
