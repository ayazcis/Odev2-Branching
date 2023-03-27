using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scorecont : MonoBehaviour
{
	private int scen;
	public GameObject canva;
	private void Start()
	{
		scen = SceneManager.GetActiveScene().buildIndex;
		
	}


	// Update is called once per frame
	void Update()
    {
        Invoke(nameof(next), 20.0f);
		Invoke(nameof(caca), 1.0f);

    }
    public void next()
	{
        SceneManager.LoadScene(scen+1);
	}
	public void caca()
	{
		Destroy(canva.gameObject);
	}
}
