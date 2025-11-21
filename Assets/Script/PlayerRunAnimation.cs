using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerRunAnimation : MonoBehaviour
{
    public InputActionAsset magnusPlayerAction;
    public Animator magnusAnimator;
    
    
    // Update is called once per frame
    void Update()
    {
        if (magnusPlayerAction.FindAction("Move").IsPressed())
        {
            magnusAnimator.SetBool("Run", true);
        }
        else
        {
            magnusAnimator.SetBool("Run", false);
        }
        
    }
}
