using UnityEngine;

public class DoorScript : MonoBehaviour
{
    private Vector3 targetP;
    [SerializeField] private Vector3 BottomP;

    // Start is called before the first frame update
    void Start()
    {
        targetP = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, targetP, Time.deltaTime * 5f);
    }

    public void OpenDoor()
    {
        targetP = BottomP;
    }
}
