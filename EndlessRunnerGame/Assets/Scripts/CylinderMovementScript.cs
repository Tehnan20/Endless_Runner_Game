using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinderMovementScript : MonoBehaviour
{
    public Transform ObstacleCylinderRight;
    public Transform ObstacleCylinderLeft;

    public GameObject CylinderGameObjects;
    public float Speed = 0.5f;

    public Transform RightPoint;
    public Transform LeftPoint;

    private Vector3 RCTargetPosition;
    private Vector3 LCTargetPosition;

    // Start is called before the first frame update
    void Start()
    {
        RCTargetPosition = LeftPoint.position;       
        LCTargetPosition = RightPoint.position;       
    }

    // Update is called once per frame
    void Update()
    {
        ObstacleCylinderRight.position = Vector3.MoveTowards(ObstacleCylinderRight.position, RCTargetPosition, Speed *Time.deltaTime);
        float distanceRC = Vector3.Distance(ObstacleCylinderRight.position, RCTargetPosition);

        Vector3 obstacleRCTranform = ObstacleCylinderRight.transform.position;
        obstacleRCTranform.z -= 30 *Time.deltaTime;
        ObstacleCylinderRight.transform.position = obstacleRCTranform;

        if(distanceRC <= 0)
        {
            if(RCTargetPosition == LeftPoint.position)
            {
                RCTargetPosition = RightPoint.position;
            }
            else
            {
                RCTargetPosition = LeftPoint.position;
            }
        }

        ObstacleCylinderLeft.position = Vector3.MoveTowards(ObstacleCylinderLeft.position, LCTargetPosition, Speed *Time.deltaTime);
        float distanceLC = Vector3.Distance(ObstacleCylinderLeft.position, LCTargetPosition);

        Vector3 obstacleLCTranform = ObstacleCylinderLeft.transform.position;
        obstacleLCTranform.z -= 30 *Time.deltaTime;
        ObstacleCylinderLeft.transform.position = obstacleLCTranform;

        if(distanceLC <= 0)
        {
            if(LCTargetPosition == RightPoint.position)
            {
                LCTargetPosition = LeftPoint.position;
            }
            else
            {
                LCTargetPosition = RightPoint.position;
            }
        }

        for(int i = 0; i < CylinderGameObjects.transform.childCount; i++)
        {
            if(CylinderGameObjects.transform.GetChild(i).position.z < -3.0f)
            {
                CylinderGameObjects.transform.GetChild(i).gameObject.SetActive(false);
            }
        }
    }
}
