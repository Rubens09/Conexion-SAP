using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;
using static API_SAP.Controllers.HomeController;
using System.Net;
using System.IO;
using Microsoft.AspNetCore.Http;
using System.Security.Policy;
using Microsoft.AspNetCore.DataProtection.KeyManagement;
using System.Reflection;
using Microsoft.AspNetCore.Mvc;
using System.Collections;

namespace Api_SAG.Models
{
    public class Metodos
    {
        public static string Conexion_SAP()
        {
            string msgError = "";
            int retVal = -1;
            SAPbobsCOM.Company oCompany = new SAPbobsCOM.Company();
            oCompany.Server = @"SERVIDORSAP";
            oCompany.UserName = "Sistm001";
            oCompany.Password = "TransMed1";
            oCompany.LicenseServer = "192.168.0.6";
            oCompany.DbUserName = "sa";
            oCompany.DbPassword = "TransMed12";
            oCompany.CompanyDB = "zzzzzMEDRANOCENTROAzzzzz";
            oCompany.DbServerType = SAPbobsCOM.BoDataServerTypes.dst_MSSQL2016;

            retVal = oCompany.Connect();
            if (retVal == 0)
            {
                Console.WriteLine("Conexion exitosa");
                return "1";
            }
            else
            {
                Console.WriteLine("Error de conexion");
                oCompany.GetLastError(out retVal, out msgError);
                Console.WriteLine(msgError);
                return "0";
            }
        }
    }
}