using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;




public class DLL : MonoBehaviour
{

    //Lets make our calls from the Plugin
    [DllImport("Project1", EntryPoint = "?Add@Functions@MathLibrary@@SANNN@Z")]
    private static extern double Add(double x, double y);

    // [DllImport("LMA_OPENCV_PLUGIN", EntryPoint = "?ProcessFrame@Functions@BackgroundSubtraction@@SAPEAEXZ")]
    // private static extern byte[] ProcessFrame();
    // Material m;
    void Start()
    {
        double x = 40.0;
        double y = 20.0;
        Debug.Log(Add(x, y));
        Debug.Log("done");
        //  m = new Material(Shader.Find("Diffuse"));
    }

    // void Update()
    //{
    //   byte[] imgData = ProcessFrame();
    //   Texture2D tex = new Texture2D(640, 480, TextureFormat.BGRA32, false);
    //   tex.LoadRawTextureData(imgData);
    //   tex.Apply();
    //  m.mainTexture = tex;
    //   this.GetComponent<Renderer>().material = m;
    // }
}