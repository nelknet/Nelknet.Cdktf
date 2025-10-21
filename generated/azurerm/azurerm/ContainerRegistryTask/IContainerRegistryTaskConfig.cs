using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ContainerRegistryTask
{
    [JsiiInterface(nativeType: typeof(IContainerRegistryTaskConfig), fullyQualifiedName: "azurerm.containerRegistryTask.ContainerRegistryTaskConfig")]
    public interface IContainerRegistryTaskConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_task#container_registry_id ContainerRegistryTask#container_registry_id}.</summary>
        [JsiiProperty(name: "containerRegistryId", typeJson: "{\"primitive\":\"string\"}")]
        string ContainerRegistryId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_task#name ContainerRegistryTask#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_task#agent_pool_name ContainerRegistryTask#agent_pool_name}.</summary>
        [JsiiProperty(name: "agentPoolName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AgentPoolName
        {
            get
            {
                return null;
            }
        }

        /// <summary>agent_setting block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_task#agent_setting ContainerRegistryTask#agent_setting}
        /// </remarks>
        [JsiiProperty(name: "agentSetting", typeJson: "{\"fqn\":\"azurerm.containerRegistryTask.ContainerRegistryTaskAgentSetting\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.ContainerRegistryTask.IContainerRegistryTaskAgentSetting? AgentSetting
        {
            get
            {
                return null;
            }
        }

        /// <summary>base_image_trigger block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_task#base_image_trigger ContainerRegistryTask#base_image_trigger}
        /// </remarks>
        [JsiiProperty(name: "baseImageTrigger", typeJson: "{\"fqn\":\"azurerm.containerRegistryTask.ContainerRegistryTaskBaseImageTrigger\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.ContainerRegistryTask.IContainerRegistryTaskBaseImageTrigger? BaseImageTrigger
        {
            get
            {
                return null;
            }
        }

        /// <summary>docker_step block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_task#docker_step ContainerRegistryTask#docker_step}
        /// </remarks>
        [JsiiProperty(name: "dockerStep", typeJson: "{\"fqn\":\"azurerm.containerRegistryTask.ContainerRegistryTaskDockerStep\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.ContainerRegistryTask.IContainerRegistryTaskDockerStep? DockerStep
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_task#enabled ContainerRegistryTask#enabled}.</summary>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Enabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>encoded_step block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_task#encoded_step ContainerRegistryTask#encoded_step}
        /// </remarks>
        [JsiiProperty(name: "encodedStep", typeJson: "{\"fqn\":\"azurerm.containerRegistryTask.ContainerRegistryTaskEncodedStep\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.ContainerRegistryTask.IContainerRegistryTaskEncodedStep? EncodedStep
        {
            get
            {
                return null;
            }
        }

        /// <summary>file_step block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_task#file_step ContainerRegistryTask#file_step}
        /// </remarks>
        [JsiiProperty(name: "fileStep", typeJson: "{\"fqn\":\"azurerm.containerRegistryTask.ContainerRegistryTaskFileStep\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.ContainerRegistryTask.IContainerRegistryTaskFileStep? FileStep
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_task#id ContainerRegistryTask#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Id
        {
            get
            {
                return null;
            }
        }

        /// <summary>identity block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_task#identity ContainerRegistryTask#identity}
        /// </remarks>
        [JsiiProperty(name: "identity", typeJson: "{\"fqn\":\"azurerm.containerRegistryTask.ContainerRegistryTaskIdentity\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.ContainerRegistryTask.IContainerRegistryTaskIdentity? Identity
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_task#is_system_task ContainerRegistryTask#is_system_task}.</summary>
        [JsiiProperty(name: "isSystemTask", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsSystemTask
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_task#log_template ContainerRegistryTask#log_template}.</summary>
        [JsiiProperty(name: "logTemplate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LogTemplate
        {
            get
            {
                return null;
            }
        }

        /// <summary>platform block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_task#platform ContainerRegistryTask#platform}
        /// </remarks>
        [JsiiProperty(name: "platform", typeJson: "{\"fqn\":\"azurerm.containerRegistryTask.ContainerRegistryTaskPlatform\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.ContainerRegistryTask.IContainerRegistryTaskPlatform? Platform
        {
            get
            {
                return null;
            }
        }

        /// <summary>registry_credential block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_task#registry_credential ContainerRegistryTask#registry_credential}
        /// </remarks>
        [JsiiProperty(name: "registryCredential", typeJson: "{\"fqn\":\"azurerm.containerRegistryTask.ContainerRegistryTaskRegistryCredential\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.ContainerRegistryTask.IContainerRegistryTaskRegistryCredential? RegistryCredential
        {
            get
            {
                return null;
            }
        }

        /// <summary>source_trigger block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_task#source_trigger ContainerRegistryTask#source_trigger}
        /// </remarks>
        [JsiiProperty(name: "sourceTrigger", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.containerRegistryTask.ContainerRegistryTaskSourceTrigger\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SourceTrigger
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_task#tags ContainerRegistryTask#tags}.</summary>
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_task#timeout_in_seconds ContainerRegistryTask#timeout_in_seconds}.</summary>
        [JsiiProperty(name: "timeoutInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? TimeoutInSeconds
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_task#timeouts ContainerRegistryTask#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.containerRegistryTask.ContainerRegistryTaskTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.ContainerRegistryTask.IContainerRegistryTaskTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        /// <summary>timer_trigger block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_task#timer_trigger ContainerRegistryTask#timer_trigger}
        /// </remarks>
        [JsiiProperty(name: "timerTrigger", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.containerRegistryTask.ContainerRegistryTaskTimerTrigger\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? TimerTrigger
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IContainerRegistryTaskConfig), fullyQualifiedName: "azurerm.containerRegistryTask.ContainerRegistryTaskConfig")]
        internal sealed class _Proxy : DeputyBase, azurerm.ContainerRegistryTask.IContainerRegistryTaskConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_task#container_registry_id ContainerRegistryTask#container_registry_id}.</summary>
            [JsiiProperty(name: "containerRegistryId", typeJson: "{\"primitive\":\"string\"}")]
            public string ContainerRegistryId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_task#name ContainerRegistryTask#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_task#agent_pool_name ContainerRegistryTask#agent_pool_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "agentPoolName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AgentPoolName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>agent_setting block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_task#agent_setting ContainerRegistryTask#agent_setting}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "agentSetting", typeJson: "{\"fqn\":\"azurerm.containerRegistryTask.ContainerRegistryTaskAgentSetting\"}", isOptional: true)]
            public azurerm.ContainerRegistryTask.IContainerRegistryTaskAgentSetting? AgentSetting
            {
                get => GetInstanceProperty<azurerm.ContainerRegistryTask.IContainerRegistryTaskAgentSetting?>();
            }

            /// <summary>base_image_trigger block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_task#base_image_trigger ContainerRegistryTask#base_image_trigger}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "baseImageTrigger", typeJson: "{\"fqn\":\"azurerm.containerRegistryTask.ContainerRegistryTaskBaseImageTrigger\"}", isOptional: true)]
            public azurerm.ContainerRegistryTask.IContainerRegistryTaskBaseImageTrigger? BaseImageTrigger
            {
                get => GetInstanceProperty<azurerm.ContainerRegistryTask.IContainerRegistryTaskBaseImageTrigger?>();
            }

            /// <summary>docker_step block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_task#docker_step ContainerRegistryTask#docker_step}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dockerStep", typeJson: "{\"fqn\":\"azurerm.containerRegistryTask.ContainerRegistryTaskDockerStep\"}", isOptional: true)]
            public azurerm.ContainerRegistryTask.IContainerRegistryTaskDockerStep? DockerStep
            {
                get => GetInstanceProperty<azurerm.ContainerRegistryTask.IContainerRegistryTaskDockerStep?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_task#enabled ContainerRegistryTask#enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? Enabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>encoded_step block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_task#encoded_step ContainerRegistryTask#encoded_step}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "encodedStep", typeJson: "{\"fqn\":\"azurerm.containerRegistryTask.ContainerRegistryTaskEncodedStep\"}", isOptional: true)]
            public azurerm.ContainerRegistryTask.IContainerRegistryTaskEncodedStep? EncodedStep
            {
                get => GetInstanceProperty<azurerm.ContainerRegistryTask.IContainerRegistryTaskEncodedStep?>();
            }

            /// <summary>file_step block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_task#file_step ContainerRegistryTask#file_step}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "fileStep", typeJson: "{\"fqn\":\"azurerm.containerRegistryTask.ContainerRegistryTaskFileStep\"}", isOptional: true)]
            public azurerm.ContainerRegistryTask.IContainerRegistryTaskFileStep? FileStep
            {
                get => GetInstanceProperty<azurerm.ContainerRegistryTask.IContainerRegistryTaskFileStep?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_task#id ContainerRegistryTask#id}.</summary>
            /// <remarks>
            /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
            /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Id
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>identity block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_task#identity ContainerRegistryTask#identity}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "identity", typeJson: "{\"fqn\":\"azurerm.containerRegistryTask.ContainerRegistryTaskIdentity\"}", isOptional: true)]
            public azurerm.ContainerRegistryTask.IContainerRegistryTaskIdentity? Identity
            {
                get => GetInstanceProperty<azurerm.ContainerRegistryTask.IContainerRegistryTaskIdentity?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_task#is_system_task ContainerRegistryTask#is_system_task}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isSystemTask", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? IsSystemTask
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_task#log_template ContainerRegistryTask#log_template}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "logTemplate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LogTemplate
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>platform block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_task#platform ContainerRegistryTask#platform}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "platform", typeJson: "{\"fqn\":\"azurerm.containerRegistryTask.ContainerRegistryTaskPlatform\"}", isOptional: true)]
            public azurerm.ContainerRegistryTask.IContainerRegistryTaskPlatform? Platform
            {
                get => GetInstanceProperty<azurerm.ContainerRegistryTask.IContainerRegistryTaskPlatform?>();
            }

            /// <summary>registry_credential block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_task#registry_credential ContainerRegistryTask#registry_credential}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "registryCredential", typeJson: "{\"fqn\":\"azurerm.containerRegistryTask.ContainerRegistryTaskRegistryCredential\"}", isOptional: true)]
            public azurerm.ContainerRegistryTask.IContainerRegistryTaskRegistryCredential? RegistryCredential
            {
                get => GetInstanceProperty<azurerm.ContainerRegistryTask.IContainerRegistryTaskRegistryCredential?>();
            }

            /// <summary>source_trigger block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_task#source_trigger ContainerRegistryTask#source_trigger}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sourceTrigger", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.containerRegistryTask.ContainerRegistryTaskSourceTrigger\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? SourceTrigger
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_task#tags ContainerRegistryTask#tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_task#timeout_in_seconds ContainerRegistryTask#timeout_in_seconds}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "timeoutInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? TimeoutInSeconds
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_task#timeouts ContainerRegistryTask#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.containerRegistryTask.ContainerRegistryTaskTimeouts\"}", isOptional: true)]
            public azurerm.ContainerRegistryTask.IContainerRegistryTaskTimeouts? Timeouts
            {
                get => GetInstanceProperty<azurerm.ContainerRegistryTask.IContainerRegistryTaskTimeouts?>();
            }

            /// <summary>timer_trigger block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_task#timer_trigger ContainerRegistryTask#timer_trigger}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timerTrigger", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.containerRegistryTask.ContainerRegistryTaskTimerTrigger\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? TimerTrigger
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.SSHProvisionerConnection\"},{\"fqn\":\"cdktf.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktf.TerraformCount\"}]}}", isOptional: true)]
            public object? Count
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktf.ITerraformIterator\"}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformIterator? ForEach
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformIterator?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true)]
            public HashiCorp.Cdktf.TerraformProvider? Provider
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.TerraformProvider?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.FileProvisioner\"},{\"fqn\":\"cdktf.LocalExecProvisioner\"},{\"fqn\":\"cdktf.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
            public object[]? Provisioners
            {
                get => GetInstanceProperty<object[]?>();
            }
        }
    }
}
