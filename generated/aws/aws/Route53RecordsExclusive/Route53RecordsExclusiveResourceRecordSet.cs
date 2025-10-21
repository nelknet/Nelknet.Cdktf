using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Route53RecordsExclusive
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.route53RecordsExclusive.Route53RecordsExclusiveResourceRecordSet")]
    public class Route53RecordsExclusiveResourceRecordSet : aws.Route53RecordsExclusive.IRoute53RecordsExclusiveResourceRecordSet
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_records_exclusive#name Route53RecordsExclusive#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        private object? _aliasTarget;

        /// <summary>alias_target block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_records_exclusive#alias_target Route53RecordsExclusive#alias_target}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "aliasTarget", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.route53RecordsExclusive.Route53RecordsExclusiveResourceRecordSetAliasTarget\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? AliasTarget
        {
            get => _aliasTarget;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.Route53RecordsExclusive.IRoute53RecordsExclusiveResourceRecordSetAliasTarget[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Route53RecordsExclusive.IRoute53RecordsExclusiveResourceRecordSetAliasTarget).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _aliasTarget = value;
            }
        }

        private object? _cidrRoutingConfig;

        /// <summary>cidr_routing_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_records_exclusive#cidr_routing_config Route53RecordsExclusive#cidr_routing_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cidrRoutingConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.route53RecordsExclusive.Route53RecordsExclusiveResourceRecordSetCidrRoutingConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? CidrRoutingConfig
        {
            get => _cidrRoutingConfig;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.Route53RecordsExclusive.IRoute53RecordsExclusiveResourceRecordSetCidrRoutingConfig[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Route53RecordsExclusive.IRoute53RecordsExclusiveResourceRecordSetCidrRoutingConfig).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _cidrRoutingConfig = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_records_exclusive#failover Route53RecordsExclusive#failover}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "failover", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Failover
        {
            get;
            set;
        }

        private object? _geolocation;

        /// <summary>geolocation block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_records_exclusive#geolocation Route53RecordsExclusive#geolocation}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "geolocation", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.route53RecordsExclusive.Route53RecordsExclusiveResourceRecordSetGeolocation\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Geolocation
        {
            get => _geolocation;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.Route53RecordsExclusive.IRoute53RecordsExclusiveResourceRecordSetGeolocation[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Route53RecordsExclusive.IRoute53RecordsExclusiveResourceRecordSetGeolocation).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _geolocation = value;
            }
        }

        private object? _geoproximityLocation;

        /// <summary>geoproximity_location block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_records_exclusive#geoproximity_location Route53RecordsExclusive#geoproximity_location}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "geoproximityLocation", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.route53RecordsExclusive.Route53RecordsExclusiveResourceRecordSetGeoproximityLocation\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? GeoproximityLocation
        {
            get => _geoproximityLocation;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.Route53RecordsExclusive.IRoute53RecordsExclusiveResourceRecordSetGeoproximityLocation[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Route53RecordsExclusive.IRoute53RecordsExclusiveResourceRecordSetGeoproximityLocation).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _geoproximityLocation = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_records_exclusive#health_check_id Route53RecordsExclusive#health_check_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "healthCheckId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? HealthCheckId
        {
            get;
            set;
        }

        private object? _multiValueAnswer;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_records_exclusive#multi_value_answer Route53RecordsExclusive#multi_value_answer}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "multiValueAnswer", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? MultiValueAnswer
        {
            get => _multiValueAnswer;
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
                _multiValueAnswer = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_records_exclusive#region Route53RecordsExclusive#region}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Region
        {
            get;
            set;
        }

        private object? _resourceRecords;

        /// <summary>resource_records block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_records_exclusive#resource_records Route53RecordsExclusive#resource_records}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "resourceRecords", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.route53RecordsExclusive.Route53RecordsExclusiveResourceRecordSetResourceRecords\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ResourceRecords
        {
            get => _resourceRecords;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.Route53RecordsExclusive.IRoute53RecordsExclusiveResourceRecordSetResourceRecords[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Route53RecordsExclusive.IRoute53RecordsExclusiveResourceRecordSetResourceRecords).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _resourceRecords = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_records_exclusive#set_identifier Route53RecordsExclusive#set_identifier}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "setIdentifier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SetIdentifier
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_records_exclusive#traffic_policy_instance_id Route53RecordsExclusive#traffic_policy_instance_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "trafficPolicyInstanceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TrafficPolicyInstanceId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_records_exclusive#ttl Route53RecordsExclusive#ttl}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ttl", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Ttl
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_records_exclusive#type Route53RecordsExclusive#type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Type
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_records_exclusive#weight Route53RecordsExclusive#weight}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "weight", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Weight
        {
            get;
            set;
        }
    }
}
