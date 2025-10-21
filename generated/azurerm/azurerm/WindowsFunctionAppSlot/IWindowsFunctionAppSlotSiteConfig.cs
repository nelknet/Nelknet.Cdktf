using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.WindowsFunctionAppSlot
{
    [JsiiInterface(nativeType: typeof(IWindowsFunctionAppSlotSiteConfig), fullyQualifiedName: "azurerm.windowsFunctionAppSlot.WindowsFunctionAppSlotSiteConfig")]
    public interface IWindowsFunctionAppSlotSiteConfig
    {
        /// <summary>If this Windows Web App is Always On enabled. Defaults to `false`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app_slot#always_on WindowsFunctionAppSlot#always_on}
        /// </remarks>
        [JsiiProperty(name: "alwaysOn", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AlwaysOn
        {
            get
            {
                return null;
            }
        }

        /// <summary>The URL of the API definition that describes this Windows Function App.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app_slot#api_definition_url WindowsFunctionAppSlot#api_definition_url}
        /// </remarks>
        [JsiiProperty(name: "apiDefinitionUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ApiDefinitionUrl
        {
            get
            {
                return null;
            }
        }

        /// <summary>The ID of the API Management API for this Windows Function App.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app_slot#api_management_api_id WindowsFunctionAppSlot#api_management_api_id}
        /// </remarks>
        [JsiiProperty(name: "apiManagementApiId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ApiManagementApiId
        {
            get
            {
                return null;
            }
        }

        /// <summary>The program and any arguments used to launch this app via the command line. (Example `node myapp.js`).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app_slot#app_command_line WindowsFunctionAppSlot#app_command_line}
        /// </remarks>
        [JsiiProperty(name: "appCommandLine", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AppCommandLine
        {
            get
            {
                return null;
            }
        }

        /// <summary>The Connection String for linking the Windows Function App to Application Insights.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app_slot#application_insights_connection_string WindowsFunctionAppSlot#application_insights_connection_string}
        /// </remarks>
        [JsiiProperty(name: "applicationInsightsConnectionString", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ApplicationInsightsConnectionString
        {
            get
            {
                return null;
            }
        }

        /// <summary>The Instrumentation Key for connecting the Windows Function App to Application Insights.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app_slot#application_insights_key WindowsFunctionAppSlot#application_insights_key}
        /// </remarks>
        [JsiiProperty(name: "applicationInsightsKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ApplicationInsightsKey
        {
            get
            {
                return null;
            }
        }

        /// <summary>application_stack block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app_slot#application_stack WindowsFunctionAppSlot#application_stack}
        /// </remarks>
        [JsiiProperty(name: "applicationStack", typeJson: "{\"fqn\":\"azurerm.windowsFunctionAppSlot.WindowsFunctionAppSlotSiteConfigApplicationStack\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.WindowsFunctionAppSlot.IWindowsFunctionAppSlotSiteConfigApplicationStack? ApplicationStack
        {
            get
            {
                return null;
            }
        }

        /// <summary>The number of workers this function app can scale out to.</summary>
        /// <remarks>
        /// Only applicable to apps on the Consumption and Premium plan.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app_slot#app_scale_limit WindowsFunctionAppSlot#app_scale_limit}
        /// </remarks>
        [JsiiProperty(name: "appScaleLimit", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? AppScaleLimit
        {
            get
            {
                return null;
            }
        }

        /// <summary>app_service_logs block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app_slot#app_service_logs WindowsFunctionAppSlot#app_service_logs}
        /// </remarks>
        [JsiiProperty(name: "appServiceLogs", typeJson: "{\"fqn\":\"azurerm.windowsFunctionAppSlot.WindowsFunctionAppSlotSiteConfigAppServiceLogs\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.WindowsFunctionAppSlot.IWindowsFunctionAppSlotSiteConfigAppServiceLogs? AppServiceLogs
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app_slot#auto_swap_slot_name WindowsFunctionAppSlot#auto_swap_slot_name}.</summary>
        [JsiiProperty(name: "autoSwapSlotName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AutoSwapSlotName
        {
            get
            {
                return null;
            }
        }

        /// <summary>cors block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app_slot#cors WindowsFunctionAppSlot#cors}
        /// </remarks>
        [JsiiProperty(name: "cors", typeJson: "{\"fqn\":\"azurerm.windowsFunctionAppSlot.WindowsFunctionAppSlotSiteConfigCors\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.WindowsFunctionAppSlot.IWindowsFunctionAppSlotSiteConfigCors? Cors
        {
            get
            {
                return null;
            }
        }

        /// <summary>Specifies a list of Default Documents for the Windows Web App.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app_slot#default_documents WindowsFunctionAppSlot#default_documents}
        /// </remarks>
        [JsiiProperty(name: "defaultDocuments", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? DefaultDocuments
        {
            get
            {
                return null;
            }
        }

        /// <summary>The number of minimum instances for this Windows Function App. Only affects apps on Elastic Premium plans.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app_slot#elastic_instance_minimum WindowsFunctionAppSlot#elastic_instance_minimum}
        /// </remarks>
        [JsiiProperty(name: "elasticInstanceMinimum", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ElasticInstanceMinimum
        {
            get
            {
                return null;
            }
        }

        /// <summary>State of FTP / FTPS service for this function app.</summary>
        /// <remarks>
        /// Possible values include: <c>AllAllowed</c>, <c>FtpsOnly</c> and <c>Disabled</c>. Defaults to <c>Disabled</c>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app_slot#ftps_state WindowsFunctionAppSlot#ftps_state}
        /// </remarks>
        [JsiiProperty(name: "ftpsState", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? FtpsState
        {
            get
            {
                return null;
            }
        }

        /// <summary>The amount of time in minutes that a node is unhealthy before being removed from the load balancer.</summary>
        /// <remarks>
        /// Possible values are between <c>2</c> and <c>10</c>. Defaults to <c>10</c>. Only valid in conjunction with <c>health_check_path</c>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app_slot#health_check_eviction_time_in_min WindowsFunctionAppSlot#health_check_eviction_time_in_min}
        /// </remarks>
        [JsiiProperty(name: "healthCheckEvictionTimeInMin", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? HealthCheckEvictionTimeInMin
        {
            get
            {
                return null;
            }
        }

        /// <summary>The path to be checked for this function app health.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app_slot#health_check_path WindowsFunctionAppSlot#health_check_path}
        /// </remarks>
        [JsiiProperty(name: "healthCheckPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? HealthCheckPath
        {
            get
            {
                return null;
            }
        }

        /// <summary>Specifies if the http2 protocol should be enabled. Defaults to `false`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app_slot#http2_enabled WindowsFunctionAppSlot#http2_enabled}
        /// </remarks>
        [JsiiProperty(name: "http2Enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Http2Enabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>ip_restriction block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app_slot#ip_restriction WindowsFunctionAppSlot#ip_restriction}
        /// </remarks>
        [JsiiProperty(name: "ipRestriction", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.windowsFunctionAppSlot.WindowsFunctionAppSlotSiteConfigIpRestriction\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IpRestriction
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app_slot#ip_restriction_default_action WindowsFunctionAppSlot#ip_restriction_default_action}.</summary>
        [JsiiProperty(name: "ipRestrictionDefaultAction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? IpRestrictionDefaultAction
        {
            get
            {
                return null;
            }
        }

        /// <summary>The Site load balancing mode. Possible values include: `WeightedRoundRobin`, `LeastRequests`, `LeastResponseTime`, `WeightedTotalTraffic`, `RequestHash`, `PerSiteRoundRobin`. Defaults to `LeastRequests` if omitted.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app_slot#load_balancing_mode WindowsFunctionAppSlot#load_balancing_mode}
        /// </remarks>
        [JsiiProperty(name: "loadBalancingMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LoadBalancingMode
        {
            get
            {
                return null;
            }
        }

        /// <summary>The Managed Pipeline mode. Possible values include: `Integrated`, `Classic`. Defaults to `Integrated`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app_slot#managed_pipeline_mode WindowsFunctionAppSlot#managed_pipeline_mode}
        /// </remarks>
        [JsiiProperty(name: "managedPipelineMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ManagedPipelineMode
        {
            get
            {
                return null;
            }
        }

        /// <summary>The configures the minimum version of TLS required for SSL requests.</summary>
        /// <remarks>
        /// Possible values include: <c>1.0</c>, <c>1.1</c>, and  <c>1.2</c>. Defaults to <c>1.2</c>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app_slot#minimum_tls_version WindowsFunctionAppSlot#minimum_tls_version}
        /// </remarks>
        [JsiiProperty(name: "minimumTlsVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MinimumTlsVersion
        {
            get
            {
                return null;
            }
        }

        /// <summary>The number of pre-warmed instances for this function app. Only affects apps on an Elastic Premium plan.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app_slot#pre_warmed_instance_count WindowsFunctionAppSlot#pre_warmed_instance_count}
        /// </remarks>
        [JsiiProperty(name: "preWarmedInstanceCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? PreWarmedInstanceCount
        {
            get
            {
                return null;
            }
        }

        /// <summary>Should Remote Debugging be enabled. Defaults to `false`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app_slot#remote_debugging_enabled WindowsFunctionAppSlot#remote_debugging_enabled}
        /// </remarks>
        [JsiiProperty(name: "remoteDebuggingEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RemoteDebuggingEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>The Remote Debugging Version. Possible values include `VS2017`, `VS2019`, and `VS2022`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app_slot#remote_debugging_version WindowsFunctionAppSlot#remote_debugging_version}
        /// </remarks>
        [JsiiProperty(name: "remoteDebuggingVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RemoteDebuggingVersion
        {
            get
            {
                return null;
            }
        }

        /// <summary>Should Functions Runtime Scale Monitoring be enabled.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app_slot#runtime_scale_monitoring_enabled WindowsFunctionAppSlot#runtime_scale_monitoring_enabled}
        /// </remarks>
        [JsiiProperty(name: "runtimeScaleMonitoringEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RuntimeScaleMonitoringEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>scm_ip_restriction block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app_slot#scm_ip_restriction WindowsFunctionAppSlot#scm_ip_restriction}
        /// </remarks>
        [JsiiProperty(name: "scmIpRestriction", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.windowsFunctionAppSlot.WindowsFunctionAppSlotSiteConfigScmIpRestriction\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ScmIpRestriction
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app_slot#scm_ip_restriction_default_action WindowsFunctionAppSlot#scm_ip_restriction_default_action}.</summary>
        [JsiiProperty(name: "scmIpRestrictionDefaultAction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ScmIpRestrictionDefaultAction
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures the minimum version of TLS required for SSL requests to the SCM site Possible values include: `1.0`, `1.1`, and  `1.2`. Defaults to `1.2`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app_slot#scm_minimum_tls_version WindowsFunctionAppSlot#scm_minimum_tls_version}
        /// </remarks>
        [JsiiProperty(name: "scmMinimumTlsVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ScmMinimumTlsVersion
        {
            get
            {
                return null;
            }
        }

        /// <summary>Should the Windows Function App `ip_restriction` configuration be used for the SCM also.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app_slot#scm_use_main_ip_restriction WindowsFunctionAppSlot#scm_use_main_ip_restriction}
        /// </remarks>
        [JsiiProperty(name: "scmUseMainIpRestriction", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ScmUseMainIpRestriction
        {
            get
            {
                return null;
            }
        }

        /// <summary>Should the Windows Function App use a 32-bit worker.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app_slot#use_32_bit_worker WindowsFunctionAppSlot#use_32_bit_worker}
        /// </remarks>
        [JsiiProperty(name: "use32BitWorker", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Use32BitWorker
        {
            get
            {
                return null;
            }
        }

        /// <summary>Should all outbound traffic to have Virtual Network Security Groups and User Defined Routes applied? Defaults to `false`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app_slot#vnet_route_all_enabled WindowsFunctionAppSlot#vnet_route_all_enabled}
        /// </remarks>
        [JsiiProperty(name: "vnetRouteAllEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? VnetRouteAllEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Should Web Sockets be enabled. Defaults to `false`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app_slot#websockets_enabled WindowsFunctionAppSlot#websockets_enabled}
        /// </remarks>
        [JsiiProperty(name: "websocketsEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? WebsocketsEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>The number of Workers for this Windows Function App.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app_slot#worker_count WindowsFunctionAppSlot#worker_count}
        /// </remarks>
        [JsiiProperty(name: "workerCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? WorkerCount
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWindowsFunctionAppSlotSiteConfig), fullyQualifiedName: "azurerm.windowsFunctionAppSlot.WindowsFunctionAppSlotSiteConfig")]
        internal sealed class _Proxy : DeputyBase, azurerm.WindowsFunctionAppSlot.IWindowsFunctionAppSlotSiteConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>If this Windows Web App is Always On enabled. Defaults to `false`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app_slot#always_on WindowsFunctionAppSlot#always_on}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "alwaysOn", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? AlwaysOn
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>The URL of the API definition that describes this Windows Function App.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app_slot#api_definition_url WindowsFunctionAppSlot#api_definition_url}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "apiDefinitionUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ApiDefinitionUrl
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The ID of the API Management API for this Windows Function App.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app_slot#api_management_api_id WindowsFunctionAppSlot#api_management_api_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "apiManagementApiId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ApiManagementApiId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The program and any arguments used to launch this app via the command line. (Example `node myapp.js`).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app_slot#app_command_line WindowsFunctionAppSlot#app_command_line}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "appCommandLine", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AppCommandLine
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The Connection String for linking the Windows Function App to Application Insights.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app_slot#application_insights_connection_string WindowsFunctionAppSlot#application_insights_connection_string}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "applicationInsightsConnectionString", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ApplicationInsightsConnectionString
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The Instrumentation Key for connecting the Windows Function App to Application Insights.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app_slot#application_insights_key WindowsFunctionAppSlot#application_insights_key}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "applicationInsightsKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ApplicationInsightsKey
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>application_stack block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app_slot#application_stack WindowsFunctionAppSlot#application_stack}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "applicationStack", typeJson: "{\"fqn\":\"azurerm.windowsFunctionAppSlot.WindowsFunctionAppSlotSiteConfigApplicationStack\"}", isOptional: true)]
            public azurerm.WindowsFunctionAppSlot.IWindowsFunctionAppSlotSiteConfigApplicationStack? ApplicationStack
            {
                get => GetInstanceProperty<azurerm.WindowsFunctionAppSlot.IWindowsFunctionAppSlotSiteConfigApplicationStack?>();
            }

            /// <summary>The number of workers this function app can scale out to.</summary>
            /// <remarks>
            /// Only applicable to apps on the Consumption and Premium plan.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app_slot#app_scale_limit WindowsFunctionAppSlot#app_scale_limit}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "appScaleLimit", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? AppScaleLimit
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>app_service_logs block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app_slot#app_service_logs WindowsFunctionAppSlot#app_service_logs}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "appServiceLogs", typeJson: "{\"fqn\":\"azurerm.windowsFunctionAppSlot.WindowsFunctionAppSlotSiteConfigAppServiceLogs\"}", isOptional: true)]
            public azurerm.WindowsFunctionAppSlot.IWindowsFunctionAppSlotSiteConfigAppServiceLogs? AppServiceLogs
            {
                get => GetInstanceProperty<azurerm.WindowsFunctionAppSlot.IWindowsFunctionAppSlotSiteConfigAppServiceLogs?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app_slot#auto_swap_slot_name WindowsFunctionAppSlot#auto_swap_slot_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "autoSwapSlotName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AutoSwapSlotName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>cors block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app_slot#cors WindowsFunctionAppSlot#cors}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cors", typeJson: "{\"fqn\":\"azurerm.windowsFunctionAppSlot.WindowsFunctionAppSlotSiteConfigCors\"}", isOptional: true)]
            public azurerm.WindowsFunctionAppSlot.IWindowsFunctionAppSlotSiteConfigCors? Cors
            {
                get => GetInstanceProperty<azurerm.WindowsFunctionAppSlot.IWindowsFunctionAppSlotSiteConfigCors?>();
            }

            /// <summary>Specifies a list of Default Documents for the Windows Web App.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app_slot#default_documents WindowsFunctionAppSlot#default_documents}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "defaultDocuments", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? DefaultDocuments
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>The number of minimum instances for this Windows Function App. Only affects apps on Elastic Premium plans.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app_slot#elastic_instance_minimum WindowsFunctionAppSlot#elastic_instance_minimum}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "elasticInstanceMinimum", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ElasticInstanceMinimum
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>State of FTP / FTPS service for this function app.</summary>
            /// <remarks>
            /// Possible values include: <c>AllAllowed</c>, <c>FtpsOnly</c> and <c>Disabled</c>. Defaults to <c>Disabled</c>.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app_slot#ftps_state WindowsFunctionAppSlot#ftps_state}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ftpsState", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FtpsState
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The amount of time in minutes that a node is unhealthy before being removed from the load balancer.</summary>
            /// <remarks>
            /// Possible values are between <c>2</c> and <c>10</c>. Defaults to <c>10</c>. Only valid in conjunction with <c>health_check_path</c>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app_slot#health_check_eviction_time_in_min WindowsFunctionAppSlot#health_check_eviction_time_in_min}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "healthCheckEvictionTimeInMin", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? HealthCheckEvictionTimeInMin
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>The path to be checked for this function app health.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app_slot#health_check_path WindowsFunctionAppSlot#health_check_path}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "healthCheckPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? HealthCheckPath
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Specifies if the http2 protocol should be enabled. Defaults to `false`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app_slot#http2_enabled WindowsFunctionAppSlot#http2_enabled}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "http2Enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? Http2Enabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>ip_restriction block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app_slot#ip_restriction WindowsFunctionAppSlot#ip_restriction}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ipRestriction", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.windowsFunctionAppSlot.WindowsFunctionAppSlotSiteConfigIpRestriction\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? IpRestriction
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app_slot#ip_restriction_default_action WindowsFunctionAppSlot#ip_restriction_default_action}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ipRestrictionDefaultAction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? IpRestrictionDefaultAction
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The Site load balancing mode. Possible values include: `WeightedRoundRobin`, `LeastRequests`, `LeastResponseTime`, `WeightedTotalTraffic`, `RequestHash`, `PerSiteRoundRobin`. Defaults to `LeastRequests` if omitted.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app_slot#load_balancing_mode WindowsFunctionAppSlot#load_balancing_mode}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "loadBalancingMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LoadBalancingMode
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The Managed Pipeline mode. Possible values include: `Integrated`, `Classic`. Defaults to `Integrated`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app_slot#managed_pipeline_mode WindowsFunctionAppSlot#managed_pipeline_mode}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "managedPipelineMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ManagedPipelineMode
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The configures the minimum version of TLS required for SSL requests.</summary>
            /// <remarks>
            /// Possible values include: <c>1.0</c>, <c>1.1</c>, and  <c>1.2</c>. Defaults to <c>1.2</c>.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app_slot#minimum_tls_version WindowsFunctionAppSlot#minimum_tls_version}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "minimumTlsVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MinimumTlsVersion
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The number of pre-warmed instances for this function app. Only affects apps on an Elastic Premium plan.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app_slot#pre_warmed_instance_count WindowsFunctionAppSlot#pre_warmed_instance_count}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "preWarmedInstanceCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? PreWarmedInstanceCount
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Should Remote Debugging be enabled. Defaults to `false`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app_slot#remote_debugging_enabled WindowsFunctionAppSlot#remote_debugging_enabled}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "remoteDebuggingEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? RemoteDebuggingEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>The Remote Debugging Version. Possible values include `VS2017`, `VS2019`, and `VS2022`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app_slot#remote_debugging_version WindowsFunctionAppSlot#remote_debugging_version}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "remoteDebuggingVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RemoteDebuggingVersion
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Should Functions Runtime Scale Monitoring be enabled.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app_slot#runtime_scale_monitoring_enabled WindowsFunctionAppSlot#runtime_scale_monitoring_enabled}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "runtimeScaleMonitoringEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? RuntimeScaleMonitoringEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>scm_ip_restriction block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app_slot#scm_ip_restriction WindowsFunctionAppSlot#scm_ip_restriction}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "scmIpRestriction", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.windowsFunctionAppSlot.WindowsFunctionAppSlotSiteConfigScmIpRestriction\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ScmIpRestriction
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app_slot#scm_ip_restriction_default_action WindowsFunctionAppSlot#scm_ip_restriction_default_action}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "scmIpRestrictionDefaultAction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ScmIpRestrictionDefaultAction
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Configures the minimum version of TLS required for SSL requests to the SCM site Possible values include: `1.0`, `1.1`, and  `1.2`. Defaults to `1.2`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app_slot#scm_minimum_tls_version WindowsFunctionAppSlot#scm_minimum_tls_version}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "scmMinimumTlsVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ScmMinimumTlsVersion
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Should the Windows Function App `ip_restriction` configuration be used for the SCM also.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app_slot#scm_use_main_ip_restriction WindowsFunctionAppSlot#scm_use_main_ip_restriction}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "scmUseMainIpRestriction", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? ScmUseMainIpRestriction
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Should the Windows Function App use a 32-bit worker.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app_slot#use_32_bit_worker WindowsFunctionAppSlot#use_32_bit_worker}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "use32BitWorker", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? Use32BitWorker
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Should all outbound traffic to have Virtual Network Security Groups and User Defined Routes applied? Defaults to `false`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app_slot#vnet_route_all_enabled WindowsFunctionAppSlot#vnet_route_all_enabled}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "vnetRouteAllEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? VnetRouteAllEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Should Web Sockets be enabled. Defaults to `false`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app_slot#websockets_enabled WindowsFunctionAppSlot#websockets_enabled}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "websocketsEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? WebsocketsEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>The number of Workers for this Windows Function App.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app_slot#worker_count WindowsFunctionAppSlot#worker_count}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "workerCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? WorkerCount
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
