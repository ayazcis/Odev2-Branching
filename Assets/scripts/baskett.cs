using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class baskett : MonoBehaviour
{
	private int scene;
	public GameObject button;
	public float hýz = 4.0f;
	static public int score = 0;
	public TextMeshProUGUI text;
	private void Start()
	{
		scene = SceneManager.GetActiveScene().buildIndex;
	}
	private void Update()
	{
		if (Input.GetKey(KeyCode.LeftArrow))
		{
			transform.Translate(-hýz * Time.deltaTime, 0, 0);
		}
		if (Input.GetKey(KeyCode.RightArrow))
		{
			transform.Translate(hýz * Time.deltaTime, 0, 0);
		}
		Invoke(nameof(but), 13.0f);
	}
	private void OnCollisionEnter(Collision collision)
	{
		float konum = Random.Range(-3.0f, 12.0f);
		if (collision.gameObject.CompareTag("apple"))
		{
			score++;
			text.text = score.ToString();
		
				collision.gameObject.transform.position = new Vector3(konum, 14.0f, -6.9f);
			
	
			
		}
	}
	public void but()
	{
		button.gameObject.SetActive(true);
	}
}
