using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    [SerializeField] private GameObject _mainPanel;
    [SerializeField] private GameObject _settingsPanel;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SetMainPenel();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetMainPenel()
    {
        _mainPanel.SetActive(true);
        _settingsPanel.SetActive(false);
    }

    public void SetSettingsPenel()
    {
        _settingsPanel.SetActive(true);
        _mainPanel.SetActive(false);
    }

    public void Play()
    {
        SceneManager.LoadSceneAsync(1);
    }

    public void Exit()
    {
        Application.Quit();
    }
}
