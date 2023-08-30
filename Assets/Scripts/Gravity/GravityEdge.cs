using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityEdge : MonoBehaviour
{
    private PhysicCenter _physicCenter;
    private void Start()
    {
        _physicCenter = GetComponentInParent<PhysicCenter>();
    }

    private void Update()
    {
        _physicCenter.gravityCenters.ForEach(gc =>
        {
            if (gc.Captured(transform.position))
            {
                gameObject.layer = (int)Mathf.Floor(Mathf.Log(_physicCenter.beCaptured, 2));
            }
        });
    }
}
