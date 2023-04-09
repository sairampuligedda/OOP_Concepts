using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    internal class Post
    {
        private readonly string _name;
        private readonly string _description;
        private readonly DateTime _created;
        private DateTime _updated;
        private int _votes;

        public Post(string name, string description)
        {
            _name = name;
            _description = description;
            _created = DateTime.Now;
        }

        public void UpVote()
        {
            _votes++;
            _updated = DateTime.Now;
        }

        public void DownVote()
        {
            _votes--;   
            _updated = DateTime.Now;
        }

        public string GetVotes()
        {
            return String.Format("The Current Votes of {0} are - {1}! last voted on: {2}", _name, _votes, _updated.ToString());
        }

        ///// master change
    }
}
