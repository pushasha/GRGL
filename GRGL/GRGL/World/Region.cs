// Region.cs
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

namespace Grgl.World
{
    ///  <inheritdoc cref="IRegion"/>
    public class Region : IRegion
    {

        #region Properties
        ///  <inheritdoc />
        public string RefId
        {
            get;
            protected set;
        }

        ///  <inheritdoc />
        public string Name
        {
            get; 
            protected set;
        }

        ///  <inheritdoc />
        public IDictionary<string, IRegion> Subregions
        {
            get;
            protected set;
        } 
        
        #endregion

        /// <summary>
        /// Creates a new instance of a Region object.
        /// </summary>
        /// <param name="idArg">RefId of this region</param>
        /// <param name="nameArg">Human-readable name of this region</param>
        public Region(string idArg, string nameArg)
        {
            this.RefId = idArg;
            this.Name = nameArg;
            this.Subregions = new Dictionary<string, IRegion>();
        }

    }//end class
}