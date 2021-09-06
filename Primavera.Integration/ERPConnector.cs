using Primavera.Integration.Engine;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primavera.Integration
{
    public class ERPConnector
    {
        static ERPConnector()
        {
            
        }
        public static void LoadAssemblies()
        {
            AppDomain.CurrentDomain.AssemblyResolve += new ResolveEventHandler(CurrentDomain_AssemblyResolve);
        }

        /*public static void Configure(ConfigEmpresa config)
        {
            if (Instance != null)
            {
                //Instance.ErpInstance.Dispose();

                Instance = null;
            }
            Instance = new ERPConnector();
            try
            {
                
 
            }
            catch (Exception)
            {

                throw;
            }
           
        }*/

        static System.Reflection.Assembly CurrentDomain_AssemblyResolve(object sender, ResolveEventArgs args)
        {
            string assemblyFullName;
            System.Reflection.AssemblyName assemblyName;

            const string PRIMAVERA_FOLDER = "PRIMAVERA\\SG100\\Apl";

            assemblyName = new System.Reflection.AssemblyName(args.Name);
            assemblyFullName = System.IO.Path.Combine(System.IO.Path.Combine(System.Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86), PRIMAVERA_FOLDER), assemblyName.Name + ".dll");
            
            if (File.Exists(assemblyFullName))
            {
                byte[] AssmBytes = File.ReadAllBytes(assemblyFullName);
                return System.Reflection.Assembly.LoadFrom(assemblyFullName);
            }
            else
                return null;
        }


        /*public static PriEngine GetErpInstance()
        {
            return PriEngine.CreatContext("DEV", "DevTeam", "Aa@123456");
        }*/
    }
}
