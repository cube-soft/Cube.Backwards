/* ------------------------------------------------------------------------- */
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

namespace Cube.Enumerations
{
    /* --------------------------------------------------------------------- */
    ///
    /// Enumerations.Operations
    /// 
    /// <summary>
    /// Enum の拡張メソッド用クラスです。
    /// </summary>
    /// 
    /// <remarks>
    /// .NET Framework 4 以降に追加されたメソッドを補完します。
    /// </remarks>
    ///
    /* --------------------------------------------------------------------- */
    public static class Operations
    {
        /* ----------------------------------------------------------------- */
        ///
        /// HasFlag
        /// 
        /// <summary>
        /// 現在のインスタンスで 1 つ以上のビットフィールドが設定されて
        /// いるかどうかを判断します。
        /// </summary>
        /// 
        /// <param name="src">判別元 Enum オブジェクト</param>
        /// <param name="flag">ビットフィールド</param>
        /// 
        /// <returns>
        /// ビットフィールドが設定されているかどうかを示す値
        /// </returns>
        ///
        /* ----------------------------------------------------------------- */
        public static bool HasFlag(this Enum src, Enum flag)
        {
            if (src.GetType() != flag.GetType()) throw new ArgumentException();

            var n0 = Convert.ToUInt64(src);
            var n1 = Convert.ToUInt64(flag);

            return (n0 & n1) == n1;
        }
    }
}
