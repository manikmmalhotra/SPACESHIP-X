﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacles : MonoBehaviour
{
    [SerializeField] GameObject obstaclePrefab;
    // Start is called before the first frame update
    void Start()
    {
        for(int i=0;i< Random.Range(10, 25); i++)
        {
            GameObject temp = Instantiate(obstaclePrefab, new Vector3(Random.Range(-45, 45), 4, Random.Range(transform.position.z - 100, transform.position.z + 100)),Quaternion.identity);
            temp.transform.parent = gameObject.transform;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
