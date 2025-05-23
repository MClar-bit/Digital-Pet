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
        //save the scene
        PlayerPrefs.SetInt("hunger", 10);
        PlayerPrefs.SetInt("clean", 10);

        //open scene
        SceneManager.LoadScene(gameNum);

    }
}
