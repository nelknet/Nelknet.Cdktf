using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudwatchEventEndpoint
{
    [JsiiClass(nativeType: typeof(aws.CloudwatchEventEndpoint.CloudwatchEventEndpointRoutingConfigFailoverConfigOutputReference), fullyQualifiedName: "aws.cloudwatchEventEndpoint.CloudwatchEventEndpointRoutingConfigFailoverConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class CloudwatchEventEndpointRoutingConfigFailoverConfigOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public CloudwatchEventEndpointRoutingConfigFailoverConfigOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected CloudwatchEventEndpointRoutingConfigFailoverConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CloudwatchEventEndpointRoutingConfigFailoverConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putPrimary", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.cloudwatchEventEndpoint.CloudwatchEventEndpointRoutingConfigFailoverConfigPrimary\"}}]")]
        public virtual void PutPrimary(aws.CloudwatchEventEndpoint.ICloudwatchEventEndpointRoutingConfigFailoverConfigPrimary @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.CloudwatchEventEndpoint.ICloudwatchEventEndpointRoutingConfigFailoverConfigPrimary)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSecondary", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.cloudwatchEventEndpoint.CloudwatchEventEndpointRoutingConfigFailoverConfigSecondary\"}}]")]
        public virtual void PutSecondary(aws.CloudwatchEventEndpoint.ICloudwatchEventEndpointRoutingConfigFailoverConfigSecondary @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.CloudwatchEventEndpoint.ICloudwatchEventEndpointRoutingConfigFailoverConfigSecondary)}, new object[]{@value});
        }

        [JsiiProperty(name: "primary", typeJson: "{\"fqn\":\"aws.cloudwatchEventEndpoint.CloudwatchEventEndpointRoutingConfigFailoverConfigPrimaryOutputReference\"}")]
        public virtual aws.CloudwatchEventEndpoint.CloudwatchEventEndpointRoutingConfigFailoverConfigPrimaryOutputReference Primary
        {
            get => GetInstanceProperty<aws.CloudwatchEventEndpoint.CloudwatchEventEndpointRoutingConfigFailoverConfigPrimaryOutputReference>()!;
        }

        [JsiiProperty(name: "secondary", typeJson: "{\"fqn\":\"aws.cloudwatchEventEndpoint.CloudwatchEventEndpointRoutingConfigFailoverConfigSecondaryOutputReference\"}")]
        public virtual aws.CloudwatchEventEndpoint.CloudwatchEventEndpointRoutingConfigFailoverConfigSecondaryOutputReference Secondary
        {
            get => GetInstanceProperty<aws.CloudwatchEventEndpoint.CloudwatchEventEndpointRoutingConfigFailoverConfigSecondaryOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "primaryInput", typeJson: "{\"fqn\":\"aws.cloudwatchEventEndpoint.CloudwatchEventEndpointRoutingConfigFailoverConfigPrimary\"}", isOptional: true)]
        public virtual aws.CloudwatchEventEndpoint.ICloudwatchEventEndpointRoutingConfigFailoverConfigPrimary? PrimaryInput
        {
            get => GetInstanceProperty<aws.CloudwatchEventEndpoint.ICloudwatchEventEndpointRoutingConfigFailoverConfigPrimary?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "secondaryInput", typeJson: "{\"fqn\":\"aws.cloudwatchEventEndpoint.CloudwatchEventEndpointRoutingConfigFailoverConfigSecondary\"}", isOptional: true)]
        public virtual aws.CloudwatchEventEndpoint.ICloudwatchEventEndpointRoutingConfigFailoverConfigSecondary? SecondaryInput
        {
            get => GetInstanceProperty<aws.CloudwatchEventEndpoint.ICloudwatchEventEndpointRoutingConfigFailoverConfigSecondary?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.cloudwatchEventEndpoint.CloudwatchEventEndpointRoutingConfigFailoverConfig\"}", isOptional: true)]
        public virtual aws.CloudwatchEventEndpoint.ICloudwatchEventEndpointRoutingConfigFailoverConfig? InternalValue
        {
            get => GetInstanceProperty<aws.CloudwatchEventEndpoint.ICloudwatchEventEndpointRoutingConfigFailoverConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
