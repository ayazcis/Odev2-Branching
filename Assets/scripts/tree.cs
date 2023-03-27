using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tree : MonoBehaviour
{
    // Start is called before the first frame update
    void Update()
    {
        Invoke(nameof(rotate), 0.4f);
        Invoke(nameof(delayrotate), 0.6f);
    }

    // Update is called once per frame
    public void rotate()
    {
        transform.Rotate(0.2f, 0, 0);
       
    }
    public void delayrotate()
	{
        transform.Rotate(-0.2f, 0, 0);
    }
}
