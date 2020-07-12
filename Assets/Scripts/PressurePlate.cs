using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlate : MonoBehaviour
{
    public Collider plate;
    public GameObject door;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerStay(Collider collider)
    {
        door.SetActive(false);
        // Debug.LogFormat("OnTriggerStay {0}", plate.name);
    }

    private void OnTriggerEnter(Collider collider)
    {
        // Do nothing for now
        // Debug.LogFormat("OnTriggerEnter ${0}", plate.name);
    }

    private void OnTriggerExit(Collider collider)
    {
        door.SetActive(true);
        // Debug.LogFormat("OnTriggerExit {0}", plate.name);
    }
}
