using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ec2Fleet
{
    [JsiiByValue(fqn: "aws.ec2Fleet.Ec2FleetSpotOptions")]
    public class Ec2FleetSpotOptions : aws.Ec2Fleet.IEc2FleetSpotOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_fleet#allocation_strategy Ec2Fleet#allocation_strategy}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "allocationStrategy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AllocationStrategy
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_fleet#instance_interruption_behavior Ec2Fleet#instance_interruption_behavior}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "instanceInterruptionBehavior", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? InstanceInterruptionBehavior
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_fleet#instance_pools_to_use_count Ec2Fleet#instance_pools_to_use_count}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "instancePoolsToUseCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? InstancePoolsToUseCount
        {
            get;
            set;
        }

        /// <summary>maintenance_strategies block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_fleet#maintenance_strategies Ec2Fleet#maintenance_strategies}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "maintenanceStrategies", typeJson: "{\"fqn\":\"aws.ec2Fleet.Ec2FleetSpotOptionsMaintenanceStrategies\"}", isOptional: true)]
        public aws.Ec2Fleet.IEc2FleetSpotOptionsMaintenanceStrategies? MaintenanceStrategies
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_fleet#max_total_price Ec2Fleet#max_total_price}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxTotalPrice", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MaxTotalPrice
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_fleet#min_target_capacity Ec2Fleet#min_target_capacity}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "minTargetCapacity", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MinTargetCapacity
        {
            get;
            set;
        }

        private object? _singleAvailabilityZone;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_fleet#single_availability_zone Ec2Fleet#single_availability_zone}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "singleAvailabilityZone", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? SingleAvailabilityZone
        {
            get => _singleAvailabilityZone;
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
                _singleAvailabilityZone = value;
            }
        }

        private object? _singleInstanceType;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_fleet#single_instance_type Ec2Fleet#single_instance_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "singleInstanceType", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? SingleInstanceType
        {
            get => _singleInstanceType;
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
                _singleInstanceType = value;
            }
        }
    }
}
