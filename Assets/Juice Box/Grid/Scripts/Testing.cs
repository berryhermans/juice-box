using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testing : MonoBehaviour
{
    private Grid grid;

    private void Start()
    {
        grid = new Grid(20, 10, 10f, Vector3.zero);
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 pos = Utilities.GetMouseWorldPosition();
            int value = grid.GetValue(pos);
            grid.SetValue(pos, value + 5);
        }
    }
}
