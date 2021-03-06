﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class LuaProfilerExtensionWrap
{
	public static void Register(LuaState L)
	{
		L.BeginStaticLibs("LuaProfilerExtension");
		L.RegFunction("BeginSample", BeginSample);
		L.RegFunction("EndSample", EndSample);
		L.EndStaticLibs();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int BeginSample(IntPtr L)
	{
#if UNITY_EDITOR
        ToluaProfiler.AddCallRecord("LuaProfilerExtension.Register");
#endif
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1)
			{
				int arg0 = (int)LuaDLL.luaL_checknumber(L, 1);
				LuaProfilerExtension.BeginSample(arg0);
				return 0;
			}
			else if (count == 2)
			{
				int arg0 = (int)LuaDLL.luaL_checknumber(L, 1);
				string arg1 = ToLua.CheckString(L, 2);
				LuaProfilerExtension.BeginSample(arg0, arg1);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: LuaProfilerExtension.BeginSample");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int EndSample(IntPtr L)
	{
#if UNITY_EDITOR
        ToluaProfiler.AddCallRecord("LuaProfilerExtension.EndSample");
#endif
		try
		{
			ToLua.CheckArgsCount(L, 0);
			LuaProfilerExtension.EndSample();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}

