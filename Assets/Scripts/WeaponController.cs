using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Base script for all weapons, add summary

public class WeaponController : Monobehaviour
{
	[Header("weapon stats")]
	public GameObject prefab;
	public float damage;
	public float speed;
	public float cooldownDuration;
	float currentCooldown;
	public int pierce;
	
	protected PlayerMovement pm;
	
	protected virtual void Start()
	{
		pm = FindObjectOfType<PlayerMovement>();
		currentCooldown = cooldownDuration;
	}
	
	protected virtual void Update()
	{
		currentCooldown -= Time.deltaTime;
		if(currentCooldown <= 0f) Attack();
	}
	
	protected virtual void Attack()
	{
		currentCooldown = cooldownDuration;
	}
}
