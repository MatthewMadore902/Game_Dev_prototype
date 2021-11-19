using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slime : MonoBehaviour
{

    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        OnColliderEnter();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnColliderEnter(Collider other)
    {
        if (other.name == "Player")
        {
            speed -= 10f;
        }
        else
        {
            
        }
    }
}
