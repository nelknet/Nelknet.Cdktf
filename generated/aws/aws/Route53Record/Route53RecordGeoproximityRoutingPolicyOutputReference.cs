using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Route53Record
{
    [JsiiClass(nativeType: typeof(aws.Route53Record.Route53RecordGeoproximityRoutingPolicyOutputReference), fullyQualifiedName: "aws.route53Record.Route53RecordGeoproximityRoutingPolicyOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class Route53RecordGeoproximityRoutingPolicyOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public Route53RecordGeoproximityRoutingPolicyOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Route53RecordGeoproximityRoutingPolicyOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Route53RecordGeoproximityRoutingPolicyOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCoordinates", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.route53Record.Route53RecordGeoproximityRoutingPolicyCoordinates\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutCoordinates(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.Route53Record.IRoute53RecordGeoproximityRoutingPolicyCoordinates[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Route53Record.IRoute53RecordGeoproximityRoutingPolicyCoordinates).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Route53Record.IRoute53RecordGeoproximityRoutingPolicyCoordinates).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAwsRegion")]
        public virtual void ResetAwsRegion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBias")]
        public virtual void ResetBias()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCoordinates")]
        public virtual void ResetCoordinates()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLocalZoneGroup")]
        public virtual void ResetLocalZoneGroup()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "coordinates", typeJson: "{\"fqn\":\"aws.route53Record.Route53RecordGeoproximityRoutingPolicyCoordinatesList\"}")]
        public virtual aws.Route53Record.Route53RecordGeoproximityRoutingPolicyCoordinatesList Coordinates
        {
            get => GetInstanceProperty<aws.Route53Record.Route53RecordGeoproximityRoutingPolicyCoordinatesList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "awsRegionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AwsRegionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "biasInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? BiasInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "coordinatesInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.route53Record.Route53RecordGeoproximityRoutingPolicyCoordinates\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? CoordinatesInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "localZoneGroupInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LocalZoneGroupInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "awsRegion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AwsRegion
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "bias", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Bias
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "localZoneGroup", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LocalZoneGroup
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.route53Record.Route53RecordGeoproximityRoutingPolicy\"}", isOptional: true)]
        public virtual aws.Route53Record.IRoute53RecordGeoproximityRoutingPolicy? InternalValue
        {
            get => GetInstanceProperty<aws.Route53Record.IRoute53RecordGeoproximityRoutingPolicy?>();
            set => SetInstanceProperty(value);
        }
    }
}
