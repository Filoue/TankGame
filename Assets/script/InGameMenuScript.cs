using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InGameMenuScript : MonoBehaviour
{
    [SerializeField] private GameObject uiMenu;
    [SerializeField] private GameObject _gameOverMenu;
    [SerializeField] private GameObject _player;
    private bool active;
    void Start()
    {
        _gameOverMenu.SetActive(false);
    }

    void Update()
    {
        if (_player == null)
            _gameOverMenu.SetActive(true);
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
