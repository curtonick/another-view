using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlate : MonoBehaviour
{
    public Collider plate;
    public GameObject door;

    private bool isClosed = true;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        door.SetActive(isClosed ? false : true);
        isClosed = !isClosed;
    }
}
