using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private bool gameHasEnded = false;

    public Rotator rotator;
    public Spawner spawner;

    public Animator animator;

    public Text NameBox;
    public Text LifeBox;

    void Start()
    {
        NameBox.text = PlayerPrefs.GetString("playerName");
    }

    void Update()
    {
        int lifeCount = PlayerPrefs.GetInt("totalLives");
        LifeBox.text = lifeCount.ToString();
    }

    public void EndGame()
    {
        if(gameHasEnded)
            return;
        
        rotator.enabled = false;
        spawner.enabled = false;

        animator.SetTrigger("EndGame");

        gameHasEnded = true;

    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void EndScene()
    {
        SceneManager.LoadScene("Exit");
    }
}
