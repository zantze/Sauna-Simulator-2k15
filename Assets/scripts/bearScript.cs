using UnityEngine;
using System.Collections;

public class bearScript : MonoBehaviour {

	public GameObject nextWaypoint;
	public float bearSpeed;
	public GameObject player;

	Transform lastSeen;

	bool followingPlayer;

	Ray ray;
	RaycastHit hit;

	void Start () {
		player = Player.current.gameObject;
	}
	// homofsddsf
	void Update () {
		if (followingPlayer){
			transform.LookAt(lastSeen);
			if (Vector3.Distance (transform.position,lastSeen.position) < 1){
				followingPlayer = false;
			}
		}
		else
		transform.LookAt(nextWaypoint.transform);

		transform.Translate (Vector3.forward * bearSpeed * Time.deltaTime);

		if (Vector3.Distance (transform.position,nextWaypoint.transform.position)<= 2f){
			Debug.Log ("Get next wp...");
			nextWaypoint = nextWaypoint.GetComponent<waypoint>().GetNextWaypoint();
		}

		if (Physics.Raycast(transform.forward,player.transform.position, out hit,20f)){
			if (hit.collider.gameObject == player)
			{
				Debug.Log ("I see you!");
				followingPlayer = true;
				lastSeen = player.transform;
			}
		}


	}
}
