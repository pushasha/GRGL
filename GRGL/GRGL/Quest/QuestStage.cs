// QuestStage.cs
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
    ///  <inheritdoc />
    public class QuestStage : IQuestStage
    {
        #region Properties
        public bool IsComplete
        {
            get;
            set;
        }

        public bool IsEndStage
        {
            get;
            protected set;
        }

        public string CompletedWithStage
        {
            get;
            set;
        }

        public IList<string> ChildStages
        {
            get;
            private set;
        }

        public string Name
        {
            get;
            protected set;
        }

        public string RefId
        {
            get;
            protected set;
        } 
        #endregion

        /// <summary>
        /// Creates a new instance of a QuestStage object
        /// </summary>
        /// <param name="idArg">The RefId of this quest stage</param>
        public QuestStage(string idArg)
        {
            this.RefId = idArg;
            this.Name = null;
            this.ChildStages = new List<string>();

            // init default property values
            this.CompletedWithStage = null;
            this.IsComplete = false;
        }

    }//end class
}