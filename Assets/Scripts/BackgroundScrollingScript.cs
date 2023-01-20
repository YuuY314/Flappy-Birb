using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScrollingScript : MonoBehaviour
{
    public MeshRenderer myMeshRenderer;
    public float speedScrolling;
    
    void Start()
    {
        
    }

    void Update()
    {
        myMeshRenderer.material.mainTextureOffset += new Vector2(speedScrolling * Time.deltaTime, 0);
    }
}
