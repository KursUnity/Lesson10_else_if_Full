using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CarMover : MonoBehaviour
{
    public Text numberText;
    int number;
    bool isCanMoveForward;
    bool isCanMoveBackward;
    public float speed = 2f;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            number++;
            numberText.text = number.ToString();
            
            if (number > 5 && number < 10) // Выполняется блок кода если number больше 5 И number меньше 10 | Если хоть одно условие неверное, то код не сработает
            {
                isCanMoveBackward = false;
                isCanMoveForward = true;
            }
            else if(number > 10 || number == 3) // Выполняется блок кода если number больше 10 ИЛИ number равен 3 | Если хотя бы 1 условие верное, код сработает
            {
                isCanMoveForward = false;
                isCanMoveBackward = true;
            }
            else
            {
                isCanMoveForward = false;
                isCanMoveBackward = false;
            }

        }

        if (isCanMoveForward)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - speed * Time.deltaTime);
        }

        if (isCanMoveBackward)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + speed * Time.deltaTime);
        }
    }
}
