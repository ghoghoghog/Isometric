using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Hidecolidercolor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<TilemapRenderer>().enabled = false;
    }

}
