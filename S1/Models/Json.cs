using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Globalization;
using System.Web.Security;
using System.Text.RegularExpressions;
using System.IO;
using System.Text;
using System.Runtime.Serialization.Json;


namespace S1.Models
{
    public class Auta
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public string Nadwozie { get; set; }
        public int Rok_Produkcji { get; set; }
        public int Pojemnosc_Silnika { get; set; }
        public string Paliwo { get; set; }
        public int Cena { get; set; }
    }

    public class JsonHelper
    {

        public static string JsonSerializer<T>(T t)
        {
            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(T));
            MemoryStream ms = new MemoryStream();
            ser.WriteObject(ms, t);
            string jsonString = Encoding.UTF8.GetString(ms.ToArray());
            ms.Close();
            return jsonString;
        }

        public static T JsonDeserialize<T>(string jsonString)
        {
            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(T));
            MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(jsonString));
            T obj = (T)ser.ReadObject(ms);
            return obj;
        }
    }
}