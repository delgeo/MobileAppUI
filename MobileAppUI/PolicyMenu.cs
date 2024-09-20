using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileAppUI
{
    public class PolicyMenu
    {
        private PolicyModel _oldmodel;
        public string IconID { get; set; }

        public ObservableCollection<PolicyModel> Policys { get; set; }

        public PolicyMenu()
        {
            Policys = new ObservableCollection<PolicyModel>()
          {
              new PolicyModel
              {
                   PolicyName="Active Policy",
                   IsVisible=false,
                   Image="menu1",
                   Icon ="down",
                   Policy_Details = new ObservableCollection<PolicyDetails>{
                       new PolicyDetails{
                           Submenu1="View Policy List",
                           Submenu2="Download Policy Schedule",
                           Submenu3="View Premium Recipt",
                           Submenu4="View Product Benefits",
                           Submenu5="Surrendering Policys",
                           Submenu6="Mail Me Policy"
                       },





                  }


              },
              new PolicyModel
              {
                    PolicyName="Policy Changes",
                   IsVisible=false,
                   Image="menu2",
                   Icon ="down",
                   Policy_Details = new ObservableCollection<PolicyDetails>{
                       new PolicyDetails
                       {
                           Submenu1="xxxxx",
                           Submenu2="xxxxxx",
                           Submenu3="xxxxxx",
                           Submenu4="xxxxxx",
                           Submenu5="xxxxxx",
                           Submenu6="xxxxxx"
                       },





                  }
              },
               new PolicyModel
              {
                    PolicyName=" Lapsed Policy" ,
                   IsVisible=false,
                   Image="menu3",

                   Icon="down",
                   Policy_Details = new ObservableCollection<PolicyDetails>{
                       new PolicyDetails
                       {
                        Submenu1="xxxxx",
                           Submenu2="xxxxxx",
                           Submenu3="xxxxxx",
                           Submenu4="xxxxxx",
                           Submenu5="xxxxxx",
                           Submenu6="xxxxxx"
                       },





                  }
              },
                new PolicyModel
              {
                    PolicyName="Payments",
                   IsVisible=false,
                   Image="menu4",

                   Icon ="down",
                   Policy_Details = new ObservableCollection<PolicyDetails>{
                       new PolicyDetails
                       {
                          Submenu1="xxxxx",
                           Submenu2="xxxxxx",
                           Submenu3="xxxxxx",
                           Submenu4="xxxxxx",
                           Submenu5="xxxxxx",
                           Submenu6="xxxxxx"
                       },






                  }
              },
          };
        }

        public void ShowHide(PolicyModel Policy)
        {

            if (_oldmodel == Policy)
            {
                Policy.IsVisible = !Policy.IsVisible;


                if (Policy.IsVisible)
                {
                    Policy.Icon = "up";
                }
                else
                {
                    Policy.Icon = "down";
                }

                UpdatePolicy(Policy);

            }
            else
            {
                if (_oldmodel != null)
                {
                    _oldmodel.IsVisible = false;
                    UpDown(Policy);
                    UpdatePolicy(Policy);




                }
                Policy.IsVisible = true;


                if (Policy.IsVisible)
                {
                    Policy.Icon = "up";
                }
                else
                {
                    Policy.Icon = "down";
                }

                UpdatePolicy(Policy);

            }
            _oldmodel = Policy;
            /* Policy.Icon = "down";*/
        }
        public void UpdatePolicy(PolicyModel Policy)
        {

            var Index = Policys.IndexOf(Policy);
            Policys.Remove(Policy);

            Policys.Insert(Index, Policy);

        }
        public void UpDown(PolicyModel policy)
        {
            policy.IsVisible = !policy.IsVisible;

            if (policy.IsVisible)
            {
                policy.Icon = "up";
            }
            else
            {
                policy.Icon = "down";
            }
        }

    }
    public class PolicyModel
    {
        public string PolicyName { get; set; }
        public bool IsVisible { get; set; }
        public string Image { get; set; }
        public string Up { get; set; }
        public string Down { get; set; }
        public string Icon { get; set; }

        public ObservableCollection<PolicyDetails> Policy_Details { get; set; }

    }
    public class PolicyDetails
    {
        public string Submenu1 { get; set; }
        public string Submenu2 { get; set; }
        public string Submenu3 { get; set; }
        public string Submenu4 { get; set; }
        public string Submenu5 { get; set; }
        public string Submenu6 { get; set; }
        public string Side { get; set; }


    }
}