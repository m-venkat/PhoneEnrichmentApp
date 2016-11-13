using PhoneNumbers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace PhoneValidatorApp
{
    public partial class PhoneValidator : Form
    {
        public PhoneValidator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Dictionary<string, string> countryDict = new Dictionary<string, string>();
            countryDict.Add("AF", "Afghanistan");
            countryDict.Add("AX", "Åland Islands");
            countryDict.Add("AL", "Albania");
            countryDict.Add("DZ", "Algeria");
            countryDict.Add("AS", "American Samoa");
            countryDict.Add("AD", "Andorra");
            countryDict.Add("AO", "Angola");
            countryDict.Add("AI", "Anguilla");
            countryDict.Add("AQ", "Antarctica");
            countryDict.Add("AG", "Antigua and Barbuda");
            countryDict.Add("AR", "Argentina");
            countryDict.Add("AM", "Armenia");
            countryDict.Add("AW", "Aruba");
            countryDict.Add("AU", "Australia");
            countryDict.Add("AT", "Austria");
            countryDict.Add("AZ", "Azerbaijan");
            countryDict.Add("BS", "Bahamas");
            countryDict.Add("BH", "Bahrain");
            countryDict.Add("BD", "Bangladesh");
            countryDict.Add("BB", "Barbados");
            countryDict.Add("BY", "Belarus");
            countryDict.Add("BE", "Belgium");
            countryDict.Add("BZ", "Belize");
            countryDict.Add("BJ", "Benin");
            countryDict.Add("BM", "Bermuda");
            countryDict.Add("BT", "Bhutan");
            countryDict.Add("BO", "Bolivia (Plurinational State of)");
            countryDict.Add("BQ", "Bonaire, Sint Eustatius and Saba");
            countryDict.Add("BA", "Bosnia and Herzegovina");
            countryDict.Add("BW", "Botswana");
            countryDict.Add("BV", "Bouvet Island");
            countryDict.Add("BR", "Brazil");
            countryDict.Add("IO", "British Indian Ocean Territory");
            countryDict.Add("BN", "Brunei Darussalam");
            countryDict.Add("BG", "Bulgaria");
            countryDict.Add("BF", "Burkina Faso");
            countryDict.Add("BI", "Burundi");
            countryDict.Add("CV", "Cabo Verde");
            countryDict.Add("KH", "Cambodia");
            countryDict.Add("CM", "Cameroon");
            countryDict.Add("CA", "Canada");
            countryDict.Add("KY", "Cayman Islands");
            countryDict.Add("CF", "Central African Republic");
            countryDict.Add("TD", "Chad");
            countryDict.Add("CL", "Chile");
            countryDict.Add("CN", "China");
            countryDict.Add("CX", "Christmas Island");
            countryDict.Add("CC", "Cocos (Keeling) Islands");
            countryDict.Add("CO", "Colombia");
            countryDict.Add("KM", "Comoros");
            countryDict.Add("CG", "Congo");
            countryDict.Add("CD", "Congo (Democratic Republic of the)");
            countryDict.Add("CK", "Cook Islands");
            countryDict.Add("CR", "Costa Rica");
            countryDict.Add("CI", "Côte d'Ivoire");
            countryDict.Add("HR", "Croatia");
            countryDict.Add("CU", "Cuba");
            countryDict.Add("CW", "Curaçao");
            countryDict.Add("CY", "Cyprus");
            countryDict.Add("CZ", "Czech Republic");
            countryDict.Add("DK", "Denmark");
            countryDict.Add("DJ", "Djibouti");
            countryDict.Add("DM", "Dominica");
            countryDict.Add("DO", "Dominican Republic");
            countryDict.Add("EC", "Ecuador");
            countryDict.Add("EG", "Egypt");
            countryDict.Add("SV", "El Salvador");
            countryDict.Add("GQ", "Equatorial Guinea");
            countryDict.Add("ER", "Eritrea");
            countryDict.Add("EE", "Estonia");
            countryDict.Add("ET", "Ethiopia");
            countryDict.Add("FK", "Falkland Islands (Malvinas)");
            countryDict.Add("FO", "Faroe Islands");
            countryDict.Add("FJ", "Fiji");
            countryDict.Add("FI", "Finland");
            countryDict.Add("FR", "France");
            countryDict.Add("GF", "French Guiana");
            countryDict.Add("PF", "French Polynesia");
            countryDict.Add("TF", "French Southern Territories");
            countryDict.Add("GA", "Gabon");
            countryDict.Add("GM", "Gambia");
            countryDict.Add("GE", "Georgia");
            countryDict.Add("DE", "Germany");
            countryDict.Add("GH", "Ghana");
            countryDict.Add("GI", "Gibraltar");
            countryDict.Add("GR", "Greece");
            countryDict.Add("GL", "Greenland");
            countryDict.Add("GD", "Grenada");
            countryDict.Add("GP", "Guadeloupe");
            countryDict.Add("GU", "Guam");
            countryDict.Add("GT", "Guatemala");
            countryDict.Add("GG", "Guernsey");
            countryDict.Add("GN", "Guinea");
            countryDict.Add("GW", "Guinea-Bissau");
            countryDict.Add("GY", "Guyana");
            countryDict.Add("HT", "Haiti");
            countryDict.Add("HM", "Heard Island and McDonald Islands");
            countryDict.Add("VA", "Holy See");
            countryDict.Add("HN", "Honduras");
            countryDict.Add("HK", "Hong Kong");
            countryDict.Add("HU", "Hungary");
            countryDict.Add("IS", "Iceland");
            countryDict.Add("IN", "India");
            countryDict.Add("ID", "Indonesia");
            countryDict.Add("IR", "Iran (Islamic Republic of)");
            countryDict.Add("IQ", "Iraq");
            countryDict.Add("IE", "Ireland");
            countryDict.Add("IM", "Isle of Man");
            countryDict.Add("IL", "Israel");
            countryDict.Add("IT", "Italy");
            countryDict.Add("JM", "Jamaica");
            countryDict.Add("JP", "Japan");
            countryDict.Add("JE", "Jersey");
            countryDict.Add("JO", "Jordan");
            countryDict.Add("KZ", "Kazakhstan");
            countryDict.Add("KE", "Kenya");
            countryDict.Add("KI", "Kiribati");
            countryDict.Add("KP", "Korea (Democratic People's Republic of)");
            countryDict.Add("KR", "Korea (Republic of)");
            countryDict.Add("KW", "Kuwait");
            countryDict.Add("KG", "Kyrgyzstan");
            countryDict.Add("LA", "Lao People|s Democratic Republic");
            countryDict.Add("LV", "Latvia");
            countryDict.Add("LB", "Lebanon");
            countryDict.Add("LS", "Lesotho");
            countryDict.Add("LR", "Liberia");
            countryDict.Add("LY", "Libya");
            countryDict.Add("LI", "Liechtenstein");
            countryDict.Add("LT", "Lithuania");
            countryDict.Add("LU", "Luxembourg");
            countryDict.Add("MO", "Macao");
            countryDict.Add("MK", "Macedonia (the former Yugoslav Republic of)");
            countryDict.Add("MG", "Madagascar");
            countryDict.Add("MW", "Malawi");
            countryDict.Add("MY", "Malaysia");
            countryDict.Add("MV", "Maldives");
            countryDict.Add("ML", "Mali");
            countryDict.Add("MT", "Malta");
            countryDict.Add("MH", "Marshall Islands");
            countryDict.Add("MQ", "Martinique");
            countryDict.Add("MR", "Mauritania");
            countryDict.Add("MU", "Mauritius");
            countryDict.Add("YT", "Mayotte");
            countryDict.Add("MX", "Mexico");
            countryDict.Add("FM", "Micronesia (Federated States of)");
            countryDict.Add("MD", "Moldova (Republic of)");
            countryDict.Add("MC", "Monaco");
            countryDict.Add("MN", "Mongolia");
            countryDict.Add("ME", "Montenegro");
            countryDict.Add("MS", "Montserrat");
            countryDict.Add("MA", "Morocco");
            countryDict.Add("MZ", "Mozambique");
            countryDict.Add("MM", "Myanmar");
            countryDict.Add("NA", "Namibia");
            countryDict.Add("NR", "Nauru");
            countryDict.Add("NP", "Nepal");
            countryDict.Add("NL", "Netherlands");
            countryDict.Add("NC", "New Caledonia");
            countryDict.Add("NZ", "New Zealand");
            countryDict.Add("NI", "Nicaragua");
            countryDict.Add("NE", "Niger");
            countryDict.Add("NG", "Nigeria");
            countryDict.Add("NU", "Niue");
            countryDict.Add("NF", "Norfolk Island");
            countryDict.Add("MP", "Northern Mariana Islands");
            countryDict.Add("NO", "Norway");
            countryDict.Add("OM", "Oman");
            countryDict.Add("PK", "Pakistan");
            countryDict.Add("PW", "Palau");
            countryDict.Add("PS", "Palestine, State of");
            countryDict.Add("PA", "Panama");
            countryDict.Add("PG", "Papua New Guinea");
            countryDict.Add("PY", "Paraguay");
            countryDict.Add("PE", "Peru");
            countryDict.Add("PH", "Philippines");
            countryDict.Add("PN", "Pitcairn");
            countryDict.Add("PL", "Poland");
            countryDict.Add("PT", "Portugal");
            countryDict.Add("PR", "Puerto Rico");
            countryDict.Add("QA", "Qatar");
            countryDict.Add("RE", "Réunion");
            countryDict.Add("RO", "Romania");
            countryDict.Add("RU", "Russian Federation");
            countryDict.Add("RW", "Rwanda");
            countryDict.Add("BL", "Saint Barthélemy");
            countryDict.Add("SH", "Saint Helena, Ascension and Tristan da Cunha");
            countryDict.Add("KN", "Saint Kitts and Nevis");
            countryDict.Add("LC", "Saint Lucia");
            countryDict.Add("MF", "Saint Martin (French part)");
            countryDict.Add("PM", "Saint Pierre and Miquelon");
            countryDict.Add("VC", "Saint Vincent and the Grenadines");
            countryDict.Add("WS", "Samoa");
            countryDict.Add("SM", "San Marino");
            countryDict.Add("ST", "Sao Tome and Principe");
            countryDict.Add("SA", "Saudi Arabia");
            countryDict.Add("SN", "Senegal");
            countryDict.Add("RS", "Serbia");
            countryDict.Add("SC", "Seychelles");
            countryDict.Add("SL", "Sierra Leone");
            countryDict.Add("SG", "Singapore");
            countryDict.Add("SX", "Sint Maarten (Dutch part)");
            countryDict.Add("SK", "Slovakia");
            countryDict.Add("SI", "Slovenia");
            countryDict.Add("SB", "Solomon Islands");
            countryDict.Add("SO", "Somalia");
            countryDict.Add("ZA", "South Africa");
            countryDict.Add("GS", "South Georgia and the South Sandwich Islands");
            countryDict.Add("SS", "South Sudan");
            countryDict.Add("ES", "Spain");
            countryDict.Add("LK", "Sri Lanka");
            countryDict.Add("SD", "Sudan");
            countryDict.Add("SR", "Suriname");
            countryDict.Add("SJ", "Svalbard and Jan Mayen");
            countryDict.Add("SZ", "Swaziland");
            countryDict.Add("SE", "Sweden");
            countryDict.Add("CH", "Switzerland");
            countryDict.Add("SY", "Syrian Arab Republic");
            countryDict.Add("TW", "Taiwan, Province of China[a]");
            countryDict.Add("TJ", "Tajikistan");
            countryDict.Add("TZ", "Tanzania, United Republic of");
            countryDict.Add("TH", "Thailand");
            countryDict.Add("TL", "Timor-Leste");
            countryDict.Add("TG", "Togo");
            countryDict.Add("TK", "Tokelau");
            countryDict.Add("TO", "Tonga");
            countryDict.Add("TT", "Trinidad and Tobago");
            countryDict.Add("TN", "Tunisia");
            countryDict.Add("TR", "Turkey");
            countryDict.Add("TM", "Turkmenistan");
            countryDict.Add("TC", "Turks and Caicos Islands");
            countryDict.Add("TV", "Tuvalu");
            countryDict.Add("UG", "Uganda");
            countryDict.Add("UA", "Ukraine");
            countryDict.Add("AE", "United Arab Emirates");
            countryDict.Add("GB", "United Kingdom of Great Britain and Northern Ireland");
            countryDict.Add("US", "United States of America");
            countryDict.Add("UM", "United States Minor Outlying Islands");
            countryDict.Add("UY", "Uruguay");
            countryDict.Add("UZ", "Uzbekistan");
            countryDict.Add("VU", "Vanuatu");
            countryDict.Add("VE", "Venezuela (Bolivarian Republic of)");
            countryDict.Add("VN", "Viet Nam");
            countryDict.Add("VG", "Virgin Islands (British)");
            countryDict.Add("VI", "Virgin Islands (U.S.)");
            countryDict.Add("WF", "Wallis and Futuna");
            countryDict.Add("EH", "Western Sahara");
            countryDict.Add("YE", "Yemen");
            countryDict.Add("ZM", "Zambia");
            countryDict.Add("ZW", "Zimbabwe");
            cbCountry.DataSource = new BindingSource(countryDict,null);
            cbCountry.ValueMember = "Key";
            cbCountry.DisplayMember = "Value";
            cbCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            cbCountry.AutoCompleteMode = AutoCompleteMode.Append;
            cbCountry.AutoCompleteSource = AutoCompleteSource.ListItems;
            WriteToHtmlControl(string.Empty);
        }


        private void btnValidate_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(cbCountry.SelectedValue + " - " + cbCountry.Text);
            Control.CheckForIllegalCrossThreadCalls = false;
            //Task.Run(()=>ValidatePhoneAsync());
            try { 
            btnValidate.Text = "Processing...";
             Task.Run(() => ValidatePhoneHtmlAsync()).Wait();
                btnValidate.Text = "Validate";
            }catch(Exception ex)
            {
                MessageBox.Show("Exception Occured:" + ex.StackTrace);
                btnValidate.Text = "Validate";
            }



        }

        public string GetTextFromNode(XmlDocument doc, string searchExpXPath)
        {
            if (doc.SelectSingleNode(searchExpXPath) != null)
                return doc.SelectSingleNode(searchExpXPath).InnerText;
            else
                return string.Empty;

        }

        public void PhoneNumberEnrichInformatica(string phoneNumber)
        {
            string result = string.Empty;
            string url = $"http://ws.strikeiron.com/StrikeIron/GlobalPhoneVal15/GlobalPhoneValidation15/ValidateNumber?LicenseInfo.RegisteredUser.UserID=2A52D91D3CE31F9ABAFF&LicenseInfo.RegisteredUser.Password=&ValidateNumber.PhoneNumber={phoneNumber}";

            System.Net.WebRequest request = System.Net.WebRequest.Create(url);
            request.Method = "GET";
            WebResponse response = request.GetResponse();           
            Stream dataStream = response.GetResponseStream();
            XmlTextReader xmlReader = new XmlTextReader(dataStream);
            xmlReader.Namespaces = false;
            XmlDocument doc = new XmlDocument();
            doc.Load(xmlReader);
            //doc.LoadXml(responseFromServer);
            string strInformaticaReqeustStatus = GetTextFromNode(doc,"//ServiceStatus/StatusDescription");
            string phoneNumberStatus = GetTextFromNode(doc,"//ItemStatus/StatusDescription");
            string strNumber = GetTextFromNode(doc,"//Listing/Number");
            string strCountryCode = GetTextFromNode(doc,"//Listing/CountryCode");
            string strInternationalPrefix = GetTextFromNode(doc,"//Listing/InternationalPrefix");
            string strNationalPrefix = GetTextFromNode(doc,"//Listing/NationalPrefix");
            string strCellPrefix = GetTextFromNode(doc,"//Listing/CellPrefix");
            string strNDC = GetTextFromNode(doc,"//Listing/NDC");
            string strSN_From = GetTextFromNode(doc,"//Listing/SN_From");
            string strSN_To = GetTextFromNode(doc,"//Listing/SN_To");
            string strUses_NDC = GetTextFromNode(doc,"//Listing/Uses_NDC");
            string strNumber_Type = GetTextFromNode(doc,"//Listing/Number_Type");
            string strCarrierName = GetTextFromNode(doc,"//Listing/CarrierName");
            string strLanguage = GetTextFromNode(doc,"//Listing/Language");
            string strCountry = GetTextFromNode(doc,"//Listing/Country");
            string strISO = GetTextFromNode(doc,"//Listing/ISO");
            string strRegionCode = GetTextFromNode(doc,"//Listing/RegionCode");
            string strRegionName = GetTextFromNode(doc,"//Listing/RegionName");
            string strCity = GetTextFromNode(doc,"//Listing/City");
            string strTimeZone = GetTextFromNode(doc,"//Listing/TimeZone");
            string strUTC = GetTextFromNode(doc,"//Listing/UTC");
            string strDST = GetTextFromNode(doc,"//Listing/DST");
            string strLatitude = GetTextFromNode(doc,"//Listing/Latitude");
            string strLongitude = GetTextFromNode(doc,"//Listing/Longitude");
            string strErrorCode = GetTextFromNode(doc,"//Listing/ErrorCode");

            response.Close();
            //txtValidationArea.AppendText(responseFromServer);
        }
        public void PhoneNumberEnrichInformaticaHtml(StringBuilder htmlContent,string phoneNumber)
        {
            string result = string.Empty;
            string url = $"http://ws.strikeiron.com/StrikeIron/GlobalPhoneVal15/GlobalPhoneValidation15/ValidateNumber?LicenseInfo.RegisteredUser.UserID=<REDACTED>&LicenseInfo.RegisteredUser.Password=&ValidateNumber.PhoneNumber={phoneNumber.Replace("+","")}";

            System.Net.WebRequest request = System.Net.WebRequest.Create(url);
            request.Method = "GET";
            WebResponse response = request.GetResponse();
            Stream dataStream = response.GetResponseStream();
            XmlTextReader xmlReader = new XmlTextReader(dataStream);
            xmlReader.Namespaces = false;
            XmlDocument doc = new XmlDocument();
            doc.Load(xmlReader);
            //doc.LoadXml(responseFromServer);
            string strInformaticaReqeustStatus = GetTextFromNode(doc, "//ServiceStatus/StatusDescription");
            string phoneNumberStatus = GetTextFromNode(doc, "//ItemStatus/StatusDescription");
            string strNumber = GetTextFromNode(doc, "//Listing/Number");
            string strCountryCode = GetTextFromNode(doc, "//Listing/CountryCode");
            string strInternationalPrefix = GetTextFromNode(doc, "//Listing/InternationalPrefix");
            string strNationalPrefix = GetTextFromNode(doc, "//Listing/NationalPrefix");
            string strCellPrefix = GetTextFromNode(doc, "//Listing/CellPrefix");
            string strNDC = GetTextFromNode(doc, "//Listing/NDC");
            string strSN_From = GetTextFromNode(doc, "//Listing/SN_From");
            string strSN_To = GetTextFromNode(doc, "//Listing/SN_To");
            string strUses_NDC = GetTextFromNode(doc, "//Listing/Uses_NDC");
            string strNumber_Type = GetTextFromNode(doc, "//Listing/Number_Type");
            string strCarrierName = GetTextFromNode(doc, "//Listing/CarrierName");
            string strLanguage = GetTextFromNode(doc, "//Listing/Language");
            string strCountry = GetTextFromNode(doc, "//Listing/Country");
            string strISO = GetTextFromNode(doc, "//Listing/ISO");
            string strRegionCode = GetTextFromNode(doc, "//Listing/RegionCode");
            string strRegionName = GetTextFromNode(doc, "//Listing/RegionName");
            string strCity = GetTextFromNode(doc, "//Listing/City");
            string strTimeZone = GetTextFromNode(doc, "//Listing/TimeZone");
            string strUTC = GetTextFromNode(doc, "//Listing/UTC");
            string strDST = GetTextFromNode(doc, "//Listing/DST");
            string strLatitude = GetTextFromNode(doc, "//Listing/Latitude");
            string strLongitude = GetTextFromNode(doc, "//Listing/Longitude");
            string strErrorCode = GetTextFromNode(doc, "//Listing/ErrorCode");
            htmlContent.Append("<H3><CENTER>INFORMATICA ENRICHMENT<CENTER></H3>");
            htmlContent.Append("<hr/>");
            htmlContent.Append($"<table border=0 align=right><tr><td><span style='font-family:verdana;font-weight:bold;font-color:red'>Remaining API Hits :{GetTextFromNode(doc, "//RemainingHits")}</span></td></tr></table>");

            htmlContent.Append("<table border=\"0\" cellpadding=\"1\" cellspacing=\"0\" style=\"font-family:verdana;font-size:12px;border-colapse:none\" width=\"100%\">");
            htmlContent.Append($"<tr><td>Number</td><td>{strNumber}</td></tr>");
            htmlContent.Append($"<tr><td>Phone Number Status</td><td>{phoneNumberStatus}</td></tr>");

           
            if (!phoneNumberStatus.Contains("Invalid"))
            {
                htmlContent.Append($"<tr><td>CountryCode</td><td>{strCountryCode}</td></tr>");
                htmlContent.Append($"<tr><td>InternationalPrefix</td><td>{strInternationalPrefix}</td></tr>");
                htmlContent.Append($"<tr><td>NationalPrefix</td><td>{strNationalPrefix}</td></tr>");
                htmlContent.Append($"<tr><td>CellPrefix</td><td>{strCellPrefix}</td></tr>");

                htmlContent.Append($"<tr><td>NDC</td><td>{strNDC}</td></tr>");
                htmlContent.Append($"<tr><td>SN_From</td><td>{strSN_From}</td></tr>");
                htmlContent.Append($"<tr><td>SN_To</td><td>{strSN_To}</td></tr>");
                htmlContent.Append($"<tr><td>Uses_NDC</td><td>{strUses_NDC}</td></tr>");

                htmlContent.Append($"<tr><td>Number_Type</td><td>{strNumber_Type}</td></tr>");
                htmlContent.Append($"<tr><td>CarrierName</td><td>{strCarrierName}</td></tr>");
                htmlContent.Append($"<tr><td>Language</td><td>{strLanguage}</td></tr>");
                htmlContent.Append($"<tr><td>Country</td><td>{strCountry}</td></tr>");

                htmlContent.Append($"<tr><td>ISO</td><td>{strISO}</td></tr>");
                htmlContent.Append($"<tr><td>RegionCode</td><td>{strRegionCode}</td></tr>");
                htmlContent.Append($"<tr><td>RegionName</td><td>{strRegionName}</td></tr>");
                htmlContent.Append($"<tr><td>City</td><td>{strCity}</td></tr>");

                htmlContent.Append($"<tr><td>TimeZone</td><td>{strTimeZone}</td></tr>");
                htmlContent.Append($"<tr><td>UTC</td><td>{strUTC}</td></tr>");
                htmlContent.Append($"<tr><td>DST</td><td>{strDST}</td></tr>");
                htmlContent.Append($"<tr><td>Latitude</td><td>{strLatitude}</td></tr>");

                htmlContent.Append($"<tr><td>TimeZone</td><td>{strTimeZone}</td></tr>");
                htmlContent.Append($"<tr><td>UTC</td><td>{strUTC}</td></tr>");
                htmlContent.Append($"<tr><td>DST</td><td>{strDST}</td></tr>");
                htmlContent.Append($"<tr><td>Latitude</td><td>{strLatitude}</td></tr>");

                htmlContent.Append($"<tr><td>Longitude</td><td>{strLongitude}</td></tr>");
                htmlContent.Append($"<tr><td>ErrorCode</td><td>{strErrorCode}</td></tr>");
               
            }
            htmlContent.Append("</table>");
            WriteToHtmlControl(htmlContent.ToString());
            response.Close();
            btnValidate.Text = "Validate";
        }

        private void WriteToHtmlControl(string htmlContent)
        {
            //bgWorker.RunWorkerAsync(htmlContent);
            wbBrowser.Navigate("about:blank");
            wbBrowser.DocumentText = htmlContent;
            wbBrowser.Refresh();
            Application.DoEvents();
            
        }

        public async void ValidatePhoneAsync()
        {
            string countryCode = cbCountry.SelectedValue.ToString();
            string typedPhoneNumber = txtPhoneInput.Text;
            if (typedPhoneNumber.Length >= 1 && countryCode.Length >= 1)
            {
                PhoneNumberUtil phoneUtil = PhoneNumberUtil.GetInstance();
                try
                {
                    PhoneNumber phonenumberObject=null;
                    await Task.Run(() => {
                        phonenumberObject= phoneUtil.Parse(typedPhoneNumber, countryCode); 

                        PhoneNumberOfflineGeocoder geocoder = PhoneNumberOfflineGeocoder.GetInstance();
                        if (phoneUtil.IsValidNumber(phonenumberObject))
                        {
                            PhoneNumberEnrichInformatica(phoneUtil.Format(phonenumberObject, PhoneNumberFormat.E164));
                        }
                    });

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Exception Occured :" + ex.StackTrace);
                    btnValidate.Text = "Validate";
                }
            }
        }

        public async void ValidatePhoneHtmlAsync()
        {
            wbBrowser.DocumentText = "<html></html>";//Directly setting HTML content for first time doesnt work.
            StringBuilder htmlContent = new StringBuilder("<H3><CENTER>OPEN SOURCE PHONE VALIDATION<CENTER></H3>"); 
            htmlContent.Append("<hr/>");

            string countryCode = cbCountry.SelectedValue.ToString();
            string typedPhoneNumber = txtPhoneInput.Text;
            if (typedPhoneNumber.Length >= 1 && countryCode.Length >= 1)
            {
                PhoneNumberUtil phoneUtil = PhoneNumberUtil.GetInstance();
                try
                {
                    PhoneNumber phonenumberObject = null;
                    //await Task.Run(() => {
                        phonenumberObject = phoneUtil.Parse(typedPhoneNumber, countryCode);
                    string regionCoundFromPhoneNumber = phoneUtil.GetRegionCodeForCountryCode(phonenumberObject.CountryCode);
                        htmlContent.Append("<table border=\"0\" cellpadding=\"1\" cellspacing=\"0\" style=\"font-family:verdana;font-size:12px;border-colapse:none\" width=\"100%\">");
                        htmlContent.Append($"<tr><td>Typed Phone Number</td><td>{typedPhoneNumber}</td></tr>");
                        htmlContent.Append($"<tr><td>Is Valid Phone Number</td><td>{regionCoundFromPhoneNumber == countryCode && phoneUtil.IsValidNumber(phonenumberObject)}</td></tr>");
                        PhoneNumberOfflineGeocoder geocoder = PhoneNumberOfflineGeocoder.GetInstance();
                    if (regionCoundFromPhoneNumber == countryCode && phoneUtil.IsValidNumber(phonenumberObject))
                    {
                        htmlContent.Append($"<tr><td>Country Code</td><td>{Convert.ToString(phonenumberObject.CountryCode)}</td></tr>");
                        htmlContent.Append($"<tr><td>E164 Format </td><td>{phoneUtil.Format(phonenumberObject, PhoneNumberFormat.E164) }</td></tr>");
                        htmlContent.Append($"<tr><td>Intenational Format</td><td>{phoneUtil.Format(phonenumberObject, PhoneNumberFormat.INTERNATIONAL)}</td></tr>");
                        htmlContent.Append($"<tr><td>RFC Format </td><td>{phoneUtil.Format(phonenumberObject, PhoneNumberFormat.RFC3966) }</td></tr>");
                        htmlContent.Append($"<tr><td>National Format</td><td>{phoneUtil.Format(phonenumberObject, PhoneNumberFormat.NATIONAL)}</td></tr>");
                        htmlContent.Append($"<tr><td>Has CountryCode </td><td>{ Convert.ToString(phonenumberObject.HasCountryCode)}</td></tr>");
                        htmlContent.Append($"<tr><td>Phone Number Type </td><td>{ phoneUtil.GetNumberType(phonenumberObject)}</td></tr>");
                        htmlContent.Append($"<tr><td>Phone Location </td><td>{geocoder.GetDescriptionForNumber(phonenumberObject, Locale.ENGLISH)}</td></tr>");
                        htmlContent.Append("</table>");
                        WriteToHtmlControl(htmlContent.ToString());
                        //PhoneNumberEnrichInformaticaHtml(htmlContent, phoneUtil.Format(phonenumberObject, PhoneNumberFormat.E164));
                    }
                    else
                    {
                        htmlContent.Append("</table>");
                        WriteToHtmlControl(htmlContent.ToString());
                    }
                }
                catch (NumberParseException ex)
                {
                    MessageBox.Show("Invalid Phone Number");
                }
            }
        }

        private void cbCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cbCountry_SelectionChangeCommitted(sender, e);
        }

        private void bgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            wbBrowser.Navigate("about:blank");
            
           
            HtmlDocument hmldoc = wbBrowser.Document;
            hmldoc.Write(string.Empty);
            wbBrowser.DocumentText = e.Argument.ToString();
        }
    }
}
