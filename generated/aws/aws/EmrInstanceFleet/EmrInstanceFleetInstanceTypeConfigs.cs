using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EmrInstanceFleet
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.emrInstanceFleet.EmrInstanceFleetInstanceTypeConfigs")]
    public class EmrInstanceFleetInstanceTypeConfigs : aws.EmrInstanceFleet.IEmrInstanceFleetInstanceTypeConfigs
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_instance_fleet#instance_type EmrInstanceFleet#instance_type}.</summary>
        [JsiiProperty(name: "instanceType", typeJson: "{\"primitive\":\"string\"}")]
        public string InstanceType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_instance_fleet#bid_price EmrInstanceFleet#bid_price}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "bidPrice", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? BidPrice
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_instance_fleet#bid_price_as_percentage_of_on_demand_price EmrInstanceFleet#bid_price_as_percentage_of_on_demand_price}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "bidPriceAsPercentageOfOnDemandPrice", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? BidPriceAsPercentageOfOnDemandPrice
        {
            get;
            set;
        }

        private object? _configurations;

        /// <summary>configurations block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_instance_fleet#configurations EmrInstanceFleet#configurations}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "configurations", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.emrInstanceFleet.EmrInstanceFleetInstanceTypeConfigsConfigurations\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Configurations
        {
            get => _configurations;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.EmrInstanceFleet.IEmrInstanceFleetInstanceTypeConfigsConfigurations[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.EmrInstanceFleet.IEmrInstanceFleetInstanceTypeConfigsConfigurations).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _configurations = value;
            }
        }

        private object? _ebsConfig;

        /// <summary>ebs_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_instance_fleet#ebs_config EmrInstanceFleet#ebs_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ebsConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.emrInstanceFleet.EmrInstanceFleetInstanceTypeConfigsEbsConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? EbsConfig
        {
            get => _ebsConfig;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.EmrInstanceFleet.IEmrInstanceFleetInstanceTypeConfigsEbsConfig[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.EmrInstanceFleet.IEmrInstanceFleetInstanceTypeConfigsEbsConfig).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _ebsConfig = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_instance_fleet#weighted_capacity EmrInstanceFleet#weighted_capacity}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "weightedCapacity", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? WeightedCapacity
        {
            get;
            set;
        }
    }
}
