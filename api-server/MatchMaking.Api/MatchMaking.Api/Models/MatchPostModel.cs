namespace MatchMaking.Api.Models
{
    public class MatchPostModel
    {
        public int MatchMakerId { get; set; }

        /// עמימות
        public int IdF { get; set; }
        public DateTime Date { get; set; }
    }
}
