using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class ImageController : MonoBehaviour
{
    // ячейка под отслеживаемый объект
    public GameObject Anchor;

    // ячейка под объект, который устанавливается относительно Anchor
    public GameObject Room;
    
    public bool SetAnchor;

    // скрипт, отвечающий за отслеживание изображений (меток)
    private ARTrackedImageManager ARTrackedImageManagerScript;

    private void Awake()
    {
        // Создание ссылки на скрипт, , отвечающий за отслеживание изображений (меток) 
        ARTrackedImageManagerScript = FindObjectOfType<ARTrackedImageManager>();
    }


    // Update is called once per frame
    void Update()
    {
        // Нахождение в сцене объекта с тэгом Anchor
        Anchor = GameObject.FindWithTag("Anchor");
        // Присваивание объекту имени Anchor
        Anchor.name = "Anchor";

        if (SetAnchor)
        {
            // Установка объекта Room в место объекта Anchor
            Instantiate(Room, Anchor.transform.position, Anchor.transform.rotation);

            // Отключение отслеживания изображений (меток)
            ARTrackedImageManagerScript.SetTrackablesActive(false);

            SetAnchor = false;
        }

    }
}
