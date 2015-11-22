using UnityEngine;
using System.Collections;

public class waypoint : MonoBehaviour {

	public GameObject[] nextWaypoint;



	void OnDrawGizmosSelected(){
		Gizmos.color = Color.blue;

		for (int i = 0;i < nextWaypoint.Length;i++)
		{
			Gizmos.DrawLine(transform.position, nextWaypoint[i].transform.position);
		}

	}

	public GameObject GetNextWaypoint(){
		GameObject position = nextWaypoint[Random.Range(0,nextWaypoint.Length)];

		if (position)
			return position;

		else
			return null;
	}
}
