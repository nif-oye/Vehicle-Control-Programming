using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10f;
    public float turnSpeed;
    public float horizontalInput;
    void Start()
    {
        
    }
    
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(speed * Time.deltaTime * Vector3.forward);
        transform.Translate(turnSpeed * Time.deltaTime * Vector3.right * horizontalInput);
    }
}
