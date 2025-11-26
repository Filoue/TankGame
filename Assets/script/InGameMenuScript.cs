using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InGameMenuScript : MonoBehaviour
{
    [SerializeField] private GameObject uiMenu;
    private bool active;
    void Start()
    {
    }

    void Update()
    {
    }

    public void setMenu()
    {
        if (uiMenu.activeSelf == false)
        {
            Time.timeScale = 0;
            uiMenu.SetActive(true);
        }
        else
        {
            Time.timeScale = 1;
            uiMenu.SetActive(false);
        }
        
    }
    
    public void Resume()
    {
        Time.timeScale = 1;
        uiMenu.SetActive(false);
    }

    public void MainMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadSceneAsync(0);
    }
    
    public void Exit()
    {
        Application.Quit();
    }
    
}
