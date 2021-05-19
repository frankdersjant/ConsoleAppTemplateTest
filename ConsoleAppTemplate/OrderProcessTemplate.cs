using System;

namespace ConsoleAppTemplate
{
    public abstract class OrderProcessTemplate
    {
        public Boolean isGift;

        //Hooks
        public abstract void doSelect();

        //Hooks
        public abstract void doPayment();

        public void giftWrap()
        {
            try
            {
                Console.WriteLine("Gift wrap successfull");
            }
            catch (Exception e)
            {
                Console.WriteLine("Gift wrap unsuccessful", e.Message);
            }
        }

        //Hooks
        public abstract void doDelivery();

        public void processOrder(Boolean isGift)
        {
            doSelect();
            doPayment();
            if (isGift)
            {
                giftWrap();
            }
            doDelivery();
        }
    }
}
