using UnityEngine;
using System.Collections;

public class ScrollingBackground : MonoBehaviour {
    public GameObject bgTop;
    public GameObject bgBot;

    private Vector2 topSpawn;

	// Use this for initialization
	void Start () {
        topSpawn = bgTop.transform.position;
        StartCoroutine("moveBG");
        Debug.Log(bgBot.transform.position);
	}
	
	// Update is called once per frame
	void Update () {

        
	}

    public IEnumerator moveBG()
    {
        float x = 0.001f;
        while (true)
        {
            bgBot.transform.position = new Vector2(bgBot.transform.position.x, bgBot.transform.position.y + x);
            yield return new WaitForSeconds(0.05f);
        }
    }
}
