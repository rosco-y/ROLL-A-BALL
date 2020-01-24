using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerController : MonoBehaviour
{
    int _count = 0;

    public float _Speed = 2.0f;
    Rigidbody _rBody;
    public Text _CountText;
    
    void Start()
    {
        _rBody = GetComponent<Rigidbody>();
        _count = 0;
        displayScore();
    }

    void displayScore()
    {
        if (_count < 23)
            _CountText.text = $"Count: {_count}";
        else
            _CountText.text = "You Win!!!";
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        _rBody.AddForce(new Vector3(h * _Speed, 0f, v * _Speed));
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("pickup"))
        {
            other.gameObject.SetActive(false);
            _count++;
            displayScore();
        }
    }

}
