using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BatchJobDefinition
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.batchJobDefinition.BatchJobDefinitionEksPropertiesPodProperties")]
    public class BatchJobDefinitionEksPropertiesPodProperties : aws.BatchJobDefinition.IBatchJobDefinitionEksPropertiesPodProperties
    {
        private object _containers;

        /// <summary>containers block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/batch_job_definition#containers BatchJobDefinition#containers}
        /// </remarks>
        [JsiiProperty(name: "containers", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.batchJobDefinition.BatchJobDefinitionEksPropertiesPodPropertiesContainers\"},\"kind\":\"array\"}}]}}")]
        public object Containers
        {
            get => _containers;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.BatchJobDefinition.IBatchJobDefinitionEksPropertiesPodPropertiesContainers[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.BatchJobDefinition.IBatchJobDefinitionEksPropertiesPodPropertiesContainers).FullName}[]; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.BatchJobDefinition.IBatchJobDefinitionEksPropertiesPodPropertiesContainers).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _containers = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/batch_job_definition#dns_policy BatchJobDefinition#dns_policy}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dnsPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DnsPolicy
        {
            get;
            set;
        }

        private object? _hostNetwork;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/batch_job_definition#host_network BatchJobDefinition#host_network}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "hostNetwork", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? HostNetwork
        {
            get => _hostNetwork;
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
                _hostNetwork = value;
            }
        }

        private object? _imagePullSecret;

        /// <summary>image_pull_secret block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/batch_job_definition#image_pull_secret BatchJobDefinition#image_pull_secret}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "imagePullSecret", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.batchJobDefinition.BatchJobDefinitionEksPropertiesPodPropertiesImagePullSecret\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ImagePullSecret
        {
            get => _imagePullSecret;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.BatchJobDefinition.IBatchJobDefinitionEksPropertiesPodPropertiesImagePullSecret[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.BatchJobDefinition.IBatchJobDefinitionEksPropertiesPodPropertiesImagePullSecret).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _imagePullSecret = value;
            }
        }

        private object? _initContainers;

        /// <summary>init_containers block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/batch_job_definition#init_containers BatchJobDefinition#init_containers}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "initContainers", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.batchJobDefinition.BatchJobDefinitionEksPropertiesPodPropertiesInitContainers\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? InitContainers
        {
            get => _initContainers;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.BatchJobDefinition.IBatchJobDefinitionEksPropertiesPodPropertiesInitContainers[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.BatchJobDefinition.IBatchJobDefinitionEksPropertiesPodPropertiesInitContainers).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _initContainers = value;
            }
        }

        /// <summary>metadata block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/batch_job_definition#metadata BatchJobDefinition#metadata}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"aws.batchJobDefinition.BatchJobDefinitionEksPropertiesPodPropertiesMetadata\"}", isOptional: true)]
        public aws.BatchJobDefinition.IBatchJobDefinitionEksPropertiesPodPropertiesMetadata? Metadata
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/batch_job_definition#service_account_name BatchJobDefinition#service_account_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "serviceAccountName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ServiceAccountName
        {
            get;
            set;
        }

        private object? _shareProcessNamespace;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/batch_job_definition#share_process_namespace BatchJobDefinition#share_process_namespace}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "shareProcessNamespace", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? ShareProcessNamespace
        {
            get => _shareProcessNamespace;
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
                _shareProcessNamespace = value;
            }
        }

        private object? _volumes;

        /// <summary>volumes block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/batch_job_definition#volumes BatchJobDefinition#volumes}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "volumes", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.batchJobDefinition.BatchJobDefinitionEksPropertiesPodPropertiesVolumes\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Volumes
        {
            get => _volumes;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.BatchJobDefinition.IBatchJobDefinitionEksPropertiesPodPropertiesVolumes[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.BatchJobDefinition.IBatchJobDefinitionEksPropertiesPodPropertiesVolumes).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _volumes = value;
            }
        }
    }
}
