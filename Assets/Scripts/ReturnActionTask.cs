using NodeCanvas.Framework;
using UnityEngine.AI;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions
{
    public class ReturnActionTask : ActionTask
    {
        public BBParameter<Vector3> startingPosition;
        public float arrivalDistance;

        private NavMeshAgent navAgent;

        protected override string OnInit()
        {
            navAgent = agent.GetComponent<NavMeshAgent>();
            return null;
        }

        protected override void OnExecute()
        {
            if (!NavMesh.SamplePosition(startingPosition.value, out NavMeshHit navMeshHit, 2, NavMesh.AllAreas))
            {
                Debug.Log("Could not generate a path.");
            }
            else
            {
                navAgent.SetDestination(navMeshHit.position);
            }
        }

        protected override void OnUpdate()
        {
            float distanceToTarget = Vector3.Distance(startingPosition.value, agent.transform.position);
            if (navAgent.pathStatus == NavMeshPathStatus.PathComplete &&
                 distanceToTarget < arrivalDistance)
            {
                EndAction(true);
            }
        }
    }
}