﻿using System;
using System.Threading.Tasks;

namespace Naylah.Xamarin.Common
{
    public interface IDispatcherWrapper
    {
        void Dispatch(Action action, int delayms = 0);
        Task DispatchAsync(Func<Task> func, int delayms = 0);
        Task DispatchAsync(Action action, int delayms = 0);
        Task<T> DispatchAsync<T>(Func<T> func, int delayms = 0);
    }
}