using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.OpensearchDomain
{
    [JsiiInterface(nativeType: typeof(IOpensearchDomainClusterConfig), fullyQualifiedName: "aws.opensearchDomain.OpensearchDomainClusterConfig")]
    public interface IOpensearchDomainClusterConfig
    {
        /// <summary>cold_storage_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#cold_storage_options OpensearchDomain#cold_storage_options}
        /// </remarks>
        [JsiiProperty(name: "coldStorageOptions", typeJson: "{\"fqn\":\"aws.opensearchDomain.OpensearchDomainClusterConfigColdStorageOptions\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.OpensearchDomain.IOpensearchDomainClusterConfigColdStorageOptions? ColdStorageOptions
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#dedicated_master_count OpensearchDomain#dedicated_master_count}.</summary>
        [JsiiProperty(name: "dedicatedMasterCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? DedicatedMasterCount
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#dedicated_master_enabled OpensearchDomain#dedicated_master_enabled}.</summary>
        [JsiiProperty(name: "dedicatedMasterEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DedicatedMasterEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#dedicated_master_type OpensearchDomain#dedicated_master_type}.</summary>
        [JsiiProperty(name: "dedicatedMasterType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DedicatedMasterType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#instance_count OpensearchDomain#instance_count}.</summary>
        [JsiiProperty(name: "instanceCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? InstanceCount
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#instance_type OpensearchDomain#instance_type}.</summary>
        [JsiiProperty(name: "instanceType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? InstanceType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#multi_az_with_standby_enabled OpensearchDomain#multi_az_with_standby_enabled}.</summary>
        [JsiiProperty(name: "multiAzWithStandbyEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? MultiAzWithStandbyEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>node_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#node_options OpensearchDomain#node_options}
        /// </remarks>
        [JsiiProperty(name: "nodeOptions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.opensearchDomain.OpensearchDomainClusterConfigNodeOptions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? NodeOptions
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#warm_count OpensearchDomain#warm_count}.</summary>
        [JsiiProperty(name: "warmCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? WarmCount
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#warm_enabled OpensearchDomain#warm_enabled}.</summary>
        [JsiiProperty(name: "warmEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? WarmEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#warm_type OpensearchDomain#warm_type}.</summary>
        [JsiiProperty(name: "warmType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? WarmType
        {
            get
            {
                return null;
            }
        }

        /// <summary>zone_awareness_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#zone_awareness_config OpensearchDomain#zone_awareness_config}
        /// </remarks>
        [JsiiProperty(name: "zoneAwarenessConfig", typeJson: "{\"fqn\":\"aws.opensearchDomain.OpensearchDomainClusterConfigZoneAwarenessConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.OpensearchDomain.IOpensearchDomainClusterConfigZoneAwarenessConfig? ZoneAwarenessConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#zone_awareness_enabled OpensearchDomain#zone_awareness_enabled}.</summary>
        [JsiiProperty(name: "zoneAwarenessEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ZoneAwarenessEnabled
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IOpensearchDomainClusterConfig), fullyQualifiedName: "aws.opensearchDomain.OpensearchDomainClusterConfig")]
        internal sealed class _Proxy : DeputyBase, aws.OpensearchDomain.IOpensearchDomainClusterConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>cold_storage_options block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#cold_storage_options OpensearchDomain#cold_storage_options}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "coldStorageOptions", typeJson: "{\"fqn\":\"aws.opensearchDomain.OpensearchDomainClusterConfigColdStorageOptions\"}", isOptional: true)]
            public aws.OpensearchDomain.IOpensearchDomainClusterConfigColdStorageOptions? ColdStorageOptions
            {
                get => GetInstanceProperty<aws.OpensearchDomain.IOpensearchDomainClusterConfigColdStorageOptions?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#dedicated_master_count OpensearchDomain#dedicated_master_count}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "dedicatedMasterCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? DedicatedMasterCount
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#dedicated_master_enabled OpensearchDomain#dedicated_master_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "dedicatedMasterEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? DedicatedMasterEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#dedicated_master_type OpensearchDomain#dedicated_master_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "dedicatedMasterType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DedicatedMasterType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#instance_count OpensearchDomain#instance_count}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "instanceCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? InstanceCount
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#instance_type OpensearchDomain#instance_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "instanceType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? InstanceType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#multi_az_with_standby_enabled OpensearchDomain#multi_az_with_standby_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "multiAzWithStandbyEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? MultiAzWithStandbyEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>node_options block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#node_options OpensearchDomain#node_options}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "nodeOptions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.opensearchDomain.OpensearchDomainClusterConfigNodeOptions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? NodeOptions
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#warm_count OpensearchDomain#warm_count}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "warmCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? WarmCount
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#warm_enabled OpensearchDomain#warm_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "warmEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? WarmEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#warm_type OpensearchDomain#warm_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "warmType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? WarmType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>zone_awareness_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#zone_awareness_config OpensearchDomain#zone_awareness_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "zoneAwarenessConfig", typeJson: "{\"fqn\":\"aws.opensearchDomain.OpensearchDomainClusterConfigZoneAwarenessConfig\"}", isOptional: true)]
            public aws.OpensearchDomain.IOpensearchDomainClusterConfigZoneAwarenessConfig? ZoneAwarenessConfig
            {
                get => GetInstanceProperty<aws.OpensearchDomain.IOpensearchDomainClusterConfigZoneAwarenessConfig?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#zone_awareness_enabled OpensearchDomain#zone_awareness_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "zoneAwarenessEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? ZoneAwarenessEnabled
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
