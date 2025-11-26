using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float _speed = 1000f;
    
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
        Destroy(gameObject);
        Debug.Log(collision.gameObject.name);
    }


}
