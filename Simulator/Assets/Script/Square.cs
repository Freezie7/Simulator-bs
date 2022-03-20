using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square : MonoBehaviour
{

    [Tooltip("Скорость перемещения квадрата")]
    public float moveSpeed;
    [Tooltip("Прирост скорости при перерождении")]
    public float speedFactor;
    [Tooltip("Уменьшение размера при перерождении")]
    public float scaleFactor;
    [Tooltip("Сколько раз нужно поймать квадрат, чтобы он исчез?")]
    public int catchCount;
    [Tooltip("Это квадрат опасен для игрока?")]
    public bool isTrap;
    [Tooltip("Компонент, управляющий анимацией Квадрата")]
    public Animator animator;

    // Точка, к которой движется квадрат
    private Vector3 targetPosition;

    void Start()
    {
        // Задаем случайную позицию для перемещения
        targetPosition = GetRandomPosition();

        if (isTrap == false)
        {
            // Регистрируем в списке квадратов
            Player.squares.Add(this);
        }
    }

    void Update()
    {
        // Двигаемся к целевой позиции
        transform.position = Vector3.MoveTowards(transform.position,
            targetPosition, moveSpeed * Time.deltaTime);

        // Если приехали
        if (transform.position == targetPosition)
        {
            // Переназначаем случайную позицию для перемещения
            targetPosition = GetRandomPosition();
        }

    }

    void OnMouseDown()
    {
        if (isTrap)
        {
           // animator.SetTrigger("trap");
            Player.Defeat();
        }
        else
        {
           // animator.SetTrigger("catch");
            Catch();
        }
    }

    void Catch()
    {
        // Засчитываем очко Игроку
        Player.score++;
        // Отнимаем жизни
        catchCount--;

        // Если жизни квадрата закончились
        if (catchCount == 0)
        {
            // Исключаем из списка квадратов в игре
            Player.squares.Remove(this);
            // Уничтожаем его
            Destroy(gameObject);
        }
        else
        {
            // Увеличиваем скорость
            moveSpeed += speedFactor;
            // Уменьшаем размер
            transform.localScale -= new Vector3(scaleFactor, scaleFactor, scaleFactor);
            // Телепортируем в случайное место
            transform.position = GetRandomPosition();
        }


    }

    Vector3 GetRandomPosition()
    {
        Vector3 randomPosition = new Vector3();

        randomPosition.x = Random.Range(-8, 8);
        randomPosition.y = Random.Range(-4, 4);
        randomPosition.z = transform.position.z;

        return randomPosition;
    }
}
