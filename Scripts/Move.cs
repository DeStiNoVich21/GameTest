using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveHero : MonoBehaviour
{
    public float moveSpeed = 5f; // �������� �������� ���������

    void Update()
    {
        // �������� ������� ������ � ������ (WASD ��� �������)
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");

        // ��������� ������� ��������� �������� ����� Transform
        transform.position += new Vector3(moveX, moveY, 0) * moveSpeed * Time.deltaTime;
    }
}
