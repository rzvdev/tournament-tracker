namespace TrackerLibrary
{
    /// <summary>
    /// Represent the tournament prizes.
    /// </summary>
    public class PrizeModel
    {
        /// <summary>
        /// Represents the place won in the tournament.
        /// </summary>
        public int PlaceNumber { get; set; }

        /// <summary>
        /// Represents the place name won in the tournament.
        /// </summary>
        public string PlaceName { get; set; }

        /// <summary>
        /// Represents the gain value of the place won in tournament.
        /// </summary>
        public decimal PrizeAmount { get; set; }

        /// <summary>
        /// Represents the percentage of prize
        /// </summary>
        public double PrizePercentage { get; set; }
    }
}