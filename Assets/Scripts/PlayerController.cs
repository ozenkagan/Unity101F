using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] public float speed;
    private Vector3 moveDirection;

    private bool isGrounded;
    private bool jump;
    [SerializeField] public float jumpPower = 1f;
    private Vector3 jumpDirection;
    private Rigidbody rb;
    private const int MAX_JUMP = 10;
    private int currentJump = 0;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
rb = GetComponent<Rigidbody>();

        jump = Input.GetButton("Jump");

        moveDirection = new Vector3(moveHorizontal, 0.0f, moveVertical);
        Move();
        Jump();
    }

    void FixedUpdate()
    {
        
    }

    void Move()
    {
        rb.AddForce(moveDirection * speed);
            currentJump++;
            Debug.Log(currentJump);
            Debug.Log(isGrounded);
    }

    
    void Jump()
    {
        //isGrounded = Physics.Raycast(transform.position, Vector3.down, 3f);
        LayerMask layer = 1 << gameObject.layer;
        layer = ~layer;
        isGrounded = Physics.CheckSphere(transform.position, 2f, layer);

        if((jump) && (isGrounded ||  MAX_JUMP > currentJump))
        {
            rb.AddForce(jumpDirection.normalized * jumpPower, ForceMode.Impulse);
            isGrounded = false;
            currentJump++;
            Debug.Log(currentJump);
            Debug.Log(isGrounded);
        }
    }

    private void OnCollisonEnter(Collision collision)
    {
        
    }

    private void OnCollisionStay(Collision collision)
    {
        jumpDirection = Vector3.zero;
        currentJump = 0;
        
        
        foreach(ContactPoint c in collision.contacts)
        {
            jumpDirection += c.normal;
            isGrounded = true;
            currentJump = 0;
        }
      
    }
  
}
