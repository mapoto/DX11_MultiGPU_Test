using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimedTranslation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position = new Vector3(gameObject.transform.position.x, Mathf.Sin(Time.time ), gameObject.transform.position.z);
    }
}
