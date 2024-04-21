using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

namespace CompactMORPG
{
    [Serializable]
    public class WayPoint
    {
        public Vector3 localPosition;
    }
    
    public class Patrol : MonoBehaviour
    {
        public List<WayPoint> m_WayPointsList = new List<WayPoint>();
        public float distance = 10f;
        
        private void Awake()
        {

        }

        public void Init()
        {
            foreach (var wayPoint in m_WayPointsList)
            {
                float randomX = UnityEngine.Random.Range(-distance, distance);
                float randomZ = UnityEngine.Random.Range(-distance, distance);
                
                wayPoint.localPosition = new Vector3(randomX, 0, randomZ);
            }

        }

        public void CleanUp()
        {
            m_WayPointsList.Clear();
            m_WayPointsList = null;
        }
        
        public void DrawGizmos()
        {
            Gizmos.color = Color.red;
            foreach (var wayPoint in m_WayPointsList)
            {
                Gizmos.DrawSphere(wayPoint.localPosition, 0.5f);
            }
        }
    }
}