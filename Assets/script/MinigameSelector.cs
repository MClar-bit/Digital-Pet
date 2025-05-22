using UnityEngine;
using UnityEngine.SceneManagement;
public class Minigame : MonoBehaviour
{
    public int gameNum;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    public void OpenGame()
    {
        SceneManager.LoadScene(gameNum);
        PlayerPrefs.SetInt("hunger", 10);
        PlayerPrefs.SetInt("")

    }
}
