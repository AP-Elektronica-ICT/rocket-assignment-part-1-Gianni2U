using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketController : MonoBehaviour
{
Rigidbody _rigidbody;



[SerializeField]  float rcsTime = 20f;
[SerializeField] float mainTime = 6f;

// Start is called before the first frame update
void Start()
{
    _rigidbody = GetComponent<Rigidbody>();
}

// Update is called once per frame
void Update()
{
    CheckIfThrusting();
    Rotate();
}

private void Rotate()
{

    float rotationSpeed = rcsTime * Time.deltaTime;
    _rigidbody.freezeRotation = true; //take manual control of rotation

    if (Input.GetKey(KeyCode.Q))
    {

        transform.Rotate(Vector3.forward * rotationSpeed);
    };
    if (Input.GetKey(KeyCode.D))
    {
        transform.Rotate(-Vector3.forward * rotationSpeed);
    };
    _rigidbody.freezeRotation = false; //release that control
}

private void CheckIfThrusting()
{
    if (Input.GetKey(KeyCode.Space))
    {
        _rigidbody.AddRelativeForce(Vector3.up * mainTime);

    }

}
}
