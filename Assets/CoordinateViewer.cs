using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CoordinateViewer : MonoBehaviour
{
    public Camera camera;

    public TMP_Text text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        string coords = string.Format("X:{0}, Y{1}, Z{2}", camera.transform.position.x, camera.transform.position.y, camera.transform.position.z);
        text.text = coords;
    }
}
