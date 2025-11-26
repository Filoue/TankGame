using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class TankController : MonoBehaviour
{
    public Transform _turret;
    public Transform _canon;
    public Transform _canon2;
    
    public GameObject _ammoPrefab;
    
    public float _moveSpeed = 5f;
    public float _turnSpeed = 5f;
    public float _turretSpeed = 10f;
    public float _canonSpeed = 10f;
    
    Gamepad _gamepad;
    
    private List<GameObject> _ammo;
    
    private Rigidbody _rigidbody;

    private bool _isConnected;
    private float _turretInput;
    private float _moveInput;
    private float _turnInput;
    private float _canonInput;
    
    private float _attackInput;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _rigidbody.freezeRotation = true;
        
        _gamepad = Gamepad.current;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        /*
         * Autre manière d'utiliser les transform
         * transform.Rotate(new Vector3(0,_turnInput * _turnSpeed * Time.deltaTime,0));
         */
        
        // Moving Tank
        /*transform.Translate(Vector3.forward * _moveInput * _moveSpeed * Time.deltaTime);
        transform.Rotate(Vector3.up * _turnInput * _turnSpeed * Time.deltaTime);*/
        Vector3 velocity = this._moveInput * _moveSpeed * transform.forward;

        _rigidbody.linearVelocity = new Vector3(velocity.x, _rigidbody.linearVelocity.y, velocity.z);
        //_rigidbody.angularVelocity = _turnInput * Mathf.Deg2Rad  * _turnSpeed * transform.up;
        transform.Rotate(Vector3.up * _turnInput * _turnSpeed * Time.deltaTime);
        
        // Rotating the turret
        _turret.Rotate(new Vector3(0,_turretInput * _turretSpeed * Time.deltaTime, 0));
        _canon2.Rotate(Vector3.left * _canonInput * _canonSpeed * Time.deltaTime);
 
    }

    public void OnMove(InputAction.CallbackContext ctx)
    {
        Debug.Log("Move from" + ctx.ReadValue<float>());
        _moveInput =  ctx.ReadValue<float>();
    }

    public void OnTurn(InputAction.CallbackContext ctx)
    {
        Debug.Log("Turn from" + ctx.ReadValue<float>());
        _turnInput = ctx.ReadValue<float>();
    }

    public void OnTurretRotate(InputAction.CallbackContext ctx)
    {
        Debug.Log("Turret Rotate from" + ctx.ReadValue<float>());
        _turretInput = ctx.ReadValue<float>();
    }

    public void OnCanonUpDown(InputAction.CallbackContext ctx)
    {
        _canonInput = ctx.ReadValue<float>();
    }

    public void OnAttack(InputAction.CallbackContext ctx)
    {
        Instantiate(_ammoPrefab, _canon.position, _canon.rotation);
    }
    


}
