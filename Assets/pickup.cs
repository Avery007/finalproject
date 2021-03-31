using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickup : MonoBehaviour
{
    public GameObject player;
    public UnityEngine.UI.Text text;
    private static int number = 0;
    //public GameObject text;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject == player)
        {
            Debug.Log("detection");
           
            Destroy(this.gameObject);
            number = number + 1;
            text.text = "Crystal collected: " + number;
            Debug.Log(number);
            // text.SetActive(true);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
