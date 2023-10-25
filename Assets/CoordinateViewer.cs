using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

public class CoordinateViewer : MonoBehaviour
{
    public Camera camera;

    public TMP_Text text;

    // static string serverIP = "10.193.162.205";
    // static int serverPort= 8080;
    // static TcpClient client = new TcpClient(serverIP, serverPort);



    void Update()
    {
        string coords = string.Format("X:{0}, Y{1}, Z{2}", camera.transform.position.x, camera.transform.position.y, camera.transform.position.z);
        text.text = coords;

        

        // Генерируйте новые координаты здесь
        double coordinates1, coordinates2, coordinates3;
        coordinates1 = camera.transform.position.x;
        coordinates2 = camera.transform.position.y;
        coordinates3 = camera.transform.position.z;
        
        string coordinates = string.Format("{0};{1};{2}", coordinates1, coordinates2, coordinates3);

       

        // byte[] data = Encoding.UTF8.GetBytes();
        // stream.Write(data, 0, data.Length);
        System.Console.WriteLine("Координаты отправлены: ");
    }
}
    