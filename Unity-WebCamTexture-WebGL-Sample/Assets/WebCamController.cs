using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WebCamController : MonoBehaviour
 {
    int width = 960;
    int height = 540;
    int fps = 30;
    WebCamTexture webcamTexture;

    void Start () 
    {
        WebCamDevice[] devices = WebCamTexture.devices;
        webcamTexture = new WebCamTexture(devices[0].name, this.width, this.height, this.fps);
        GetComponent<Renderer> ().material.mainTexture = webcamTexture;
        webcamTexture.Play();
    }
}