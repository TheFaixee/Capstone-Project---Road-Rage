using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinishPoint : MonoBehaviour
{
    public GameObject minLabelBest;
    public GameObject secLabelBest;
    public GameObject miliLabelBest;

    public GameObject fpoint;
    public GameObject halfPoint;

    public GameObject raceFinish;

    public GameObject lapsCounterLabel;
    public int lapsCounter;

    private void OnTriggerEnter()
    {
        lapsCounter = lapsCounter + 1;
        if(lapsCounter == 2)
        {
            raceFinish.SetActive(true);
        }

        miliLabelBest.GetComponent<Text>().text = "" + LapTimer.mili.ToString("F0");

        if (LapTimer.sec > 0 && LapTimer.sec < 10)
        {
            secLabelBest.GetComponent<Text>().text = "0" + LapTimer.sec.ToString() + ".";
        }
        else if (LapTimer.sec >= 10 && LapTimer.sec <= 59)
        {
            secLabelBest.GetComponent<Text>().text = "" + LapTimer.sec.ToString() + ".";
        }
        if (LapTimer.min > 0 && LapTimer.min < 10)
        {
            minLabelBest.GetComponent<Text>().text = "0" + LapTimer.min.ToString() + ":";
        }
        else if (LapTimer.sec >= 10 && LapTimer.sec <= 59)
        {
            minLabelBest.GetComponent<Text>().text = "" + LapTimer.min.ToString() + ":";
        }

        lapsCounterLabel.GetComponent<Text>().text = "" + lapsCounter;

        LapTimer.mili = 0;
        LapTimer.sec = 0;
        LapTimer.min = 0;

        fpoint.SetActive(false);
        halfPoint.SetActive(true);
    }

}
