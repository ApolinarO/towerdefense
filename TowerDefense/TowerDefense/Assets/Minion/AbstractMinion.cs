﻿//Apolinar Ortega
using UnityEngine;
using System.Collections;

//Serializable?
public class AbstractMinion : MonoBehaviour 
{
	public int Health { get; private set;} // Minion HP
	public int Bounty { get; private set;} // How much money/points minion drops
	public float MoveSpeed { get; private set;} // How fast  the minion moves
	private GameObject startTile, endTile;

	public void Start()
	{
		startTile = GameObject.Find("tileEnter");
		endTile = GameObject.Find ("tileExit");
		SetMinionColor (new Color(Random.Range(0.0f,1.0f),Random.Range(0.0f,1.0f),Random.Range(0.0f,1.0f)));
	}
	public void Update()
	{
		gameObject.GetComponent<MinionMove> ().Move ( endTile.transform.position, MoveSpeed);
	}

	public void SetMinion(int health, int bounty, float movespeed, GameObject start, GameObject end)
	{
		this.Health = health;
		this.Bounty = bounty;
		this.MoveSpeed = movespeed;
		startTile = start;
		endTile = end;
	}
	public void SetMinionColor(Color color)
	{
		gameObject.GetComponent<Renderer> ().material.color = color;
	}

	//public abstract void Die ();
	//when the minion dies, it gives the player gold, removes itself from the list, and destroys itself
	//To have parameter specifying who or what killed it?
	//Condition as to why it dies? Or new method?
}