using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    private Rigidbody rb;
	public float speed= 10f;
	public bool onGround= true;
	
    // Start is called before the first frame update
    void Start()
    {
       rb= GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
		
	}

	void FixedUpdate()
	{
		float horizontal= Input.GetAxis("Horizontal") * Time.deltaTime * speed;
		float vertical= Input.GetAxis("Vertical") * Time.deltaTime * speed;

		transform.Translate(horizontal, 0, vertical);

		if (Input.GetButtonDown("Jump") && onGround== true)
		{
			rb.AddForce(new Vector3(0,20,0),ForceMode.Impulse);
		}
	}
	
	private void OnCollisionEnter(Collision collision)
	{
		if(collision.gameObject.name == "environnement")
		{
			onGround= true;
		}
		if(collision.gameObject.name == "plateforme")
		{
			onGround= true;
		}
		if(collision.gameObject.name == "ville")
		{
			onGround= true;
		}
		if(collision.gameObject.name == "Stairs")
		{
			onGround= true;
		}
	}

	private void OnCollisionExit(Collision collision)
	{
		onGround= false;
	}
}