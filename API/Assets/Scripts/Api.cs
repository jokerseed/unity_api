using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * unity中的事件函数以及执行的顺序
 */

public class Api : MonoBehaviour
{
    //editor======================================================================
    //是在editor状态下使用
    //组件reset的时候调用
    private void Reset()
    {

    }

    //initialization===============================================================
    //相当于gameobject初始化的时候调用
    //脚本即使禁用了依然会执行
    private void Awake()
    {
        Debug.Log("awake");
    }
    //组件激活的时候调用
    private void OnEnable()
    {

    }
    // Start is called before the first frame update
    //游戏开始的第一帧之前执行
    void Start()
    {

    }

    //physics=====================================================================
    //每秒调用固定的次数
    private void FixedUpdate()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        
    }

    //input event=========================================================================
    //鼠标输入事件
    private void OnMouseDown()
    {
        
    }
    private void OnMouseUp()
    {
        
    }

    //gamelogic==========================================================================
    // Update is called once per frame
    //与电脑的硬件有关，每秒调用的次数不固定
    //update和lateupdate是在同一帧内调用
    void Update()
    {

    }
    private void LateUpdate()
    {
        
    }

    //sceneRender场景渲染部分===========================================================================
    private void OnWillRenderObject()
    {
        
    }
    private void OnPreCull()
    {
        
    }

    //GizmosRender工作在editor中===================================================================================
    private void OnDrawGizmos()
    {
        
    }
    private void OnDrawGizmosSelected()
    {
        
    }

    //GUIrender会在多次不同的帧刷新中调用=====================================================================================
    private void OnGUI()
    {
        
    }

    //endOfFrame--yieldWaitForEndOfFrame=========================================================

    //pause=======================================================================================
    //游戏暂停
    private void OnApplicationPause(bool pause)
    {
        
    }

    //最后步骤===================================================================================
    //推出游戏的时候
    private void OnApplicationQuit()
    {
        
    }
    //组件失活的时候调用
    private void OnDisable()
    {

    }
    //销毁
    private void OnDestroy()
    {
        
    }
}
