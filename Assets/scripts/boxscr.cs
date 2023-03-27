using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class boxscr : MonoBehaviour
{

	private int scene;
	private void Start()
	{
		scene = SceneManager.GetActiveScene().buildIndex;
	}

	private void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.CompareTag("apple"))
		{
			float konum = Random.Range(-3.0f, 12.0f);
			if (collision.gameObject.CompareTag("apple"))
			{
			
					collision.gameObject.transform.position = new Vector3(konum, 14.0f, -6.9f);
				
			
			}
		}
	}
}
