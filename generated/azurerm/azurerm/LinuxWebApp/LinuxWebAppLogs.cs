using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.LinuxWebApp
{
    [JsiiByValue(fqn: "azurerm.linuxWebApp.LinuxWebAppLogs")]
    public class LinuxWebAppLogs : azurerm.LinuxWebApp.ILinuxWebAppLogs
    {
        /// <summary>application_logs block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app#application_logs LinuxWebApp#application_logs}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "applicationLogs", typeJson: "{\"fqn\":\"azurerm.linuxWebApp.LinuxWebAppLogsApplicationLogs\"}", isOptional: true)]
        public azurerm.LinuxWebApp.ILinuxWebAppLogsApplicationLogs? ApplicationLogs
        {
            get;
            set;
        }

        private object? _detailedErrorMessages;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app#detailed_error_messages LinuxWebApp#detailed_error_messages}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "detailedErrorMessages", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? DetailedErrorMessages
        {
            get => _detailedErrorMessages;
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
                _detailedErrorMessages = value;
            }
        }

        private object? _failedRequestTracing;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app#failed_request_tracing LinuxWebApp#failed_request_tracing}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "failedRequestTracing", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? FailedRequestTracing
        {
            get => _failedRequestTracing;
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
                _failedRequestTracing = value;
            }
        }

        /// <summary>http_logs block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app#http_logs LinuxWebApp#http_logs}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "httpLogs", typeJson: "{\"fqn\":\"azurerm.linuxWebApp.LinuxWebAppLogsHttpLogs\"}", isOptional: true)]
        public azurerm.LinuxWebApp.ILinuxWebAppLogsHttpLogs? HttpLogs
        {
            get;
            set;
        }
    }
}
