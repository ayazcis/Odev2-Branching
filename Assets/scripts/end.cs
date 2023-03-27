using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class end : MonoBehaviour
{
    private float time;
    public GameObject saniye;

    // Start is called before the first frame update
 

    // Update is called once per frame
    void Update()
    {
        Invoke(nameof(endit), 20.0f);
        Invoke(nameof(sanye), 1.8f);
    }
    public void endit()
	{
		if (baskett.score > 0)
		{
            SceneManager.LoadScene(4);
        }
        else if (baskett.score == 0)
		{
            SceneManager.LoadScene(5);
		}
        
    }
    public void sanye()
	{
        Destroy(saniye.gameObject);
	}
}
