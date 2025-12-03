using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HUDmanager : MonoBehaviour
{
    [SerializeField] private TMP_Text _text;
    [SerializeField] private Image _gaugeFill;
    
    [SerializeField] private BoxManager _boxManager;
    
    void Start()
    {
        
    }

    void Update()
    {
        SetCounter(_boxManager.boxesCount,_boxManager.MaxBoxes );
    }

    public void SetCounter(int count, int maxCount)
    {
        _text.text = count.ToString("D2") + " | " + maxCount.ToString("D2");
        _gaugeFill.fillAmount = (float)count / maxCount;
    }
}
