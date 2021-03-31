using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attack : MonoBehaviour
{
  
        // Start is called before the first frame update
        public Transform target;
        public GameObject player;
        //public GameObject text;
        public GameObject cube;
        private void OnTriggerEnter(Collider collision)
    {
        Debug.Log("check");
        if (collision.gameObject == player)
            {
                Debug.Log("detection");
                Vector3 force = new Vector3(100, 100, 5);
            player.GetComponent<Rigidbody>().isKinematic = false;
            player.GetComponent<Rigidbody>().AddForce(force);
                //text.SetActive(true);
                //Destroy(collision.collider.gameObject);

            }
        }
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (cube != null)
            {
                //this.transform.position += (this.transform.position - target.position).normalized * speed * Time.deltaTime;
                //this.transform.position = Vector3.Lerp(this.transform.position, target.position, 0.1f);
                this.transform.Translate(Vector3.Normalize(target.position - this.transform.position) * 0.03f);
            }
        }
    }