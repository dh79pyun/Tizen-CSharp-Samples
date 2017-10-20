/*
 * Copyright (c) 2016 Samsung Electronics Co., Ltd All Rights Reserved
 *
 * Licensed under the Apache License, Version 2.0 (the License);
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an AS IS BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using Clock.Interfaces;
using Clock.Tizen.Mobile.Impls;
using Tizen.System;

[assembly: Xamarin.Forms.Dependency(typeof(SystemInformation))]

namespace Clock.Tizen.Mobile.Impls
{
    /// <summary>
    /// The SystemInfo class to get system informaion
    /// </summary>
    class SystemInformation : ISystemInfo
    {
        public SystemInformation()
        {
        }

        /// <summary>
        /// Gets system information
        /// </summary>
        /// <param name="key">The name of the key to get</param>
        /// <param name="value">The output value</param>
        /// <returns>Returns the bool value true if it executes successfully; otherwise, returns false. </returns>
        public bool TryGetValue<T>(string key, out T value)
        {
            bool res = false;
            if (typeof(T) != typeof(int))
            {
                value = (T)(object)null;
                return res;
            }
            else
            {
                int dpi;
                res = Information.TryGetValue<int>(key, out dpi);
                value = (T)(object)dpi;
                return res;
            }
        }
    }
}
