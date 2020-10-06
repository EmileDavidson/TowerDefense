using System;
using System.Collections;
using System.Collections.Generic;
using Scrips.Towers;
using UnityEngine;

public class TowerBase : MonoBehaviour
{
    protected EnemyInRangeChecker _rangeChecker;
    protected Enemy _target;
    private float _cooldown = 0;
    private float _currentCooldown = 0;
    private void Awake()
    {
        _rangeChecker = GetComponent<EnemyInRangeChecker>();
        _currentCooldown = _cooldown;
    }

    private void Update()
    {
        if (!CanAttack()) return;
        Attack();
    }

    protected virtual bool CanAttack()
    {
        return false;
    }
    protected virtual void Attack()
    {
    }
}
