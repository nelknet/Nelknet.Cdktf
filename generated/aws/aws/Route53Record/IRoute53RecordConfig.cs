using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Route53Record
{
    [JsiiInterface(nativeType: typeof(IRoute53RecordConfig), fullyQualifiedName: "aws.route53Record.Route53RecordConfig")]
    public interface IRoute53RecordConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_record#name Route53Record#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_record#type Route53Record#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_record#zone_id Route53Record#zone_id}.</summary>
        [JsiiProperty(name: "zoneId", typeJson: "{\"primitive\":\"string\"}")]
        string ZoneId
        {
            get;
        }

        /// <summary>alias block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_record#alias Route53Record#alias}
        /// </remarks>
        [JsiiProperty(name: "alias", typeJson: "{\"fqn\":\"aws.route53Record.Route53RecordAlias\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Route53Record.IRoute53RecordAlias? Alias
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_record#allow_overwrite Route53Record#allow_overwrite}.</summary>
        [JsiiProperty(name: "allowOverwrite", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AllowOverwrite
        {
            get
            {
                return null;
            }
        }

        /// <summary>cidr_routing_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_record#cidr_routing_policy Route53Record#cidr_routing_policy}
        /// </remarks>
        [JsiiProperty(name: "cidrRoutingPolicy", typeJson: "{\"fqn\":\"aws.route53Record.Route53RecordCidrRoutingPolicy\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Route53Record.IRoute53RecordCidrRoutingPolicy? CidrRoutingPolicy
        {
            get
            {
                return null;
            }
        }

        /// <summary>failover_routing_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_record#failover_routing_policy Route53Record#failover_routing_policy}
        /// </remarks>
        [JsiiProperty(name: "failoverRoutingPolicy", typeJson: "{\"fqn\":\"aws.route53Record.Route53RecordFailoverRoutingPolicy\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Route53Record.IRoute53RecordFailoverRoutingPolicy? FailoverRoutingPolicy
        {
            get
            {
                return null;
            }
        }

        /// <summary>geolocation_routing_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_record#geolocation_routing_policy Route53Record#geolocation_routing_policy}
        /// </remarks>
        [JsiiProperty(name: "geolocationRoutingPolicy", typeJson: "{\"fqn\":\"aws.route53Record.Route53RecordGeolocationRoutingPolicy\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Route53Record.IRoute53RecordGeolocationRoutingPolicy? GeolocationRoutingPolicy
        {
            get
            {
                return null;
            }
        }

        /// <summary>geoproximity_routing_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_record#geoproximity_routing_policy Route53Record#geoproximity_routing_policy}
        /// </remarks>
        [JsiiProperty(name: "geoproximityRoutingPolicy", typeJson: "{\"fqn\":\"aws.route53Record.Route53RecordGeoproximityRoutingPolicy\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Route53Record.IRoute53RecordGeoproximityRoutingPolicy? GeoproximityRoutingPolicy
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_record#health_check_id Route53Record#health_check_id}.</summary>
        [JsiiProperty(name: "healthCheckId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? HealthCheckId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_record#id Route53Record#id}.</summary>
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

        /// <summary>latency_routing_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_record#latency_routing_policy Route53Record#latency_routing_policy}
        /// </remarks>
        [JsiiProperty(name: "latencyRoutingPolicy", typeJson: "{\"fqn\":\"aws.route53Record.Route53RecordLatencyRoutingPolicy\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Route53Record.IRoute53RecordLatencyRoutingPolicy? LatencyRoutingPolicy
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_record#multivalue_answer_routing_policy Route53Record#multivalue_answer_routing_policy}.</summary>
        [JsiiProperty(name: "multivalueAnswerRoutingPolicy", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? MultivalueAnswerRoutingPolicy
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_record#records Route53Record#records}.</summary>
        [JsiiProperty(name: "records", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Records
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_record#set_identifier Route53Record#set_identifier}.</summary>
        [JsiiProperty(name: "setIdentifier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SetIdentifier
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_record#timeouts Route53Record#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.route53Record.Route53RecordTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Route53Record.IRoute53RecordTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_record#ttl Route53Record#ttl}.</summary>
        [JsiiProperty(name: "ttl", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Ttl
        {
            get
            {
                return null;
            }
        }

        /// <summary>weighted_routing_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_record#weighted_routing_policy Route53Record#weighted_routing_policy}
        /// </remarks>
        [JsiiProperty(name: "weightedRoutingPolicy", typeJson: "{\"fqn\":\"aws.route53Record.Route53RecordWeightedRoutingPolicy\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Route53Record.IRoute53RecordWeightedRoutingPolicy? WeightedRoutingPolicy
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IRoute53RecordConfig), fullyQualifiedName: "aws.route53Record.Route53RecordConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Route53Record.IRoute53RecordConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_record#name Route53Record#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_record#type Route53Record#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_record#zone_id Route53Record#zone_id}.</summary>
            [JsiiProperty(name: "zoneId", typeJson: "{\"primitive\":\"string\"}")]
            public string ZoneId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>alias block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_record#alias Route53Record#alias}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "alias", typeJson: "{\"fqn\":\"aws.route53Record.Route53RecordAlias\"}", isOptional: true)]
            public aws.Route53Record.IRoute53RecordAlias? Alias
            {
                get => GetInstanceProperty<aws.Route53Record.IRoute53RecordAlias?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_record#allow_overwrite Route53Record#allow_overwrite}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "allowOverwrite", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? AllowOverwrite
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>cidr_routing_policy block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_record#cidr_routing_policy Route53Record#cidr_routing_policy}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cidrRoutingPolicy", typeJson: "{\"fqn\":\"aws.route53Record.Route53RecordCidrRoutingPolicy\"}", isOptional: true)]
            public aws.Route53Record.IRoute53RecordCidrRoutingPolicy? CidrRoutingPolicy
            {
                get => GetInstanceProperty<aws.Route53Record.IRoute53RecordCidrRoutingPolicy?>();
            }

            /// <summary>failover_routing_policy block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_record#failover_routing_policy Route53Record#failover_routing_policy}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "failoverRoutingPolicy", typeJson: "{\"fqn\":\"aws.route53Record.Route53RecordFailoverRoutingPolicy\"}", isOptional: true)]
            public aws.Route53Record.IRoute53RecordFailoverRoutingPolicy? FailoverRoutingPolicy
            {
                get => GetInstanceProperty<aws.Route53Record.IRoute53RecordFailoverRoutingPolicy?>();
            }

            /// <summary>geolocation_routing_policy block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_record#geolocation_routing_policy Route53Record#geolocation_routing_policy}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "geolocationRoutingPolicy", typeJson: "{\"fqn\":\"aws.route53Record.Route53RecordGeolocationRoutingPolicy\"}", isOptional: true)]
            public aws.Route53Record.IRoute53RecordGeolocationRoutingPolicy? GeolocationRoutingPolicy
            {
                get => GetInstanceProperty<aws.Route53Record.IRoute53RecordGeolocationRoutingPolicy?>();
            }

            /// <summary>geoproximity_routing_policy block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_record#geoproximity_routing_policy Route53Record#geoproximity_routing_policy}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "geoproximityRoutingPolicy", typeJson: "{\"fqn\":\"aws.route53Record.Route53RecordGeoproximityRoutingPolicy\"}", isOptional: true)]
            public aws.Route53Record.IRoute53RecordGeoproximityRoutingPolicy? GeoproximityRoutingPolicy
            {
                get => GetInstanceProperty<aws.Route53Record.IRoute53RecordGeoproximityRoutingPolicy?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_record#health_check_id Route53Record#health_check_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "healthCheckId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? HealthCheckId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_record#id Route53Record#id}.</summary>
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

            /// <summary>latency_routing_policy block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_record#latency_routing_policy Route53Record#latency_routing_policy}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "latencyRoutingPolicy", typeJson: "{\"fqn\":\"aws.route53Record.Route53RecordLatencyRoutingPolicy\"}", isOptional: true)]
            public aws.Route53Record.IRoute53RecordLatencyRoutingPolicy? LatencyRoutingPolicy
            {
                get => GetInstanceProperty<aws.Route53Record.IRoute53RecordLatencyRoutingPolicy?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_record#multivalue_answer_routing_policy Route53Record#multivalue_answer_routing_policy}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "multivalueAnswerRoutingPolicy", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? MultivalueAnswerRoutingPolicy
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_record#records Route53Record#records}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "records", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Records
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_record#set_identifier Route53Record#set_identifier}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "setIdentifier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SetIdentifier
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_record#timeouts Route53Record#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.route53Record.Route53RecordTimeouts\"}", isOptional: true)]
            public aws.Route53Record.IRoute53RecordTimeouts? Timeouts
            {
                get => GetInstanceProperty<aws.Route53Record.IRoute53RecordTimeouts?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_record#ttl Route53Record#ttl}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ttl", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Ttl
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>weighted_routing_policy block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_record#weighted_routing_policy Route53Record#weighted_routing_policy}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "weightedRoutingPolicy", typeJson: "{\"fqn\":\"aws.route53Record.Route53RecordWeightedRoutingPolicy\"}", isOptional: true)]
            public aws.Route53Record.IRoute53RecordWeightedRoutingPolicy? WeightedRoutingPolicy
            {
                get => GetInstanceProperty<aws.Route53Record.IRoute53RecordWeightedRoutingPolicy?>();
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
