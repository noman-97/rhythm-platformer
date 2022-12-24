using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteDelay : MonoBehaviour
{
    // Start is called before the first frame update
    
    void Start()
    {
        
        delayedDestroy();
    }

    // Update is called once per frame
    void delayedDestroy()
    {
        Destroy(this.gameObject,30f);
    }
}
