using System;
using System.Collections;
using System.Collections.Generic;
using Scrips.Towers;
using UnityEngine;

public class TowerBase : MonoBehaviour
{
    protected EnemyInRangeChecker _rangeChecker;
    protected Enemy _target;
    [SerializeField] private float _cooldown = 0;
    [SerializeField] private float _currentCooldown = 0;
    private void Awake()
    {
        _rangeChecker = GetComponent<EnemyInRangeChecker>();
        _currentCooldown = _cooldown;
    }

    private void Update()
    {
        if(CanAttack()) RotateToTarget(_target.transform.position);
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
    
    protected virtual void RotateToTarget(Vector3 location)
    {
    }
    
    public virtual void setUsterinterface(GameObject obj){}
}
