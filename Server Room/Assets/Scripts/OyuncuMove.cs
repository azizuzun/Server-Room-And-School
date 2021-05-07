using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OyuncuMove : MonoBehaviour
{
    
    //public bool acikMi = false;
    public Transform player;
    //public Transform animationPos;
    //public bool icerdeMi = false;
    [SerializeField] private string horizontalInputName;
    [SerializeField] private string verticalInputName;
    [SerializeField] private float movementSpeed;
    private float backw;
    float h;
    float v;
    private CharacterController charController;

    [SerializeField] private AnimationCurve jumpFallOff;
    [SerializeField] private float jumpMultiplier;
    [SerializeField] private KeyCode jumpKey;

    Vector3 moveDir = Vector3.zero;
    float sprint;
    CharacterController controller;
    Animator anim;

    void Start()
    {
       
        controller = GetComponent<CharacterController>();
        anim = GetComponent<Animator>();
    }
    private bool isJumping;
   
    private void Awake()
    {
        charController = GetComponent<CharacterController>();
    }
    
    private void Update()
    {
        
        v = Input.GetAxis("Vertical");
        h = Input.GetAxis("Horizontal");
        if (Input.GetKeyDown(KeyCode.Escape) == true)
        {
            Application.Quit();
        }
        PlayerMovement();
        if (controller.isGrounded)
        {
            if (Input.GetKey(KeyCode.W))
            {
                anim.SetFloat("Walk", v);
                movementSpeed = 3;
                moveDir = new Vector3(0, 0, 1);
                moveDir *= movementSpeed;
                moveDir = transform.TransformDirection(moveDir);

            }
            if (Input.GetKey(KeyCode.S))
            {
                backw = 0.4f;
                anim.SetFloat("Backward", backw);
                movementSpeed = 2;
                moveDir = new Vector3(0, 0, -1);
                moveDir *= movementSpeed;
                moveDir = transform.TransformDirection(moveDir);

            }
            if (Input.GetKey(KeyCode.D))
            {
                anim.SetFloat("Right", h);
                movementSpeed = 1;

                moveDir = new Vector3(1, 0, 0);
                moveDir *= movementSpeed;
                moveDir = transform.TransformDirection(moveDir);

            }
            if (Input.GetKey(KeyCode.A))
            {

                anim.SetFloat("Left", 1);
                movementSpeed = 1;
                moveDir = new Vector3(-1, 0, 0);
                moveDir *= movementSpeed;
                moveDir = transform.TransformDirection(moveDir);

            }
            if (Input.GetKey(KeyCode.Space))
            {

                anim.SetFloat("Jump", 1);
                movementSpeed = 1;
                moveDir = new Vector3(0, 1, 1);
                moveDir *= movementSpeed;
                moveDir = transform.TransformDirection(moveDir);

            }
            /*if (icerdeMi)
            {
                if (Input.GetKey(KeyCode.E))
                {
                    player.position = animationPos.position;
                    player.rotation = animationPos.rotation;
                    acikMi = !acikMi;
                    anim.SetFloat("Typing", 1);


                }
            }*/
            /*if (Input.GetKey(KeyCode.LeftShift))
            {
                movementSpeed = 6;
                sprint = 6;
                anim.SetFloat("Sprint", sprint);

                moveDir = new Vector3(0, 0, 1);
                moveDir *= movementSpeed;
                moveDir = transform.TransformDirection(moveDir);

            }*/
        }

        if (Input.GetKeyUp(KeyCode.W))
        {
            anim.SetFloat("Walk", 0);
            
            moveDir = new Vector3(0, 0, 0);

        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            backw = 0;
            anim.SetFloat("Backward", backw);

            moveDir = new Vector3(0, 0, 0);

        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            anim.SetFloat("Left", 0);

            moveDir = new Vector3(0, 0, 0);

        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            anim.SetFloat("Right", 0);

            moveDir = new Vector3(0, 0, 0);

        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            anim.SetFloat("Jump", 0);

            moveDir = new Vector3(0, 0, 0);

        }
        
       /* if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            sprint = 0;
            anim.SetFloat("Sprint", sprint);

            moveDir = new Vector3(0, 0, 0);

        }*/

    }
    
    /*Kullanıcı Hareket ve Hızı*/
    private void PlayerMovement()
    {
        float horizInput = Input.GetAxis(horizontalInputName) * movementSpeed;
        float vertInput = Input.GetAxis(verticalInputName) * movementSpeed;
        
        Vector3 forwardMovement = transform.forward * vertInput;
       
        Vector3 rightMovement = transform.right * horizInput;
        
        charController.SimpleMove(forwardMovement + rightMovement);

        //JumpInput();

    }
    /*Zıplama Tuşunu Ayarlıyoruz.*/
    /*private void JumpInput()
    {
        if (Input.GetKeyDown(jumpKey) && !isJumping)
        {
            isJumping = true;
            StartCoroutine(JumpEvent());
        }
    }
    
    /*Zıplama Eveenti*/
    /*private IEnumerator JumpEvent()
    {
        charController.slopeLimit = 90.0f;
        float timeInAir = 0.0f;

        do
        {
            float jumpForce = jumpFallOff.Evaluate(timeInAir);
            charController.Move(Vector3.up * jumpForce * jumpMultiplier * Time.deltaTime);
            timeInAir += Time.deltaTime;
            yield return null;
        } while (!charController.isGrounded && charController.collisionFlags != CollisionFlags.Above);

        charController.slopeLimit = 45.0f;
        isJumping = false;
    }*/

     
     /*void OnGUI()
     {
       GUI.TextField(new Rect(510, 20, 250, 20), "Yukardan Görünüm İçin M tuşuna basınız");


     }*/
    void DoMyWindow(int windowID)
    {

        



    }
}