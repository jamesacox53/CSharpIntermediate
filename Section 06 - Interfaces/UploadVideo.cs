using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section06Namespace
{
    internal class UploadVideo : IActivity
    {

        private string _fileName;
        private string FileName 
        { 
            get 
            { 
                return _fileName; 
            }
            set 
            {
                if (value == null || value.Trim() == "") throw new ArgumentNullException();
                _fileName = value; 
            }
        }

        public UploadVideo(string fileName)
        {
            this.FileName = fileName;
        }

        public void Execute()
        {
            Console.WriteLine("Uploading Video: " + this.FileName + " to cloud storage.");
        }
    }
}
