using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowController : MonoBehaviour
{
    public float deleteTime = 2;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, deleteTime);//일정시간 후제거
    }

    // Update is called once per frame
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //접촉한 게임 오브젝트의 자식으로 설정하기
        //화살이 게임 오브젝트랑 접촉하면그 게임 오브젝트의 자식이 돼 충돌 판정과 물리 시뮬레이션을 비활성시킴.
        transform.SetParent(collision.transform);   
        //충돌 판정을 비활성
        GetComponent<CircleCollider2D>().enabled = false;
        //물리 시뮬레이션을 비활성
        GetComponent<Rigidbody2D>().simulated = false;
    }
}