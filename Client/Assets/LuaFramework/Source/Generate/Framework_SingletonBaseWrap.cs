﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class Framework_SingletonBaseWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(Framework.SingletonBase), typeof(Framework.Singletoninterface));
		L.RegFunction("Launch", Launch);
		L.RegFunction("SingletoninterfaceOnInitialize", SingletoninterfaceOnInitialize);
		L.RegFunction("SingletoninterfaceOnUninitialize", SingletoninterfaceOnUninitialize);
		L.RegFunction("New", _CreateFramework_SingletonBase);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("OnInitializeHandler", get_OnInitializeHandler, set_OnInitializeHandler);
		L.RegVar("OnUninitializeHandler", get_OnUninitializeHandler, set_OnUninitializeHandler);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateFramework_SingletonBase(IntPtr L)
	{
#if UNITY_EDITOR
        ToluaProfiler.AddCallRecord("Framework.SingletonBase.ctor");
#endif
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				Framework.SingletonBase obj = new Framework.SingletonBase();
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: Framework.SingletonBase.New");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Launch(IntPtr L)
	{
#if UNITY_EDITOR
        ToluaProfiler.AddCallRecord("Framework.SingletonBase.Launch");
#endif
		try
		{
			ToLua.CheckArgsCount(L, 1);
			Framework.SingletonBase obj = (Framework.SingletonBase)ToLua.CheckObject<Framework.SingletonBase>(L, 1);
			obj.Launch();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SingletoninterfaceOnInitialize(IntPtr L)
	{
#if UNITY_EDITOR
        ToluaProfiler.AddCallRecord("Framework.SingletonBase.SingletoninterfaceOnInitialize");
#endif
		try
		{
			ToLua.CheckArgsCount(L, 1);
			Framework.SingletonBase obj = (Framework.SingletonBase)ToLua.CheckObject<Framework.SingletonBase>(L, 1);
			obj.SingletoninterfaceOnInitialize();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SingletoninterfaceOnUninitialize(IntPtr L)
	{
#if UNITY_EDITOR
        ToluaProfiler.AddCallRecord("Framework.SingletonBase.SingletoninterfaceOnUninitialize");
#endif
		try
		{
			ToLua.CheckArgsCount(L, 1);
			Framework.SingletonBase obj = (Framework.SingletonBase)ToLua.CheckObject<Framework.SingletonBase>(L, 1);
			obj.SingletoninterfaceOnUninitialize();
			return 0;
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
        ToluaProfiler.AddCallRecord("Framework.SingletonBase.OnInitializeHandler");
#endif
		ToLua.Push(L, new EventObject(typeof(Framework.OnInitializeEventHandler)));
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_OnUninitializeHandler(IntPtr L)
	{
#if UNITY_EDITOR
        ToluaProfiler.AddCallRecord("Framework.SingletonBase.OnUninitializeHandler");
#endif
		ToLua.Push(L, new EventObject(typeof(Framework.OnUninitializeEventHandler)));
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_OnInitializeHandler(IntPtr L)
	{
#if UNITY_EDITOR
        ToluaProfiler.AddCallRecord("Framework.SingletonBase.set_OnInitializeHandler");
#endif
		try
		{
			Framework.SingletonBase obj = (Framework.SingletonBase)ToLua.CheckObject(L, 1, typeof(Framework.SingletonBase));
			EventObject arg0 = null;

			if (LuaDLL.lua_isuserdata(L, 2) != 0)
			{
				arg0 = (EventObject)ToLua.ToObject(L, 2);
			}
			else
			{
				return LuaDLL.luaL_throw(L, "The event 'Framework.SingletonBase.OnInitializeHandler' can only appear on the left hand side of += or -= when used outside of the type 'Framework.SingletonBase'");
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
        ToluaProfiler.AddCallRecord("Framework.SingletonBase.set_OnUninitializeHandler");
#endif
		try
		{
			Framework.SingletonBase obj = (Framework.SingletonBase)ToLua.CheckObject(L, 1, typeof(Framework.SingletonBase));
			EventObject arg0 = null;

			if (LuaDLL.lua_isuserdata(L, 2) != 0)
			{
				arg0 = (EventObject)ToLua.ToObject(L, 2);
			}
			else
			{
				return LuaDLL.luaL_throw(L, "The event 'Framework.SingletonBase.OnUninitializeHandler' can only appear on the left hand side of += or -= when used outside of the type 'Framework.SingletonBase'");
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

