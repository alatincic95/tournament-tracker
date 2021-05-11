using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary.Models1
{
    public class MatchupEntryModel
    {
        public int Id { get; set; }

        public int TeamCompetingId { get; set; }

        /// <summary>
        /// Represents one team in matchup.
        /// </summary>
        public TeamModel TeamCompeting { get; set; }

        /// <summary>
        /// Represents score for this particular team.
        /// </summary>
        public double Score { get; set; }

        public int ParentMatchupId { get; set; }

        /// <summary>
        /// Repreents the matchup that this team came
        /// from as the winner.
        /// </summary>
        public MatchupModel ParentMatchup { get; set; }

    }
}
