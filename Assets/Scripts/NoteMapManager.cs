using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteMapManager : MonoBehaviour
{
        public float noteSpeed;

    // Start is called before the first frame update
    void Start()
    {
        QualitySettings.vSyncCount = 0; // Set vSyncCount to 0 so that using .targetFrameRate is enabled.
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
                transform.position += new Vector3(0, 0, noteSpeed);

    }
}
