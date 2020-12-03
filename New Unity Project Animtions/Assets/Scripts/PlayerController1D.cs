using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController1D : MonoBehaviour
{
    private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }
    private void Update()
    {
        float vertical = Input.GetAxis("Vertical"); //위 아래 방향키 입력

        //shift키를 안누름녀 최대 0.5, shift  키를 누르면 최대 1까지 값이 바뀌게 된다.
        float offset = 0.5f + Input.GetAxis("Sprint") * 0.5f;

        //오른쪽 방향키를 누르면 forward가 + 이지만 왼쪽 방향키를 누르면 forwad가 - 이기 때문에
        //애니메이션 파라미터를 설정할 때 에는 절대값으로 적용한다.

        float moveParameter = Mathf.Abs(vertical * offset);

        //MoveParameter 값에 따라 애니메이션 재생 (0 대기 0.5 걷기 1 뛰기)
        animator.SetFloat("MoveSpeed", moveParameter);

            //이동속도 : shift키를 안눌렀을 땐 walkSpeed, Shift키를 눌렀을 땐 runSpeed값이 moveSpeed에 저장 
            //float moveSpeed = mathf.Lerp(walkSpeed , runSpeed , Input.getaxis("sprint"));
            //실제 이동
            //transform.position += new Vecter3(vectical,0,0) * moveSpedd *Time.deltaTime;
    }

}
