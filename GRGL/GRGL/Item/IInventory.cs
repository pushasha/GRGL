// IInventory.cs
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

using System;
using System.Collections.Generic;

namespace Grgl.Item
{
    public interface IInventory
    {
        /// <summary>
        /// Represents a collection of items
        /// </summary>
        /// <remarks>The key for the dictionary is the item baseId, and the corresponding value
        /// is a Tuple, with the first value representing the quantity of items
        /// in the inventory with that baseId, and the second value holding
        /// an array of refIds representing the unique references of objects with that baseId that 
        /// the inventory contains.</remarks>
        Dictionary<string, Tuple<int, string[]>> Items { get; } 

        /// <summary>
        /// Returns a boolean that evaluates to false if the inventory does not contain any items
        /// </summary>
        bool IsEmpty { get; }
         
    }
}