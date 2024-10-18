using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class NoteManager : MonoBehaviour
{
    private GameObject Drum;

    public float noteSpeed;
    public float noteCenter;

    public float distance;

    public float hitAcuracy;

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

        distance = Drum.transform.position.z - transform.position.z;;

        hitAcuracy = distance / Drum.transform.position.z;

        Player.currentAcuracy -= hitAcuracy;

        // Debug.Log($" distance {(int)distance}");
        // Debug.Log($" hitAcuracy {(int)hitAcuracy}");
        // Debug.Log($" currentAcuracy {(int)Player.currentAcuracy} %");

        Destroy(this.gameObject);

    }


    void Update()
    {
        transform.position += new Vector3(0, 0, noteSpeed);
        //Debug.Log($"{noteCenter}");

    }
}
