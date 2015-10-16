using UnityEngine;
using System.Collections;

public class Grid : MonoBehaviour {
    public GameObject tile;
    public GameObject enteranceTile;
    public GameObject exitTile;
    public int enterx = 0;
    public int enterz = 9;
    public int exitx = 9;
    public int exitz = 0;
    public int width = 10;
    public int height = 10;

    private GameObject [,] grid = new GameObject[10,10];

    //use this before game start
    void Awake()
    {
        for(int x =0; x < width; x++)
        {
            for(int z = 0; z < height; z++)
            {
                GameObject gridPlane;
                if (x==enterx && z == enterz)
                {
                    gridPlane = (GameObject)Instantiate(enteranceTile);
                    gridPlane.name = "tileEnter";
                }
                else if (x == exitx && z == exitz)
                {
                    gridPlane = (GameObject)Instantiate(exitTile);
                    gridPlane.name = "tileExit";
                }
                else
                {
                    gridPlane = (GameObject)Instantiate(tile);
                    gridPlane.name = "tile" + x + "-" + z;
                }
                
                gridPlane.transform.position = new Vector2(x,z);
                grid[x, z] = gridPlane;
            }
        }
    }


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
