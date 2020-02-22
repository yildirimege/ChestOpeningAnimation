using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LegendaryCardRotate : MonoBehaviour
{
    public GameObject heroCard;
    public GameObject legendaryCard;
    public GameObject legendrayCardImage;
    public Material cardMaterial;
    public float rotateSpeed=4f;
    private float rotateDegree =360f;
    public GameObject sparkle;

    // Start is called before the first frame update
    void Start()
    {
        sparkle.SetActive(false);



    }

    // Update is called once per frame
    void Update()
    {

        rotateSpeed -= 0.03f;
        if (rotateSpeed > 0.03f)
        {
            RotateAround();

        }


        else if (rotateSpeed <= 0.03f)
        {

            rotateSpeed = 0;

            transform.rotation = Quaternion.Lerp(transform.rotation,  Quaternion.Euler(0,180,0),  Time.deltaTime);

          
          

            legendrayCardImage.GetComponent<Renderer>().material = cardMaterial;
            sparkle.SetActive(true);
        }

    }

    


    void RotateAround()
    {

       transform.Rotate(Vector3.up * rotateDegree * rotateSpeed * Time.deltaTime, Space.World);
        

    }

   
    
}
