using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Vehicles.Car;


public class CountDownManager : MonoBehaviour
{
    public GameObject counterLabel;

    public AudioSource readySound;
    public AudioSource goSound;

    public GameObject car;
    public GameObject AICar;
    public GameObject lapTimeCounter;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CountDown());
    }
    IEnumerator CountDown()
    {
        yield return new WaitForSeconds(0.03f);
        counterLabel.GetComponent<Text>().text = "3";
        readySound.Play();
        counterLabel.SetActive(true);
        yield return new WaitForSeconds(1);
        counterLabel.SetActive(false);

        counterLabel.GetComponent<Text>().text = "2";
        readySound.Play();
        counterLabel.SetActive(true);
        yield return new WaitForSeconds(1);
        counterLabel.SetActive(false);

        counterLabel.GetComponent<Text>().text = "1";
        readySound.Play();
        counterLabel.SetActive(true);
        yield return new WaitForSeconds(1);
        counterLabel.SetActive(false);
        goSound.Play();

        car.GetComponent<PrometeoCarController>().enabled = true;
        AICar.GetComponent<CarAIControl>().enabled = true;
        lapTimeCounter.GetComponent<LapTimer>().enabled = true;
    }    
}
