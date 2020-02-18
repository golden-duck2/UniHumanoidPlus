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

    Dictionary<HumanBodyBones, Transform> boneDict = new Dictionary<HumanBodyBones, Transform>();

    HumanBodyBones[] createList = new HumanBodyBones[]{
        HumanBodyBones.Head,
        HumanBodyBones.LeftShoulder,
        HumanBodyBones.RightShoulder,
        HumanBodyBones.LeftLowerLeg,
        HumanBodyBones.RightLowerLeg,
        HumanBodyBones.LeftUpperLeg,
        HumanBodyBones.RightUpperLeg,
    };


    // Start is called before the first frame update
    void Start()
    {

    }

    private void CreateParts()
    {

    }
}
