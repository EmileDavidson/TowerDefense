using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blaster : TowerBase
{

    [SerializeField] private float rotateSpeed = 10f;
    protected override bool CanAttack()
    {
        _target = _rangeChecker.GetFirstEnemyInRange();
        return _target != null;
    }

    protected override void Attack()
    {
        RotateToTarget();
        _target.RemoveHealth(1);
    }
        
    protected override void RotateToTarget()
    {
        Vector3 location = _target.transform.position;
        Vector3 dir = location - transform.position;
        dir.y = 0;
        Quaternion rot = Quaternion.LookRotation(dir);
        transform.rotation = Quaternion.Slerp(transform.rotation, rot, rotateSpeed * Time.deltaTime);
    }
}
