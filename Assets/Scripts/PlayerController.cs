using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Rigidbody2D rb;
    public Animator animator;
    public SpriteRenderer spriteRenderer;

    Vector2 movement;

    public IInteractable currentInteractable;

    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        if(movement.x < 0)
            spriteRenderer.flipX = true;
        else if(movement.x > 0)
            spriteRenderer.flipX = false;

        if (animator != null)
        {
            if(movement.x != 0)
                animator.SetBool("Horizontal", true);
            else
                animator.SetBool("Horizontal", false);

            if (movement.y > 0)
            {
                animator.SetBool("VerticalUp", true);
                animator.SetBool("VerticalDown", false);
            }
            else if(movement.y < 0)
            {
                animator.SetBool("VerticalDown", true);
                animator.SetBool("VerticalUp", false);
            }
            else
            {
                animator.SetBool("VerticalUp", false);
                animator.SetBool("VerticalDown", false);
            }

            animator.SetFloat("Speed", movement.sqrMagnitude);
        }

        if(Input.GetButtonDown("Fire1") && currentInteractable != null)
        {
            Interact();
        }
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    } 

    public void SetCurrentInteractable(IInteractable interactable)
    {
        currentInteractable = interactable;
    }

    void Interact()
    {
        currentInteractable.Interact();
    }
}
