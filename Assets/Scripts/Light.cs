using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Light : MonoBehaviour
{
    public bool on = true;
    public GameObject flashlight;


	private void Start()
	{

	}
	// Update is called once per frame
	void Update()
    {

        if (Input.GetKeyDown(KeyCode.F))
        {
            if (on == true)
            {
                flashlight.SetActive(false);
                on = false;
            }
           
            else
            {
                flashlight.SetActive(true);
                on = true;
            }
        }
    }
}
