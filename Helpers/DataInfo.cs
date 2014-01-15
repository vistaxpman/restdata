using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace Helpers
{
    public class DataItemInfo
    {
        public DataItemInfo()
        { }

        public string text
        {
            get;
            set;
        }
        public string value
        {
            get;
            set;
        }
    }
    // This the information that is needed by each checkbox in the 
    // CheckBoxList helper.  
    public class CheckBoxListInfo
    {
        public CheckBoxListInfo(string value, string displayText, bool isChecked)
        {
            this.Value = value;
            this.DisplayText = displayText;
            this.IsChecked = isChecked;
        }
        public string Value { get; private set; }
        public string DisplayText { get; private set; }
        public bool IsChecked { get; private set; }
    }
    public class RolePageInfo
    {
        public RolePageInfo()
        { }
        public string PageID
        {
            get;
            set;
        }
        public string PageGroup
        {
            get;
            set;
        }
        public string PageName
        {
            get;
            set;
        }
        public int Index
        {
            get;
            set;
        }
    }
}
