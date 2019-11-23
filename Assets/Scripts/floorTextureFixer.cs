using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class floorTextureFixer : MonoBehaviour
{
    void Start()
    {
        GameObject[] floors = GameObject.FindGameObjectsWithTag("floor");
        for(int i = 0; i < floors.Length; i++)
        {
            floors[i].GetComponent<Renderer>().material.SetTextureScale("_BaseMap", new Vector2(floors[i].transform.localScale.x, floors[i].transform.localScale.y));
            Debug.Log(floors[i].name);
        }
    }
}
