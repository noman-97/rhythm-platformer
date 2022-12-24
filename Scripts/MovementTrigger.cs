using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MovementTrigger : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject movingTag;
    public GameObject[] movingTags;

    private GameObject player;
    private GameObject player2;
    private GameObject bgm;
    


    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        bgm = GameObject.FindGameObjectWithTag("BackgroundMusic");
        player2 = GameObject.FindGameObjectWithTag("Player2");

    }


    void OnTriggerEnter2D(Collider2D col)
    {
        

        if (col.gameObject.name == "Player")
        {
            
            movingTags = GameObject.FindGameObjectsWithTag("Moving");

            player.GetComponent<BackwardMovement>().startMovement();
            player2.GetComponent<BackwardMovement>().startMovement();

            bgm.GetComponent<StartMusic>().startMusic();



            foreach (GameObject movingTag in movingTags)
            {
                movingTag.GetComponent<BackwardMovement>().startMovement();
            }


            Destroy(gameObject);


        }

        


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
