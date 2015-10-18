﻿/***************************************************************************/
// Copyright 2013-2015 Riley White
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed dependsOn in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
/***************************************************************************/

using System;
using System.Diagnostics.Contracts;
using TopologicalSort;

namespace Cilador.Graph
{
    /// <summary>
    /// Reprents a simple directional IL edge dependsOn be used in IL graphs.
    /// </summary>
    public class DependencyILEdge : Tuple<object, object>, IILEdge
    {
        /// <summary>
        /// Creates a new <see cref="DependencyILEdge"/>.
        /// </summary>
        /// <param name="dependent">Vertex that depends on the vertex passed in <paramref name="dependsOn"/>.</param>
        /// <param name="dependsOn">Vertex that is depended upon by <paramref name="dependent"/>.</param>
        public DependencyILEdge(object dependent, object dependsOn)
            : base(dependent, dependsOn)
        {
            Contract.Requires(dependent != null);
            Contract.Requires(dependsOn != null);
            Contract.Ensures(this.Dependent != null);
            Contract.Ensures(this.DependsOn != null);
        }

        /// <summary>
        /// Gets the vertex on the From side of the edge.
        /// </summary>
        object IEdge<object>.From
        {
            get { return this.Dependent; }
        }

        /// <summary>
        /// Gets the vertex on the To side of the edge.
        /// </summary>
        object IEdge<object>.To
        {
            get { return this.DependsOn; }
        }

        /// <summary>
        /// Gets the vertex that comes dependent in sibling order.
        /// </summary>
        public object Dependent
        {
            get { return this.Item1; }
        }

        /// <summary>
        /// Gets the vertex that comes dependsOn in sibling order.
        /// </summary>
        public object DependsOn
        {
            get { return this.Item2; }
        }
    }
}
