using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public Vector3 rotatingL = new Vector3(0, 1.0f, 0);
    public Vector3 rotatingR = new Vector3(0, -1.0f, 0);

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 change = this.transform.TransformVector(0.03f, 0, 0);
        Vector3 changeVertical = this.transform.TransformVector(0, 0, 0.03f);
        if (Input.GetKey(KeyCode.D))
        {
            //Vector3 change = this.transform.TransformVector(0.005f, 0, 0);

            this.transform.position = this.transform.position + change;
            if (this.transform.position.x > 182)
            {
                Vector3 newX = this.transform.position;
                newX.x = 182;
                this.transform.position = newX;

            }
            if (this.transform.position.x < -182)
            {
                Vector3 newX = this.transform.position;
                newX.x = -182;
                this.transform.position = newX;

            }
            if (this.transform.position.z < -182)
            {
                Vector3 newZ = this.transform.position;
                newZ.z = -180;
                this.transform.position = newZ;

            }
            if (this.transform.position.z > 182)
            {
                Vector3 newZ = this.transform.position;
                newZ.z = 182;
                this.transform.position = newZ;

            }

            //transform.TransformPoint(vector);
            //this.transform.TransformPoint(new Vector3(0.5f, 0, 0));


        }

        if (Input.GetKey(KeyCode.A))
        {  
            this.transform.position = this.transform.position - change;
            if (this.transform.position.x < -185)
            {
                Vector3 newX = this.transform.position;
                newX.x = -185;
                this.transform.position = newX;

            }
            if (this.transform.position.x > 185)
            {
                Vector3 newX = this.transform.position;
                newX.x = 185;
                this.transform.position = newX;

            }
            if (this.transform.position.z < -185)
            {
                Vector3 newZ = this.transform.position;
                newZ.z = -185;
                this.transform.position = newZ;

            }
            if (this.transform.position.z > 185)
            {
                Vector3 newZ = this.transform.position;
                newZ.z = 185;
                this.transform.position = newZ;

            }

        }

        if (Input.GetKey(KeyCode.W))
        {
            this.transform.position = this.transform.position + changeVertical;
            if (this.transform.position.z > 185)
            {
                Vector3 newZ = this.transform.position;
                newZ.z = 185;
                this.transform.position = newZ;
                
            }
            if (this.transform.position.z < -185)
            {
                Vector3 newZ = this.transform.position;
                newZ.z = -185;
                this.transform.position = newZ;

            }
            if (this.transform.position.x < -185)
            {
                Vector3 newX = this.transform.position;
                newX.x = -185;
                this.transform.position = newX;

            }
            if (this.transform.position.x > 185)
            {
                Vector3 newX = this.transform.position;
                newX.x = 185;
                this.transform.position = newX;

            }

        }

        if (Input.GetKey(KeyCode.S))
        {
            this.transform.position = this.transform.position - changeVertical;
            if (this.transform.position.z <-185)
            {
                Vector3 newZ = this.transform.position;
                newZ.z = -185;
                this.transform.position = newZ;

            }
            if (this.transform.position.z > 185)
            {
                Vector3 newZ = this.transform.position;
                newZ.z = 185;
                this.transform.position = newZ;

            }
            if (this.transform.position.x < -185)
            {
                Vector3 newX = this.transform.position;
                newX.x = -185;
                this.transform.position = newX;

            }
            if (this.transform.position.x > 185)
            {
                Vector3 newX = this.transform.position;
                newX.x = 185;
                this.transform.position = newX;

            }

        }

        if (Input.GetKey(KeyCode.E))
        {

            this.GetComponent<Transform>().Rotate(rotatingL);
        }

        if (Input.GetKey(KeyCode.Q))
        {
            this.GetComponent<Transform>().Rotate(rotatingR);
        }




    }
}