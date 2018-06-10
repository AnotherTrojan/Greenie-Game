using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanSpawn : MonoBehaviour {
    public Transform[] positions;
    public List<Transform> posList;
    public GameObject[] cans;
    public int totalCans;
	// Use this for initialization
	void Start ()
    {
        posList.AddRange(positions);
        for (int i = 0; i < totalCans; i++)
        {
            int index1 = Random.Range(0, cans.Length);
            int index2 = Random.Range(0, posList.Count);
            Instantiate(cans[index1], posList[index2].position, Quaternion.identity);
            posList.RemoveAt(index2);
        }
    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
