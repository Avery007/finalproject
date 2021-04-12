using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kill : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    //public GameObject text;
    public Transform target;

    //public GameObject text;
    public GameObject ocean;


    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject == player)
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
        float disX = this.transform.position.x - player.transform.position.x;
        float disZ = this.transform.position.z - player.transform.position.z;
        if (ocean != null)
        {
            if (disZ < 20 && disX < 20)
            {
                //this.transform.position += (this.transform.position - target.position).normalized * speed * Time.deltaTime;
                //this.transform.position = Vector3.Lerp(this.transform.position, target.position, 0.1f);
                this.transform.Translate(Vector3.Normalize(target.position - this.transform.position) * 0.05f);
            }

       
    }   }   
}

