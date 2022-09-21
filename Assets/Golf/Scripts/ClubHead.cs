using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ClubHead : MonoBehaviour

{	
	public bool useScript = false;

	[SerializeField]
	private ClubHeadFollower clubHeadFollowerPrefab;

	private void Awake()
	{
		if (useScript)
		{
			SpawnClubHeadFollower();
		}

	}

	private void SpawnClubHeadFollower()
	{
		var follower = Instantiate(clubHeadFollowerPrefab);
		follower.transform.position = transform.position;
		follower.transform.rotation = transform.rotation;
		follower.SetFollowTarget(this);
	}
}