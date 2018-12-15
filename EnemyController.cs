using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour {

    public GameObject player;
    public NavMeshAgent enemyAgent;

	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
        enemyAgent = GetComponentInParent<NavMeshAgent>();
	}
	
	// Update is called once per frame
	void Update () {
        
        enemyAgent.SetDestination(player.transform.position);
	}
}
