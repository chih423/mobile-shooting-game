using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Player Target;
    public float TurnSpeed;
    public float Speed;
    public float FollowRadius;
    private CharacterController cc;
    // Start is called before the first frame update
    void Start()
    {
        cc = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 relativePos = Target.transform.position - transform.position;
        Quaternion targetRotation = Quaternion.LookRotation(relativePos);
        transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, TurnSpeed * Time.deltaTime);
        float distance = Vector3.Distance(transform.position, Target.transform.position);
        if(distance < FollowRadius)
        {
            Vector3 dir = (Target.transform.position - transform.position).normalized;
            cc.Move(dir * Speed * Time.deltaTime);
        }
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, FollowRadius);
    }

}
