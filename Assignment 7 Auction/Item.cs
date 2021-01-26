using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_7_Auction
{
    class Item
    {
        private string des; //description of item 
        private double RPrice;//reserve price
        private double HBid; // highest bid
        private int ID;
        int BidderID = 0;

        public Item(string des,double RPrice)
        {
            this.des = des;
            this.RPrice = RPrice;
        }
        public string GetDes()
        {
            return des;
        }
        public double GetRPrice()
        {
            return RPrice;
        }
        public double GetHBid()
        {
            return HBid;
        }
        public int GetID()
        {
            return ID;
        }

        public bool SetHighestBid(double newBid,int ID)
        {
            if (newBid > HBid)
            {
                HBid = newBid;
                ID = BidderID;
                return true;
            }
            else 
            {
                return false;
            }
        }

        public void SetBidderID(int ID)
        {
            BidderID = ID;
        }
    }
}
