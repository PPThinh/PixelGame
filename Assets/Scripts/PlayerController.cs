using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 1f;
    public float collisionOffet = 0.05f; // khoang cach va cham obj khac
    public ContactFilter2D movementFilter; // 
    Vector2 movementInput;
    Rigidbody2D rb;

    Animator animator;
    List<RaycastHit2D> castCollision = new List<RaycastHit2D>();
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
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
        movementInput.x = Input.GetAxisRaw("Horizontal");
        movementInput.y = Input.GetAxisRaw("Vertical");
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
        int count = rb.Cast(direction, movementFilter, castCollision, moveSpeed * Time.deltaTime + collisionOffet);

        if (count == 0)
        {
            rb.MovePosition(rb.position + direction * moveSpeed * Time.deltaTime);
            return true;
        }
        else return false;
    }

    void OnMove(InputValue movementValue)
    {
        movementInput = movementValue.Get<Vector2>();
    }
}
