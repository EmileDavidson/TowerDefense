using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Opdrachten
{
    /// <summary>
    /// De path follower class is verantwoordelijk voor de beweging.
    /// Deze class zorgt ervoor dat het object (in Tower Defense) vaak een enemy, het path afloopt
    /// tip: je kunt de transform.LookAt() functie gebruiken en vooruitbewegen.
    /// </summary>
    public class PathFollower : MonoBehaviour
    {
        [SerializeField] private Path _path;
        private Vector3 _startPos;
        private Waypoint _currentWaypoint;
        public float speed = 5;
    

        void Start()
        {
            _currentWaypoint = _path.getCurrentWaypoint();
            _startPos = transform.position;
        }

        private void Update()
        {
            if (_currentWaypoint == null)
            {
                print("Enemy is bij het einde");
                return;
            }
            
            Vector3 targetPos = _path.getCurrentWaypoint().Position;
            
            transform.position = Vector3.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);

            if (transform.position == targetPos)
            {
                float distance = Vector3.Distance(_startPos, transform.position);
                print("afstand: " + distance);
                _startPos = transform.position;
                _currentWaypoint = _path.GetNextWaypoint();
                _path.currentWayPoint++;
            }
        }
    }
}