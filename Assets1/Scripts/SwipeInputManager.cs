using UnityEngine;
using UnityEngine.InputSystem;

public class SwipeInputManager : MonoBehaviour
{
    public static SwipeInputManager Instance { get; private set; }

    private Vector2 swipeStartPos;
    private Vector2 swipeEndPos;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public Vector2 GetSwipeDirection()
    {
        return swipeEndPos - swipeStartPos;
    }

    public void OnSwipe(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            swipeStartPos = context.ReadValue<Vector2>();
        }
        else if (context.canceled)
        {
            swipeEndPos = context.ReadValue<Vector2>();
        }
    }
}
