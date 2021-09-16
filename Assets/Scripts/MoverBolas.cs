using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MoverBolas : MonoBehaviour
{
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnAMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>();
    }

    void FixedUpdate()
    {
        
    }
}
  