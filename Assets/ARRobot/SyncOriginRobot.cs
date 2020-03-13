using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SyncOriginRobot : MonoBehaviour
{

    public SyncTransforms source;
    SyncTransforms dist = new SyncTransforms();

    [SerializeField] Animator thisAnimator = default;

    [System.Serializable]
    public class SyncTransforms
    {
        public Transform Hip = default;
        public Transform Chest = default;
        public Transform UpperChest = default;
        public Transform Neck = default;
        public Transform Head = default;

        public RobotArm LeftArm;
        public RobotArm RightArm;
        public RobotLeg LeftLeg;
        public RobotLeg RightLeg;

        [System.Serializable]

        public class RobotLeg
        {
            public Transform Leg = default;
            public Transform LegHint = default;
            public Transform Foot = default;
        }

        [System.Serializable]
        public class RobotArm
        {
            public Transform Shoulder = default;
            public Transform UpperArm = default;
            public Transform LowerArm = default;
            public Transform Hand = default;
        }
    }

    private void Update()
    {
        dist.Hip = thisAnimator.GetBoneTransform(HumanBodyBones.Hips);
        dist.Chest = thisAnimator.GetBoneTransform(HumanBodyBones.Chest);
        dist.UpperChest = thisAnimator.GetBoneTransform(HumanBodyBones.UpperChest);
        dist.Neck = thisAnimator.GetBoneTransform(HumanBodyBones.Neck);
        dist.Head = thisAnimator.GetBoneTransform(HumanBodyBones.Head);
    }
}
