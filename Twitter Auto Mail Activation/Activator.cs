using Microsoft.Exchange.WebServices.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twitter_Auto_Mail_Activation
{
    class Activator
    {
       private ExchangeService exchange;
        public Activator()
        {
            exchange = new ExchangeService(ExchangeVersion.Exchange2013_SP1);
            exchange.Credentials = new WebCredentials("syjecomujira@hotmail.com", "mno12300", "@hotmail.com");
            exchange.AutodiscoverUrl("syjecomujira@hotmail.com");




        }

       public string GetLastTwitterMessage()
        {



            if (exchange != null)
            {
                FindItemsResults<Item> result = exchange.FindItems(WellKnownFolderName.Inbox, new ItemView(15));
                foreach (var item in result)
                {
                    EmailMessage Message = EmailMessage.Bind(exchange, item.Id);
                    if (Message.IsRead == false)
                    {


                        //                        textBox1.AppendText(Message.Subject + Environment.NewLine);
                        //                      textBox1.AppendText(Message.TextBody + Environment.NewLine);
                        //                    textBox1.AppendText("-----------" + Environment.NewLine);
                        return "aaa";

                    }
                    return "";

                }
                return "";
            }
            return "";

        }




    }
}
