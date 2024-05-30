using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPad : MonoBehaviour
{
    Rigidbody rb;

    private void OnTriggerEnter(Collider other)
    {
        rb = other.GetComponent<Rigidbody>();

        if (rb != null)
        {
            rb.velocity = Vector3.zero;
            rb.AddForce(Vector3.up * 200, ForceMode.Impulse);
        }
    }
}
