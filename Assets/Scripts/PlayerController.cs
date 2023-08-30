using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody _rigidbody;
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        var target = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        // _rigidbody.AddForce(0.2f*Time.deltaTime*target);
        transform.Translate(Time.deltaTime*target);
    }
}
