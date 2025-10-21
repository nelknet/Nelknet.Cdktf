using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.LinuxFunctionAppSlot
{
    [JsiiInterface(nativeType: typeof(ILinuxFunctionAppSlotSiteConfigApplicationStack), fullyQualifiedName: "azurerm.linuxFunctionAppSlot.LinuxFunctionAppSlotSiteConfigApplicationStack")]
    public interface ILinuxFunctionAppSlotSiteConfigApplicationStack
    {
        /// <summary>docker block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app_slot#docker LinuxFunctionAppSlot#docker}
        /// </remarks>
        [JsiiProperty(name: "docker", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.linuxFunctionAppSlot.LinuxFunctionAppSlotSiteConfigApplicationStackDocker\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Docker
        {
            get
            {
                return null;
            }
        }

        /// <summary>The version of .Net. Possible values are `3.1`, `6.0` and `7.0`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app_slot#dotnet_version LinuxFunctionAppSlot#dotnet_version}
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

        /// <summary>The version of Java to use. Possible values are `8`, `11`, and `17`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app_slot#java_version LinuxFunctionAppSlot#java_version}
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

        /// <summary>The version of Node to use. Possible values include `12`, `14`, `16`, `18` and `20`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app_slot#node_version LinuxFunctionAppSlot#node_version}
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

        /// <summary>The version of PowerShell Core to use. Possibles values are `7`, `7.2`, and `7.4`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app_slot#powershell_core_version LinuxFunctionAppSlot#powershell_core_version}
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

        /// <summary>The version of Python to use. Possible values include `3.12`, `3.11`, `3.10`, `3.9`, `3.8`, and `3.7`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app_slot#python_version LinuxFunctionAppSlot#python_version}
        /// </remarks>
        [JsiiProperty(name: "pythonVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PythonVersion
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app_slot#use_custom_runtime LinuxFunctionAppSlot#use_custom_runtime}.</summary>
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app_slot#use_dotnet_isolated_runtime LinuxFunctionAppSlot#use_dotnet_isolated_runtime}
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

        [JsiiTypeProxy(nativeType: typeof(ILinuxFunctionAppSlotSiteConfigApplicationStack), fullyQualifiedName: "azurerm.linuxFunctionAppSlot.LinuxFunctionAppSlotSiteConfigApplicationStack")]
        internal sealed class _Proxy : DeputyBase, azurerm.LinuxFunctionAppSlot.ILinuxFunctionAppSlotSiteConfigApplicationStack
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>docker block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app_slot#docker LinuxFunctionAppSlot#docker}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "docker", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.linuxFunctionAppSlot.LinuxFunctionAppSlotSiteConfigApplicationStackDocker\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Docker
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>The version of .Net. Possible values are `3.1`, `6.0` and `7.0`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app_slot#dotnet_version LinuxFunctionAppSlot#dotnet_version}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dotnetVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DotnetVersion
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The version of Java to use. Possible values are `8`, `11`, and `17`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app_slot#java_version LinuxFunctionAppSlot#java_version}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "javaVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? JavaVersion
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The version of Node to use. Possible values include `12`, `14`, `16`, `18` and `20`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app_slot#node_version LinuxFunctionAppSlot#node_version}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "nodeVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? NodeVersion
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The version of PowerShell Core to use. Possibles values are `7`, `7.2`, and `7.4`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app_slot#powershell_core_version LinuxFunctionAppSlot#powershell_core_version}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "powershellCoreVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PowershellCoreVersion
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The version of Python to use. Possible values include `3.12`, `3.11`, `3.10`, `3.9`, `3.8`, and `3.7`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app_slot#python_version LinuxFunctionAppSlot#python_version}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "pythonVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PythonVersion
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app_slot#use_custom_runtime LinuxFunctionAppSlot#use_custom_runtime}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "useCustomRuntime", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? UseCustomRuntime
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Should the DotNet process use an isolated runtime. Defaults to `false`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app_slot#use_dotnet_isolated_runtime LinuxFunctionAppSlot#use_dotnet_isolated_runtime}
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
