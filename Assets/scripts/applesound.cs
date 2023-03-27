using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class applesound : MonoBehaviour
{
    public AudioSource apple;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	private void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.CompareTag("basket"))
		{
            apple.Play();
		}
	}
}
