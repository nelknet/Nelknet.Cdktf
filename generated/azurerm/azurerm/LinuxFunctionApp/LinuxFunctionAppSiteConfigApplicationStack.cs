using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.LinuxFunctionApp
{
    [JsiiByValue(fqn: "azurerm.linuxFunctionApp.LinuxFunctionAppSiteConfigApplicationStack")]
    public class LinuxFunctionAppSiteConfigApplicationStack : azurerm.LinuxFunctionApp.ILinuxFunctionAppSiteConfigApplicationStack
    {
        private object? _docker;

        /// <summary>docker block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app#docker LinuxFunctionApp#docker}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "docker", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.linuxFunctionApp.LinuxFunctionAppSiteConfigApplicationStackDocker\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Docker
        {
            get => _docker;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.LinuxFunctionApp.ILinuxFunctionAppSiteConfigApplicationStackDocker[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.LinuxFunctionApp.ILinuxFunctionAppSiteConfigApplicationStackDocker).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _docker = value;
            }
        }

        /// <summary>The version of .Net. Possible values are `3.1`, `6.0` and `7.0`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app#dotnet_version LinuxFunctionApp#dotnet_version}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dotnetVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DotnetVersion
        {
            get;
            set;
        }

        /// <summary>The version of Java to use. Possible values are `8`, `11`, and `17`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app#java_version LinuxFunctionApp#java_version}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "javaVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? JavaVersion
        {
            get;
            set;
        }

        /// <summary>The version of Node to use. Possible values include `12`, `14`, `16`, `18` and `20`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app#node_version LinuxFunctionApp#node_version}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "nodeVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? NodeVersion
        {
            get;
            set;
        }

        /// <summary>The version of PowerShell Core to use. Possibles values are `7`, `7.2`, and `7.4`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app#powershell_core_version LinuxFunctionApp#powershell_core_version}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "powershellCoreVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PowershellCoreVersion
        {
            get;
            set;
        }

        /// <summary>The version of Python to use. Possible values include `3.12`, `3.11`, `3.10`, `3.9`, `3.8`, and `3.7`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app#python_version LinuxFunctionApp#python_version}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "pythonVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PythonVersion
        {
            get;
            set;
        }

        private object? _useCustomRuntime;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app#use_custom_runtime LinuxFunctionApp#use_custom_runtime}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "useCustomRuntime", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? UseCustomRuntime
        {
            get => _useCustomRuntime;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _useCustomRuntime = value;
            }
        }

        private object? _useDotnetIsolatedRuntime;

        /// <summary>Should the DotNet process use an isolated runtime. Defaults to `false`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app#use_dotnet_isolated_runtime LinuxFunctionApp#use_dotnet_isolated_runtime}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "useDotnetIsolatedRuntime", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? UseDotnetIsolatedRuntime
        {
            get => _useDotnetIsolatedRuntime;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _useDotnetIsolatedRuntime = value;
            }
        }
    }
}
