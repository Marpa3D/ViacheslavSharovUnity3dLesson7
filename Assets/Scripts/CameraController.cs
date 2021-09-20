using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Скрипт управления камерой от Вячеслава Шарова

     private float mouseX;
     private float mouseY;

    [SerializeField] Transform _player;

    [Header("Чувствительность мыши")]
    [SerializeField] private float sensMouse;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    
    void Update()
    {
        mouseX = Input.GetAxis("Mouse X") * sensMouse * Time.deltaTime;
        mouseY = Input.GetAxis("Mouse Y") * sensMouse * Time.deltaTime;

        _player.Rotate(mouseX * new Vector3(0, 1, 0));
        transform.Rotate(-mouseY * new Vector3(1, 0, 0));
    }
}
