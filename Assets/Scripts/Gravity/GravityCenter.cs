using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class GravityCenter : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        GetComponentInParent<PhysicCenter>().gravityCenters.Add(this);
        Debug.Log($"New GravityCenter, has: {GetComponentInParent<PhysicCenter>().gravityCenters.Count}");
    }
    
    // 计算捕获与否
    public bool Captured(Vector3 other)
    {
        return Vector3.Distance(transform.position, other) < 1;
    }
}
