using UnityEngine;
using System.Collections;

public class ScrollingBackground : MonoBehaviour {

    public float scrollSpeed = .5f;
    public float offset;

    void Update()
    {
        offset += (Time.deltaTime * scrollSpeed) / 10;
        renderer.material.SetTextureOffset("_MainTex", new Vector2(offset, 0));
    }
}
