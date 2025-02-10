using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;
using UnityEngine.UI;

namespace NodeCanvas.Tasks.Actions {

	public class ShowTheUI : ActionTask {

		public BBParameter<GameObject> Sleepzzz;//Sleep in bed
		public BBParameter<GameObject> badboyhhh;//push the bowl

		
		protected override void OnExecute() {
			if (Sleepzzz.value != null)
			{
				Sleepzzz.value.SetActive(true);
			}
			EndAction(true);
		}

		//Called once per frame while the action is active.
		protected override void OnUpdate() {
			
		}

	}
}