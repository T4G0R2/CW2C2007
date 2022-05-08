using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float XInput;
    private float ZInput;
    private Vector3 velocity;
    private Vector3 LastPosition;
    public AudioSource Footsteps;

    public float Gravity = -9.81f;
    public CharacterController Controller;
    public float Speed = 12f;
    public float JumpHeight = 3f;
    public GameObject Player;

    public Transform GroundCheck;
    public float GroundDistance = 0.4f;
    public LayerMask GroundMask;

    public bool IsGrounded;

    void Start()
    {
        LastPosition = Player.transform.position;
        Footsteps = Player.GetComponent<AudioSource>();
    }

    void Update()
    {
        IsGrounded = Physics.CheckSphere(GroundCheck.position, GroundDistance, GroundMask);

        if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
        {
            Speed = 20f;
        }
        else Speed = 12f;

        if (IsGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        if (Input.GetButtonDown("Jump") && IsGrounded)
        {
            velocity.y = Mathf.Sqrt(JumpHeight * -2f * Gravity);
        }

        XInput = Input.GetAxis("Horizontal");
        ZInput = Input.GetAxis("Vertical");

        Vector3 Move = transform.right * XInput + transform.forward * ZInput;
        Controller.Move(Move * Speed * Time.deltaTime);

        velocity.y += Gravity * Time.deltaTime;
        Controller.Move(velocity * Time.deltaTime);

        if (LastPosition != Player.transform.position)
        {
            //-- Do whatever it is you need to do when the object is moving.
            if (Footsteps.isPlaying == false)
            {
                Footsteps.Play();
            }
        }
        LastPosition = Player.transform.position;
    }
}
