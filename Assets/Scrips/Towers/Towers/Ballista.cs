using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Scrips.Towers.Towers
{
    public class Ballista : TowerBase
    {
        [SerializeField] private GameObject _userInterfaceObject;
        [SerializeField] private float rotateSpeed = 10f;
        [SerializeField] private int _maxTargets = 3;
        protected override bool CanAttack()
        {
            _targets = _rangeChecker.GetAllEnemiesInRange();
           // print(_targets);
            return _targets != null;
        }

        protected override void Attack()
        {
            Debug.Log(_targets);
            if(_targets.Length <= 0) return;
            if (_targets.Length >= _maxTargets)
            {
                //er zijn meer of precies gelijk targets dan je max targets
                for (int i = 0; i < _maxTargets; i++)
                {
                    _targets[i].RemoveHealth(1);
                }
            }
            else
            {
                //er zijn minder targets dan je max targets \
                for (int i = 0; i < _targets.Length; i++)
                {
                    _targets[i].RemoveHealth(1);
                }
            }
        }

        protected override void RotateToTarget()
        {
            float targetNumber;
            if (_targets.Length <= 0) return;
            if (_targets.Length >= _maxTargets)
            {
                 targetNumber = _maxTargets / 2f;
            }
            else
            {
                 targetNumber = _targets.Length / 2f;
            }
            Vector3 location = _targets[Mathf.RoundToInt(targetNumber)].transform.position;
            Vector3 dir = location - transform.position;
            dir.y = 0;
            Quaternion rot = Quaternion.LookRotation(dir);
            transform.rotation = Quaternion.Slerp(transform.rotation, rot, rotateSpeed * Time.deltaTime);
        }
        

        public override void setUsterinterface(GameObject obj)
        {
            _userInterfaceObject = obj;
            hasInterface = true;
        }

        public override void openUserinterface()
        {
            _userInterfaceObject.SetActive(true);
        }
        
        public override bool hasUserinterface()
        {
            if (hasInterface) return true;
            return false;
        }
    }
}