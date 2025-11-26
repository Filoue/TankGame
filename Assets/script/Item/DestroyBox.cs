using UnityEngine;

public class DestroyBox : MonoBehaviour
{
    [SerializeField] private float _capForce, _boxForce;
    
    [SerializeField] private Rigidbody _caprb;
    [SerializeField] private Rigidbody _boxrb;
    
    private bool shouldExplode;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (shouldExplode)
        {
            _caprb.AddForce(Vector3.up * _capForce, ForceMode.Impulse);
            _boxrb.AddForce(Vector3.forward * _boxForce, ForceMode.Impulse);
            shouldExplode = false;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Bullet"))
        {
            shouldExplode = true;
        }
    }
}
