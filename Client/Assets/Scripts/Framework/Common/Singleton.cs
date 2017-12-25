/********************************************************************************
** auth:  https://github.com/HushengStudent
** date:  2017/12/25 23:37:56
** desc:  单例模板
*********************************************************************************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Framework
{
	public class Singleton<T> where T : class,new()
	{
	    protected static T instance = null;
	
	    public static T Instance
	    {
	        get
	        {
	            if (null == instance)
	            {
	                instance = new T(); //调用构造函数  
	            }
	            return instance;
	        }
	    }
	
	    /// <summary>
	    /// SingletonManager构造函数
	    /// </summary>
	    protected Singleton()
	    {
	        if (null != instance)
	            Debug.Log("This " + (typeof(T)).ToString() + " Singleton Instance is not null!");
	        Init();
	    }
	
	    public virtual void Init() { }
	
	    public virtual void OnDestroy()
	    {
	        instance = null;
	    }
	}
}
