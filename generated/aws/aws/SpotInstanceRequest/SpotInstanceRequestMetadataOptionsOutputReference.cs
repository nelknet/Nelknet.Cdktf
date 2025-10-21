using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SpotInstanceRequest
{
    [JsiiClass(nativeType: typeof(aws.SpotInstanceRequest.SpotInstanceRequestMetadataOptionsOutputReference), fullyQualifiedName: "aws.spotInstanceRequest.SpotInstanceRequestMetadataOptionsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class SpotInstanceRequestMetadataOptionsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public SpotInstanceRequestMetadataOptionsOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected SpotInstanceRequestMetadataOptionsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SpotInstanceRequestMetadataOptionsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetHttpEndpoint")]
        public virtual void ResetHttpEndpoint()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHttpProtocolIpv6")]
        public virtual void ResetHttpProtocolIpv6()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHttpPutResponseHopLimit")]
        public virtual void ResetHttpPutResponseHopLimit()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHttpTokens")]
        public virtual void ResetHttpTokens()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInstanceMetadataTags")]
        public virtual void ResetInstanceMetadataTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "httpEndpointInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? HttpEndpointInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "httpProtocolIpv6Input", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? HttpProtocolIpv6Input
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "httpPutResponseHopLimitInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? HttpPutResponseHopLimitInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "httpTokensInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? HttpTokensInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "instanceMetadataTagsInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? InstanceMetadataTagsInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "httpEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HttpEndpoint
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "httpProtocolIpv6", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HttpProtocolIpv6
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "httpPutResponseHopLimit", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double HttpPutResponseHopLimit
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "httpTokens", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HttpTokens
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "instanceMetadataTags", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InstanceMetadataTags
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.spotInstanceRequest.SpotInstanceRequestMetadataOptions\"}", isOptional: true)]
        public virtual aws.SpotInstanceRequest.ISpotInstanceRequestMetadataOptions? InternalValue
        {
            get => GetInstanceProperty<aws.SpotInstanceRequest.ISpotInstanceRequestMetadataOptions?>();
            set => SetInstanceProperty(value);
        }
    }
}
