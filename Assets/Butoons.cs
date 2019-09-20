using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Butoons : MonoBehaviour
{
    public Animator animator;

    public void ChangeAnimation(string value)
    {
        //changing the current animation to the given value
        animator.Play(value);
    }
    public void ResetPosition(GameObject character)
    {
        //reseting the character so that is is within camera veiw
        character.transform.position = new Vector3(0,0,10);
    }

    public void QuitApplication()
    {
        //Self Explanatory
        Application.Quit();
    }
    public void MenuSlide(GameObject menu)
    {
        
    }
}
