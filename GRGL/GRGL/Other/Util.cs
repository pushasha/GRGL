// Util.cs
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

namespace Grgl.Other
{
    /// <summary>
    /// A structure representing a point in three-dimensional space.
    /// </summary>
    public struct Point3D
    {
        /// <summary>
        /// The X, Y, and Z coordinates of this point
        /// </summary>
        public float X, Y, Z;

        /// <summary>
        /// Point3D constructor
        /// </summary>
        /// <param name="xArg">X coordinate</param>
        /// <param name="yArg">Y coordinate</param>
        /// <param name="zArg">Z coordinate</param>
        public Point3D(float xArg, float yArg, float zArg)
        {
            X = xArg;
            Y = yArg;
            Z = zArg;
        }

    }//end struct
}
