using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//Basic Player Script//
//controls: 
//A, D, Left, Right to move
//Left Alt to attack
//Space to jump
//Z is to see dead animation

public class Demo : MonoBehaviour {

    public GameObject BulletEmitter;
    public GameObject Bullet;

	//variable for how fast player runs//
	private float speed = 5f;
    public Vector3 position;
    private bool facingRight = true;
	private Animator anim;
	bool grounded = false;
	public Transform groundCheck;
	float groundRadius = 0.2f;
	public LayerMask whatIsGround;
    public bool Xminenabled = false;
    public float Xminvalue = 0;


    //variable for how high player jumps//
    [SerializeField]
	private float jumpForce = 300f;

	public Rigidbody2D rb { get; set; }

	bool dead = false;
	bool attack = false;

	void Start () {
         position = transform.position;
		GetComponent<Rigidbody2D> ().freezeRotation = true;
		rb = GetComponent<Rigidbody2D> ();
		anim = GetComponentInChildren<Animator> ();

	}

	void Update()
	{
		HandleInput ();
        position = transform.position;
        position.x = Mathf.Clamp(position.x, Xminvalue, position.x);
        position.y = Mathf.Clamp(position.y, -3.69f, 3.1f);
        transform.position = position;

    }

    //movement//
    void FixedUpdate ()
	{
		grounded = Physics2D.OverlapCircle (groundCheck.position, groundRadius, whatIsGround);
		anim.SetBool ("Ground", grounded);

		float horizontal = Input.GetAxis("Horizontal");
		if (!dead && !attack)
		{
			anim.SetFloat ("vSpeed", rb.velocity.y);
			anim.SetFloat ("Speed", Mathf.Abs (horizontal));
			rb.velocity = new Vector2 (horizontal * speed, rb.velocity.y);
		}
		if (horizontal > 0 && !facingRight && !dead && !attack) {
			Flip (horizontal);
		}

		else if (horizontal < 0 && facingRight && !dead && !attack){
			Flip (horizontal);
            Xminvalue = transform.position.x - 7.5f;
        }
	}

	//attacking and jumping//
	private void HandleInput()
	{
		if (Input.GetKeyDown (KeyCode.LeftAlt) && !dead) 
		{
			attack = true;
			anim.SetBool ("Attack", true);
			anim.SetFloat ("Speed", 0);

		}
		if (Input.GetKeyUp(KeyCode.LeftAlt))
			{
			attack = false;
			anim.SetBool ("Attack", false);
            //The Bullet instantiation happens here.
            GameObject Temporary_Bullet_Handler;
            Temporary_Bullet_Handler = Instantiate(Bullet, BulletEmitter.transform.position, BulletEmitter.transform.rotation) as GameObject;
        }

		if (grounded && Input.GetKeyDown(KeyCode.Space) && !dead)
		{
			anim.SetBool ("Ground", false);
			rb.AddForce (new Vector2 (0,jumpForce));
		}

		//dead animation for testing//
		if (Input.GetKeyDown (KeyCode.Z)) 
		{
            Die();
		}
	}

    public void Die()
    {
        if (!dead)
        {
            anim.SetBool("Dead", true);
            anim.SetFloat("Speed", 0);
            dead = true;
        }
        else
        {
            anim.SetBool("Dead", false);
            dead = false;
        }
    }
	private void Flip (float horizontal)
	{
			facingRight = !facingRight;
        transform.Rotate(0f, 180f, 0f);
	}
}
