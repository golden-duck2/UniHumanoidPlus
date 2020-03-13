using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateAvatar : MonoBehaviour
{
    [SerializeField] Transform Head;
    [SerializeField] Transform RightHand;
    [SerializeField] Transform LeftHand;
    [SerializeField] Transform RightLeg;
    [SerializeField] Transform LeftLeg;
    [SerializeField] Transform Hip;

    public BodyPartPosition BodyPartPositionPrefab;

    Dictionary<HumanBodyBones, BodyPartPosition> boneDict = new Dictionary<HumanBodyBones, BodyPartPosition>();

    HumanBodyBones[] createList = new HumanBodyBones[]{
        // Trunk
        HumanBodyBones.Head,
        HumanBodyBones.Neck,
        HumanBodyBones.Chest,
        HumanBodyBones.Spine,
        HumanBodyBones.Hips,
        // Arms
        HumanBodyBones.LeftShoulder,
        HumanBodyBones.LeftUpperArm,
        HumanBodyBones.LeftLowerArm,
        HumanBodyBones.LeftHand,
        HumanBodyBones.RightShoulder,
        HumanBodyBones.RightUpperArm,
        HumanBodyBones.RightLowerArm,
        HumanBodyBones.RightHand,
        // Legs
        HumanBodyBones.LeftLowerLeg,
        HumanBodyBones.LeftUpperLeg,
        HumanBodyBones.LeftFoot,
        HumanBodyBones.RightLowerLeg,
        HumanBodyBones.RightUpperLeg,
        HumanBodyBones.RightFoot,
    };


    // Start is called before the first frame update
    void Start()
    {

    }

    private void CreateParts(HumanBodyBones bone)
    {
        var go = Instantiate(BodyPartPositionPrefab, Vector3.zero, Quaternion.identity) as BodyPartPosition;

        
    }
}
