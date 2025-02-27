using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody _rb;
    private float _speed = 4.0f;
    private Vector3 _movement;

    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        float horizontalValue = Input.GetAxis("Horizontal");
        float verticalValue = Input.GetAxis("Vertical");

        _movement.Set(horizontalValue, 0f, verticalValue);

        if(horizontalValue != 0 || verticalValue != 0)
        {
            _movement.Normalize();

            Vector3 deltaMovement = _movement * _speed * Time.deltaTime;
            _rb.MovePosition(transform.position + deltaMovement); 
        }
    }
}
