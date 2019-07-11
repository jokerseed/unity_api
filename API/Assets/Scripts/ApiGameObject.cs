using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * 创建游戏物体GameObject的三种方式
 * 使用代码给游戏物体添加组件
 * 禁用和启用物体和组件
 * 游戏物体广播调用函数
 */

public class ApiGameObject : MonoBehaviour
{
    public GameObject myPrefab;

    // Start is called before the first frame update
    void Start()
    {
        //创建游戏物体，用new
        GameObject go1 = new GameObject("Cube");
        //使用instanitate,使用预制体
        //也可以直接克隆别的gameObject
        GameObject go2 = Instantiate(myPrefab);
        //使用CreatePrimitive创建基本的游戏图形
        GameObject go3 = GameObject.CreatePrimitive(PrimitiveType.Cube);

        //使用addcomponent给gameObject添加组件
        go3.AddComponent<Rigidbody>();

        //activeInHierarchy在世界中的激活与否
        //activeSelf物体自身的激活与否，父物体禁用不影响子物体
        Debug.Log(go1.activeInHierarchy);
        Debug.Log(go2.activeSelf);
        go2.SetActive(false);
        go1.SetActive(true);

        //广播调用该物体以及子物体上的Test方法
        //可减少耦合
        this.BroadcastMessage("Test", 0.5f, SendMessageOptions.DontRequireReceiver);
        //只是给此物体发送一个消息
        this.SendMessage("Test");
        //给此物体的直接父对象发送消息
        this.SendMessageUpwards("Test");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
