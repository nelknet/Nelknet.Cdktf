using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.OpensearchDomain
{
    [JsiiInterface(nativeType: typeof(IOpensearchDomainConfig), fullyQualifiedName: "aws.opensearchDomain.OpensearchDomainConfig")]
    public interface IOpensearchDomainConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#domain_name OpensearchDomain#domain_name}.</summary>
        [JsiiProperty(name: "domainName", typeJson: "{\"primitive\":\"string\"}")]
        string DomainName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#access_policies OpensearchDomain#access_policies}.</summary>
        [JsiiProperty(name: "accessPolicies", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AccessPolicies
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#advanced_options OpensearchDomain#advanced_options}.</summary>
        [JsiiProperty(name: "advancedOptions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? AdvancedOptions
        {
            get
            {
                return null;
            }
        }

        /// <summary>advanced_security_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#advanced_security_options OpensearchDomain#advanced_security_options}
        /// </remarks>
        [JsiiProperty(name: "advancedSecurityOptions", typeJson: "{\"fqn\":\"aws.opensearchDomain.OpensearchDomainAdvancedSecurityOptions\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.OpensearchDomain.IOpensearchDomainAdvancedSecurityOptions? AdvancedSecurityOptions
        {
            get
            {
                return null;
            }
        }

        /// <summary>auto_tune_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#auto_tune_options OpensearchDomain#auto_tune_options}
        /// </remarks>
        [JsiiProperty(name: "autoTuneOptions", typeJson: "{\"fqn\":\"aws.opensearchDomain.OpensearchDomainAutoTuneOptions\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.OpensearchDomain.IOpensearchDomainAutoTuneOptions? AutoTuneOptions
        {
            get
            {
                return null;
            }
        }

        /// <summary>cluster_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#cluster_config OpensearchDomain#cluster_config}
        /// </remarks>
        [JsiiProperty(name: "clusterConfig", typeJson: "{\"fqn\":\"aws.opensearchDomain.OpensearchDomainClusterConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.OpensearchDomain.IOpensearchDomainClusterConfig? ClusterConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>cognito_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#cognito_options OpensearchDomain#cognito_options}
        /// </remarks>
        [JsiiProperty(name: "cognitoOptions", typeJson: "{\"fqn\":\"aws.opensearchDomain.OpensearchDomainCognitoOptions\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.OpensearchDomain.IOpensearchDomainCognitoOptions? CognitoOptions
        {
            get
            {
                return null;
            }
        }

        /// <summary>domain_endpoint_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#domain_endpoint_options OpensearchDomain#domain_endpoint_options}
        /// </remarks>
        [JsiiProperty(name: "domainEndpointOptions", typeJson: "{\"fqn\":\"aws.opensearchDomain.OpensearchDomainDomainEndpointOptions\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.OpensearchDomain.IOpensearchDomainDomainEndpointOptions? DomainEndpointOptions
        {
            get
            {
                return null;
            }
        }

        /// <summary>ebs_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#ebs_options OpensearchDomain#ebs_options}
        /// </remarks>
        [JsiiProperty(name: "ebsOptions", typeJson: "{\"fqn\":\"aws.opensearchDomain.OpensearchDomainEbsOptions\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.OpensearchDomain.IOpensearchDomainEbsOptions? EbsOptions
        {
            get
            {
                return null;
            }
        }

        /// <summary>encrypt_at_rest block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#encrypt_at_rest OpensearchDomain#encrypt_at_rest}
        /// </remarks>
        [JsiiProperty(name: "encryptAtRest", typeJson: "{\"fqn\":\"aws.opensearchDomain.OpensearchDomainEncryptAtRest\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.OpensearchDomain.IOpensearchDomainEncryptAtRest? EncryptAtRest
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#engine_version OpensearchDomain#engine_version}.</summary>
        [JsiiProperty(name: "engineVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? EngineVersion
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#id OpensearchDomain#id}.</summary>
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#ip_address_type OpensearchDomain#ip_address_type}.</summary>
        [JsiiProperty(name: "ipAddressType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? IpAddressType
        {
            get
            {
                return null;
            }
        }

        /// <summary>log_publishing_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#log_publishing_options OpensearchDomain#log_publishing_options}
        /// </remarks>
        [JsiiProperty(name: "logPublishingOptions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.opensearchDomain.OpensearchDomainLogPublishingOptions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? LogPublishingOptions
        {
            get
            {
                return null;
            }
        }

        /// <summary>node_to_node_encryption block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#node_to_node_encryption OpensearchDomain#node_to_node_encryption}
        /// </remarks>
        [JsiiProperty(name: "nodeToNodeEncryption", typeJson: "{\"fqn\":\"aws.opensearchDomain.OpensearchDomainNodeToNodeEncryption\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.OpensearchDomain.IOpensearchDomainNodeToNodeEncryption? NodeToNodeEncryption
        {
            get
            {
                return null;
            }
        }

        /// <summary>off_peak_window_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#off_peak_window_options OpensearchDomain#off_peak_window_options}
        /// </remarks>
        [JsiiProperty(name: "offPeakWindowOptions", typeJson: "{\"fqn\":\"aws.opensearchDomain.OpensearchDomainOffPeakWindowOptions\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.OpensearchDomain.IOpensearchDomainOffPeakWindowOptions? OffPeakWindowOptions
        {
            get
            {
                return null;
            }
        }

        /// <summary>snapshot_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#snapshot_options OpensearchDomain#snapshot_options}
        /// </remarks>
        [JsiiProperty(name: "snapshotOptions", typeJson: "{\"fqn\":\"aws.opensearchDomain.OpensearchDomainSnapshotOptions\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.OpensearchDomain.IOpensearchDomainSnapshotOptions? SnapshotOptions
        {
            get
            {
                return null;
            }
        }

        /// <summary>software_update_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#software_update_options OpensearchDomain#software_update_options}
        /// </remarks>
        [JsiiProperty(name: "softwareUpdateOptions", typeJson: "{\"fqn\":\"aws.opensearchDomain.OpensearchDomainSoftwareUpdateOptions\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.OpensearchDomain.IOpensearchDomainSoftwareUpdateOptions? SoftwareUpdateOptions
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#tags OpensearchDomain#tags}.</summary>
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#tags_all OpensearchDomain#tags_all}.</summary>
        [JsiiProperty(name: "tagsAll", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? TagsAll
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#timeouts OpensearchDomain#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.opensearchDomain.OpensearchDomainTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.OpensearchDomain.IOpensearchDomainTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        /// <summary>vpc_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#vpc_options OpensearchDomain#vpc_options}
        /// </remarks>
        [JsiiProperty(name: "vpcOptions", typeJson: "{\"fqn\":\"aws.opensearchDomain.OpensearchDomainVpcOptions\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.OpensearchDomain.IOpensearchDomainVpcOptions? VpcOptions
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IOpensearchDomainConfig), fullyQualifiedName: "aws.opensearchDomain.OpensearchDomainConfig")]
        internal sealed class _Proxy : DeputyBase, aws.OpensearchDomain.IOpensearchDomainConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#domain_name OpensearchDomain#domain_name}.</summary>
            [JsiiProperty(name: "domainName", typeJson: "{\"primitive\":\"string\"}")]
            public string DomainName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#access_policies OpensearchDomain#access_policies}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "accessPolicies", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AccessPolicies
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#advanced_options OpensearchDomain#advanced_options}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "advancedOptions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? AdvancedOptions
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>advanced_security_options block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#advanced_security_options OpensearchDomain#advanced_security_options}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "advancedSecurityOptions", typeJson: "{\"fqn\":\"aws.opensearchDomain.OpensearchDomainAdvancedSecurityOptions\"}", isOptional: true)]
            public aws.OpensearchDomain.IOpensearchDomainAdvancedSecurityOptions? AdvancedSecurityOptions
            {
                get => GetInstanceProperty<aws.OpensearchDomain.IOpensearchDomainAdvancedSecurityOptions?>();
            }

            /// <summary>auto_tune_options block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#auto_tune_options OpensearchDomain#auto_tune_options}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "autoTuneOptions", typeJson: "{\"fqn\":\"aws.opensearchDomain.OpensearchDomainAutoTuneOptions\"}", isOptional: true)]
            public aws.OpensearchDomain.IOpensearchDomainAutoTuneOptions? AutoTuneOptions
            {
                get => GetInstanceProperty<aws.OpensearchDomain.IOpensearchDomainAutoTuneOptions?>();
            }

            /// <summary>cluster_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#cluster_config OpensearchDomain#cluster_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "clusterConfig", typeJson: "{\"fqn\":\"aws.opensearchDomain.OpensearchDomainClusterConfig\"}", isOptional: true)]
            public aws.OpensearchDomain.IOpensearchDomainClusterConfig? ClusterConfig
            {
                get => GetInstanceProperty<aws.OpensearchDomain.IOpensearchDomainClusterConfig?>();
            }

            /// <summary>cognito_options block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#cognito_options OpensearchDomain#cognito_options}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cognitoOptions", typeJson: "{\"fqn\":\"aws.opensearchDomain.OpensearchDomainCognitoOptions\"}", isOptional: true)]
            public aws.OpensearchDomain.IOpensearchDomainCognitoOptions? CognitoOptions
            {
                get => GetInstanceProperty<aws.OpensearchDomain.IOpensearchDomainCognitoOptions?>();
            }

            /// <summary>domain_endpoint_options block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#domain_endpoint_options OpensearchDomain#domain_endpoint_options}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "domainEndpointOptions", typeJson: "{\"fqn\":\"aws.opensearchDomain.OpensearchDomainDomainEndpointOptions\"}", isOptional: true)]
            public aws.OpensearchDomain.IOpensearchDomainDomainEndpointOptions? DomainEndpointOptions
            {
                get => GetInstanceProperty<aws.OpensearchDomain.IOpensearchDomainDomainEndpointOptions?>();
            }

            /// <summary>ebs_options block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#ebs_options OpensearchDomain#ebs_options}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ebsOptions", typeJson: "{\"fqn\":\"aws.opensearchDomain.OpensearchDomainEbsOptions\"}", isOptional: true)]
            public aws.OpensearchDomain.IOpensearchDomainEbsOptions? EbsOptions
            {
                get => GetInstanceProperty<aws.OpensearchDomain.IOpensearchDomainEbsOptions?>();
            }

            /// <summary>encrypt_at_rest block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#encrypt_at_rest OpensearchDomain#encrypt_at_rest}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "encryptAtRest", typeJson: "{\"fqn\":\"aws.opensearchDomain.OpensearchDomainEncryptAtRest\"}", isOptional: true)]
            public aws.OpensearchDomain.IOpensearchDomainEncryptAtRest? EncryptAtRest
            {
                get => GetInstanceProperty<aws.OpensearchDomain.IOpensearchDomainEncryptAtRest?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#engine_version OpensearchDomain#engine_version}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "engineVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EngineVersion
            {
                get => GetInstanceProperty<string?>();
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
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#ip_address_type OpensearchDomain#ip_address_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ipAddressType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? IpAddressType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>log_publishing_options block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#log_publishing_options OpensearchDomain#log_publishing_options}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "logPublishingOptions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.opensearchDomain.OpensearchDomainLogPublishingOptions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? LogPublishingOptions
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>node_to_node_encryption block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#node_to_node_encryption OpensearchDomain#node_to_node_encryption}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "nodeToNodeEncryption", typeJson: "{\"fqn\":\"aws.opensearchDomain.OpensearchDomainNodeToNodeEncryption\"}", isOptional: true)]
            public aws.OpensearchDomain.IOpensearchDomainNodeToNodeEncryption? NodeToNodeEncryption
            {
                get => GetInstanceProperty<aws.OpensearchDomain.IOpensearchDomainNodeToNodeEncryption?>();
            }

            /// <summary>off_peak_window_options block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#off_peak_window_options OpensearchDomain#off_peak_window_options}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "offPeakWindowOptions", typeJson: "{\"fqn\":\"aws.opensearchDomain.OpensearchDomainOffPeakWindowOptions\"}", isOptional: true)]
            public aws.OpensearchDomain.IOpensearchDomainOffPeakWindowOptions? OffPeakWindowOptions
            {
                get => GetInstanceProperty<aws.OpensearchDomain.IOpensearchDomainOffPeakWindowOptions?>();
            }

            /// <summary>snapshot_options block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#snapshot_options OpensearchDomain#snapshot_options}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "snapshotOptions", typeJson: "{\"fqn\":\"aws.opensearchDomain.OpensearchDomainSnapshotOptions\"}", isOptional: true)]
            public aws.OpensearchDomain.IOpensearchDomainSnapshotOptions? SnapshotOptions
            {
                get => GetInstanceProperty<aws.OpensearchDomain.IOpensearchDomainSnapshotOptions?>();
            }

            /// <summary>software_update_options block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#software_update_options OpensearchDomain#software_update_options}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "softwareUpdateOptions", typeJson: "{\"fqn\":\"aws.opensearchDomain.OpensearchDomainSoftwareUpdateOptions\"}", isOptional: true)]
            public aws.OpensearchDomain.IOpensearchDomainSoftwareUpdateOptions? SoftwareUpdateOptions
            {
                get => GetInstanceProperty<aws.OpensearchDomain.IOpensearchDomainSoftwareUpdateOptions?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#tags OpensearchDomain#tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#tags_all OpensearchDomain#tags_all}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tagsAll", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? TagsAll
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#timeouts OpensearchDomain#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.opensearchDomain.OpensearchDomainTimeouts\"}", isOptional: true)]
            public aws.OpensearchDomain.IOpensearchDomainTimeouts? Timeouts
            {
                get => GetInstanceProperty<aws.OpensearchDomain.IOpensearchDomainTimeouts?>();
            }

            /// <summary>vpc_options block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#vpc_options OpensearchDomain#vpc_options}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "vpcOptions", typeJson: "{\"fqn\":\"aws.opensearchDomain.OpensearchDomainVpcOptions\"}", isOptional: true)]
            public aws.OpensearchDomain.IOpensearchDomainVpcOptions? VpcOptions
            {
                get => GetInstanceProperty<aws.OpensearchDomain.IOpensearchDomainVpcOptions?>();
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
