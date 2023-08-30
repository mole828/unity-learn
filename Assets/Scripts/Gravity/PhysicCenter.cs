using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicCenter : MonoBehaviour
{
    public LayerMask beCaptured;
    public List<GravityCenter> gravityCenters;
    private void Start()
    {
        Debug.Log($"beCaptured {(int)beCaptured}");
    }
}
