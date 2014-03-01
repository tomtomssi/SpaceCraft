using UnityEngine;
using System.Collections.Generic;

public class GenerateBackground : MonoBehaviour
{

    public GameObject backgroundPrefab;
    private GameObject backgroundClone;

    private float maxY = 1.5f;
    private float minY = -1.5f;

    private float maxX = 3.75f;
    private float minX = -3.75f;

    void Start()
    {
        for (int i = 0; i < Mathf.Round(Mathf.Abs(minY) + maxY) + 1; i++)
        {
            for (int j = 0; j < Mathf.Round(Mathf.Abs(minX) + maxX) + 1; ++j)
            {
                backgroundClone = (GameObject)Instantiate(
                                                            backgroundPrefab,
                                                            new Vector2(minX + j, minY + i),
                                                            Quaternion.identity
                                                            );

                backgroundClone.transform.parent = GameObject.Find("Background").transform;
            }
        }
    }
}
