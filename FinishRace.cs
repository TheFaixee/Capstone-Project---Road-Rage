using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class FinishRace : MonoBehaviour
{
    public GameObject car;

    public GameObject finishCamera;

    public GameObject normalCamera;

    public GameObject finishPoint;

    public TextMeshProUGUI finishText;



    private void OnTriggerEnter()
    {
        this.GetComponent<BoxCollider>().enabled = false;
        car.SetActive(false);
        PrometeoCarController.maxSpeed = 0;
        car.GetComponent<PrometeoCarController>().enabled = false;
        car.SetActive(true);
        finishCamera.SetActive(true);
        normalCamera.SetActive(false);
        finishText.gameObject.SetActive(true);


    }

    
}
