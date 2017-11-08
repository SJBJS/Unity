﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMV : MonoBehaviour
{
    public float speed; //이동 속도.
    public float jumpfoace;
    public float grivityScale; // 중력 적용 배율.
    public bool isDebugMode;
    private Rigidbody2D m_ri2d;
    private bool isJump = true;

    [SerializeField]
    private PolygonCollider2D[] m_collider;
    private int m_collIdx = 0;

    CheckGround checkGround;
    // Use this for initialization
    void Awake()
    {
        m_ri2d = GetComponent<Rigidbody2D>();
        m_ri2d.gravityScale = grivityScale;
        checkGround = GetComponent<CheckGround>();
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.
        if (isDebugMode)
        {
            Debug.Log(checkGround.IsGrounded());
            m_ri2d.gravityScale = grivityScale;
        }
        //왼쪽방향으로 speed만큼 이동하게됩니다.
        transform.Translate(Vector2.right * speed * Time.deltaTime);

        //x좌표가 -12.8보다 작아지게 되면...
        if (transform.position.x < -12.8f)
        {
            //위치를 0, 0 으로 옮겨줍니다.
            transform.position = new Vector2(0, 0);
        }

        if (Input.GetButtonDown("Jump"))
        {
            OnJump();
        }

    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            isJump = true;
        }
    }

    public void SetColliderForSprite(int spriteNum)
    {
        m_collider[m_collIdx].enabled = false;
        m_collIdx = spriteNum;
        m_collider[m_collIdx].enabled = true;
    }

    void OnJump()
    {
        if (!checkGround.IsGrounded())
        {
            return;
        }
        m_ri2d.AddForce(transform.up * jumpfoace, ForceMode2D.Impulse);

    }

    //플레이어가 죽을시 씬을 변경합니다.
    void OnDie()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("GameOver");
    }
}