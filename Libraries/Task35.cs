﻿/* ------------------------------------------------------------------------- */
///
/// Copyright (c) 2010 CubeSoft, Inc.
/// 
/// Licensed under the Apache License, Version 2.0 (the "License");
/// you may not use this file except in compliance with the License.
/// You may obtain a copy of the License at
///
///  http://www.apache.org/licenses/LICENSE-2.0
///
/// Unless required by applicable law or agreed to in writing, software
/// distributed under the License is distributed on an "AS IS" BASIS,
/// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
/// See the License for the specific language governing permissions and
/// limitations under the License.
///
/* ------------------------------------------------------------------------- */
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Cube
{
    /* --------------------------------------------------------------------- */
    ///
    /// Task35
    /// 
    /// <summary>
    /// System.Threading.Tasks.Task クラスに関する静的メソッド群を定義した
    /// クラスです。
    /// </summary>
    /// 
    /// <remarks>
    /// Task Parallel Library for .NET 3.5 に定義されていないメソッドを
    /// 代替するためのクラスです。
    /// </remarks>
    ///
    /* --------------------------------------------------------------------- */
    public static class Task35
    {
        #region Run

        /* --------------------------------------------------------------------- */
        ///
        /// Run
        /// 
        /// <summary>
        /// 指定された作業を行うタスクを生成します。
        /// </summary>
        ///
        /* --------------------------------------------------------------------- */
        public static Task Run(Action action) => Run(action, CancellationToken.None);

        /* --------------------------------------------------------------------- */
        ///
        /// Run
        /// 
        /// <summary>
        /// 指定された作業を行うタスクを生成します。
        /// </summary>
        ///
        /* --------------------------------------------------------------------- */
        public static Task Run(Action action, CancellationToken token)
            => Task.Factory.StartNew(
                action,
                token,
                TaskCreationOptions.None,
                TaskScheduler.Default
            );

        /* --------------------------------------------------------------------- */
        ///
        /// Run
        /// 
        /// <summary>
        /// 指定された作業を行うタスクを生成します。
        /// </summary>
        ///
        /* --------------------------------------------------------------------- */
        public static Task Run(Func<Task> func) => Run(func, CancellationToken.None);

        /* --------------------------------------------------------------------- */
        ///
        /// Run
        /// 
        /// <summary>
        /// 指定された作業を行うタスクを生成します。
        /// </summary>
        ///
        /* --------------------------------------------------------------------- */
        public static Task Run(Func<Task> func, CancellationToken token)
            => Task<Task>.Factory.StartNew(
                func,
                token,
                TaskCreationOptions.None,
                TaskScheduler.Default
            ).Unwrap();

        /* --------------------------------------------------------------------- */
        ///
        /// Run
        /// 
        /// <summary>
        /// 指定された作業を行うタスクを生成します。
        /// </summary>
        ///
        /* --------------------------------------------------------------------- */
        public static Task<TResult> Run<TResult>(Func<TResult> func)
            => Run(func, CancellationToken.None);

        /* --------------------------------------------------------------------- */
        ///
        /// Run
        /// 
        /// <summary>
        /// 指定された作業を行うタスクを生成します。
        /// </summary>
        ///
        /* --------------------------------------------------------------------- */
        public static Task<TResult> Run<TResult>(Func<TResult> func, CancellationToken token)
            => Task<TResult>.Factory.StartNew(
                func,
                token,
                TaskCreationOptions.None,
                TaskScheduler.Default
            );

        /* --------------------------------------------------------------------- */
        ///
        /// Run
        /// 
        /// <summary>
        /// 指定された作業を行うタスクを生成します。
        /// </summary>
        ///
        /* --------------------------------------------------------------------- */
        public static Task<TResult> Run<TResult>(Func<Task<TResult>> func)
            => Run(func, CancellationToken.None);

        /* --------------------------------------------------------------------- */
        ///
        /// Run
        /// 
        /// <summary>
        /// 指定された作業を行うタスクを生成します。
        /// </summary>
        ///
        /* --------------------------------------------------------------------- */
        public static Task<TResult> Run<TResult>(Func<Task<TResult>> func, CancellationToken token)
            => Task<Task<TResult>>.Factory.StartNew(
                func,
                token,
                TaskCreationOptions.None,
                TaskScheduler.Default
            ).Unwrap();

        #endregion

        #region Delay

        /* --------------------------------------------------------------------- */
        ///
        /// Delay
        /// 
        /// <summary>
        /// 遅延後に完了するタスクを作成します。
        /// </summary>
        ///
        /* --------------------------------------------------------------------- */
        public static Task Delay(TimeSpan span)
            => Delay((int)span.TotalMilliseconds);

        /* --------------------------------------------------------------------- */
        ///
        /// Delay
        /// 
        /// <summary>
        /// 遅延後に完了するタスクを作成します。
        /// </summary>
        ///
        /* --------------------------------------------------------------------- */
        public static Task Delay(int msec)
            => Delay(msec, CancellationToken.None);

        /* --------------------------------------------------------------------- */
        ///
        /// Delay
        /// 
        /// <summary>
        /// 遅延後に完了するタスクを作成します。
        /// </summary>
        ///
        /* --------------------------------------------------------------------- */
        public static Task Delay(TimeSpan span, CancellationToken token)
            => Delay((int)span.TotalMilliseconds, token);

        /* --------------------------------------------------------------------- */
        ///
        /// Delay
        /// 
        /// <summary>
        /// 遅延後に完了するタスクを作成します。
        /// </summary>
        ///
        /* --------------------------------------------------------------------- */
        public static Task Delay(int msec, CancellationToken token)
            => Run(() =>
            {
                var mres = new ManualResetEventSlim();
                mres.Wait(msec, token);
            }, token);

        #endregion

        #region WhenAny

        /* --------------------------------------------------------------------- */
        ///
        /// WhenAny
        /// 
        /// <summary>
        /// 指定されたいずれかのタスクが完了した時点で、続行するタスクを
        /// 生成します。
        /// </summary>
        ///
        /* --------------------------------------------------------------------- */
        public static Task<Task> WhenAny(params Task[] tasks)
            => Task<Task>.Factory.ContinueWhenAny(tasks, t => t);

        /* --------------------------------------------------------------------- */
        ///
        /// WhenAny
        /// 
        /// <summary>
        /// 指定されたいずれかのタスクが完了した時点で、続行するタスクを
        /// 生成します。
        /// </summary>
        ///
        /* --------------------------------------------------------------------- */
        public static Task<Task<TResult>> WhenAny<TResult>(params Task<TResult>[] tasks)
            => Task<Task<TResult>>.Factory.ContinueWhenAny(tasks, t => t);

        #endregion
    }
}
