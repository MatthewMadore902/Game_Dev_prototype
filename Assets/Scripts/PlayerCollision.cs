using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour
{

	private void OnCollisionEnter(Collision other)
	{

		if (other.gameObject.CompareTag ("Enemy"))
		{

			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);


		}
	
	}

	void update()
	{

		//OnCollisionEnter();
	
	}

}
