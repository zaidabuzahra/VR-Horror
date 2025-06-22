using UnityEngine;

public class TriggerEnter : MonoBehaviour
{
    public Animator doorAnimator;
    public string enterTrigger = "OpenDoor", exitTrigger = "CloseDoor";
    public bool enterVal, exitVal;
    public bool isEnterTrigger, isExitTrigger;
    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player")) return;
        Enter();
    }
    public void Enter()
    {
        doorAnimator.SetBool(enterTrigger, enterVal);
        Debug.Log(gameObject.name + " HUHHH");
    }
    public void Exit()
    {
        doorAnimator.SetBool(exitTrigger, exitVal);
    }
    private void OnTriggerExit(Collider other)
    {
        if (!other.CompareTag("Player")) return;
        Exit();
    }
}
