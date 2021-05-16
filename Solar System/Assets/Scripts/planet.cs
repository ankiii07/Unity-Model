using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class planet : MonoBehaviour
{
   public Transform Sun;
    public float speed = 5;
   
    // Start is called before the first frame update
    void Start()
    {
        Sun = GameObject.FindGameObjectWithTag("Sun").transform;
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(Sun.position, Vector3.up, speed * Time.deltaTime);
    }
}
