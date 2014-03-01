using UnityEngine;
using System.Collections.Generic;

public class GenerateBackground : MonoBehaviour {

    public GameObject backgroundPrefab;

    private int offset = 1;

    private float maxY = 1.5f;
    private float minY = -1.5f; //4

    private float maxX = 3.75f;
    private float minX = -3.75f; //8

    private List<GameObject> matrix;
	// Use this for initialization
	void Start () {
        for (int i = 0; i < Mathf.Round(Mathf.Abs(minY) + maxY) + 1; i++)
        {
            for (int j = 0; j < Mathf.Round(Mathf.Abs(minX) + maxX) + 1; ++j)
            {
                Instantiate(backgroundPrefab, new Vector2(minX + j, minY + i), Quaternion.identity);
            } 
        }
	}
}
