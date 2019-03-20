using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieList
{
    class AnimatedMovie : Movie
    {
        //Already has release year and title
        public string AnimationStudio
        {
            get;
            set;
        }
        public string AnimationType
        {
            get;
            set;
        }
        public AnimatedMovie(string myTitle, int myReleaseYear, string myAnimationStudio, string myAnimationType)
        {
            this.Title = myTitle;
            this.ReleaseYear = myReleaseYear;
            this.AnimationStudio = myAnimationStudio;
            this.AnimationType = myAnimationStudio;
        }
        public override void ShowDetails()
        {

        }

    }
}
