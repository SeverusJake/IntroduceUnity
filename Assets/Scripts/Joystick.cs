using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Joystick : MonoBehaviour, IPointerUpHandler, IPointerDownHandler
{
    private PlayerJoystick playerMove;

    // Start is called before the first frame update
    void Start()
    {
        playerMove = GameObject.Find("Player").GetComponent<PlayerJoystick>();
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        if (gameObject.name == "Left")
        {
            playerMove.SetMoveLeft(true);
        }
        if (gameObject.name == "Right")
        {
            playerMove.SetMoveLeft(false) ;
        }
        if (gameObject.name == "Jump")
        {
            playerMove.SetJumpUp(true);
        }
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        playerMove.StopMoving();
        playerMove.SetJumpUp(false);
    }

    

    // Update is called once per frame
    void Update()
    {
        
    }
}
