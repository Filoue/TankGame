using System;
using UnityEngine;

public class DestroyBox : MonoBehaviour
{
    [SerializeField] private float _capForce, _boxForce;
    
    [SerializeField] private Rigidbody _caprb;
    [SerializeField] private Rigidbody _boxrb;
    
    public Action<DestroyBox> OnBoxDestroyed;
    


    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Bullet") || other.CompareTag("Player"))
        {
            _caprb.AddForce(Vector3.up * _capForce, ForceMode.Impulse);
            _boxrb.AddForce(Vector3.forward * _boxForce, ForceMode.Impulse);
            Collider myCollider = GetComponent<Collider>();
            Destroy(myCollider);
            
            OnBoxDestroyed.Invoke(this);
        }
    }
}
