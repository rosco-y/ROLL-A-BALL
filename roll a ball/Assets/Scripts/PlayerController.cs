using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float _Speed = 2.0f;
    Rigidbody _rBody;
    void Start()
    {
        _rBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        _rBody.AddForce(new Vector3(h * _Speed, 0f, v * _Speed));
    }
}
