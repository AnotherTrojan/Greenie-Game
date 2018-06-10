using UnityEngine;

public class CanClickDestroy : MonoBehaviour
{
    private void OnMouseDown()
    {
        Debug.Log("hi");
        Destroy(gameObject);
    }
}
