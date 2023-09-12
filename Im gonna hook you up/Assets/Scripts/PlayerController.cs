using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public enum State
    {
        None,
        Throw,
        Wait,
        Hook,
        Dance
    }

    public State state = State.None;
    public bool isPlay = false;
    private Animator anim;

    private void Awake()
    {
        anim = GetComponent<Animator>();
    }
    void Update()
    {
        if(Input.GetKey(KeyCode.K))
        {
            state = State.Throw;
        }
        else
        {
            state = State.None;
        }
    }
    IEnumerator KiwiAction()
    {
        while (!isPlay)
        {
            switch (state)
            {
                case State.None:
                    anim.Play("None");
                    break;
                case State.Throw:
                    anim.Play("Throw");
                    break;
                case State.Wait:
                    break;
                case State.Hook:
                    break;
                case State.Dance:
                    break;
            }
        }
        yield return new WaitForSeconds(0.1f);
    }
}
