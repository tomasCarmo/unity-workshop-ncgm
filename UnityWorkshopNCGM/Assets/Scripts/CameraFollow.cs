using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform _player_transform;

    // Start is called before the first frame update
    void Start()
    {
        transform.Rotate(60,0,0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        transform.position = _player_transform.position + Vector3.back * 5.0f + Vector3.up * 7.0f;
    }
}
