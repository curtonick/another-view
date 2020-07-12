using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float movementSpeed = 3;
    public float rotateSpeed = 70;
    public float jumpForce = 300;
    public float timeBeforeNextJump = 1.2f;
    private float canJump = 0f;
    Animator anim;
    Rigidbody rb;

    void Start()
    {
        anim = transform.Find("Maae").GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        ControllPlayer();
    }

    void ControllPlayer()
    {
        float moveHorizontal = Input.GetAxisRaw("Horizontal");
        float moveVertical = Input.GetAxisRaw("Vertical");

        transform.Rotate(0.0f, Time.deltaTime * rotateSpeed * moveHorizontal, 0.0f);
        transform.Translate(Vector3.forward * moveVertical * movementSpeed * Time.deltaTime, Space.Self);
        anim.SetInteger("Walk", moveHorizontal != 0 || moveVertical != 0 ? 1 : 0);

        if (Input.GetButtonDown("Jump") && Time.time > canJump)
        {
            rb.AddForce(0, jumpForce, 0);
            canJump = Time.time + timeBeforeNextJump;
            anim.SetTrigger("jump");
        }
    }
}