﻿/*
 * Copyright (C) 2011 Patrick Mezard
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace PhoneNumbers
{
    internal class EnumerableFromConstructor<T> : IEnumerable<T>
    {
        private readonly Func<IEnumerator<T>> fn;

        public EnumerableFromConstructor(Func<IEnumerator<T>> fn)
        {
            this.fn = fn;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return fn();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return fn();
        }
    }
}
