using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform car;
    public Vector3 offset;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.position = car.position + offset;

    }
}
