using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grab : MonoBehaviour
{

    public GameObject child;
    public GameObject parent = null;
    public bool _grabbed;
    public bool snapTo = false;
    public Transform loc;
    // Start is called before the first frame update
    void Start()
    {
        _grabbed = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (_grabbed)
        {
            //this.transform.position = parent.position + link;
            //this.transform.rotation = parent.rotation;
            child.transform.SetParent(parent.transform);
        }
        else
        {
            //    this.transform.position = loc.position;
            //    this.transform.rotation = loc.rotation;
            child.transform.SetParent(null);
        }

        if (snapTo) {
            child.transform.position = loc.position;
            child.transform.rotation = loc.rotation;
            snapTo = false;
        }

    }

    
}
