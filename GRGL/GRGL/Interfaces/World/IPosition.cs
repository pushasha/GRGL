﻿// IPosition.cs
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

namespace Grgl.Interfaces.World
{
    /// <summary>
    /// Interface that acts like a vector to store 3D coordinates.
    /// </summary>
    /// <remarks>TODO: Make this more generic somehow (i.e. don't restrict to float type)</remarks>
    public interface IPosition
    {
        /// <summary>
        /// Represents the position of an object in a 3D coordinate plane
        /// </summary>
        Tuple<float, float, float> Coords { get; set; }
 
        /// <summary>
        /// Represents the game region in which the object currently exists
        /// </summary>
        IRegion Region { get; set; }

        float X { get;}
        float Y { get;}
        float Z { get;}
    }
}