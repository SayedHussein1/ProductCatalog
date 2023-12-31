﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Reflection;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.Threading;
using System.Web;

using System.Linq;
//using System.Web.Hosting;
using System.IO;
using System.Net;
using System.Text;
using App.Application.Model;
using App.Application.Services;
using Microsoft.AspNetCore.Http;
using App.Application.Caching;
using App.Application.Interfaces;
using App.Application.Framwork;
using Microsoft.AspNetCore.Localization;
using AutoMapper;

namespace App.Application.Framwork
{
    /// <summary>
    /// Represents a common helper
    /// </summary>
    public partial class CommonHelper
    {
        private static LanguageModel _cachedLanguage;
      //  public static int LanguageId { get; set; } = 1;
        public static LanguageModel WorkingLanguage
        {
            get
            {
                var _httpContextAccessor = EngineContext.Current.Resolve<IHttpContextAccessor>();
                var _cacheManager = EngineContext.Current.Resolve<ICacheManager>();

                var CacheKey = string.Format(ModelCacheEventConsumer.Current_Customer_Language_KEY, _httpContextAccessor.HttpContext.User.GetId());

                _cachedLanguage = _cacheManager.Get<LanguageModel>(CacheKey);

                if (_cachedLanguage != null)
                    return _cachedLanguage;

                LanguageModel detectedLanguage = null;

                var _languageService = EngineContext.Current.Resolve<ILanguageSevices>();

                var allLanguage = _languageService.GetListLanguage().Result;
            

                if (detectedLanguage == null)
                    detectedLanguage = allLanguage.OrderBy(s => s.DisplayOrder).FirstOrDefault();

                if (detectedLanguage == null)
                    detectedLanguage = GetLanguageFromRequest();

                _cacheManager.Remove(CacheKey);

                _cachedLanguage = _cacheManager.Get(CacheKey, () =>
                {
                    return detectedLanguage;
                });

                return _cachedLanguage;
            }
            set
            {
                var _httpContextAccessor = EngineContext.Current.Resolve<IHttpContextAccessor>();
                var _languageService = EngineContext.Current.Resolve<ILanguageSevices>();
                var _usersService = EngineContext.Current.Resolve<IUsersService>();
                var _cacheManager = EngineContext.Current.Resolve<ICacheManager>();

                var languageId = value?.Id ?? 0;

                var CacheKey = string.Format(ModelCacheEventConsumer.Current_Customer_Language_KEY, _httpContextAccessor.HttpContext.User.GetId());

                _cacheManager.Remove(CacheKey);

                _cachedLanguage = _cacheManager.Get(CacheKey, () =>
                {
                    var currentLanguage = _languageService.GetById(languageId).Result;

                    return currentLanguage;
                });
            }
        }
        protected static LanguageModel GetLanguageFromRequest()
        {
            var _httpContextAccessor = EngineContext.Current.Resolve<IHttpContextAccessor>();

            if (_httpContextAccessor.HttpContext?.Request == null)
                return null;

            var _languageService = EngineContext.Current.Resolve<ILanguageSevices>();
            var _mapper = EngineContext.Current.Resolve<IMapper>();

            //get request culture
            var requestCulture = _httpContextAccessor.HttpContext.Features.Get<IRequestCultureFeature>()?.RequestCulture;
            if (requestCulture == null)
                return null;

            //try to get language by culture name
            var requestLanguage = _languageService.GetAllLanguage().Result.FirstOrDefault(language =>
                language.LanguageCulture.Equals(requestCulture.Culture.Name, StringComparison.InvariantCultureIgnoreCase));

            //check language availability
            if (requestLanguage == null || !requestLanguage.IsPublish)
                return null;

            var model = _mapper.Map<LanguageModel>(requestLanguage);

            return model;
        }
        /// <summary>
        /// Ensures the subscriber email or throw.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <returns></returns>
        public static string EnsureSubscriberEmailOrThrow(string email)
        {
            string output = EnsureNotNull(email);
            output = output.Trim();
            output = EnsureMaximumLength(output, 255);

            if (!IsValidEmail(output))
            {
                throw new Exception("Email is not valid.");
            }

            return output;
        }

        /// <summary>
        /// Verifies that a string is in valid e-mail format
        /// </summary>
        /// <param name="email">Email to verify</param>
        /// <returns>true if the string is a valid e-mail address and false if it's not</returns>
        public static bool IsValidEmail(string email)
        {
            if (String.IsNullOrEmpty(email))
                return false;

            email = email.Trim();
            var result = Regex.IsMatch(email, "^(?:[\\w\\!\\#\\$\\%\\&\\'\\*\\+\\-\\/\\=\\?\\^\\`\\{\\|\\}\\~]+\\.)*[\\w\\!\\#\\$\\%\\&\\'\\*\\+\\-\\/\\=\\?\\^\\`\\{\\|\\}\\~]+@(?:(?:(?:[a-zA-Z0-9](?:[a-zA-Z0-9\\-](?!\\.)){0,61}[a-zA-Z0-9]?\\.)+[a-zA-Z0-9](?:[a-zA-Z0-9\\-](?!$)){0,61}[a-zA-Z0-9]?)|(?:\\[(?:(?:[01]?\\d{1,2}|2[0-4]\\d|25[0-5])\\.){3}(?:[01]?\\d{1,2}|2[0-4]\\d|25[0-5])\\]))$", RegexOptions.IgnoreCase);
            return result;
        }

        /// <summary>
        /// Verifies that string is an valid IP-Address
        /// </summary>
        /// <param name="ipAddress">IPAddress to verify</param>
        /// <returns>true if the string is a valid IpAddress and false if it's not</returns>
        public static bool IsValidIpAddress(string ipAddress)
        {
            IPAddress ip;
            return IPAddress.TryParse(ipAddress, out ip);
        }

        /// <summary>
        /// Generate random digit code
        /// </summary>
        /// <param name="length">Length</param>
        /// <returns>Result string</returns>
        public static string GenerateRandomDigitCode(int length)
        {
            var random = new Random();
            string str = string.Empty;
            for (int i = 0; i < length; i++)
                str = String.Concat(str, random.Next(10).ToString());
            return str;
        }

        /// <summary>
        /// Returns an random interger number within a specified rage
        /// </summary>
        /// <param name="min">Minimum number</param>
        /// <param name="max">Maximum number</param>
        /// <returns>Result</returns>
        public static int GenerateRandomInteger(int min = 0, int max = int.MaxValue)
        {
            var randomNumberBuffer = new byte[10];
            new RNGCryptoServiceProvider().GetBytes(randomNumberBuffer);
            return new Random(BitConverter.ToInt32(randomNumberBuffer, 0)).Next(min, max);
        }

        /// <summary>
        /// Ensure that a string doesn't exceed maximum allowed length
        /// </summary>
        /// <param name="str">Input string</param>
        /// <param name="maxLength">Maximum length</param>
        /// <param name="postfix">A string to add to the end if the original string was shorten</param>
        /// <returns>Input string if its lengh is OK; otherwise, truncated input string</returns>
        public static string EnsureMaximumLength(string str, int maxLength, string postfix = null)
        {
            if (String.IsNullOrEmpty(str))
                return str;

            if (str.Length > maxLength)
            {
                var pLen = postfix == null ? 0 : postfix.Length;

                var result = str.Substring(0, maxLength - pLen);
                if (!String.IsNullOrEmpty(postfix))
                {
                    result += postfix;
                }
                return result;
            }

            return str;
        }

        /// <summary>
        /// Ensures that a string only contains numeric values
        /// </summary>
        /// <param name="str">Input string</param>
        /// <returns>Input string with only numeric values, empty string if input is null/empty</returns>
        public static string EnsureNumericOnly(string str)
        {
            return string.IsNullOrEmpty(str) ? string.Empty : new string(str.Where(p => char.IsDigit(p)).ToArray());
        }

        /// <summary>
        /// Ensure that a string is not null
        /// </summary>
        /// <param name="str">Input string</param>
        /// <returns>Result</returns>
        public static string EnsureNotNull(string str)
        {
            return str ?? string.Empty;
        }

        /// <summary>
        /// Indicates whether the specified strings are null or empty strings
        /// </summary>
        /// <param name="stringsToValidate">Array of strings to validate</param>
        /// <returns>Boolean</returns>
        public static bool AreNullOrEmpty(params string[] stringsToValidate)
        {
            return stringsToValidate.Any(p => string.IsNullOrEmpty(p));
        }

        /// <summary>
        /// Compare two arrasy
        /// </summary>
        /// <typeparam name="T">Type</typeparam>
        /// <param name="a1">Array 1</param>
        /// <param name="a2">Array 2</param>
        /// <returns>Result</returns>
        public static bool ArraysEqual<T>(T[] a1, T[] a2)
        {
            //also see Enumerable.SequenceEqual(a1, a2);
            if (ReferenceEquals(a1, a2))
                return true;

            if (a1 == null || a2 == null)
                return false;

            if (a1.Length != a2.Length)
                return false;

            var comparer = EqualityComparer<T>.Default;
            for (int i = 0; i < a1.Length; i++)
            {
                if (!comparer.Equals(a1[i], a2[i])) return false;
            }
            return true;
        }

        /// <summary>
        /// Convert enum for front-end
        /// </summary>
        /// <param name="str">Input string</param>
        /// <returns>Converted string</returns>
        public static string ConvertEnum(string str)
        {
            if (string.IsNullOrEmpty(str)) return string.Empty;
            string result = string.Empty;
            foreach (var c in str)
                if (c.ToString() != c.ToString().ToLower())
                    result += " " + c.ToString();
                else
                    result += c.ToString();
            return result;
        }

        /// <summary>
        /// Set Telerik (Kendo UI) culture
        /// </summary>
        public static void SetTelerikCulture()
        {
            //little hack here
            //always set culture to 'en-US' (Kendo UI has a bug related to editing decimal values in other cultures). Like currently it's done for admin area in Global.asax.cs

            var culture = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentCulture = culture;
            Thread.CurrentThread.CurrentUICulture = culture;
        }

        /// <summary>
        /// Get difference in years
        /// </summary>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <returns></returns>
        public static int GetDifferenceInYears(DateTime startDate, DateTime endDate)
        {
            //source: http://stackoverflow.com/questions/9/how-do-i-calculate-someones-age-in-c
            //this assumes you are looking for the western idea of age and not using East Asian reckoning.
            int age = endDate.Year - startDate.Year;
            if (startDate > endDate.AddYears(-age))
                age--;
            return age;
        }

        /// <summary>
        /// Maps a virtual path to a physical disk path.
        /// </summary>
        /// <param name="path">The path to map. E.g. "~/bin"</param>
        /// <returns>The physical path. E.g. "c:\inetpub\wwwroot\bin"</returns>
        /// 

        public static string ExtractVideoIdFromUri(string url)
        {
            if (url != null)
            {


                Uri uri = new Uri(url);
                string YoutubeLinkRegex = "(?:.+?)?(?:\\/v\\/|watch\\/|\\?v=|\\&v=|youtu\\.be\\/|\\/v=|^youtu\\.be\\/)([a-zA-Z0-9_-]{11})+";
                Regex regexExtractId = new Regex(YoutubeLinkRegex, RegexOptions.Compiled);
                string[] validAuthorities = { "youtube.com", "www.youtube.com", "youtu.be", "www.youtu.be" };

                try
                {
                    string authority = new UriBuilder(uri).Uri.Authority.ToLower();

                    //check if the url is a youtube url
                    if (validAuthorities.Contains(authority))
                    {
                        //and extract the id
                        var regRes = regexExtractId.Match(uri.ToString());
                        if (regRes.Success)
                        {
                            return regRes.Groups[1].Value;
                        }
                    }
                }
                catch { }
            }

            return null;
        }
    }
}
