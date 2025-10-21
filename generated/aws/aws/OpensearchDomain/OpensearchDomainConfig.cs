using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.OpensearchDomain
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.opensearchDomain.OpensearchDomainConfig")]
    public class OpensearchDomainConfig : aws.OpensearchDomain.IOpensearchDomainConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#domain_name OpensearchDomain#domain_name}.</summary>
        [JsiiProperty(name: "domainName", typeJson: "{\"primitive\":\"string\"}")]
        public string DomainName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#access_policies OpensearchDomain#access_policies}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "accessPolicies", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AccessPolicies
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#advanced_options OpensearchDomain#advanced_options}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "advancedOptions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? AdvancedOptions
        {
            get;
            set;
        }

        /// <summary>advanced_security_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#advanced_security_options OpensearchDomain#advanced_security_options}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "advancedSecurityOptions", typeJson: "{\"fqn\":\"aws.opensearchDomain.OpensearchDomainAdvancedSecurityOptions\"}", isOptional: true)]
        public aws.OpensearchDomain.IOpensearchDomainAdvancedSecurityOptions? AdvancedSecurityOptions
        {
            get;
            set;
        }

        /// <summary>auto_tune_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#auto_tune_options OpensearchDomain#auto_tune_options}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "autoTuneOptions", typeJson: "{\"fqn\":\"aws.opensearchDomain.OpensearchDomainAutoTuneOptions\"}", isOptional: true)]
        public aws.OpensearchDomain.IOpensearchDomainAutoTuneOptions? AutoTuneOptions
        {
            get;
            set;
        }

        /// <summary>cluster_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#cluster_config OpensearchDomain#cluster_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "clusterConfig", typeJson: "{\"fqn\":\"aws.opensearchDomain.OpensearchDomainClusterConfig\"}", isOptional: true)]
        public aws.OpensearchDomain.IOpensearchDomainClusterConfig? ClusterConfig
        {
            get;
            set;
        }

        /// <summary>cognito_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#cognito_options OpensearchDomain#cognito_options}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cognitoOptions", typeJson: "{\"fqn\":\"aws.opensearchDomain.OpensearchDomainCognitoOptions\"}", isOptional: true)]
        public aws.OpensearchDomain.IOpensearchDomainCognitoOptions? CognitoOptions
        {
            get;
            set;
        }

        /// <summary>domain_endpoint_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#domain_endpoint_options OpensearchDomain#domain_endpoint_options}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "domainEndpointOptions", typeJson: "{\"fqn\":\"aws.opensearchDomain.OpensearchDomainDomainEndpointOptions\"}", isOptional: true)]
        public aws.OpensearchDomain.IOpensearchDomainDomainEndpointOptions? DomainEndpointOptions
        {
            get;
            set;
        }

        /// <summary>ebs_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#ebs_options OpensearchDomain#ebs_options}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ebsOptions", typeJson: "{\"fqn\":\"aws.opensearchDomain.OpensearchDomainEbsOptions\"}", isOptional: true)]
        public aws.OpensearchDomain.IOpensearchDomainEbsOptions? EbsOptions
        {
            get;
            set;
        }

        /// <summary>encrypt_at_rest block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#encrypt_at_rest OpensearchDomain#encrypt_at_rest}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "encryptAtRest", typeJson: "{\"fqn\":\"aws.opensearchDomain.OpensearchDomainEncryptAtRest\"}", isOptional: true)]
        public aws.OpensearchDomain.IOpensearchDomainEncryptAtRest? EncryptAtRest
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#engine_version OpensearchDomain#engine_version}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "engineVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? EngineVersion
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#id OpensearchDomain#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Id
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#ip_address_type OpensearchDomain#ip_address_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ipAddressType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? IpAddressType
        {
            get;
            set;
        }

        private object? _logPublishingOptions;

        /// <summary>log_publishing_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#log_publishing_options OpensearchDomain#log_publishing_options}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "logPublishingOptions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.opensearchDomain.OpensearchDomainLogPublishingOptions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? LogPublishingOptions
        {
            get => _logPublishingOptions;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.OpensearchDomain.IOpensearchDomainLogPublishingOptions[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.OpensearchDomain.IOpensearchDomainLogPublishingOptions).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _logPublishingOptions = value;
            }
        }

        /// <summary>node_to_node_encryption block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#node_to_node_encryption OpensearchDomain#node_to_node_encryption}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "nodeToNodeEncryption", typeJson: "{\"fqn\":\"aws.opensearchDomain.OpensearchDomainNodeToNodeEncryption\"}", isOptional: true)]
        public aws.OpensearchDomain.IOpensearchDomainNodeToNodeEncryption? NodeToNodeEncryption
        {
            get;
            set;
        }

        /// <summary>off_peak_window_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#off_peak_window_options OpensearchDomain#off_peak_window_options}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "offPeakWindowOptions", typeJson: "{\"fqn\":\"aws.opensearchDomain.OpensearchDomainOffPeakWindowOptions\"}", isOptional: true)]
        public aws.OpensearchDomain.IOpensearchDomainOffPeakWindowOptions? OffPeakWindowOptions
        {
            get;
            set;
        }

        /// <summary>snapshot_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#snapshot_options OpensearchDomain#snapshot_options}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "snapshotOptions", typeJson: "{\"fqn\":\"aws.opensearchDomain.OpensearchDomainSnapshotOptions\"}", isOptional: true)]
        public aws.OpensearchDomain.IOpensearchDomainSnapshotOptions? SnapshotOptions
        {
            get;
            set;
        }

        /// <summary>software_update_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#software_update_options OpensearchDomain#software_update_options}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "softwareUpdateOptions", typeJson: "{\"fqn\":\"aws.opensearchDomain.OpensearchDomainSoftwareUpdateOptions\"}", isOptional: true)]
        public aws.OpensearchDomain.IOpensearchDomainSoftwareUpdateOptions? SoftwareUpdateOptions
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#tags OpensearchDomain#tags}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#tags_all OpensearchDomain#tags_all}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tagsAll", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? TagsAll
        {
            get;
            set;
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#timeouts OpensearchDomain#timeouts}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.opensearchDomain.OpensearchDomainTimeouts\"}", isOptional: true)]
        public aws.OpensearchDomain.IOpensearchDomainTimeouts? Timeouts
        {
            get;
            set;
        }

        /// <summary>vpc_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#vpc_options OpensearchDomain#vpc_options}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "vpcOptions", typeJson: "{\"fqn\":\"aws.opensearchDomain.OpensearchDomainVpcOptions\"}", isOptional: true)]
        public aws.OpensearchDomain.IOpensearchDomainVpcOptions? VpcOptions
        {
            get;
            set;
        }

        private object? _connection;

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.SSHProvisionerConnection\"},{\"fqn\":\"cdktf.WinrmProvisionerConnection\"}]}}", isOptional: true)]
        public object? Connection
        {
            get => _connection;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.ISSHProvisionerConnection cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IWinrmProvisionerConnection cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.ISSHProvisionerConnection).FullName}, {typeof(HashiCorp.Cdktf.IWinrmProvisionerConnection).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _connection = value;
            }
        }

        private object? _count;

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktf.TerraformCount\"}]}}", isOptional: true)]
        public object? Count
        {
            get => _count;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case double cast_cd4240:
                            break;
                        case byte cast_cd4240:
                            break;
                        case decimal cast_cd4240:
                            break;
                        case float cast_cd4240:
                            break;
                        case int cast_cd4240:
                            break;
                        case long cast_cd4240:
                            break;
                        case sbyte cast_cd4240:
                            break;
                        case short cast_cd4240:
                            break;
                        case uint cast_cd4240:
                            break;
                        case ulong cast_cd4240:
                            break;
                        case ushort cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.TerraformCount cast_cd4240:
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: double, {typeof(HashiCorp.Cdktf.TerraformCount).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _count = value;
            }
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
        public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktf.ITerraformIterator\"}", isOptional: true)]
        public HashiCorp.Cdktf.ITerraformIterator? ForEach
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true)]
        public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true)]
        public HashiCorp.Cdktf.TerraformProvider? Provider
        {
            get;
            set;
        }

        private object[]? _provisioners;

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.FileProvisioner\"},{\"fqn\":\"cdktf.LocalExecProvisioner\"},{\"fqn\":\"cdktf.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
        public object[]? Provisioners
        {
            get => _provisioners;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    for (var __idx_cd4240 = 0 ; __idx_cd4240 < value.Length ; __idx_cd4240++)
                    {
                        switch (value[__idx_cd4240])
                        {
                            case HashiCorp.Cdktf.IFileProvisioner cast_e9c63e:
                                break;
                            case HashiCorp.Cdktf.ILocalExecProvisioner cast_e9c63e:
                                break;
                            case HashiCorp.Cdktf.IRemoteExecProvisioner cast_e9c63e:
                                break;
                            case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_e9c63e:
                                // Not enough information to type-check...
                                break;
                            case null:
                                throw new System.ArgumentException($"Expected {nameof(value)}[{__idx_cd4240}] to be one of: {typeof(HashiCorp.Cdktf.IFileProvisioner).FullName}, {typeof(HashiCorp.Cdktf.ILocalExecProvisioner).FullName}, {typeof(HashiCorp.Cdktf.IRemoteExecProvisioner).FullName}; received null", nameof(value));
                            default:
                                throw new System.ArgumentException($"Expected {nameof(value)}[{__idx_cd4240}] to be one of: {typeof(HashiCorp.Cdktf.IFileProvisioner).FullName}, {typeof(HashiCorp.Cdktf.ILocalExecProvisioner).FullName}, {typeof(HashiCorp.Cdktf.IRemoteExecProvisioner).FullName}; received {value[__idx_cd4240].GetType().FullName}", nameof(value));
                        }
                    }
                }
                _provisioners = value;
            }
        }
    }
}
