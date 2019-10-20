using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainUpDown : MonoBehaviour
{
    public float dr;
    void Update()
    {

        if (Input.GetKey(KeyCode.UpArrow))
            transform.Rotate(-dr, 0, 0);
        else if (Input.GetKey(KeyCode.DownArrow))
            transform.Rotate(dr, 0, 0);
    }
}
