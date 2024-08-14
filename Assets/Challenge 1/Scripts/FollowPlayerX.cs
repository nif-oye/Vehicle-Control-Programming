using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;
    private Vector3 offset = new(43, 0.5f, 10.3f);

    void Start()
    {

    }

    void Update()
    {
        transform.position = plane.transform.position + offset;
    }
}
