﻿// IInventoryItem.cs
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

namespace Grgl.Item
{
    /// <summary>
    /// Represents the quantity of items in an inventory using an integer value, and a dictionary of the item instances
    /// </summary>
    public interface IInventoryItem
    {
        /// <summary>
        /// Represents quantity of particular item in character's inventory
        /// </summary>
        int ItemQuantity { get; set; } // TODO: make this GET only?

        /// <summary>
        /// A dictionary of all instances of this item in the character's inventory
        /// accessible by RefId
        /// </summary>
        IDictionary<string, IItem> ItemInstancesDictionary { get; }

    }
}