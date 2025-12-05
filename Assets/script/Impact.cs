using UnityEngine;

public class Impact : MonoBehaviour
{
    
    [SerializeField] private ParticleSystem _particleSystem;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (_particleSystem.time > _particleSystem.main.duration)
        {
            Destroy(gameObject);
        }
    }
}
