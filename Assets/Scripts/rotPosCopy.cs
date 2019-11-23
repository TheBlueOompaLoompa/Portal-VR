using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class rotPosCopy : MonoBehaviour
{
    public Transform copy;
    void Update()
    {
        transform.position = copy.position;
        transform.rotation = copy.rotation;
    }
}
