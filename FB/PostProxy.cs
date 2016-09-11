using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FB
{
    public class PostProxy : Post
    {
        protected override void OnPropertyChanged(string i_PropertyName)
        {
            
            base.OnPropertyChanged(i_PropertyName);
        }
    }
}