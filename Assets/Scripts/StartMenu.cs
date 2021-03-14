using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartMenu : MonoBehaviour
{
    public InputField textBox;
    public Dropdown lifeTotal;

    public void StartGame()
    {
        SceneManager.LoadScene("MainLevel");
    }

    public void Quit()
    {
        Debug.Log("Quit");
        Application.Quit();
    }

    public void saveName()
    {
        PlayerPrefs.SetString("playerName", textBox.text);
        Debug.Log(PlayerPrefs.GetString("playerName"));
    }

    public void setRotationSpeed()
    {
        //PlayerPrefs.SetFloat("spinSpeed", );
        //Debug.Log(PlayerPrefs.GetFloat("spinSpeed"));
    }

    public void setArrowSpeed()
    {
        //PlayerPrefs.SetInt("arrowSpeed", );
        //Debug.Log(PlayerPrefs.GetInt("arrowSpeed"));
    }

    public void setLifeTotal()
    {
        switch(lifeTotal.value)
        {
            case 0:
                PlayerPrefs.SetInt("totalLives", 1);
                break;

            case 1:
                PlayerPrefs.SetInt("totalLives", 2);
                break;

            case 2:
                PlayerPrefs.SetInt("totalLives", 3);
                break;
        }
        Debug.Log(PlayerPrefs.GetInt("totalLives"));
    }
}
