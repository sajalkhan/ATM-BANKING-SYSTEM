using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace MyControls
{
    class MyComboBox:System.Windows.Forms.ComboBox
    {
        public MyComboBox():base()
        {
            this.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
        }

        public bool Source(DataSet ds,string display="name",string value="id")
        {
            this.DataSource = ds.Tables[0];
            this.DisplayMember = display;
            this.ValueMember = value;
            return true;
        }
    }
}
