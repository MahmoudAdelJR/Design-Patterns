using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class VoteMachine
    {
        private static VoteMachine _voteMachine = null;
        private int _totalVotes = 0;
        private static readonly object locker = new object();
        private VoteMachine()
        {

        }
        public static VoteMachine GetVoteMachine
        {
            get
             { 
                    lock(locker)
                    {
                        if (_voteMachine is null)
                        {
                            _voteMachine = new VoteMachine();
                        }
                    }
                return _voteMachine;
            }
        }

        public void RegisterVote()
        {
            _totalVotes += 1;
            Console.WriteLine("Registered Vote !");
        }

        public int TotalVotes
        {
            get
            {
                return _totalVotes;
            }
        }

    }
}
