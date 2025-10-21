using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ElasticsearchDomain
{
    [JsiiByValue(fqn: "aws.elasticsearchDomain.ElasticsearchDomainClusterConfig")]
    public class ElasticsearchDomainClusterConfig : aws.ElasticsearchDomain.IElasticsearchDomainClusterConfig
    {
        /// <summary>cold_storage_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticsearch_domain#cold_storage_options ElasticsearchDomain#cold_storage_options}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "coldStorageOptions", typeJson: "{\"fqn\":\"aws.elasticsearchDomain.ElasticsearchDomainClusterConfigColdStorageOptions\"}", isOptional: true)]
        public aws.ElasticsearchDomain.IElasticsearchDomainClusterConfigColdStorageOptions? ColdStorageOptions
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticsearch_domain#dedicated_master_count ElasticsearchDomain#dedicated_master_count}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dedicatedMasterCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? DedicatedMasterCount
        {
            get;
            set;
        }

        private object? _dedicatedMasterEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticsearch_domain#dedicated_master_enabled ElasticsearchDomain#dedicated_master_enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dedicatedMasterEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? DedicatedMasterEnabled
        {
            get => _dedicatedMasterEnabled;
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
                _dedicatedMasterEnabled = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticsearch_domain#dedicated_master_type ElasticsearchDomain#dedicated_master_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dedicatedMasterType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DedicatedMasterType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticsearch_domain#instance_count ElasticsearchDomain#instance_count}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "instanceCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? InstanceCount
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticsearch_domain#instance_type ElasticsearchDomain#instance_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "instanceType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? InstanceType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticsearch_domain#warm_count ElasticsearchDomain#warm_count}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "warmCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? WarmCount
        {
            get;
            set;
        }

        private object? _warmEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticsearch_domain#warm_enabled ElasticsearchDomain#warm_enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "warmEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? WarmEnabled
        {
            get => _warmEnabled;
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
                _warmEnabled = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticsearch_domain#warm_type ElasticsearchDomain#warm_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "warmType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? WarmType
        {
            get;
            set;
        }

        /// <summary>zone_awareness_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticsearch_domain#zone_awareness_config ElasticsearchDomain#zone_awareness_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "zoneAwarenessConfig", typeJson: "{\"fqn\":\"aws.elasticsearchDomain.ElasticsearchDomainClusterConfigZoneAwarenessConfig\"}", isOptional: true)]
        public aws.ElasticsearchDomain.IElasticsearchDomainClusterConfigZoneAwarenessConfig? ZoneAwarenessConfig
        {
            get;
            set;
        }

        private object? _zoneAwarenessEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticsearch_domain#zone_awareness_enabled ElasticsearchDomain#zone_awareness_enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "zoneAwarenessEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? ZoneAwarenessEnabled
        {
            get => _zoneAwarenessEnabled;
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
                _zoneAwarenessEnabled = value;
            }
        }
    }
}
