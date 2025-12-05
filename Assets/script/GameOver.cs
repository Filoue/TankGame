using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    [SerializeField] private BoxManager boxManager;
    [SerializeField] private GameObject gameOverUI;
    
    [SerializeField] private GameObject gameWinUI;
    [SerializeField] private DamageTaker damageTaker;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameWinUI.SetActive(false);
        gameOverUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (boxManager.boxesCount <= 0)
        {
            gameWinUI.SetActive(true);
        }
        if (damageTaker._hp <= 0)
        {
            gameOverUI.SetActive(true);
        }
    }
}
