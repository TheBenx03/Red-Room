using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeController : WeaponController
{
	
	protected override void Start()
	{
		base.Start();	
	}
	
	protected override void Attack()
	{
		base.Attack();
		gameObject spawnedKnife = Instantiate(prefab);
		spawnedKnife.transform.position = transform.position;
		spawnedKnife.GetComponent<KnifeBehaviour>().DirectionChecker(pm.moveDirection); //Reference and set the direction
	}
}
