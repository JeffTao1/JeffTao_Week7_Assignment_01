using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;
using UnityEngine.AI;


namespace NodeCanvas.Tasks.Actions {
    
    public class Mousemovement : ActionTask {
        public  NavMeshAgent navAgent;
       


		
		protected override void OnExecute() {
            if (Input.GetMouseButtonDown(0))
            {
                Ray mouseRay = Camera.main.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(mouseRay, out RaycastHit hitInfo))
                {
                    navAgent.SetDestination(hitInfo.point);

                }
            }

            EndAction(true);
		}

		
	}
}