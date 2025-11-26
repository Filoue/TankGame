using UnityEngine;

public class towerAI : MonoBehaviour
{
    [SerializeField] Transform _turret;
    [SerializeField] Transform _player;
    
    [SerializeField] GameObject _ammoPrefab;
    
    [SerializeField] float _turretSpeed = 20f;
    [SerializeField] float _maxDistance = 15f;
    [SerializeField] float _betweenShots = 5f;
    [SerializeField] float _nextTimeToFire;
    
    private Time _time;
    
    // Update is called once per frame
    void Update()
    {
        if (_player == null)
        {
            // Tente de trouver le joueur s'il n'est pas assigné dans l'Inspector
            GameObject joueur = GameObject.FindWithTag("Player");
            if (joueur != null)
            {
                if (Time.time <= _nextTimeToFire)
                {
                    
                }
                _player = joueur.transform;
            }
        }

        float distance = Vector3.Distance(_turret.position, _player.position);
        if (distance <= _maxDistance)
        {
            FollowTarget();
            
        }
    }

    private void FollowTarget()
    {
        Vector3 directionToTarget = _player.position - transform.position;
        
        Quaternion rotationDesiree = Quaternion.LookRotation(directionToTarget);


        _turret.rotation = Quaternion.Slerp(
            _turret.rotation,
            rotationDesiree,
            _turretSpeed * Time.deltaTime);
    }
}
