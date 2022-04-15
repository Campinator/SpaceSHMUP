using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialScroller : MonoBehaviour
{
    public Vector2 scrollSpeed = new Vector2(0, 0.4f);

    private Renderer goRenderer;
    private Material goMaterial;

    private Vector2 offset;
    // Start is called before the first frame update
    void Start()
    {
        goRenderer = GetComponent<Renderer>();
        goMaterial = goRenderer.material;
    }

    // Update is called once per frame
    void Update()
    {
        offset = (scrollSpeed * Time.deltaTime);
        goMaterial.mainTextureOffset += offset;
    }
}
