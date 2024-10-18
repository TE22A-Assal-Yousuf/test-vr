using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;


public class DrumManager : MonoBehaviour
{

    public float drumCenter;


    private void Start()
    {
        drumCenter = transform.position.z;
        
    }

}
