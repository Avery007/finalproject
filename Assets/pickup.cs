using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickup : MonoBehaviour
{
    public GameObject player;
    public GameObject sea;
  
    public UnityEngine.UI.Text text;
    private static int number = 0;
    public GameObject message;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject == player)
        {
            Debug.Log("detection");
           
            Destroy(this.gameObject);
            number = number + 1;
            text.text = "Crystal collected: " + number;
            Debug.Log(number);
           
            if (number == 12)
            {
                Destroy(sea);
               //estroy(mushroom);
               //estroy(monster);
                text.text = "Good job you got all of them! ";
                message.SetActive(true);
            }
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
