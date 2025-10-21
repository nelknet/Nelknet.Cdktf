using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.VpclatticeTargetGroup
{
    [JsiiByValue(fqn: "aws.vpclatticeTargetGroup.VpclatticeTargetGroupConfigHealthCheck")]
    public class VpclatticeTargetGroupConfigHealthCheck : aws.VpclatticeTargetGroup.IVpclatticeTargetGroupConfigHealthCheck
    {
        private object? _enabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_target_group#enabled VpclatticeTargetGroup#enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? Enabled
        {
            get => _enabled;
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
                _enabled = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_target_group#health_check_interval_seconds VpclatticeTargetGroup#health_check_interval_seconds}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "healthCheckIntervalSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? HealthCheckIntervalSeconds
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_target_group#health_check_timeout_seconds VpclatticeTargetGroup#health_check_timeout_seconds}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "healthCheckTimeoutSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? HealthCheckTimeoutSeconds
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_target_group#healthy_threshold_count VpclatticeTargetGroup#healthy_threshold_count}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "healthyThresholdCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? HealthyThresholdCount
        {
            get;
            set;
        }

        /// <summary>matcher block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_target_group#matcher VpclatticeTargetGroup#matcher}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "matcher", typeJson: "{\"fqn\":\"aws.vpclatticeTargetGroup.VpclatticeTargetGroupConfigHealthCheckMatcher\"}", isOptional: true)]
        public aws.VpclatticeTargetGroup.IVpclatticeTargetGroupConfigHealthCheckMatcher? Matcher
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_target_group#path VpclatticeTargetGroup#path}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Path
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_target_group#port VpclatticeTargetGroup#port}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Port
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_target_group#protocol VpclatticeTargetGroup#protocol}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Protocol
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_target_group#protocol_version VpclatticeTargetGroup#protocol_version}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "protocolVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ProtocolVersion
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_target_group#unhealthy_threshold_count VpclatticeTargetGroup#unhealthy_threshold_count}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "unhealthyThresholdCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? UnhealthyThresholdCount
        {
            get;
            set;
        }
    }
}
