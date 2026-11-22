using UnityEngine;

public class PlayerController : MonoBehaviour
{
  public float moveSpeed;
  public float jumpForce;
  private Rigidbody2D _rigidbody2D;
  private float horizontalInput;
  private bool isJumpPressed;
  public SpriteRenderer playerSprite;

  private void Awake()
  {
    _rigidbody2D = GetComponent<Rigidbody2D>();
  }

  private void Update()
  {
    horizontalInput = Input.GetAxis("Horizontal");

{
  
} 
    if (horizontalInput < 0)
    {
      playerSprite.flipX = true;
    }
    else if (horizontalInput > 0)
    {
      playerSprite.flipX = false;
    }


    if (Input.GetKeyDown(KeyCode.Space))
    {
        isJumpPressed = true;
    }

   
  }

  private void FixedUpdate()
  {
       _rigidbody2D.linearVelocity = new Vector2(horizontalInput * moveSpeed, _rigidbody2D.linearVelocity.y);

       if (isJumpPressed)
       {
        isJumpPressed = false;
        _rigidbody2D.linearVelocity = new Vector2(_rigidbody2D.linearVelocity.x, jumpForce);
       }
  }
}
