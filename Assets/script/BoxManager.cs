using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class BoxManager : MonoBehaviour
{
    [SerializeField] private List<DestroyBox> _boxes;
    
    public int boxesCount => _boxes.Count;
    public int MaxBoxes;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _boxes = GetComponentsInChildren<DestroyBox>().ToList();

        foreach (DestroyBox box in _boxes)
        {
            box.OnBoxDestroyed += RemoveBox;
        }
        
        MaxBoxes = _boxes.Count;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void RemoveBox(DestroyBox box)
    {
        _boxes.Remove(box);
    }
}
