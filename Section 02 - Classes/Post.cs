using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section02Namespace
{
    internal class Post
    {
        private string _title;
        public string Title 
        { 
          get { return _title; }
          set 
            {
                ValidateTitleInput(value);
                _title = value;
            }                  
        }

        private string _description;
        public string Description
        {
            get { return _description; }
            set
            {
                ValidateDescriptionInput(value);
                _description = value;
            }
        }

        private DateTime created = DateTime.Now;

        private int _voteValue = 0;

        public int VoteValue { get { return _voteValue; } }

        public Post(string title, string description)
        {
            this.Title = title;
            this.Description = description;
        }

        private void ValidateTitleInput(string title)
        {
            if (title == null) throw new ArgumentNullException("Title cannot be null");
            if (title.Trim() == "") throw new ArgumentException("Title cannot be empty");
        }

        private void ValidateDescriptionInput(string description)
        {
            if (description == null) throw new ArgumentNullException("Description cannot be null");
            if (description.Trim() == "") throw new ArgumentException("Description cannot be empty");
        }

        public void UpVote()
        {
            this._voteValue++;
        }

        public void DownVote()
        {
            this._voteValue--;
        }
    }
}
