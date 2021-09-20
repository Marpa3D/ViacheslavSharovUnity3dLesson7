using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Контроллер движений Главного персонажа от Вячеслава Шарова
    // Ученик GeekBrains, Курс "оздание 3D игр"

    [Header("Скорость персонажа")]
    [SerializeField] private float _speed;
    
    private void Update()
    {
        GetInput();
    }

    // Функция считывания нажатия клавиш и изменющяя положение персонажа
    private void GetInput() 
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.localPosition += transform.forward * _speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.localPosition += -transform.right * _speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.localPosition += transform.right * _speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.localPosition += -transform.forward * _speed * Time.deltaTime;
        }
    }
}
