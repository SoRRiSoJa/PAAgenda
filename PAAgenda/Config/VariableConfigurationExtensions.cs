using System;


namespace PAAgenda.Config
{
    public static class VariableConfigurationExtensions
    {
        public static string GetContatoAPI_URI() => GetVariable("CONTATO_API_URI");

        #region Métodos de classe
        private static string GetVariable(string variableName)
        {
         return Environment.GetEnvironmentVariable(variableName);
        }
        #endregion
    }
}
