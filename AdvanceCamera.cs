using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdvanceCamera : MonoBehaviour
{

    public Transform Target;
    public float minDistance = 3f;
    public float maxDistance = 8f;
    public float cameraHeight = 1f;
    public float distance = 3f;
    public float scrollRate = 25f;
    public float _ySpeed = 50f;
    public float _xSpeed = 100f;

    private float wantedDistance;
    private float currentDistance;
    private float actualDistance;
    private float _y = 0.0f;
    private float _x = 0.0f;

    private bool click = false;


    void Start()
    {

        wantedDistance = distance;
        currentDistance = distance;
        actualDistance = distance;

    }


    void Update()
    {

        if (Input.GetMouseButtonDown(0))

            click = true;

        if (Input.GetMouseButtonUp(0))

            click = false;

        {

            {

                if (Target != null)

                {

                    if (click)

                    {

                        _y -= Input.GetAxis("Mouse Y") * _ySpeed * 0.05f;
                        _x += Input.GetAxis("Mouse X") * _xSpeed * 0.05f;

                    }

                    if (Input.GetAxis("Vertical") != 0 || Input.GetAxis("Horizontal") != 0) ;

                    Quaternion rotation = Quaternion.Euler(_y, _x, 0);

                    wantedDistance -= Input.GetAxis("Mouse ScrollWheel") * Time.deltaTime * scrollRate * Mathf.Abs(wantedDistance);

                    wantedDistance = Mathf.Clamp(wantedDistance, minDistance, maxDistance);

                    actualDistance = wantedDistance;

                    Vector3 position = Target.position - (rotation * Vector3.forward * wantedDistance);

                    RaycastHit collisionHit;

                    Vector3 cameraTargetPosition = new Vector3(Target.position.x, Target.position.y + cameraHeight, Target.position.z);

                    bool isCorrected = false;

                    if (Physics.Linecast(cameraTargetPosition, position, out collisionHit))

                    {

                        position = collisionHit.point;

                        actualDistance = Vector3.Distance(cameraTargetPosition, position);

                        isCorrected = true;

                    }

                    currentDistance = !isCorrected || actualDistance > currentDistance ? Mathf.Lerp(currentDistance, actualDistance, Time.deltaTime * scrollRate) : actualDistance;

                    position = Target.position - (rotation * Vector3.forward * currentDistance + new Vector3(0, -cameraHeight, 0));

                    transform.rotation = rotation;

                    transform.position = position;

                }

            }

        }
    }

}
