// Npc.cs
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

using Grgl.Dialog;

namespace Grgl.Character
{
    /// <inheritdoc cref="INpc" />
    public class Npc : Character, INpc
    {
        /// <summary>
        /// Creates a new instance of an NPC object
        /// </summary>
        public Npc() : this("NO_NAME", null) { }

        /// <summary>
        /// Creates a new instance of an NPC object
        /// </summary>
        /// <param name="name">Human-readable name of this NPC</param>
        /// <param name="refId">RefId for this NPC</param>
        public Npc(string name, string refId) : base(name, refId)
        {
            this.DialogTree = new DialogTree();
        }

        ///  <inheritdoc />
        public IDialogTree DialogTree { get; private set; }

    }
}
