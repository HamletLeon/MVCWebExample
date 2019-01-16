using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCWebTest.ViewModels
{
    public class CheckBoxListItem
    {
        public int Id { get; set; }
        public string Display { get; set; }
        public bool IsChecked { get; set; }
    }
}