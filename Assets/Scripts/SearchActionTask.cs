using NodeCanvas.Framework;
using UnityEngine.AI;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions
{
    public class SearchActionTask : ActionTask
    {
        public float randomPositionDistance;
        public float arrivalDistance;

        private NavMeshAgent navAgent;
        private Vector3 destination;

        protected override string OnInit()
        {
            navAgent = agent.GetComponent<NavMeshAgent>();
            return null;
        }

        protected override void OnExecute()
        {
            Vector3 randomPosition = randomPositionDistance * Random.insideUnitSphere + agent.transform.position;

            if (!NavMesh.SamplePosition(randomPosition, out NavMeshHit navMeshHit, randomPositionDistance * 2, NavMesh.AllAreas))
            {
                Debug.LogWarning("Could not generate a path.");
            }
            else
            {
                destination = navMeshHit.position;
                navAgent.SetDestination(destination);
            }
        }

        protected override void OnUpdate()
        {
            float distanceToTarget = Vector3.Distance(destination, agent.transform.position);

            if (navAgent.pathStatus == NavMeshPathStatus.PathComplete &&
                 distanceToTarget < arrivalDistance)
            {
                EndAction(true);
            }
        }
    }
}