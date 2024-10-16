using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Player
{
    public class PlayerMovement : Pl

    {
        public GameObject sword; // ������������ ���� ������ ���� � ����������
        public Transform weaponAnchor; // ��� ����� �� ��������� (��������, ����)


        void Start()
        {
            // ����������� ��� � ���������
            sword.transform.SetParent(weaponAnchor);
            sword.transform.localPosition = Vector3.zero; // ������������� ������� ������������ ��������� �����
        }


        public override void MoveUp()
        {




        }
        public override void MoveDown()
        {




        }
        public override void MoveLeft()
        {


        }
        public override void MoveRight()
        {



        }
        public override void Kick()
        {
            StartCoroutine(SwingSword());
        }

        // Coroutine ��� ������ ����
        private IEnumerator SwingSword()
        {
            float duration = 0.05f; // ������������ ��������
            float elapsed = 0f;

            Quaternion initialRotation = sword.transform.localRotation; // ��������� ������� ����
            Quaternion targetRotation = Quaternion.Euler(0, 0, -90); // �������� ������� (����� �� 90 ��������)

            // ������ ��������� �������� ����
            while (elapsed < duration)
            {
                elapsed += Time.deltaTime;
                float t = Mathf.Clamp01(elapsed / duration);
                sword.transform.localRotation = Quaternion.Lerp(initialRotation, targetRotation, t);
                yield return null;
            }

            // ���������� ��� � �������� ���������
            elapsed = 0f;
            while (elapsed < duration)
            {
                elapsed += Time.deltaTime;
                float t = Mathf.Clamp01(elapsed / duration);
                sword.transform.localRotation = Quaternion.Lerp(targetRotation, initialRotation, t);
                yield return null;
            }
        }
    }
}
