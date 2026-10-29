using JetBrains.Annotations;
using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering;

public class PlayerController : MonoBehaviour
{

    private Rigidbody rb;
    public float JumpForce = 8f;
    private float HorizontalVelocity = 0;
    private float VerticalVelocity = 0;
    [SerializeField] private float speed = 2f;
    [SerializeField] private LayerMask _groundLayer;
    private bool isGrounded;

    


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.RightArrow))
        {
            HorizontalVelocity = 1f;
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            HorizontalVelocity = -1f;
        }
        else
        {
            HorizontalVelocity = 0f;
        }

       




       if (Input.GetKey(KeyCode.UpArrow))
        {
            VerticalVelocity = 1f;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            VerticalVelocity = -1f;
        }
        else
        {
            VerticalVelocity = 0f;
        }



        rb.linearVelocity = new Vector3(HorizontalVelocity * speed, rb.linearVelocity.y, VerticalVelocity * speed);

        // jump

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(new Vector3(0, JumpForce, 0), ForceMode.Impulse);
            isGrounded = false;

        }

       
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (((1 << collision.gameObject.layer) & _groundLayer.value) !=0)
        {
            isGrounded = true;

        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (((1 << collision.gameObject.layer) & _groundLayer.value) !=0)
        {
            isGrounded = false;

        }
    }

  


}
