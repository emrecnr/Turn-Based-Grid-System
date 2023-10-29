using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Unit : MonoBehaviour
{
    private Vector3 _targetPosition;
    float _moveSpeed = 5f;
    float _stopDistance = 0.1f;
    private void Update()
    {
        if (GetDistance())
        {
            Vector3 moveDirection = (_targetPosition - transform.position).normalized;
            transform.position += moveDirection * Time.deltaTime * _moveSpeed;
        }


        if (Input.GetMouseButtonDown(0))
        {
            Move(MouseWorld.GetPosition());
        }
    }

    private void Move(Vector3 targetPosition)
    {
        _targetPosition = targetPosition;
    }
    private bool GetDistance()
    {

        return Vector3.Distance(transform.position, _targetPosition) > _stopDistance;
    }
}
