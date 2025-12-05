using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float _speed = 1000f;
    [SerializeField] private float _dps = 50f;
    
    [SerializeField] private ParticleSystem _impact;
    
    Rigidbody _rb;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
        _rb.AddRelativeForce(Vector3.forward * _speed, ForceMode.VelocityChange);
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnCollisionEnter(Collision collision)
    {
        OnTouch(collision.gameObject); 
        Debug.Log(collision.gameObject.name);
    }

    private void OnTouch(GameObject other)
    {
        if (other.TryGetComponent(out DamageTaker damageTaker))
        {
            damageTaker.TakeDamage(_dps * Time.deltaTime);
        }
        Instantiate(_impact, transform.position, transform.rotation);
        Destroy(gameObject);
    }


}
