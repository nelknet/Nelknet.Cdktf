using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.LinuxFunctionAppSlot
{
    [JsiiByValue(fqn: "azurerm.linuxFunctionAppSlot.LinuxFunctionAppSlotSiteConfig")]
    public class LinuxFunctionAppSlotSiteConfig : azurerm.LinuxFunctionAppSlot.ILinuxFunctionAppSlotSiteConfig
    {
        private object? _alwaysOn;

        /// <summary>If this Linux Web App is Always On enabled. Defaults to `false`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app_slot#always_on LinuxFunctionAppSlot#always_on}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "alwaysOn", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? AlwaysOn
        {
            get => _alwaysOn;
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
                _alwaysOn = value;
            }
        }

        /// <summary>The URL of the API definition that describes this Linux Function App.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app_slot#api_definition_url LinuxFunctionAppSlot#api_definition_url}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "apiDefinitionUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ApiDefinitionUrl
        {
            get;
            set;
        }

        /// <summary>The ID of the API Management API for this Linux Function App.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app_slot#api_management_api_id LinuxFunctionAppSlot#api_management_api_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "apiManagementApiId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ApiManagementApiId
        {
            get;
            set;
        }

        /// <summary>The program and any arguments used to launch this app via the command line. (Example `node myapp.js`).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app_slot#app_command_line LinuxFunctionAppSlot#app_command_line}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "appCommandLine", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AppCommandLine
        {
            get;
            set;
        }

        /// <summary>The Connection String for linking the Linux Function App to Application Insights.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app_slot#application_insights_connection_string LinuxFunctionAppSlot#application_insights_connection_string}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "applicationInsightsConnectionString", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ApplicationInsightsConnectionString
        {
            get;
            set;
        }

        /// <summary>The Instrumentation Key for connecting the Linux Function App to Application Insights.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app_slot#application_insights_key LinuxFunctionAppSlot#application_insights_key}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "applicationInsightsKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ApplicationInsightsKey
        {
            get;
            set;
        }

        /// <summary>application_stack block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app_slot#application_stack LinuxFunctionAppSlot#application_stack}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "applicationStack", typeJson: "{\"fqn\":\"azurerm.linuxFunctionAppSlot.LinuxFunctionAppSlotSiteConfigApplicationStack\"}", isOptional: true)]
        public azurerm.LinuxFunctionAppSlot.ILinuxFunctionAppSlotSiteConfigApplicationStack? ApplicationStack
        {
            get;
            set;
        }

        /// <summary>The number of workers this function app can scale out to.</summary>
        /// <remarks>
        /// Only applicable to apps on the Consumption and Premium plan.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app_slot#app_scale_limit LinuxFunctionAppSlot#app_scale_limit}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "appScaleLimit", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? AppScaleLimit
        {
            get;
            set;
        }

        /// <summary>app_service_logs block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app_slot#app_service_logs LinuxFunctionAppSlot#app_service_logs}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "appServiceLogs", typeJson: "{\"fqn\":\"azurerm.linuxFunctionAppSlot.LinuxFunctionAppSlotSiteConfigAppServiceLogs\"}", isOptional: true)]
        public azurerm.LinuxFunctionAppSlot.ILinuxFunctionAppSlotSiteConfigAppServiceLogs? AppServiceLogs
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app_slot#auto_swap_slot_name LinuxFunctionAppSlot#auto_swap_slot_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "autoSwapSlotName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AutoSwapSlotName
        {
            get;
            set;
        }

        /// <summary>The Client ID of the Managed Service Identity to use for connections to the Azure Container Registry.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app_slot#container_registry_managed_identity_client_id LinuxFunctionAppSlot#container_registry_managed_identity_client_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "containerRegistryManagedIdentityClientId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ContainerRegistryManagedIdentityClientId
        {
            get;
            set;
        }

        private object? _containerRegistryUseManagedIdentity;

        /// <summary>Should connections for Azure Container Registry use Managed Identity.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app_slot#container_registry_use_managed_identity LinuxFunctionAppSlot#container_registry_use_managed_identity}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "containerRegistryUseManagedIdentity", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? ContainerRegistryUseManagedIdentity
        {
            get => _containerRegistryUseManagedIdentity;
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
                _containerRegistryUseManagedIdentity = value;
            }
        }

        /// <summary>cors block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app_slot#cors LinuxFunctionAppSlot#cors}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cors", typeJson: "{\"fqn\":\"azurerm.linuxFunctionAppSlot.LinuxFunctionAppSlotSiteConfigCors\"}", isOptional: true)]
        public azurerm.LinuxFunctionAppSlot.ILinuxFunctionAppSlotSiteConfigCors? Cors
        {
            get;
            set;
        }

        /// <summary>Specifies a list of Default Documents for the Linux Web App.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app_slot#default_documents LinuxFunctionAppSlot#default_documents}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "defaultDocuments", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? DefaultDocuments
        {
            get;
            set;
        }

        /// <summary>The number of minimum instances for this Linux Function App. Only affects apps on Elastic Premium plans.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app_slot#elastic_instance_minimum LinuxFunctionAppSlot#elastic_instance_minimum}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "elasticInstanceMinimum", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ElasticInstanceMinimum
        {
            get;
            set;
        }

        /// <summary>State of FTP / FTPS service for this function app.</summary>
        /// <remarks>
        /// Possible values include: <c>AllAllowed</c>, <c>FtpsOnly</c> and <c>Disabled</c>. Defaults to <c>Disabled</c>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app_slot#ftps_state LinuxFunctionAppSlot#ftps_state}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ftpsState", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? FtpsState
        {
            get;
            set;
        }

        /// <summary>The amount of time in minutes that a node is unhealthy before being removed from the load balancer.</summary>
        /// <remarks>
        /// Possible values are between <c>2</c> and <c>10</c>. Defaults to <c>10</c>. Only valid in conjunction with <c>health_check_path</c>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app_slot#health_check_eviction_time_in_min LinuxFunctionAppSlot#health_check_eviction_time_in_min}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "healthCheckEvictionTimeInMin", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? HealthCheckEvictionTimeInMin
        {
            get;
            set;
        }

        /// <summary>The path to be checked for this function app health.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app_slot#health_check_path LinuxFunctionAppSlot#health_check_path}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "healthCheckPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? HealthCheckPath
        {
            get;
            set;
        }

        private object? _http2Enabled;

        /// <summary>Specifies if the http2 protocol should be enabled. Defaults to `false`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app_slot#http2_enabled LinuxFunctionAppSlot#http2_enabled}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "http2Enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? Http2Enabled
        {
            get => _http2Enabled;
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
                _http2Enabled = value;
            }
        }

        private object? _ipRestriction;

        /// <summary>ip_restriction block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app_slot#ip_restriction LinuxFunctionAppSlot#ip_restriction}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ipRestriction", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.linuxFunctionAppSlot.LinuxFunctionAppSlotSiteConfigIpRestriction\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? IpRestriction
        {
            get => _ipRestriction;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.LinuxFunctionAppSlot.ILinuxFunctionAppSlotSiteConfigIpRestriction[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.LinuxFunctionAppSlot.ILinuxFunctionAppSlotSiteConfigIpRestriction).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _ipRestriction = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app_slot#ip_restriction_default_action LinuxFunctionAppSlot#ip_restriction_default_action}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ipRestrictionDefaultAction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? IpRestrictionDefaultAction
        {
            get;
            set;
        }

        /// <summary>The Site load balancing mode. Possible values include: `WeightedRoundRobin`, `LeastRequests`, `LeastResponseTime`, `WeightedTotalTraffic`, `RequestHash`, `PerSiteRoundRobin`. Defaults to `LeastRequests` if omitted.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app_slot#load_balancing_mode LinuxFunctionAppSlot#load_balancing_mode}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "loadBalancingMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LoadBalancingMode
        {
            get;
            set;
        }

        /// <summary>The Managed Pipeline mode. Possible values include: `Integrated`, `Classic`. Defaults to `Integrated`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app_slot#managed_pipeline_mode LinuxFunctionAppSlot#managed_pipeline_mode}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "managedPipelineMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ManagedPipelineMode
        {
            get;
            set;
        }

        /// <summary>The configures the minimum version of TLS required for SSL requests.</summary>
        /// <remarks>
        /// Possible values include: <c>1.0</c>, <c>1.1</c>, and  <c>1.2</c>. Defaults to <c>1.2</c>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app_slot#minimum_tls_version LinuxFunctionAppSlot#minimum_tls_version}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "minimumTlsVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MinimumTlsVersion
        {
            get;
            set;
        }

        /// <summary>The number of pre-warmed instances for this function app. Only affects apps on an Elastic Premium plan.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app_slot#pre_warmed_instance_count LinuxFunctionAppSlot#pre_warmed_instance_count}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "preWarmedInstanceCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? PreWarmedInstanceCount
        {
            get;
            set;
        }

        private object? _remoteDebuggingEnabled;

        /// <summary>Should Remote Debugging be enabled. Defaults to `false`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app_slot#remote_debugging_enabled LinuxFunctionAppSlot#remote_debugging_enabled}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "remoteDebuggingEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? RemoteDebuggingEnabled
        {
            get => _remoteDebuggingEnabled;
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
                _remoteDebuggingEnabled = value;
            }
        }

        /// <summary>The Remote Debugging Version. Possible values include `VS2017`, `VS2019`, and `VS2022`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app_slot#remote_debugging_version LinuxFunctionAppSlot#remote_debugging_version}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "remoteDebuggingVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RemoteDebuggingVersion
        {
            get;
            set;
        }

        private object? _runtimeScaleMonitoringEnabled;

        /// <summary>Should Functions Runtime Scale Monitoring be enabled.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app_slot#runtime_scale_monitoring_enabled LinuxFunctionAppSlot#runtime_scale_monitoring_enabled}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "runtimeScaleMonitoringEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? RuntimeScaleMonitoringEnabled
        {
            get => _runtimeScaleMonitoringEnabled;
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
                _runtimeScaleMonitoringEnabled = value;
            }
        }

        private object? _scmIpRestriction;

        /// <summary>scm_ip_restriction block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app_slot#scm_ip_restriction LinuxFunctionAppSlot#scm_ip_restriction}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "scmIpRestriction", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.linuxFunctionAppSlot.LinuxFunctionAppSlotSiteConfigScmIpRestriction\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ScmIpRestriction
        {
            get => _scmIpRestriction;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.LinuxFunctionAppSlot.ILinuxFunctionAppSlotSiteConfigScmIpRestriction[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.LinuxFunctionAppSlot.ILinuxFunctionAppSlotSiteConfigScmIpRestriction).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _scmIpRestriction = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app_slot#scm_ip_restriction_default_action LinuxFunctionAppSlot#scm_ip_restriction_default_action}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "scmIpRestrictionDefaultAction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ScmIpRestrictionDefaultAction
        {
            get;
            set;
        }

        /// <summary>Configures the minimum version of TLS required for SSL requests to the SCM site Possible values include: `1.0`, `1.1`, and  `1.2`. Defaults to `1.2`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app_slot#scm_minimum_tls_version LinuxFunctionAppSlot#scm_minimum_tls_version}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "scmMinimumTlsVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ScmMinimumTlsVersion
        {
            get;
            set;
        }

        private object? _scmUseMainIpRestriction;

        /// <summary>Should the Linux Function App `ip_restriction` configuration be used for the SCM also.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app_slot#scm_use_main_ip_restriction LinuxFunctionAppSlot#scm_use_main_ip_restriction}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "scmUseMainIpRestriction", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? ScmUseMainIpRestriction
        {
            get => _scmUseMainIpRestriction;
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
                _scmUseMainIpRestriction = value;
            }
        }

        private object? _use32BitWorker;

        /// <summary>Should the Linux Web App use a 32-bit worker.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app_slot#use_32_bit_worker LinuxFunctionAppSlot#use_32_bit_worker}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "use32BitWorker", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? Use32BitWorker
        {
            get => _use32BitWorker;
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
                _use32BitWorker = value;
            }
        }

        private object? _vnetRouteAllEnabled;

        /// <summary>Should all outbound traffic to have Virtual Network Security Groups and User Defined Routes applied? Defaults to `false`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app_slot#vnet_route_all_enabled LinuxFunctionAppSlot#vnet_route_all_enabled}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "vnetRouteAllEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? VnetRouteAllEnabled
        {
            get => _vnetRouteAllEnabled;
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
                _vnetRouteAllEnabled = value;
            }
        }

        private object? _websocketsEnabled;

        /// <summary>Should Web Sockets be enabled. Defaults to `false`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app_slot#websockets_enabled LinuxFunctionAppSlot#websockets_enabled}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "websocketsEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? WebsocketsEnabled
        {
            get => _websocketsEnabled;
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
                _websocketsEnabled = value;
            }
        }

        /// <summary>The number of Workers for this Linux Function App.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app_slot#worker_count LinuxFunctionAppSlot#worker_count}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "workerCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? WorkerCount
        {
            get;
            set;
        }
    }
}
