using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//base script of all projectile behaviours (place in prefab of weapon that is proyectile)

public class ProjectileWeaponBehaviour : MonoBehaviour
{
	protected Vector3 direction;
	public float destroyAfterSeconds;
	
	protected virtual void Start()
	{
		Destroy(gameObject, destroyAfterSeconds);
	}
	
	public void DirectionChecker(Vector3 dir)
	{
		direction = dir;	
	}
}
