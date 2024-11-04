using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class SkillActive_Thr : Skill
{
    [SerializeField] Image LookCoolTime;
    [SerializeField] float CoolTime;

    public void SkillThr()
    {
        Activate();
    }

    public override void Activate()
    {
        isActived = false;

        // 스킬 코드 작성 예정
        Debug.Log("세번째 스킬 사용됨");

        CoroutineManager.Instance.ManagerCoroutineStart(SetCurrentCooltime(CoolTime, LookCoolTime, gameObject.GetComponent<Button>()), SetCoolTimeCoroutineName);
    }
}
