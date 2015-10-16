//Apolinar Ortega
using UnityEngine;
using System.Collections;
using System.Collections.Generic;


//This class is to hold a reference to all the minions and spawns them
public class MinionHoard : MonoBehaviour 
{
	public List<GameObject> Minions; //Holds a reference to all the minions generated
	public GameObject MinionTemplate; 
	private GameObject startTile;
	private GameObject endTile;

	void Start () 
	{
		Minions = new List<GameObject> ();
		startTile = GameObject.Find("tileEnter");
		endTile = GameObject.Find ("tileExit");
		SpawnEnemies (2, 2, 3, 0.01f);
		SpawnEnemies (1, 2, 3, 0.007f);
	}
	
	void Update () {}

	// Generates minions
	//Extra Parameter for minion type?
	public void SpawnEnemies(int minionCount, int healths, int bounties, float moveSpeeds )
	{
		GameObject minioni;
		for (int i = 0; i < minionCount; i++) 
		{
			minioni = (GameObject) GameObject.Instantiate(
				MinionTemplate, startTile.transform.position, Quaternion.identity);
			minioni.transform.rotation = MinionTemplate.transform.rotation; //Sets minion rotation
			minioni.GetComponent<AbstractMinion>().SetMinion(healths, bounties, moveSpeeds, startTile, endTile);
			Minions.Add (minioni); //Adds minion to list
			minioni.transform.SetParent (gameObject.transform);//Sets minion as child of this gameObject
		}
	}

	//Removes the minion from the list
	public void RemoveMinion(GameObject minion)
	{
		Minions.Remove (minion);
	}
}