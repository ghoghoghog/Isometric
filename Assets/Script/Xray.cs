using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
public class Xray : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            GetComponent<TilemapRenderer>().enabled = false;
        }
        else
        {
            GetComponent<TilemapRenderer>().enabled = true;
        }
    }
}
