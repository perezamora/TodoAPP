﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Todo.Common.Logic.Errors;
using Todo.Common.Logic.Logger;

namespace Todo.Common.Logic.Util
{
    public static class ConfigUtil
    {
        private static ILogger log = CreateInstanceClassLog(MethodBase.GetCurrentMethod().DeclaringType);

        static ConfigUtil() { }

        public static string GetValorVarEnvironment(string envVar)
        {
            log.Debug(Resources.logmessage.startMethod + System.Reflection.MethodBase.GetCurrentMethod().Name);
            try
            {
                return Environment.GetEnvironmentVariable(envVar, EnvironmentVariableTarget.User);
            }
            catch (Exception e)
            {
                log.Error(e.Message + e.StackTrace);
                throw new TodoException(Resources.logmessage.errgetvar, e.InnerException);
            }

        }

        public static void SetValorVarEnvironment(string envVar, string envContent)
        {
            log.Debug(Resources.logmessage.startMethod + System.Reflection.MethodBase.GetCurrentMethod().Name);
            try
            {
                Environment.SetEnvironmentVariable(envVar, envContent, EnvironmentVariableTarget.User);
            }
            catch (Exception e)
            {
                log.Error(e.Message + e.StackTrace);
                throw new TodoException(Resources.logmessage.errsetvar, e.InnerException);
            }
        }

        public static ILogger CreateInstanceClassLog(Type typeDeclaring)
        {
            var variable = Environment.GetEnvironmentVariable(Resources.ConfigRes.typelog, EnvironmentVariableTarget.User);
            var key = System.Configuration.ConfigurationManager.AppSettings[variable];

            Type t = Assembly.GetExecutingAssembly().GetType(key);

            object[] mParam = new object[] { typeDeclaring };
            return (ILogger)Activator.CreateInstance(t, mParam);
        }
    }
}
