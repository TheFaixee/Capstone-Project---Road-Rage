using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HalfPoint : MonoBehaviour
{
    public GameObject halfPoint;
    public GameObject finishPoint;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter()
    {
        halfPoint.SetActive(false);
        finishPoint.SetActive(true);
    }
}
