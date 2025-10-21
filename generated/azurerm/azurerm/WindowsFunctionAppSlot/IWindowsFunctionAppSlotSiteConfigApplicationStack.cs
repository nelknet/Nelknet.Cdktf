using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.WindowsFunctionAppSlot
{
    [JsiiInterface(nativeType: typeof(IWindowsFunctionAppSlotSiteConfigApplicationStack), fullyQualifiedName: "azurerm.windowsFunctionAppSlot.WindowsFunctionAppSlotSiteConfigApplicationStack")]
    public interface IWindowsFunctionAppSlotSiteConfigApplicationStack
    {
        /// <summary>The version of .Net. Possible values are `v3.0`, `v4.0`, `v6.0` and `v7.0`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app_slot#dotnet_version WindowsFunctionAppSlot#dotnet_version}
        /// </remarks>
        [JsiiProperty(name: "dotnetVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DotnetVersion
        {
            get
            {
                return null;
            }
        }

        /// <summary>The version of Java to use. Possible values are `1.8`, `11` and `17`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app_slot#java_version WindowsFunctionAppSlot#java_version}
        /// </remarks>
        [JsiiProperty(name: "javaVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? JavaVersion
        {
            get
            {
                return null;
            }
        }

        /// <summary>The version of Node to use. Possible values include `12`, `14`, `16` and `18`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app_slot#node_version WindowsFunctionAppSlot#node_version}
        /// </remarks>
        [JsiiProperty(name: "nodeVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? NodeVersion
        {
            get
            {
                return null;
            }
        }

        /// <summary>The PowerShell Core version to use. Possible values are `7`, `7.2`, and `7.4`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app_slot#powershell_core_version WindowsFunctionAppSlot#powershell_core_version}
        /// </remarks>
        [JsiiProperty(name: "powershellCoreVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PowershellCoreVersion
        {
            get
            {
                return null;
            }
        }

        /// <summary>Does the Function App use a custom Application Stack?</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app_slot#use_custom_runtime WindowsFunctionAppSlot#use_custom_runtime}
        /// </remarks>
        [JsiiProperty(name: "useCustomRuntime", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? UseCustomRuntime
        {
            get
            {
                return null;
            }
        }

        /// <summary>Should the DotNet process use an isolated runtime. Defaults to `false`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app_slot#use_dotnet_isolated_runtime WindowsFunctionAppSlot#use_dotnet_isolated_runtime}
        /// </remarks>
        [JsiiProperty(name: "useDotnetIsolatedRuntime", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? UseDotnetIsolatedRuntime
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWindowsFunctionAppSlotSiteConfigApplicationStack), fullyQualifiedName: "azurerm.windowsFunctionAppSlot.WindowsFunctionAppSlotSiteConfigApplicationStack")]
        internal sealed class _Proxy : DeputyBase, azurerm.WindowsFunctionAppSlot.IWindowsFunctionAppSlotSiteConfigApplicationStack
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The version of .Net. Possible values are `v3.0`, `v4.0`, `v6.0` and `v7.0`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app_slot#dotnet_version WindowsFunctionAppSlot#dotnet_version}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dotnetVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DotnetVersion
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The version of Java to use. Possible values are `1.8`, `11` and `17`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app_slot#java_version WindowsFunctionAppSlot#java_version}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "javaVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? JavaVersion
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The version of Node to use. Possible values include `12`, `14`, `16` and `18`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app_slot#node_version WindowsFunctionAppSlot#node_version}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "nodeVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? NodeVersion
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The PowerShell Core version to use. Possible values are `7`, `7.2`, and `7.4`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app_slot#powershell_core_version WindowsFunctionAppSlot#powershell_core_version}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "powershellCoreVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PowershellCoreVersion
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Does the Function App use a custom Application Stack?</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app_slot#use_custom_runtime WindowsFunctionAppSlot#use_custom_runtime}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "useCustomRuntime", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? UseCustomRuntime
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Should the DotNet process use an isolated runtime. Defaults to `false`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app_slot#use_dotnet_isolated_runtime WindowsFunctionAppSlot#use_dotnet_isolated_runtime}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "useDotnetIsolatedRuntime", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? UseDotnetIsolatedRuntime
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
