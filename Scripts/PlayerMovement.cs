using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Player
{
    public class PlayerMovement : Pl

    {
        public GameObject sword; // Перетаскивай сюда объект меча в инспекторе
        public Transform weaponAnchor; // Это точка на персонаже (например, рука)


        void Start()
        {
            // Привязываем меч к персонажу
            sword.transform.SetParent(weaponAnchor);
            sword.transform.localPosition = Vector3.zero; // Устанавливаем позицию относительно оружейной точки
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

        // Coroutine для взмаха меча
        private IEnumerator SwingSword()
        {
            float duration = 0.05f; // Длительность анимации
            float elapsed = 0f;

            Quaternion initialRotation = sword.transform.localRotation; // Начальная ротация меча
            Quaternion targetRotation = Quaternion.Euler(0, 0, -90); // Конечная ротация (взмах на 90 градусов)

            // Плавно анимируем вращение меча
            while (elapsed < duration)
            {
                elapsed += Time.deltaTime;
                float t = Mathf.Clamp01(elapsed / duration);
                sword.transform.localRotation = Quaternion.Lerp(initialRotation, targetRotation, t);
                yield return null;
            }

            // Возвращаем меч в исходное положение
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
