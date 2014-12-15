// Quest.cs
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

namespace Grgl.Quest
{
    ///  <inheritdoc cref="IQuest"/>
    public class Quest : IQuest
    {

        #region Properties
        ///  <inheritdoc />
        public string Name
        {
            get;
            private set;
        }

        ///  <inheritdoc />
        public string RefId
        {
            get;
            private set;
        }

        ///  <inheritdoc />
        public bool IsComplete
        {
            get;
            set;
        }

        ///  <inheritdoc />
        public string StartStage
        {
            get;
            private set;
        }

        ///  <inheritdoc />
        public IDictionary<string, IQuestStage> Stages
        {
            get;
            private set;
        } 
        #endregion

        /// <summary>
        /// Creates a new instance of a Quest object
        /// </summary>
        /// <param name="idArg">The RefId of this quest</param>
        /// <param name="nameArg">Human-readable name for this quest</param>
        public Quest(string idArg, string nameArg)
        {
            this.RefId = idArg;
            this.Name = nameArg;
            
            // set default property values
            this.IsComplete = false;
            this.StartStage = null;

            this.Stages = new Dictionary<string, IQuestStage>();
        }

    }//end class
}