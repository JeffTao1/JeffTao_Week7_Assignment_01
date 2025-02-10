using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions
{
    public class AwaitActionTask : ActionTask
    {
        //public float minWaitTime;
        //public float maxWaitTime;
        public BBParameter<Vector3> startingPosition;

        //private float totalTimeToWait;
        //private float timeWaiting = 0f;

        protected override string OnInit()
        {
            startingPosition.value = agent.transform.position;
            return null;
        }

        //protected override void OnExecute()
        //{
        //    timeWaiting = 0f;
        //    totalTimeToWait = Random.Range(minWaitTime, maxWaitTime);
        //}

        //protected override void OnUpdate()
        //{
        //    timeWaiting += Time.deltaTime;
        //    if (timeWaiting > totalTimeToWait)
        //    {
        //        EndAction(true);
        //    }
        //}
    }
}