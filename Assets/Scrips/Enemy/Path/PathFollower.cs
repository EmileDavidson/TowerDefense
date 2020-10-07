using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Opdrachten
{
    /// <summary>
    /// De path follower class is verantwoordelijk voor de beweging.
    /// Deze class zorgt ervoor dat het object (in Tower Defense) vaak een enemy, het path afloopt
    /// tip: je kunt de transform.LookAt() functie gebruiken en vooruitbewegen.
    /// </summary>
    ///
    
    public class PathFollower : MonoBehaviour
    {
        public UnityEvent onPathComplete;
        public UnityEvent ONPathComplete => onPathComplete;
        [SerializeField] private Path _path;
        private Vector3 _startPos;
        private Waypoint _currentWaypoint;
        public float speed = 5;

        void Start()
        {
            _currentWaypoint = _path.getCurrentWaypoint();
            _startPos = transform.position;
            
            if(onPathComplete == null){onPathComplete = new UnityEvent();}
        }
        
        private void Update()
        {
            if (_path == null)
            {
                print("_path == null");
                return;
            }
            if (_path.wayPoints.Length == 0)
            {
                print("er is geen path gevonden (array.lenght == 0)");
                return;
            }
            if (_currentWaypoint == null)
            {
                onPathComplete.Invoke();
                Destroy(this.gameObject);
                return;
            }
            
            Vector3 targetPos = _path.getCurrentWaypoint().Position;
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(targetPos.x, transform.position.y, targetPos.z), speed * Time.deltaTime);
            transform.LookAt(new Vector3(targetPos.x, transform.position.y, targetPos.z));
            if (transform.position == new Vector3(targetPos.x, transform.position.y, targetPos.z))
            {
                float distance = Vector3.Distance(_startPos, transform.position);
                _startPos = transform.position;
                _currentWaypoint = _path.GetNextWaypoint();
                _path.currentWayPoint++;
            }
        }
    }
}