using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject _Player;
    Vector3 _offset;
    void Start()
    {
        _offset = _Player.transform.position - transform.position;
    }
    void LateUpdate()
    {
        transform.position = _Player.transform.position - _offset;
    }
}
