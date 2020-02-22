using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chestClick : MonoBehaviour
  
{
    public GameObject openChest;
    public GameObject closedChest;
    public GameObject cardFrame;
    
    // Start is called before the first frame update
    void Start()
    {
        closedChest.SetActive(true);
        openChest.SetActive(false);
        cardFrame.SetActive(false);
        
    }

    public void ClosedChestClick()
    {
        Debug.Log("Penis");
        closedChest.SetActive(false);
        openChest.SetActive(true);
        cardFrame.SetActive(true);
       
        StartCoroutine(resetFrame());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator resetFrame()
    {

        yield return new WaitForSeconds(5);
        cardFrame.transform.rotation = Quaternion.Euler(180, 0, 180);

    }
}
