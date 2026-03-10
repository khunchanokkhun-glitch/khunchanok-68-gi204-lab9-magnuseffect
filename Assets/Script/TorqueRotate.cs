using UnityEngine;
using UnityEngine.InputSystem;

public class TorqurTotate : MonoBehaviour
{
    public float TorqueSpeed;
    Rigidbody rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddTorque(new Vector3(TorqueSpeed, 0, 0));
    }
}