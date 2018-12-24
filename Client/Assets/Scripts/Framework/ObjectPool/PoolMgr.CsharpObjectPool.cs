/********************************************************************************
** auth:  https://github.com/HushengStudent
** date:  2018/12/16 20:34:27
** desc:  Csharp����ع���;
*********************************************************************************/

using Framework.ObjectPool;
using System;
using System.Collections.Generic;

namespace Framework
{
    public partial class PoolMgr
    {
        /// <summary>
        /// Csharp Object Pool;
        /// </summary>
        private Dictionary<Type, Object> _csharpObjectPool = new Dictionary<Type, Object>();

        /// <summary>
        /// ��ȡCsharp�����Ŀ�����;
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="args">��ʼ������</param>
        /// <returns></returns>
        public T GetCsharpObject<T>(params Object[] args) where T : new()
        {
            CsharpObjectPool<T> pool;
            Object temp;
            if (_csharpObjectPool.TryGetValue(typeof(T), out temp))
            {
                pool = temp as CsharpObjectPool<T>;
            }
            else
            {
                pool = CreateCsharpPool<T>();
            }
            T t = pool.Get();
            IPool target = t as IPool;
            if (target != null)
                target.OnGet(args);
            return t;
        }

        /// <summary>
        /// �ͷ�Csharp��������;
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="type"></param>
        public void ReleaseCsharpObject<T>(T type) where T : new()
        {
            IPool target = type as IPool;
            if (target != null)
                target.OnRelease();
            CsharpObjectPool<T> pool;
            Object temp;
            if (_csharpObjectPool.TryGetValue(typeof(T), out temp))
            {
                pool = temp as CsharpObjectPool<T>;
            }
            else
            {
                pool = CreateCsharpPool<T>();
            }
            pool.Release(type);
        }

        /// <summary>
        /// ����Csharp�����;
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        private CsharpObjectPool<T> CreateCsharpPool<T>() where T : new()
        {
            Object temp;
            if (_csharpObjectPool.TryGetValue(typeof(T), out temp))
            {
                return temp as CsharpObjectPool<T>;
            }
            else
            {
                CsharpObjectPool<T> pool = new CsharpObjectPool<T>(null, null);
                _csharpObjectPool[typeof(T)] = pool;
                return pool;
            }
        }
    }
}