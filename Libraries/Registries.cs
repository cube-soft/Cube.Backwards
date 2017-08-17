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
using Microsoft.Win32;

namespace Cube.Registries
{
    /* --------------------------------------------------------------------- */
    ///
    /// Registries.Operations
    /// 
    /// <summary>
    /// Microsoft.Win32.RegistryKey クラスの拡張メソッド用クラスです。
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
        /// DeleteSubKeyTree
        /// 
        /// <summary>
        /// 指定されたサブキーとその子サブキーを再帰的に削除します。
        /// サブキーが見つからなかった場合に例外を発生させるかどうかを指定します。
        /// </summary>
        /// 
        /// <remarks>
        /// .NET 3.5 に該当メソッドが存在しないため、拡張メソッドで対応。
        /// </remarks>
        ///
        /* ----------------------------------------------------------------- */
        public static void DeleteSubKeyTree(this RegistryKey key,
            string subkey, bool throwOnMissingSubKey)
        {
            try { key.DeleteSubKeyTree(subkey); }
            catch (Exception err)
            {
                if (throwOnMissingSubKey) throw err;
            }
        }
    }
}
