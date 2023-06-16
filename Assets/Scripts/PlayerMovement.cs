using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    //Player speed
    public float moveSpeed;

    //Rigid Body access
    public Rigidbody2D rigidBody;

    //Player movement
    private Vector2 movementInput;

    //player animations
    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        //para sa player to pre kimi lang
        rigidBody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Once played or launched shesh
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W)) 
        {
            anim.SetTrigger("Move Up");
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            anim.SetTrigger("up pause");
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            anim.SetTrigger("Move Down");
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            anim.SetTrigger("down pause");
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            anim.SetTrigger("Move Right");
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            anim.SetTrigger("right pause");
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            anim.SetTrigger("Move Left");
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            anim.SetTrigger("left pause");
        }

    }
    //Fixed for physx kimi lang pre
    private void FixedUpdate()
    {
        //pampagalaw ng player
        rigidBody.velocity = movementInput * moveSpeed;
    }

    //input keybinds
    private void OnMove(InputValue inputValue)
    {
        // When A is pressed
        movementInput = inputValue.Get<Vector2>();  
    }
}
