using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class playagain : MonoBehaviour
{
	public TextMeshProUGUI text;
	public GameObject button;
	private void Update()
	{
		Invoke(nameof(wakebutton), 8.0f);
		text.text = "Score:" + baskett.score.ToString();
	}
	public void again()
	{
		SceneManager.LoadScene(0);
		baskett.score = 0;
	}
	public void wakebutton()
	{
		button.gameObject.SetActive(true);
	}
}
