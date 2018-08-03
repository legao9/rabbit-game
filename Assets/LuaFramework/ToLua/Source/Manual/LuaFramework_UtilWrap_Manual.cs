﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class LuaFramework_UtilWrap_Manual
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(LuaFramework.Util), typeof(System.Object));
        L.RegFunction("GetPosition", GetPosition);
        L.RegFunction("GetLocalPosition", GetLocalPosition);
        L.RegFunction("GetScale", GetScale);
        L.RegFunction("GetLocalScale", GetLocalScale);
        L.RegFunction("GetLocalRotation", GetLocalRotation);
        L.RegFunction("GetRotation", GetRotation);
        
        L.EndClass();
	}

    [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
    static int GetLocalPosition(IntPtr L)
    {
        try
        {
            ToLua.CheckArgsCount(L, 1);
            UnityEngine.Transform arg0 = (UnityEngine.Transform)ToLua.CheckUnityObject(L, 1, typeof(UnityEngine.Transform));
            LuaDLL.lua_pushnumber(L, arg0.localPosition.x);
            LuaDLL.lua_pushnumber(L, arg0.localPosition.y);
            LuaDLL.lua_pushnumber(L, arg0.localPosition.z);
            return 3;
        }
        catch (Exception e)
        {
            return LuaDLL.toluaL_exception(L, e);
        }
    }

    [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
    static int GetPosition(IntPtr L)
    {
        try
        {
            ToLua.CheckArgsCount(L, 1);
            UnityEngine.Transform arg0 = (UnityEngine.Transform)ToLua.CheckUnityObject(L, 1, typeof(UnityEngine.Transform));
            LuaDLL.lua_pushnumber(L, arg0.position.x);
            LuaDLL.lua_pushnumber(L, arg0.position.y);
            LuaDLL.lua_pushnumber(L, arg0.position.z);
            return 3;
        }
        catch (Exception e)
        {
            return LuaDLL.toluaL_exception(L, e);
        }
    }

    [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
    static int GetLocalScale(IntPtr L)
    {
        try
        {
            ToLua.CheckArgsCount(L, 1);
            UnityEngine.Transform arg0 = (UnityEngine.Transform)ToLua.CheckUnityObject(L, 1, typeof(UnityEngine.Transform));
            LuaDLL.lua_pushnumber(L, arg0.localScale.x);
            LuaDLL.lua_pushnumber(L, arg0.localScale.y);
            LuaDLL.lua_pushnumber(L, arg0.localScale.z);
            return 3;
        }
        catch (Exception e)
        {
            return LuaDLL.toluaL_exception(L, e);
        }
    }

    [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
    static int GetScale(IntPtr L)
    {
        try
        {
            ToLua.CheckArgsCount(L, 1);
            UnityEngine.Transform arg0 = (UnityEngine.Transform)ToLua.CheckUnityObject(L, 1, typeof(UnityEngine.Transform));
            LuaDLL.lua_pushnumber(L, arg0.lossyScale.x);
            LuaDLL.lua_pushnumber(L, arg0.lossyScale.y);
            LuaDLL.lua_pushnumber(L, arg0.lossyScale.z);
            return 3;
        }
        catch (Exception e)
        {
            return LuaDLL.toluaL_exception(L, e);
        }
    }

    [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
    static int GetLocalRotation(IntPtr L)
    {
        try
        {
            ToLua.CheckArgsCount(L, 1);
            UnityEngine.Transform arg0 = (UnityEngine.Transform)ToLua.CheckUnityObject(L, 1, typeof(UnityEngine.Transform));
            LuaDLL.lua_pushnumber(L, arg0.localRotation.x);
            LuaDLL.lua_pushnumber(L, arg0.localRotation.y);
            LuaDLL.lua_pushnumber(L, arg0.localRotation.z);
            LuaDLL.lua_pushnumber(L, arg0.localRotation.w);
            return 4;
        }
        catch (Exception e)
        {
            return LuaDLL.toluaL_exception(L, e);
        }
    }

    [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
    static int GetRotation(IntPtr L)
    {
        try
        {
            ToLua.CheckArgsCount(L, 1);
            UnityEngine.Transform arg0 = (UnityEngine.Transform)ToLua.CheckUnityObject(L, 1, typeof(UnityEngine.Transform));
            LuaDLL.lua_pushnumber(L, arg0.rotation.x);
            LuaDLL.lua_pushnumber(L, arg0.rotation.y);
            LuaDLL.lua_pushnumber(L, arg0.rotation.z);
            LuaDLL.lua_pushnumber(L, arg0.rotation.w);
            return 4;
        }
        catch (Exception e)
        {
            return LuaDLL.toluaL_exception(L, e);
        }
    }
}
