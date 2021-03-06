using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerMovement : MonoBehaviour
{
    //Camera cam;
    public CharacterController controller;

    public float speed = 12f;
    public float gravity = -9.81f;
    public float jumpHeight = 3f;
    
    public Transform groundCheck;
    public float gourndDistance = 0.4f;
    public LayerMask groundMask;

    bool isGrounded;

    public float currentSpeed;
    public bool isCrouching;
    private Vector3 originalCenter;
    private float originalHeight = 3.8f;
    private float originalMoveSpeed;

    public TextMeshProUGUI CountText;
    public int count;

    public bool isSprinting;
    public GameObject Win;


    Vector3 velocity;

    public bool slime;

    void Start()
    {
        //cam = Camera.main;
        transform.tag = "Player";
        controller = GetComponent<CharacterController>();
        originalCenter = controller.center;
        originalHeight = controller.height;
        originalMoveSpeed = speed;
        SetCountText();
    }

    void SetCountText()
    {
        CountText.text = "Count:" + count.ToString();

    }
	
	// Update is called once per frame
	void Update()
    {
        currentSpeed = controller.velocity.magnitude;
        isGrounded = Physics.CheckSphere(groundCheck.position, gourndDistance, groundMask);

        if(isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);

        if(Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);

        if (Input.GetButtonDown("Crouch") && isSprinting == false)
        {
            controller.height = 1.3f;
            controller.center = new Vector3(0f, 0f, 0f);
            speed = 3f;
            isCrouching = true;
           

        }

        if (!Input.GetButton("Crouch") && isCrouching)
        {
            controller.height = originalHeight;
            controller.center = originalCenter;
            isCrouching = false;
            speed = originalMoveSpeed;
        }

        if (Input.GetButton("Sprint") && isCrouching == false)
        {
            isSprinting = true;
            speed = 30f;
           
        }
        if (!Input.GetButton("Sprint") && isSprinting)
        {
            speed = originalMoveSpeed;
            isSprinting = false;
        }

        
    }
	void OnTriggerEnter(Collider other)
	{
        if (other.tag == "Slime")
        {
            isSprinting = false;
            slime = true;
            speed = 5f;
        }
        else 
        {
            slime = false;
        }
        if (other.gameObject.CompareTag("Salt"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;

            SetCountText();
        }
        if (count >= 3)
        {
            Win.SetActive(true);
        }
    }
}
