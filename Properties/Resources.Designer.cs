﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Notepad.Properties {
    using System;
    
    
    /// <summary>
    ///   Clase de recurso fuertemente tipado, para buscar cadenas traducidas, etc.
    /// </summary>
    // StronglyTypedResourceBuilder generó automáticamente esta clase
    // a través de una herramienta como ResGen o Visual Studio.
    // Para agregar o quitar un miembro, edite el archivo .ResX y, a continuación, vuelva a ejecutar ResGen
    // con la opción /str o recompile su proyecto de VS.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Devuelve la instancia de ResourceManager almacenada en caché utilizada por esta clase.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Notepad.Properties.Resources", typeof(Resources).Assembly);
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
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a http://localhost:8084/NotepadWebService/api/.
        /// </summary>
        public static string BASE_URL {
            get {
                return ResourceManager.GetString("BASE_URL", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a basic/access/.
        /// </summary>
        public static string BASIC_AUTHENTICATION_SUFIX {
            get {
                return ResourceManager.GetString("BASIC_AUTHENTICATION_SUFIX", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a auth/.
        /// </summary>
        public static string BEARER_AUTHENTICATION_SUFIX {
            get {
                return ResourceManager.GetString("BEARER_AUTHENTICATION_SUFIX", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Cellphone number:.
        /// </summary>
        public static string CELLPHONE_NUMBER_LABEL {
            get {
                return ResourceManager.GetString("CELLPHONE_NUMBER_LABEL", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Please check the information entered and try again..
        /// </summary>
        public static string CHECK_ENTERED_INFORMATION_LABEL {
            get {
                return ResourceManager.GetString("CHECK_ENTERED_INFORMATION_LABEL", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a No field can be left empty..
        /// </summary>
        public static string EMPTY_FIELDS_LABEL {
            get {
                return ResourceManager.GetString("EMPTY_FIELDS_LABEL", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Could not deserialize the response in JSON..
        /// </summary>
        public static string JSON_DESERIALIZE_ERROR_MESSAGE {
            get {
                return ResourceManager.GetString("JSON_DESERIALIZE_ERROR_MESSAGE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Login.
        /// </summary>
        public static string LOGIN_BUTTON {
            get {
                return ResourceManager.GetString("LOGIN_BUTTON", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Login..
        /// </summary>
        public static string LOGIN_WINDOW_TITLE {
            get {
                return ResourceManager.GetString("LOGIN_WINDOW_TITLE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a No connection to the web service..
        /// </summary>
        public static string NO_WEB_SERVICE_CONNECTION_MESSAGE {
            get {
                return ResourceManager.GetString("NO_WEB_SERVICE_CONNECTION_MESSAGE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Password:.
        /// </summary>
        public static string PASSWORD_LABEL {
            get {
                return ResourceManager.GetString("PASSWORD_LABEL", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Sign up.
        /// </summary>
        public static string SIGN_UP_BUTTON {
            get {
                return ResourceManager.GetString("SIGN_UP_BUTTON", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Welcome, .
        /// </summary>
        public static string WELCOME_LABEL {
            get {
                return ResourceManager.GetString("WELCOME_LABEL", resourceCulture);
            }
        }
    }
}
