using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackwardMovement : MonoBehaviour
{
    // Start is called before the first frame update
    private float moveSpeed = 103/30f;

    public int startMoving = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (startMoving == 1)
        {
            transform.position = transform.position + new Vector3(-moveSpeed * Time.deltaTime, 0, 0);
        }
        
    }


    public void startMovement()
    {
         startMoving = 1;
    }

}
