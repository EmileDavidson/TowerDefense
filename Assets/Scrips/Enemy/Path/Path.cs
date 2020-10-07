﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Opdrachten
{
    /// <summary>
    /// De path class beheerd een array van waypoints. En houd bij bij welk waypoint een object is.
    /// Deze vormen samen het pad. 
    /// Logica die op het path niveau plaatsvindt gebeurt in deze class.
    /// Een deel van de functies welke je nodig hebt zijn hier al beschreven.
    /// </summary>
    public class Path : MonoBehaviour
    {

        // public Waypoint[] wayPoints;
        public Waypoint[] wayPoints;
        public int currentWayPoint = 0;

        private void Awake()
        {
            // print(GameObject.Find("Waypoints").name);
            // print(GameObject.Find("Waypoints").transform.childCount);
            wayPoints = GameObject.Find("Waypoints").GetComponentsInChildren<Waypoint>();
        }

        /// <summary>
        /// Deze functie returned het volgende waypoint waar naartoe kan worden bewogen.
        /// </summary>
        public Waypoint GetNextWaypoint()
        {
            // dit is nu niet goed, zorg ervoor dat het goede waypoint wordt teruggegeven.
            if (currentWayPoint + 1 >= wayPoints.Length) return null;
            return wayPoints[currentWayPoint + 1];
        }

        public Waypoint getCurrentWaypoint()
        {
            if (wayPoints.Length < 1) return null;
            return wayPoints[currentWayPoint];
        }
    }
}