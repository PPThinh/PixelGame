using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float walkSpeed = 1f;
    public float speed;
    public float runSpeed = 1.5f;
    public float collisionOffet = 0.05f;
    public ContactFilter2D movementFilter;
    Vector2 movementInput;
    Rigidbody2D rb;

    Animator animator;
    List<RaycastHit2D> castCollision = new List<RaycastHit2D>();

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    private void FixedUpdate()
    {
        if (movementInput != Vector2.zero)
        {
            bool success = TryMove(movementInput);
            if (!success)
            {
                success = TryMove(new Vector2(movementInput.x, 0));
                if (!success)
                    success = TryMove(new Vector2(0, movementInput.y));
            }

            animator.SetBool("isMoving", success);
        }
        else animator.SetBool("isMoving", false);
    }

    private void Update()
    {

        movementInput.x = Input.GetAxis("Horizontal");
        movementInput.y = Input.GetAxis("Vertical");
        if (movementInput != Vector2.zero)
        {
            animator.SetFloat("Horizontal", movementInput.x);
            animator.SetFloat("Vertical", movementInput.y);
            animator.SetFloat("Speed", movementInput.sqrMagnitude);
            animator.SetBool("isMoving", true);
        }
        else animator.SetBool("isMoving", false);

    }
    private bool TryMove(Vector2 direction)
    {
        int count = rb.Cast(direction, movementFilter, castCollision, speed * Time.deltaTime + collisionOffet);

        if (count == 0)
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                //Debug.Log("holding shift");
                speed = runSpeed;
            }
            else
            {
                //Debug.Log("not holding shift");
                speed = walkSpeed;
            }
            rb.MovePosition(rb.position + direction * speed * Time.deltaTime);
            return true;
        }
        else return false;
    }

}
