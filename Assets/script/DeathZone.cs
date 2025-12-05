using System;
using UnityEngine;

public class DeathZone : MonoBehaviour
{
    [SerializeField] private DamageTaker damageTaker;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            damageTaker._hp = 0;
        }
    }
}
