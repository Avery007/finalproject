using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kill : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    //public GameObject text;


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject == player)
        {
            Debug.Log("detection");
            Vector3 force = new Vector3(10, 50, 2);
           player.GetComponent<Rigidbody>().isKinematic=false;
            player.GetComponent<Rigidbody>().AddForce(force);
            //Destroy(collision.collider.gameObject);
            //text.SetActive(true);

        }
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
