//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1008
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AutoBrowser {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class TemplateFile {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal TemplateFile() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("AutoBrowser.TemplateFile", typeof(TemplateFile).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
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
        ///   Looks up a localized string similar to public {__DATATYPE__} {__COLUMN__NAME__}
        ///        {
        ///            get;
        ///            set;
        ///        }
        ///.
        /// </summary>
        internal static string CLASS_PROPERTY {
            get {
                return ResourceManager.GetString("CLASS_PROPERTY", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to using System;
        ///using System.Collections.Generic;
        ///using System.Linq;
        ///using System.Web;
        ///
        ///namespace DMS.HS2Properties
        ///{
        ///    public class {__CLASS__NAME__}
        ///    {
        ///        {__CLASS__PROPERTY__}
        ///    }
        ///}.
        /// </summary>
        internal static string CLASS_TEMPLATE {
            get {
                return ResourceManager.GetString("CLASS_TEMPLATE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to if (Protect.ToString(dr.Rows[0][&quot;{__COLUMN__NAME__}&quot;].ToString()) != string.Empty) { {__INFO__DATA__} }.
        /// </summary>
        internal static string DATABIND_INFO {
            get {
                return ResourceManager.GetString("DATABIND_INFO", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to public int {__CLASS__NAME__}Add({__CLASS__NAME__} p{__CLASS__NAME__})
        ///{
        ///	int result = -1;
        ///
        ///	List&lt;SqlParameter&gt; sqlParam = new List&lt;SqlParameter&gt;();
        ///	
        ///	{__SQL__PARAMETER__}
        ///	result = DBUtils.ExecSP(textBox2.Text, textBoxStoreInsert.Text, sqlParam);
        ///
        ///	// if has primary key 
        ///	{__PRIMARY_KEY__}
        ///	return result;
        ///}.
        /// </summary>
        internal static string INSERT_FUNCTION {
            get {
                return ResourceManager.GetString("INSERT_FUNCTION", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to int idOutputParam = outputIdParam.Value as int? ?? -1;
        ///	if (idOutputParam &gt; 0)
        ///	{
        ///		result = idOutputParam;
        ///	}.
        /// </summary>
        internal static string OUT_PRIMARY_KEY {
            get {
                return ResourceManager.GetString("OUT_PRIMARY_KEY", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SqlParameter outputIdParam = new SqlParameter(&quot;@{__COLUMN__NAME__}&quot;, SqlDbType.Int)
        ///	{ 
        ///		Direction = ParameterDirection.Output 
        ///	};.
        /// </summary>
        internal static string PRIMARY_KEY {
            get {
                return ResourceManager.GetString("PRIMARY_KEY", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to sqlParam.Add(new SqlParameter(&quot;@{__COLUMN__NAME__}&quot;, p{__CLASS__NAME__}.{__COLUMN__NAME__}));.
        /// </summary>
        internal static string SQL_PARAMETER {
            get {
                return ResourceManager.GetString("SQL_PARAMETER", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to if (Protect.ToString(dr.Rows[0][&quot;{0}&quot;].ToString()) != string.Empty) {{ {1} }}.
        /// </summary>
        internal static string TEST_DATA {
            get {
                return ResourceManager.GetString("TEST_DATA", resourceCulture);
            }
        }
    }
}
