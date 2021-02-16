using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeshUtilityTesting : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("test");

        Mesh mesh = new Mesh();
        Vector3[] vertices = new Vector3[3];
        Vector2[] uv = new Vector2[3];
        int[] triangles = new int[3];

        vertices[0] = new Vector3(0, 0);
        vertices[1] = new Vector3(0, 100);
        vertices[2] = new Vector3(100, 100);

        //uv[0] = 
        //uv[1] = 
        //uv[2] = 

        triangles[0] = 0;
        triangles[1] = 1;
        triangles[2] = 2;

        mesh.vertices = vertices;
        mesh.uv = uv;
        mesh.triangles = triangles;

        GetComponent<MeshFilter>().mesh = mesh;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
