// Location.cs
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
using Grgl.Other;

namespace Grgl.World
{
    ///  <inheritdoc />
    public class Location : ILocation
    {

        #region Properties

        public Point3D Position
        {
            get;
            protected set;
        }

        public string RegionId
        {
            get;
            set;
        } 

	    #endregion

        /// <summary>
        /// Creates a new instance of a Location object
        /// </summary>
        /// <param name="regionIdArg">The RefId of the current region</param>
        /// <param name="xArg">The x-coordinate within the region</param>
        /// <param name="yArg">The y-coordinate within the region</param>
        /// <param name="zArg">The z-coordinate within the region</param>
        public Location(string regionIdArg, float xArg, float yArg, float zArg)
        {
            this.RegionId = regionIdArg;
            this.Position = new Point3D(xArg, yArg, zArg);
        }


    }//end class
}