using System;
using UnityEngine;

public class DestroyBox : MonoBehaviour
{
    [SerializeField] private float _capForce = 100, _boxForce = 100;
    
    private Rigidbody _caprb;
    private Rigidbody _boxrb;
    
    public Action<DestroyBox> OnBoxDestroyed;

    void Start()
    {
        if (transform.childCount > 0)
        {
            // Récupère le premier enfant (index 0)
            Transform childTransform = transform.GetChild(1);
            _caprb = childTransform.GetComponent<Rigidbody>();
            childTransform = transform.GetChild(0);
            _boxrb = childTransform.GetComponent<Rigidbody>();
        }
    }


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
