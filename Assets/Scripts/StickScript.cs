using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickScript : MonoBehaviour
{
    public Transform transformInput;
    public Transform transformOutput;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transformOutput.position = transformInput.position;
        transformOutput.rotation = transformInput.rotation;
    }
}
