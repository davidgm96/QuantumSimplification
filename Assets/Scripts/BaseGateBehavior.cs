using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseGateBehavior : MonoBehaviour
{

    public LinkedListNode<GateData> nodeRef;

    public BaseGateOffsetBehavior offsetBehavior;
    public Animation scaleAnimation;

    public SpriteRenderer gateSprite;

    public Color selectionColor;

    private bool selected = false;


    private void Start()
    {
    }

    public void toggle()
    {
        selected = !selected;
        if (selected)
        {
            scaleAnimation.Play("ScaleUp");
            gateSprite.color = selectionColor;
        }
        else { 
            scaleAnimation.Play("ScaleDown");
            gateSprite.color = new Color(1f, 1f, 1f);
		}

    }

    public void setSortingIndex(int i)
    {
        gateSprite.sortingOrder = i;
    }

    public void highlight()
    {
        offsetBehavior.setHint(true);
    }

    public void reset()
    {
        selected = false;
    }

    public void mistakeShake()
    {
        offsetBehavior.mistakeShake();
    }

}
