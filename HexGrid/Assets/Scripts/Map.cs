using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour {

    public GameObject hexPrefab;

    //size of map
    public int width;
    public int height;

    float xOffset = 0.882f;
    float zOffset = 0.764f;

	void Start () {

        for (int i = 0; i < width; i++)
        {
            for (int j = 0; j < height; j++)
            {
                float xPos = i*xOffset;
                if (j % 2 == 1)
                    xPos += xOffset/2f;
                
                GameObject hex_go=(GameObject)Instantiate(hexPrefab, new Vector3(xPos, 0, j * zOffset), Quaternion.identity);
                hex_go.name = "Hex_" + i + "_" + j;
                hex_go.transform.SetParent(this.transform);
                hex_go.isStatic = true;
            }
        }
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
