using NodeCanvas.Framework;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class SeekTask : ActionTask
{
    public BBParameter<bool> hasTarget;
    public BBParameter<Vector3> targetPosition;
    public Transform  target;
    protected override void OnUpdate()
    {
        hasTarget.value = target != null;
        targetPosition.value = target.position;
    }
}
