using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CATchingFish.Entities
{
    public partial class Cat
    {
        public Cat() { }

        //public Cat(int id) { }
        //public int Id { get; set; }
        //public string Name { get; set; }

        private Panel short_Hand;
        private Panel Long_Hand;

        public Cat(Panel short_Hand, Panel long_Hand)
        {
            SetShort_Hand(short_Hand);
            SetLong_Hand(long_Hand);
        }


        public Panel GetShort_Hand()
        {
            return short_Hand;
        }

        public void SetShort_Hand(Panel value)
        {
            short_Hand = value;
        }

        public Panel GetLong_Hand()
        {
            return Long_Hand;
        }

        public void SetLong_Hand(Panel value)
        {
            Long_Hand = value;
        }

        public void SetVisibleShortHand(bool value)
        {
            short_Hand.Visible = value;
        }
        public void setVisiblLongHand(bool value)
        {
            Long_Hand.Visible = value;
        }

        public void HandControl(Panel Short_Hand, Panel Long_Hand)
        {
            Short_Hand.Visible = true;
            Long_Hand.Visible = false;
        }


    }
}
