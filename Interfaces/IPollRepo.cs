using SurveyBasket.Models;

namespace SurveyBasket.Interfaces
{
    public interface IPollRepo
    {
        public List<Poll> Polls();
        public Poll? Poll(int id);
    }
}
