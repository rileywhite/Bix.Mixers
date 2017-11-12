﻿/***************************************************************************/
// Copyright 2013-2017 Riley White
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
/***************************************************************************/

using Cilador.Graph.Core;
using Mono.Cecil;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Cilador.Core
{
    /// <summary>
    /// Represents an AOP Pointcut (https://en.wikipedia.org/wiki/Pointcut).
    /// </summary>
    public class Pointcut
    {
        public IEnumerable<MethodJoinPoint> GetJoinPoints(ICilGraph cilGraph)
        {
            return cilGraph.Vertices.OfType<MethodDefinition>().Select(methodDefinition => new MethodJoinPoint(methodDefinition));
        }
    }
}