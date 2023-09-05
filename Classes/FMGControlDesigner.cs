using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Windows.Forms.Design;
using SBS_BarthLogistic.Controls;
using SBS_BarthLogistic.Interfaces;

namespace SBS_BarthLogistic.Classes
{
    /// <summary>
    ///     -- ვერსია 0.1 -- 7 Jun 2016 17:00 ნიკა
    ///     . მგონი ბოლო ვერსიაა :)))
    /// </summary>
    public class FMGControlDesigner : ControlDesigner
    {
        public override DesignerActionListCollection ActionLists
        {
            get
            {
                var d = new DesignerActionListCollection();
                d.Add(new UserControlDesigner(Component));
                return d;
            }
        }
    }

    public class UserControlDesigner : DesignerActionList
    {
        //readonly DesignerActionUIService designerActionSvc;
        readonly IFMGFindControl fmgControl;
        DesignerActionItemCollection items;

        public UserControlDesigner(IComponent component)
            : base(component)
        {
            fmgControl = component as IFMGFindControl;
            //designerActionSvc = GetService(typeof(DesignerActionUIService)) as DesignerActionUIService;
        }

        public string FieldName
        {
            get { return fmgControl.FieldName; }
            set
            {
                GetPropertyByName("FieldName").SetValue(fmgControl, value);
                RefreshAll();
            }
        }

        public bool AlwaysChecked
        {
            get { return fmgControl.AlwaysChecked; }
            set
            {
                GetPropertyByName("AlwaysChecked").SetValue(fmgControl, value);
                RefreshAll();
            }
        }

        public bool Checked
        {
            get { return fmgControl.Checked; }
            set
            {
                GetPropertyByName("Checked").SetValue(fmgControl, value);
                RefreshAll();
            }
        }

        public string ParameterName
        {
            get { return fmgControl.ParameterName; }
            set
            {
                GetPropertyByName("ParameterName").SetValue(fmgControl, value);
                RefreshAll();
            }
        }

        public string Text
        {
            get { return fmgControl.Text; }
            set
            {
                GetPropertyByName("Text").SetValue(fmgControl, value);
                RefreshAll();
            }
        }

        public string TextHidden
        {
            get { return (fmgControl as FMGCheckFilterControl).TextHidden; }
            set
            {
                GetPropertyByName("TextHidden").SetValue(fmgControl as FMGCheckFilterControl, value);
                RefreshAll();
            }
        }

        PropertyDescriptor GetPropertyByName(string propName)
        {
            var prop = TypeDescriptor.GetProperties(fmgControl)[propName];
            if (prop == null)
            {
                throw new ArgumentException("Invalid Property", propName);
            }
            return prop;
        }

        public void SetParameterName()
        {
            ParameterName = FieldName;
            GetPropertyByName("ParameterName").SetValue(fmgControl, FieldName);
            RefreshAll();
        }

        void RefreshAll()
        {
            //designerActionSvc.Refresh(fmgControl as Control);
            //(fmgControl as Control).Refresh();
        }

        public override DesignerActionItemCollection GetSortedActionItems()
        {
            items = new DesignerActionItemCollection();
            items.Add(new DesignerActionHeaderItem("Find Forms", "F"));
            items.Add(new DesignerActionPropertyItem("AlwaysChecked", "მუდმივად მონიშნული", "F",
                "მომხმარებელს არ შეელძლება ამოღნიშნოს"));
            items.Add(new DesignerActionPropertyItem("Checked", "მონიშვნა", "F"));
            items.Add(new DesignerActionPropertyItem("FieldName", "ველის სახელი", "F", "ბაზაში ველის სახელი"));
            items.Add(new DesignerActionPropertyItem("Text", "ტექსტი", "F", "ტექსტი, წარწერა"));
            if (fmgControl is FMGCheckFilterControl)
            {
                items.Add(new DesignerActionPropertyItem("TextHidden", "ტექსტი 2", "F", "დამალული ჩექბოქსის ტექსტი"));
            }
            items.Add(new DesignerActionHeaderItem("Print Forms", "prn"));
            items.Add(new DesignerActionPropertyItem("ParameterName", "პარამეტრის სახელი", "prn",
                "პარამეტრის სახელი პროცედურისთივს"));
            items.Add(new DesignerActionMethodItem(this, "SetParameterName", "პარამეტრის სახელის დაყენება", "prn",
                "პარამეტრის სახელი პროცედურისთივს", true));
            return items;
        }
    }

    public class FMGSelectDesigner : ControlDesigner
    {
        public override DesignerActionListCollection ActionLists
        {
            get
            {
                var d = new DesignerActionListCollection();
                d.Add(new UserSelectDesigner(Component));
                return d;
            }
        }
    }

    public class UserSelectDesigner : DesignerActionList
    {
        //readonly DesignerActionUIService designerActionSvc;
        readonly ISelect fmgControl;

        public UserSelectDesigner(IComponent component)
            : base(component)
        {
            fmgControl = component as ISelect;
            //designerActionSvc = GetService(typeof(DesignerActionUIService)) as DesignerActionUIService;
        }

        public bool SearchOnLeave
        {
            get { return fmgControl.SearchOnLeave; }
            set
            {
                GetPropertyByName("SearchOnLeave").SetValue(fmgControl, value);
                //fmgControl.SearchOnLeave = value;
                RefreshAll();
            }
        }

        public string Filter
        {
            get { return fmgControl.Filter; }
            set
            {
                GetPropertyByName("Filter").SetValue(fmgControl, value);
                //fmgControl.Filter = value;
                RefreshAll();
            }
        }

        PropertyDescriptor GetPropertyByName(string propName)
        {
            var prop = TypeDescriptor.GetProperties(fmgControl)[propName];
            if (prop == null)
            {
                throw new ArgumentException("Invalid Property", propName);
            }
            return prop;
        }

        void RefreshAll()
        {
            //designerActionSvc.Refresh(fmgControl as Control);
            //(fmgControl as Control).Refresh();
        }

        public override DesignerActionItemCollection GetSortedActionItems()
        {
            var items = new DesignerActionItemCollection();
            items.Add(new DesignerActionHeaderItem("ოფციები", "F"));
            items.Add(new DesignerActionPropertyItem("SearchOnLeave", "ძებნა ველის დატოვებისას", "F"));
            items.Add(new DesignerActionPropertyItem("Filter", "ფილტრი", "F"));
            return items;
        }
    }
}