using UnityEngine;

public class JourNuit : MonoBehaviour
{
    public float rotationSpeed;
    float rotation;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate()
    {
        rotation = rotationSpeed * Time.deltaTime;
        transform.Rotate(rotation, 0 , 0);
    }
}
