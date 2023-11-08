using UnityEngine;

public class DoorBottomScript : MonoBehaviour
{
    [SerializeField] DoorScript door;

    public void OnPointerEnter()
    {
        OnLook();
    }

    public void OnPointerClick()
    {

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F1))
        {
            OnLook();
        }
    }

    public void OnLook()
    {
        door.OpenDoor();
    }
}
