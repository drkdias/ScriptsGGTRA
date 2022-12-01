using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
 
public class AutoFocusCam : MonoBehaviour
{
    void Start()
    {
        Focus();
    }
 
    void Focus()
    {
        CameraDevice.Instance.SetFocusMode(CameraDevice.FocusMode.FOCUS_MODE_CONTINUOUSAUTO);
        Invoke("Focus", 1);
    }
}