using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plane : MonoBehaviour
{
    public Vector3[] newVertices;
    public int[] newTriangles;

    void Start()
    {
        gameObject.AddComponent<MeshFilter>();

        Mesh mesh = new Mesh();
        GetComponent<MeshFilter>().mesh = mesh;
        mesh.vertices = newVertices;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
