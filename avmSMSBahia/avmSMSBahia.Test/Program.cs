using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avmSMSBahia.Test
{
	class Program
	{
		static void Main(string[] args)
		{
			try
			{
				string cellphone = string.Empty;
				string message = string.Empty;

				Console.Write("Cellphone: ");
				cellphone = Console.ReadLine();
				Console.Write("SMS Message: ");
				message = Console.ReadLine();

				string result = SendSMS(cellphone, message);

				Console.WriteLine("");
				Console.WriteLine("RETURN = {0}", result);
			}
			catch (Exception ex)
			{
				Console.WriteLine("AN ERROR OCURRED: {0}", (ex.Message ?? "Unknown error"));
			}
		}

		static string SendSMS(string phone, string message)
		{
			try
			{
				if (!string.IsNullOrEmpty(phone) && !string.IsNullOrEmpty(message))
				{
					return new SMSService().SendSMS(phone, message);
				}
				else
				{
					return "Parameters unavailable";
				}
			}
			catch (Exception ex)
			{
				return "ERROR: " + ex.Message;
			}
		}
	}
}
