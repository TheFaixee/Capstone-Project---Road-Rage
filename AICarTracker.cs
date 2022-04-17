using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AICarTracker : MonoBehaviour
{
    public GameObject point1;
    public GameObject point2;
    public GameObject point3;
    public GameObject point4;
    public GameObject point5;
    public GameObject point6;
    public GameObject point7;
    public GameObject point8;
    public GameObject point9;
    public GameObject point10;
    public GameObject point11;
    public GameObject point12;
    public GameObject point13;
    public GameObject point14;
    public GameObject point15;
    public GameObject point16;
    public GameObject point17;
    public GameObject point18;
    public GameObject point19;
    public GameObject point20;
    public GameObject point21;
    public GameObject point22;
    public GameObject point23;
    public GameObject point24;
    public GameObject point25;
    public GameObject point26;
    public GameObject point27;
    public GameObject point28;
    public GameObject point29;
    public GameObject point30;
    public GameObject point31;
    public GameObject point32;
    public GameObject point33;
    public GameObject point34;
    public GameObject point35;
    public GameObject point36;
    public GameObject point37;
    public GameObject point38;
    public GameObject point39;
    public GameObject point40;

    public GameObject tracker;

    public int count;

    // Update is called once per frame
    void Update()
    {
        if(count == 0)
        {
            tracker.transform.position = point1.transform.position;
        }
        if (count == 1)
        {
            tracker.transform.position = point2.transform.position;
        }
        if (count == 2)
        {
            tracker.transform.position = point3.transform.position;
        }
        if (count == 3)
        {
            tracker.transform.position = point4.transform.position;
        }
        if (count == 4)
        {
            tracker.transform.position = point5.transform.position;
        }
        if (count == 5)
        {
            tracker.transform.position = point6.transform.position;
        }
        if (count == 6)
        {
            tracker.transform.position = point7.transform.position;
        }
        if (count == 7)
        {
            tracker.transform.position = point8.transform.position;
        }
        if (count == 8)
        {
            tracker.transform.position = point9.transform.position;
        }
        if (count == 9)
        {
            tracker.transform.position = point10.transform.position;
        }
        if (count == 10)
        {
            tracker.transform.position = point11.transform.position;
        }
        if (count == 11)
        {
            tracker.transform.position = point12.transform.position;
        }
        if (count == 12)
        {
            tracker.transform.position = point13.transform.position;
        }
        if (count == 13)
        {
            tracker.transform.position = point14.transform.position;
        }
        if (count == 14)
        {
            tracker.transform.position = point15.transform.position;
        }
        if (count == 15)
        {
            tracker.transform.position = point16.transform.position;
        }
        if (count == 16)
        {
            tracker.transform.position = point17.transform.position;
        }
        if (count == 17)
        {
            tracker.transform.position = point18.transform.position;
        }
        if (count == 18)
        {
            tracker.transform.position = point19.transform.position;
        }
        if (count == 19)
        {
            tracker.transform.position = point20.transform.position;
        }
        if (count == 20)
        {
            tracker.transform.position = point21.transform.position;
        }
        if (count == 21)
        {
            tracker.transform.position = point22.transform.position;
        }
        if (count == 22)
        {
            tracker.transform.position = point23.transform.position;
        }
        if (count == 23)
        {
            tracker.transform.position = point24.transform.position;
        }
        if (count == 24)
        {
            tracker.transform.position = point25.transform.position;
        }
        if (count == 25)
        {
            tracker.transform.position = point26.transform.position;
        }
        if (count == 26)
        {
            tracker.transform.position = point27.transform.position;
        }
        if (count == 27)
        {
            tracker.transform.position = point28.transform.position;
        }
        if (count == 28)
        {
            tracker.transform.position = point29.transform.position;
        }
        if (count == 29)
        {
            tracker.transform.position = point30.transform.position;
        }
        if (count == 30)
        {
            tracker.transform.position = point31.transform.position;
        }
        if (count == 31)
        {
            tracker.transform.position = point32.transform.position;
        }
        if (count == 32)
        {
            tracker.transform.position = point33.transform.position;
        }
        if (count == 33)
        {
            tracker.transform.position = point34.transform.position;
        }
        if (count == 34)
        {
            tracker.transform.position = point35.transform.position;
        }
        if (count == 35)
        {
            tracker.transform.position = point36.transform.position;
        }
        if (count == 36)
        {
            tracker.transform.position = point37.transform.position;
        }
        if (count == 37)
        {
            tracker.transform.position = point38.transform.position;
        }
        if (count == 38)
        {
            tracker.transform.position = point39.transform.position;
        }
        if (count == 39)
        {
            tracker.transform.position = point40.transform.position;
        }


    }
    IEnumerator OnTriggerEnter(Collider c)
    {
        if(c.gameObject.tag == "AICar")
        {
            this.GetComponent<BoxCollider>().enabled = false;
            if(count == 40)
            {
                count = 0;
            }
            count = count + 1;
            yield return new WaitForSeconds(0.02f);
            this.GetComponent<BoxCollider>().enabled = true;
        }
    }
}
