using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public Rigidbody rb;
    public float speed;
    public bool canWalk;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate() // is voor het physics systeem, update elke physics frame
    {
        if (canWalk == true) // als je kan lopen dan
        {
            Vector3 InputDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")); // pakt de karakter input

            rb.MovePosition(transform.position + InputDirection * Time.deltaTime * speed);  // beweegt de karakter naar de input elke frame met de speed
        }
    }
}
