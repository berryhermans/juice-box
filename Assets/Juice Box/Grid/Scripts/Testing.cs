using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testing : MonoBehaviour
{
    private Grid grid;

    private void Start()
    {
        grid = new Grid(4, 2, 10f, new Vector3(20,0));
        new Grid(2, 5, 5f, new Vector3(0, -20));
        new Grid(10, 10, 20f, new Vector3(-100, 50));

    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            grid.SetValue(Utilities.GetMouseWorldPosition(), 56);
        }

        if (Input.GetMouseButtonDown(1))
        {
            Debug.Log(grid.GetValue(Utilities.GetMouseWorldPosition()));
        }
    }
}
