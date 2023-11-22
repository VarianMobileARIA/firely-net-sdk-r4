/* 
 * Copyright (c) 2023, Firely (info@fire.ly) and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-net-sdk/master/LICENSE
 */

#nullable enable

using System.Collections.Generic;

namespace Hl7.Fhir.ElementModel
{
    /// <summary>
    /// An element within a tree of typed FHIR data with also a parent element.
    /// </summary>
    /// <remarks>
    /// This interface represents FHIR data as a tree of elements, including type information either present in 
    /// the instance or derived from fully aware of the FHIR definitions and types
    /// </remarks>
    public interface IScopedNode : IBaseElementNavigator
    {
        /// <summary>
        /// Enumerate the child nodes present in the source representation (if any)
        /// </summary>
        /// <param name="name">Return only the children with the given name.</param>
        /// <returns></returns>
        new IEnumerable<IScopedNode> Children(string? name = null);

        /// <summary>
        /// The parent node of this node, or null if this is the root node.
        /// </summary>
        IScopedNode? Parent { get; }
    }
}

#nullable restore