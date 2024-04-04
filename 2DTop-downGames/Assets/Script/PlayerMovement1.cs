using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class NewBehaviourScript : MonoBehaviour
{
    public float MoveSpeed;

    private Rigidbody2D rb;

    Animator an;

    public  Vector2 moveDirection;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        an = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     void FixedUpdate()
    {
        //获取玩家输入
        float MoveX = Input.GetAxis("Horizontal");
        float MoveY = Input.GetAxis("Vertical");
        Debug.Log("moveX:" + MoveX + "moveY" + MoveY);

        an.SetFloat("Horizontal", MoveX);
        an.SetFloat("Vertical", MoveY);
        an.SetFloat("Speed",moveDirection.sqrMagnitude);
        
        //计算移动方向
        moveDirection = new Vector2(MoveX, MoveY).normalized;

        //应用移动
        rb.velocity = moveDirection * MoveSpeed;
    }
}
