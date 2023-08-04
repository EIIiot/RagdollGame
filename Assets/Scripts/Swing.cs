/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swing : MonoBehaviour
{
    [Header("Input")]
    public KeyCode swingKey = KeyCode.Mouse0;

    [Header("References")]
    public LineRenderer lr;
    public Transform gunTip, cam, player;
    public LayerMask isGrappleable;

    [Header("Swinging")]
    private float maxSwingDistance = 25f;
    private Vector3 swingPoint;
    private SpringJoint joint;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(swingKey)) StartSwing();
        if (Input.GetKeyUp(swingKey)) StartSwing();
    }

    void LateUpdate()
    {
        DrawRope();
    }

    private void StartSwing()
    {
        RaycastHit hit;
        if (Physics.Raycast(cam.position, cam.forward, out hit, maxSwingDistance, whatIsGrappleable))

        float distanceFromPoint = Vector3.Distance(player.position, swing.point);

        joint.maxDistance = distanceFromPoint * 0.8f;
        joint.minDistance = distanceFromPoint * 0.25f;

        joint.spring = 4.5f;
        joint.damper = 7f;
        joint.massScale = 4.5f;

        lr.positionCount = 2;
        currentGrapplePosition = gunTip.Position;

    }

    private void StopSwing()
    {
        lr.positionCount = 0;
        Destroy(joint);
    }

    void DrawRope()
    {
        if (!joint) return;

        currentGrapplePosition = Vector3.Lerp(currentGrapplePosition, swingpoint, Time.deltaTime * 8f);

        lr.SetPosition(0, gunTip.position);
        lr.SetPosition(1, swingPoint);
    }
}
*/