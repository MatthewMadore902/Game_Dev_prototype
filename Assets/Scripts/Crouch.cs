using UnityEngine;

public class Crouch : MonoBehaviour
{
    public KeyCode crouchKey = KeyCode.C;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown[crouchKey])
        {
            Debug("Crouch");
        }
    }
}
