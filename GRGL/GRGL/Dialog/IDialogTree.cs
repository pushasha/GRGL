// IDialogTree.cs
// (c) Copyright Sarah Plotkin (splotkin@gmail.com)
// 
// This file is part of GRGL.
// GRGL is free software: you can redistribute it and/or modify
// it under the terms of the GNU Lesser General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.

// GRGL is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Lesser General Public License for more details.

// You should have received a copy of the GNU Lesser General Public License
// along with GRGL.  If not, see <http://www.gnu.org/licenses/>.

using System.Collections.Generic;

namespace Grgl.Dialog
{
    /// <summary>
    /// Represents a character's dialog tree.
    /// </summary>
    public interface IDialogTree
    {
        /// <summary>
        /// The root node of this dialog tree.
        /// </summary>
        IDialogNode Root { get; }

        /// <summary>
        /// All the nodes contained in this dialog tree, keyed with unique identifiers
        /// </summary>
        IDictionary<string, IDialogNode> NodeDictionary { get; }

        /// <summary>
        /// Add a node to this dialog tree
        /// </summary>
        /// <param name="parentId">The UID of the node that precedes the node to be added</param>
        /// <param name="nodeToAdd">The node object to be added</param>
        void AddNode(string parentId, IDialogNode nodeToAdd);

        /// <summary>
        /// Add a node to this dialog tree
        /// </summary>
        /// <param name="parentId">The UID of the node that precedes the node to be added</param>
        /// <param name="nodeToAddId">The UID of the preexisting node to be added to the tree</param>
        void AddNode(string parentId, string nodeToAddId);
    }
}