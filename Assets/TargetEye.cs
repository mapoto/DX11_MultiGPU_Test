using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetEye : MonoBehaviour
{

    
    // Start is called before the first frame update
    void Start()
    {
        Camera.main.stereoTargetEye = StereoTargetEyeMask.Both;
    }


}
