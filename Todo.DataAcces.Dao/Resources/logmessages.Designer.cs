﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Todo.DataAcces.Dao.Resources {
    using System;
    
    
    /// <summary>
    ///   Clase de recurso fuertemente tipado, para buscar cadenas traducidas, etc.
    /// </summary>
    // StronglyTypedResourceBuilder generó automáticamente esta clase
    // a través de una herramienta como ResGen o Visual Studio.
    // Para agregar o quitar un miembro, edite el archivo .ResX y, a continuación, vuelva a ejecutar ResGen
    // con la opción /str o recompile su proyecto de VS.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class logmessages {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal logmessages() {
        }
        
        /// <summary>
        ///   Devuelve la instancia de ResourceManager almacenada en caché utilizada por esta clase.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Todo.DataAcces.Dao.Resources.logmessages", typeof(logmessages).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Reemplaza la propiedad CurrentUICulture del subproceso actual para todas las
        ///   búsquedas de recursos mediante esta clase de recurso fuertemente tipado.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Error IDbCommand: .
        /// </summary>
        internal static string errordbacommand {
            get {
                return ResourceManager.GetString("errordbacommand", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Error IDbConnection: .
        /// </summary>
        internal static string errordbaconnection {
            get {
                return ResourceManager.GetString("errordbaconnection", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Error delete dao:.
        /// </summary>
        internal static string errordeleteDao {
            get {
                return ResourceManager.GetString("errordeleteDao", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Error get all dao: .
        /// </summary>
        internal static string errorgetallDao {
            get {
                return ResourceManager.GetString("errorgetallDao", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Error insert dao: .
        /// </summary>
        internal static string errorinsertDao {
            get {
                return ResourceManager.GetString("errorinsertDao", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Error select dao:.
        /// </summary>
        internal static string errorselectDao {
            get {
                return ResourceManager.GetString("errorselectDao", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Error select dao:.
        /// </summary>
        internal static string errorupdateDao {
            get {
                return ResourceManager.GetString("errorupdateDao", resourceCulture);
            }
        }
    }
}
