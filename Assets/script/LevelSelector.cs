using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelector : MonoBehaviour
{
    public void LevelOne()
    {
        SceneManager.LoadScene("Scenes/Lvl1");
    }

    public void LevelTwo()
    {
        SceneManager.LoadScene("LevelTwo");
    }
    
    public void LevelThree()
    {
        SceneManager.LoadScene("LevelThree");
    }
    
    public void BackToMenu()
    {
        SceneManager.LoadScene("Scenes/Menu");
    }
}
