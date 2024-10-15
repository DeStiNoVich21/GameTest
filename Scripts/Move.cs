using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveHero : MonoBehaviour
{
    public float moveSpeed = 5f; // Скорость движения персонажа

    void Update()
    {
        // Получаем входные данные с клавиш (WASD или стрелки)
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");

        // Обновляем позицию персонажа напрямую через Transform
        transform.position += new Vector3(moveX, moveY, 0) * moveSpeed * Time.deltaTime;
    }
}
