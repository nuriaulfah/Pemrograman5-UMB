using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GerakanPlayer : MonoBehaviour
{
	public float kecepatan;
	Rigidbody rb;
	Animator anim;
	
	//sess 3
	public Transform playerPutaran;
	
	private void Awake()
	{
		rb = GetComponent<Rigidbody>();
		anim = GetComponent<Animator>();
	}
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Berjalan();
    }
	
	void Berjalan()
	{
		float jalan = Input.GetAxis("Horizontal");
		rb.linearVelocity = Vector3.right * jalan * kecepatan;
		//session 2
		anim.SetFloat("Kecepatan", Mathf.Abs(jalan), 0.1f, Time.deltaTime);
		//sess 3
		playerPutaran.localEulerAngles = new Vector3(0, jalan * 90, 0);
	}
	
	private void OnCollisionEnter(Collision collision)
	{
		if(collision.collider.CompareTag("virus"))
		{
			Time.timeScale = 0;
			Destroy(gameObject);
		}
	}
}