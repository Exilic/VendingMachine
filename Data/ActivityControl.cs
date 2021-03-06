
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Mail;
using VendingMachine.Model;

namespace VendingMachine.Data

{

    public class ActivityControl
    {

        // Activity state = [0] Operating, energy save mode [1] Time stamp
        private static string activityState;
        private static CustomerSession customer;

        public static string RevealActivityState()
        {
            return activityState;
        }

        public static void RespondToCustomerActivity()
        {
            if (activityState == "energy save mode")
            {
                activityState = "Operating";
                customer = new CustomerSession(DateTime.Now);
            }
        }

        public static void BuyProduct(int keyPush, int latestKeyPush)
        {
            if (ProductStock.CheckSupply(keyPush))
            {
                Vending.DetailTheExchange(keyPush, latestKeyPush);
            }
            else
            {
                ConcatenateCurrentMessage($"We have run out of {ProductStock.ShowProductInfo(keyPush).ProductName}");
            }
            
        }
       
        public static void AlertSecurity() //E-mail functionality is not fully developed, because it depends on outside conditions
        {
            string[] i = Array.ConvertAll(MoneyStock.RevealMoneyAvailable(), denom => denom.ToString());

            MailMessage securityMessage = new MailMessage("VendingMachineID42", "SecurityID1D42");
            securityMessage.Subject = "Vending machine needs a new set of money";
            securityMessage.Body = ($"On {DateTime.Now.ToString()}, a security issue was registered concerning the stock of money.\nThe current stock is {i[0]}*1000kr, {i[1]}*500kr, {i[2]}100kr, {i[3]}*50kr, {i[4]}*20kr, {i[5]}*10kr, {i[6]}*5kr and {i[7]}*1kr.");
            SmtpClient client = new SmtpClient();
            client.UseDefaultCredentials = true;

            try
            {
                client.Send(securityMessage);
            }
            catch { }
        }

        public static void AlertMaintenance() //E-mail functionality is not fully developed, because it depends on outside conditions
        {
            MailMessage maintenanceMessage = new MailMessage("VendingMachineID42", "MaintenanceID42");
            maintenanceMessage.Subject = "Product stock is running low";
            maintenanceMessage.Body = ($"On {DateTime.Now.ToString()}, a maintenance issue was registered concerning the stock of products.\nThe");
            SmtpClient client = new SmtpClient();
            client.UseDefaultCredentials = true;

            try
            {
                client.Send(maintenanceMessage);
            }
            catch { }
        }
    

        public static void ConcatenateCurrentMessage(string message)
        {
            Product product = ProductStock.ShowProductInfo(Keypad.newKeyPush);
            if (message.Contains("to confirm") || message.Contains("miss by"))
            {
                Display.ChangeCurrentMessage(product.ProductName+ " for " + product.ProductPrice + ". " + message);
            }
            
            else if (message.Contains("run out") || message.Contains("not recognized") || message.Contains("Enjoy"))
            {
                Display.ChangeCurrentMessage(message);
            }


        }

        public static void EndSession()
        {
            Vending.SettleDebtToCustomer();
            Display.PowerDownDisplay();
            activityState = "energy save mode";
        }

        public static void WriteActivityLog()
        {

        }

    }

}