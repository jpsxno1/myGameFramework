﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class Framework_MonoSingletonBaseWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(Framework.MonoSingletonBase), typeof(Framework.MonoSingletoninterface));
		L.RegFunction("Launch", Launch);
		L.RegFunction("MonoSingletoninterfaceOnInitialize", MonoSingletoninterfaceOnInitialize);
		L.RegFunction("MonoSingletoninterfaceOnUninitialize", MonoSingletoninterfaceOnUninitialize);
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("OnInitializeHandler", get_OnInitializeHandler, set_OnInitializeHandler);
		L.RegVar("OnUninitializeHandler", get_OnUninitializeHandler, set_OnUninitializeHandler);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Launch(IntPtr L)
	{
#if UNITY_EDITOR
        ToluaProfiler.AddCallRecord("Framework.MonoSingletonBase.Launch");
#endif
		try
		{
			ToLua.CheckArgsCount(L, 1);
			Framework.MonoSingletonBase obj = (Framework.MonoSingletonBase)ToLua.CheckObject<Framework.MonoSingletonBase>(L, 1);
			obj.Launch();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int MonoSingletoninterfaceOnInitialize(IntPtr L)
	{
#if UNITY_EDITOR
        ToluaProfiler.AddCallRecord("Framework.MonoSingletonBase.MonoSingletoninterfaceOnInitialize");
#endif
		try
		{
			ToLua.CheckArgsCount(L, 1);
			Framework.MonoSingletonBase obj = (Framework.MonoSingletonBase)ToLua.CheckObject<Framework.MonoSingletonBase>(L, 1);
			obj.MonoSingletoninterfaceOnInitialize();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int MonoSingletoninterfaceOnUninitialize(IntPtr L)
	{
#if UNITY_EDITOR
        ToluaProfiler.AddCallRecord("Framework.MonoSingletonBase.MonoSingletoninterfaceOnUninitialize");
#endif
		try
		{
			ToLua.CheckArgsCount(L, 1);
			Framework.MonoSingletonBase obj = (Framework.MonoSingletonBase)ToLua.CheckObject<Framework.MonoSingletonBase>(L, 1);
			obj.MonoSingletoninterfaceOnUninitialize();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int op_Equality(IntPtr L)
	{
#if UNITY_EDITOR
        ToluaProfiler.AddCallRecord("Framework.MonoSingletonBase.op_Equality");
#endif
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.Object arg0 = (UnityEngine.Object)ToLua.ToObject(L, 1);
			UnityEngine.Object arg1 = (UnityEngine.Object)ToLua.ToObject(L, 2);
			bool o = arg0 == arg1;
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_OnInitializeHandler(IntPtr L)
	{
#if UNITY_EDITOR
        ToluaProfiler.AddCallRecord("Framework.MonoSingletonBase.OnInitializeHandler");
#endif
		ToLua.Push(L, new EventObject(typeof(Framework.OnInitializeEventHandler)));
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_OnUninitializeHandler(IntPtr L)
	{
#if UNITY_EDITOR
        ToluaProfiler.AddCallRecord("Framework.MonoSingletonBase.OnUninitializeHandler");
#endif
		ToLua.Push(L, new EventObject(typeof(Framework.OnUninitializeEventHandler)));
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_OnInitializeHandler(IntPtr L)
	{
#if UNITY_EDITOR
        ToluaProfiler.AddCallRecord("Framework.MonoSingletonBase.set_OnInitializeHandler");
#endif
		try
		{
			Framework.MonoSingletonBase obj = (Framework.MonoSingletonBase)ToLua.CheckObject(L, 1, typeof(Framework.MonoSingletonBase));
			EventObject arg0 = null;

			if (LuaDLL.lua_isuserdata(L, 2) != 0)
			{
				arg0 = (EventObject)ToLua.ToObject(L, 2);
			}
			else
			{
				return LuaDLL.luaL_throw(L, "The event 'Framework.MonoSingletonBase.OnInitializeHandler' can only appear on the left hand side of += or -= when used outside of the type 'Framework.MonoSingletonBase'");
			}

			if (arg0.op == EventOp.Add)
			{
				Framework.OnInitializeEventHandler ev = (Framework.OnInitializeEventHandler)arg0.func;
				obj.OnInitializeHandler += ev;
			}
			else if (arg0.op == EventOp.Sub)
			{
				Framework.OnInitializeEventHandler ev = (Framework.OnInitializeEventHandler)arg0.func;
				obj.OnInitializeHandler -= ev;
			}

			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_OnUninitializeHandler(IntPtr L)
	{
#if UNITY_EDITOR
        ToluaProfiler.AddCallRecord("Framework.MonoSingletonBase.set_OnUninitializeHandler");
#endif
		try
		{
			Framework.MonoSingletonBase obj = (Framework.MonoSingletonBase)ToLua.CheckObject(L, 1, typeof(Framework.MonoSingletonBase));
			EventObject arg0 = null;

			if (LuaDLL.lua_isuserdata(L, 2) != 0)
			{
				arg0 = (EventObject)ToLua.ToObject(L, 2);
			}
			else
			{
				return LuaDLL.luaL_throw(L, "The event 'Framework.MonoSingletonBase.OnUninitializeHandler' can only appear on the left hand side of += or -= when used outside of the type 'Framework.MonoSingletonBase'");
			}

			if (arg0.op == EventOp.Add)
			{
				Framework.OnUninitializeEventHandler ev = (Framework.OnUninitializeEventHandler)arg0.func;
				obj.OnUninitializeHandler += ev;
			}
			else if (arg0.op == EventOp.Sub)
			{
				Framework.OnUninitializeEventHandler ev = (Framework.OnUninitializeEventHandler)arg0.func;
				obj.OnUninitializeHandler -= ev;
			}

			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}

