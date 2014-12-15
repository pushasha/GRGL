// QuestLog.cs
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
    ///  <inheritdoc cref="IQuestLog"/>
    public class QuestLog : IQuestLog
    {
        #region Properties
        ///  <inheritdoc />
        public IDictionary<string, IQuest> Quests
        {
            get;
            protected set;
        }
        ///  <inheritdoc />
        public IList<string> IncompleteQuestsList
        {
            get;
            protected set;
        }
        ///  <inheritdoc />
        public IList<string> CompleteQuestsList
        {
            get;
            protected set;
        } 
        #endregion

        /// <summary>
        /// Creates a new instance of a QuestLog object
        /// </summary>
        public QuestLog()
        {
            this.Quests = new Dictionary<string, IQuest>();
            this.IncompleteQuestsList = new List<string>();
            this.CompleteQuestsList = new List<string>();
        }

        ///  <inheritdoc />
        public bool AddQuest(IQuest questArg)
        {
            if (this.Quests.ContainsKey(questArg.RefId))
            {
                return false; // quest already in log, do not add
            }
            this.Quests.Add(questArg.RefId, questArg);
            this.IncompleteQuestsList.Add(questArg.RefId);
            return true;
        }

        ///  <inheritdoc />
        public bool CompleteQuest(string idArg)
        {
            if (!this.IncompleteQuestsList.Contains(idArg) || !this.Quests.ContainsKey(idArg)) { 
                return false; // either already complete, or somehow got added to one list but not the other.
            }

            this.IncompleteQuestsList.Remove(idArg);
            this.CompleteQuestsList.Add(idArg);

            return true;
        }
    }//end class
}