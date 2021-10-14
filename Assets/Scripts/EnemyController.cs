using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class EnemyController : MonoBehaviour
{
    public float lookRadius = 10f;
    

    Transform target;
    NavMeshAgent agent;


    // you forgot to lock your PC hehe - Abby <3 <X


    // Start is called before the first frame update
    void Start()
    {
        target = PlayerManager.instance.player.transform;
        GameObject.FindGameObjectWithTag("Player");
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(target.position, transform.position);

        if (distance <= lookRadius)
        {
            agent.SetDestination(target.position);
        }
        if (distance < 70f)
        {

            agent.speed = 7.0f;

        }

    }

    void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Player")
        {
            SceneManager.LoadScene("MainGame");

            //StartCoroutine(Timer());
            //Destroy(GetComponent<SphereCollider>());
        }
    
    }

/*    IEnumerator Timer()
    {

        yield return new WaitForSeconds(20);
        agent.speed = 50.0f;
    
    }*/


    void OnDrawGizmosSelected ()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, lookRadius);
    }

}
