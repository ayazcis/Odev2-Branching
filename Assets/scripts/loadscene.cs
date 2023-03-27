using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadscene : MonoBehaviour
{
 
	private int scene;
	private void Start()
	{
		scene = SceneManager.GetActiveScene().buildIndex;
		
	}
	
	public void pýrt()
	{
		SceneManager.LoadScene(scene + 1);
	}
	
}
