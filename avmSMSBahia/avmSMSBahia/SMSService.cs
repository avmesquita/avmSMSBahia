using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avmSMSBahia
{
	/// <summary>
	/// Service Class to Send SMS through SMS Bahia Gateway
	/// </summary>
	public class SMSService : IDisposable
	{
		#region PRIVATE PROPERTIES
		// TYPE = SEND = 1
		private int _type = 1;

		// Private USER Parameter
		private string _user = string.Empty;

		// Private TOKEN Parameter
		private string _token = string.Empty;

		// Private SERIAL Parameter
		private string _serial = string.Empty;

		// Private WS Parameter
		private string _ws = string.Empty;
		#endregion

		#region Constructor / Destructor
		/// <summary>
		/// Constructor
		/// </summary>
		public SMSService()
		{
			this.SelfClean();
		}

		/// <summary>
		/// Destructor
		/// </summary>
		~SMSService()
		{
			this.SelfClean();
		}
		#endregion

		#region PRIVATE METHODS
		/// <summary>
		/// Loads SMS Bahia webservice local configuration
		/// </summary>
		private void LoadConfig()
		{
			try
			{
				// Type 1 - SEND
				this._type = 1;

				// USER Parameter
				this._user = ConfigurationManager.AppSettings["SMS_USER"];

				// TOKEN Parameter
				this._token = ConfigurationManager.AppSettings["SMS_TOKEN"];

				// SERIAL Parameter
				this._serial = ConfigurationManager.AppSettings["SMS_SERIAL"];

				// WS Parameter
				this._ws = ConfigurationManager.AppSettings["SMS_WS"];
			}
			catch
			{				
				throw new Exception("Local File Parameters are wrong.");
			}
		}

		/// <summary>
		/// Clean Dummy Method
		/// </summary>
		private void SelfClean()
		{
			_type = 0;
			_user = string.Empty;
			_token = string.Empty;
			_serial = string.Empty;
			_ws = string.Empty;
		}
		#endregion

		#region PUBLIC METHODS
		/// <summary>
		/// Send Method
		/// (with local file configuration)
		/// </summary>
		/// <param name="telefoneNumber">Cellphone Number</param>
		/// <param name="message">Message</param>
		/// <returns></returns>
		public string SendSMS(string telephoneNumber, string message)
		{
			// Load params
			LoadConfig();

			// Call main method
			return this.SendSMS(_type, _user, _token, _serial, _ws, telephoneNumber, message);
		}

		/// <summary>
		/// Full Send Method
		/// (without local file parameters)
		/// </summary>
		/// <param name="type"></param>
		/// <param name="user"></param>
		/// <param name="token"></param>
		/// <param name="serial"></param>
		/// <param name="ws"></param>
		/// <param name="telefoneNumber"></param>
		/// <param name="message"></param>
		/// <returns></returns>
		public string SendSMS(int type, string user, string token, string serial, string ws, string telephoneNumber, string message)
		{
			if (!string.IsNullOrEmpty(telephoneNumber) && !string.IsNullOrEmpty(message))
			{
				// Clean Client Instance
				wsSMSBahia.wssmsSoapClient cliente = null;
				string ret = string.Empty;
				try
				{
					// Randomize and get first 5 positions
					string correlationId = new Random(1).Next().ToString().Substring(1, 5);

					// Create a JSON message
					string json = "{'messages':[{'destination':'" + telephoneNumber + "','correlationId':'" + correlationId + "'}],'defaultValues':{'messageText':'" + message + "'}}";

					// Change single quotes to double quotes
					string JSON = json.Replace('\'', '"');

					// Translate JSON Object
					JObject jsonobj = JObject.Parse(JSON);

					try
					{
						// Client Instance
						cliente = new wsSMSBahia.wssmsSoapClient();

						// Cliente instance open connection
						cliente.Open();

						// Send using sms gateway api method
						ret = cliente.Envios(type, user, token, jsonobj.ToString());
					}
					catch (Exception ex)
					{
						// Close cliente connection
						cliente.Close();
						throw ex;
					}
					return ret;
				}
				catch (Exception ex)
				{
					// Close client connection
					cliente.Close();

					// Retorna a mensagem para identificação do erro
					return "Error: " + ex.Message ?? "Unknown error";
				}
			}
			else return "Info: Insufficient parameters to send";
		}
		#endregion

		#region IDisposable
		public void Dispose()
		{
			GC.WaitForPendingFinalizers();			
			GC.SuppressFinalize(this);
		}
		#endregion
	}
}
