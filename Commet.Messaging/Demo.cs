﻿using Smsgh.Api.Sdk.Smsgh;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Comet.SMS
{
    internal class Demo
    { 
        private static void Main(string[] args)
        {

            //Fetch Your Keys From App Settings for Security 
            ClientCredentials.ClientId = ConfigurationSettings.AppSettings["ClientId"];
            ClientCredentials.ClientSecret = ConfigurationSettings.AppSettings["ClientSecret"];

            //Enable Logging- This will be output to a .txt file
            MessageLogger.EnableLogging = true;
            //Optional Log to text Feature: create a .txt file and point to path        
            //MessageLogger.LogPath = "";

            //Get your phone Numbers .ToList() from your database, for demo purpose i am building the list
            List<string> myphone = new List<string>();
            myphone.Add("0266275605");
            myphone.Add("0266275605");
            myphone.Add("0246684093");
            myphone.Add("0266111");

            //Add list of Phone Numbers
            Phone.PhoneNumbers = myphone;
            // Configure and use the MessageClient to Send your Messages
            MessageClient msg = new MessageClient("Testing", "Testing Bulk SMS", true);
            msg.SendBulkSMS();

            Console.WriteLine("Done...");
            Console.ReadKey();
        }
    }

}
