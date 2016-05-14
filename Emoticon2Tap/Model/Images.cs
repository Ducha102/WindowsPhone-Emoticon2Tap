using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emoticon2Tap.Model
{
    class Images
    {
        public int ImageId { get; set; }
        public string ImageName { get; set; }

        public Images() { }

        public Images(int Id, string Name)
        {
            this.ImageId = Id;
            this.ImageName = Name;
        }
    }
}
