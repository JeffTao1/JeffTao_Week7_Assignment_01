using NodeCanvas.Framework;
using ParadoxNotion.Design;
//using System.Numerics;
using UnityEngine.AI;
using UnityEngine;


namespace NodeCanvas.Tasks.Actions {

	public class NavigateTask : ActionTask {

		public BBParameter<Vector3> targetPosition;
		public float sampleRate;
		public float sampleRadius;

		private NavMeshAgent nav;
		private Vector3 LastDestubatuion;
		private float timeSinceLastSample = 0;

        protected override string OnInit()
        {
			nav = agent.GetComponent<NavMeshAgent>();
			return null;
        }
        protected override void OnUpdate()
        {
			timeSinceLastSample += Time.deltaTime;
			if(timeSinceLastSample > sampleRate)
			{
				timeSinceLastSample = 0;
				if(LastDestubatuion != targetPosition.value)
				{
					LastDestubatuion = targetPosition.value;
					NavMesh.SamplePosition(targetPosition.value, out NavMeshHit hitInfo, sampleRadius, NavMesh.AllAreas);
					nav.SetDestination(hitInfo.position);
				}
			}
        }
    }
}