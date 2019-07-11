using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * unity的Time类的一些东西
 */

public class ApiTime : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Time.deltaTime:" + Time.deltaTime);

        Debug.Log("Time.fixedDeltaTime:" + Time.fixedDeltaTime);

        //从游戏开始到现在的时间
        Debug.Log("Time.fixedTime:" + Time.fixedTime);

        //游戏开始到现在的帧数
        Debug.Log("Time.frameCount:" + Time.frameCount);

        //游戏开始到现在是时间（只读,不会被timeScale影响）
        //游戏暂停或者后台运行也不会停
        //比如可以用来做性能测试
        Debug.Log("Time.realtimeSinceStartup:" + Time.realtimeSinceStartup);

        //游戏开始到现在的时间
        Debug.Log("Time.time:" + Time.time);

        //平滑的时间变化
        Debug.Log("Time.smoothDeltaTime:" + Time.smoothDeltaTime);

        Debug.Log("Time.timeScale:" + Time.timeScale);

        //场景加载完成之后开始计时
        Debug.Log("Time.timeSinceLevelLoad:" + Time.timeSinceLevelLoad);

        Debug.Log("Time.unscaledTime:" + Time.unscaledTime);
    }
}
