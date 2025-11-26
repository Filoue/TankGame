using UnityEngine;

public class DestroyTree : MonoBehaviour
{
 private void OnTriggerEnter(Collider other)
 {
     if (other.CompareTag("Bullet"))
     {
         Destroy(gameObject);
         Destroy(other.gameObject);
     }
 }
}
