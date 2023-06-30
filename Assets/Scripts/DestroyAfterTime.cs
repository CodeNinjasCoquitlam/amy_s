using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAfterTime : MonoBehaviour
{
    [Header("Destruction Timer")]
    //after this time, the object will be destroyed
    public float timeToDestruction;

    // Start is called before the first frame update
    void Start()
    {
        //execute function based on time to destrucktion
        Invoke("DestroyObject", timeToDestruction);

    }

    // this function will destroy this object :D
    void DestroyObject()
    {
        //destroy game object
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {

    }
}

