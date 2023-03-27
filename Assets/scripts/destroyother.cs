using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyother : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject canva;
   

    // Update is called once per frame
    void Update()
    {
        Invoke(nameof(des), 1.8f);
    }
    public void des()
	{
        Destroy(canva.gameObject);
	}
}
