using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement2 : MonoBehaviour
{
    // Start is called before the first frame update



    [SerializeField] private LayerMask platformlayerMask;
    private Rigidbody2D rigidbody2d;
    private BoxCollider2D boxCollider2d;
    void Awake()
    {
        rigidbody2d = transform.GetComponent<Rigidbody2D>();
        boxCollider2d = transform.GetComponent<BoxCollider2D>();
        rigidbody2d.gravityScale = -1;
    }

    // Update is called once per frame
    void Update()
    {
        if (isGrounded() && Input.GetKeyDown(KeyCode.W))
        {
            float jumpVelocity = 4f;
            rigidbody2d.velocity = Vector2.down * jumpVelocity;
        }

        HandleMovement();
    }

    private bool isGrounded()
    {
        RaycastHit2D raycasthit2d = Physics2D.BoxCast(boxCollider2d.bounds.center, boxCollider2d.bounds.size, 0f, Vector2.up, .1f, platformlayerMask);

        return raycasthit2d.collider != null;
    }


    private void HandleMovement()
    {
        float moveSpeed = 5f;
        if (Input.GetKey(KeyCode.A))
        {
            rigidbody2d.velocity = new Vector2(-moveSpeed, rigidbody2d.velocity.y);
        }
        else
        {
            if (Input.GetKey(KeyCode.D))
            {
                rigidbody2d.velocity = new Vector2(+moveSpeed, rigidbody2d.velocity.y);
            }
            else
            {
                rigidbody2d.velocity = new Vector2(0, rigidbody2d.velocity.y);
            }
        }
    }
}
