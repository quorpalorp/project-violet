using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BasicMovement : MonoBehaviour
{
    public KeyCode left = KeyCode.A, right = KeyCode.D, forward = KeyCode.W, backward = KeyCode.S, up = KeyCode.Space, down = KeyCode.LeftControl, sprint = KeyCode.LeftShift;
    public float moveSpeed = 1;
    public float Sprint = 2;
    public bool hasNoVel = true;

    private Rigidbody _rb3d;
    // Start is called before the first frame update
    void Start()
    {
        _rb3d = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (hasNoVel == true)
        {
            _rb3d.velocity = Vector3.zero;
        }

        if (Input.GetKeyUp(forward))
        {
            //if (Input.GetKey(sprint))
            //{
            //    _rb3d.velocity = Vector3.forward * Sprint;
           // }
            //else
            //{
             //   _rb3d.velocity = Vector3.forward * moveSpeed;
            //}
            _rb3d.velocity = Vector3.forward * moveSpeed;
        }
        if (Input.GetKeyUp(backward))
        {
            _rb3d.velocity = Vector3.back * moveSpeed;
        }
        if (Input.GetKeyUp(left))
        {
            _rb3d.velocity = Vector3.left * moveSpeed;
        }
        if (Input.GetKeyUp(right))
        {
            _rb3d.velocity = Vector3.right * moveSpeed;
        }
        if (Input.GetKeyUp(up))
        {
            _rb3d.velocity = Vector3.up * moveSpeed;
        }
        if (Input.GetKeyUp(down))
        {
            _rb3d.velocity = Vector3.down * moveSpeed;
        }
    }
}
