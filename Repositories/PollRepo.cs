

namespace SurveyBasket.Repositories
{
    public class PollRepo : IPollRepo
    {
        private readonly List<Poll> _polls = [
            new Poll{
                Id = 1,
                Title = "poll 1",
                Description = "first poll"
            }
            ];
        public Poll? Poll(int id)
        {
            return _polls.SingleOrDefault(pol => pol.Id == id);
        }

        public List<Poll> Polls()
        {
            return _polls;
        }
    }
}
