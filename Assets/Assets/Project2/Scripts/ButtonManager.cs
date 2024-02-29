using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    public GameObject TurbineObject;
    private bool IsActive = true;

    public void Toggle()
    {
        if(IsActive)
        {
            TurbineObject.SetActive(false);
            IsActive = false;
        }
        else
        {
            TurbineObject.SetActive(true);
            IsActive = true;
        }
    }
}
