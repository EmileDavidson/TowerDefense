using System;
using System.Collections;
using System.Collections.Generic;
using Scrips.Towers;
using UnityEngine;

public class TowerBase : MonoBehaviour
{
    protected EnemyInRangeChecker _rangeChecker;
    protected Enemy _target;
    protected Enemy[] _targets;
    [SerializeField] private float _cooldown = 0;
    [SerializeField] private float _currentCooldown = 0;
    [SerializeField] protected bool hasInterface = false;
    private void Awake()
    {
        _rangeChecker = GetComponent<EnemyInRangeChecker>();
        _currentCooldown = _cooldown;
    }

    private void Update()
    {
        if(CanAttack()) RotateToTarget();
        if (_currentCooldown < 0)
        {
            if (!CanAttack()) return;
            _currentCooldown = _cooldown;
            Attack();
        } 
        else
        {
            _currentCooldown -= Time.deltaTime;
        }
    }

    protected virtual bool CanAttack()
    {
        return false;
    }
    protected virtual void Attack()
    {
    }
    
    protected virtual void RotateToTarget()
    {
    }
    
    public virtual void setUsterinterface(GameObject obj){}
    public virtual void openUserinterface(){}

    public virtual bool hasUserinterface()
    {
        if (hasInterface) return true;
        return false;
    }
}
