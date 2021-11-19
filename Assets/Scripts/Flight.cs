using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flight : MonoBehaviour
{
    public Light flashlight;
    public bool usable = true;
    // Start is called before the first frame update
    void Start()
    {
        flashlight.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F) && usable)
        {
            flashlight.enabled = !flashlight.enabled;
        }
    }
}
