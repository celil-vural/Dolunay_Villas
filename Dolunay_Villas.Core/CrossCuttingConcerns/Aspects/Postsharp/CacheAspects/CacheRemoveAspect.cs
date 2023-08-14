﻿using Dolunay_Villas.Core.CrossCuttingConcerns.Caching.Contract;
using PostSharp.Aspects;
using System.Reflection;

namespace Dolunay_Villas.Core.Aspects.Postsharp.CacheAspects
{
    [Serializable]
    public class CacheRemoveAspect : OnMethodBoundaryAspect
    {
        private readonly string _pattern;
        private readonly Type _cacheType;
        private ICacheManager _cacheManager;
        public CacheRemoveAspect(Type cacheType)
        {
            _cacheType = cacheType;
        }
        public CacheRemoveAspect(string pattern, Type cacheType)
        {
            _pattern = pattern;
            _cacheType = cacheType;
        }
        public override void RuntimeInitialize(MethodBase method)
        {
            if (typeof(ICacheManager).IsAssignableFrom(_cacheType) == false)
            {
                throw new Exception("Wrong Cache Manager");
            }

            _cacheManager = (ICacheManager)Activator.CreateInstance(_cacheType);
            base.RuntimeInitialize(method);
        }

        public override void OnSuccess(MethodExecutionArgs args)
        {
            _cacheManager.RemoveByPattern(
                string.IsNullOrEmpty(_pattern) ?
                    string.Format("{0}.{1}.*", args.Method.ReflectedType?.Namespace, args.Method.ReflectedType?.Name)
                    : _pattern
                    );
            base.OnSuccess(args);
        }
    }
}
