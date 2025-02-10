using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Conditions {

	public class CrandomNumber : ConditionTask {

		public int thebestnumberintheworld;
		public BBParameter<int> theRandom;
		public BBParameter<int> themin;
		public BBParameter<int> theMAX;
		float TIME = 0f;

		protected override bool OnCheck() {
			          
			TIME += Time.deltaTime;
			if(TIME >= 3f)
			{
				theRandom.value = Random.Range(themin.value, theMAX.value);
                TIME = 0f;

            }
            if (theRandom.value == thebestnumberintheworld)
            {
				
               
            }
            return true;
        }
	}
}