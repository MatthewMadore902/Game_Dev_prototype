using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WinScript : MonoBehaviour
{
    //public TextMeshProUGUI WinText;
    public GameObject WinText;
    public PlayerMovement playerMovement;
    public EnemyController enemyMovement;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
	private void OnTriggerEnter(Collider other)
	{
        WinText.SetActive(true);
        
        playerMovement.enabled = false;
        enemyMovement.enabled = false;
	}
}
