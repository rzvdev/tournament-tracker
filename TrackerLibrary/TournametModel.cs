using System.Collections.Generic;

namespace TrackerLibrary
{
    public class TournametModel
    {
        /// <summary>
        /// Represents tournament name.
        /// </summary>
        public string TournamentName { get; set; }

        /// <summary>
        /// Represents the tournament entry fee.
        /// </summary>
        public decimal EntryFee { get; set; }

        /// <summary>
        /// Represents the teams registered in the tournament.
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();

        /// <summary>
        /// Represents prizes of tournament.
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();

        /// <summary>
        /// Represents one round of the tournament.
        /// </summary>
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();
    }
}
