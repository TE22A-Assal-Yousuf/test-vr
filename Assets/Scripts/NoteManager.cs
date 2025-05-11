using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class NoteManager : MonoBehaviour
{
    private GameObject Drum;
    public float noteCenter;

    public float distance;

    public float hitAcuracy;

    private bool perfectHit;
    public string drumTag;
    
    void Start()
    {

        Drum = GameObject.FindGameObjectWithTag(drumTag);
    }

    private void OnTriggerEnter(Collider other)
    {


        // Debug.Log(" stick hit the note ");

        // Debug.Log(" *BUM* ");
        // Debug.Log(" + 1000 poits \n Perfect");

        distance = Drum.transform.position.z - transform.position.z; ;

        if (0.5 > distance && distance >= 0.0001)
        {

            perfectHit = true;
        }
        if (distance <= 0)
        {
            distance *= -1;
        }

        if (perfectHit == true)
        {
            hitAcuracy = 0;
        }
        else
        {
            hitAcuracy = distance / Drum.transform.position.z;
        }

        Player.currentAcuracy -= hitAcuracy;

        Debug.Log($" distance {distance}");
        Debug.Log($" hitAcuracy {hitAcuracy}");
        Debug.Log($" currentAcuracy {(int)Player.currentAcuracy} %");

        perfectHit = false;


        void DoDelayAction(float delayTime)
        {
            StartCoroutine(DelayAction(delayTime));
        }
        IEnumerator DelayAction(float delayTime)
        {
            //Wait for the specified delay time before continuing.
            yield return new WaitForSeconds(delayTime);
            //Do the action after the delay time has finished.
        }

        Destroy(this.gameObject);


    }


    void Update()
    {
        //Debug.Log($"{noteCenter}");

    }
}
