﻿/*
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

using System;
using System.Globalization;
using Xamarin.Forms;

namespace Clock.Converters
{
    /// <summary>
    /// Converter class
    /// This class converts bindable source value to proper target value
    /// Depending on the number of items in ListView, control ListView's visibility
    /// </summary>
    class MuteToImageSourceConverter : IValueConverter
    {
        /// <summary>
        /// Converting source value to target value
        /// </summary>
        /// <param name="value">Source object</param>
        /// <param name="targetType">The target type to convert</param>
        /// <param name="parameter">parameter object</param>
        /// <param name="culture">The culture info</param>
        /// <returns>Returns converted bool to decide UI widget's visibility</returns>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            bool isMute = (bool)System.Convert.ToBoolean(value);
            if (isMute)
            {
                return "alarm/01_volume_vibration.png";
            }
            else
            {
                return "alarm/00_volume_icon.png";
            }
        }

        /// <summary>
        /// Converting back source value to target value
        /// This method is not being used in this app.
        /// </summary>
        /// <param name="value">Source object</param>
        /// <seealso cref="System.object">
        /// <param name="targetType">The target type to convert</param>
        /// <seealso cref="Type">
        /// <param name="CultureInfo">The culture info</param>
        /// <seealso cref="CultureInfo">
        /// <returns>Returns null</returns>
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}
