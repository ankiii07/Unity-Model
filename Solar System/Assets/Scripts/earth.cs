using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class earth : MonoBehaviour
{
    public Transform Earth;
    // Start is called before the first frame update
    void Start()
    {
        Earth = GameObject.FindGameObjectWithTag("Earth").transform;
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(Earth.position, Vector3.up, 1 * Time.deltaTime);
    }
}
