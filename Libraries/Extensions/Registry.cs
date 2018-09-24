/* ------------------------------------------------------------------------- */
//
// Copyright (c) 2010 CubeSoft, Inc.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//  http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
/* ------------------------------------------------------------------------- */
using Microsoft.Win32;

namespace Cube.Net35
{
    /* --------------------------------------------------------------------- */
    ///
    /// RegistryExtension
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
    public static class RegistryExtension
    {
        /* ----------------------------------------------------------------- */
        ///
        /// DeleteSubKeyTree
        ///
        /// <summary>
        /// 指定されたサブキーとその子サブキーを再帰的に削除します。
        /// サブキーが見つからなかった場合に例外を発生させるかどうかを
        /// 指定します。
        /// </summary>
        ///
        /// <param name="key">基準となる RegistryKey</param>
        /// <param name="subkey">サブキー名</param>
        /// <param name="throwException">例外を送出するかどうか</param>
        ///
        /* ----------------------------------------------------------------- */
        public static void DeleteSubKeyTree(this RegistryKey key, string subkey, bool throwException)
        {
            try { key.DeleteSubKeyTree(subkey); }
            catch
            {
                if (throwException) throw;
            }
        }
    }
}
