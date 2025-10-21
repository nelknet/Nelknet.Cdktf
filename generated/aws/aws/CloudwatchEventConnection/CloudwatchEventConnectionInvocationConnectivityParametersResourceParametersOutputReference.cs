using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudwatchEventConnection
{
    [JsiiClass(nativeType: typeof(aws.CloudwatchEventConnection.CloudwatchEventConnectionInvocationConnectivityParametersResourceParametersOutputReference), fullyQualifiedName: "aws.cloudwatchEventConnection.CloudwatchEventConnectionInvocationConnectivityParametersResourceParametersOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class CloudwatchEventConnectionInvocationConnectivityParametersResourceParametersOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public CloudwatchEventConnectionInvocationConnectivityParametersResourceParametersOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected CloudwatchEventConnectionInvocationConnectivityParametersResourceParametersOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CloudwatchEventConnectionInvocationConnectivityParametersResourceParametersOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "resourceAssociationArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourceAssociationArn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "resourceConfigurationArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ResourceConfigurationArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "resourceConfigurationArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourceConfigurationArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.cloudwatchEventConnection.CloudwatchEventConnectionInvocationConnectivityParametersResourceParameters\"}", isOptional: true)]
        public virtual aws.CloudwatchEventConnection.ICloudwatchEventConnectionInvocationConnectivityParametersResourceParameters? InternalValue
        {
            get => GetInstanceProperty<aws.CloudwatchEventConnection.ICloudwatchEventConnectionInvocationConnectivityParametersResourceParameters?>();
            set => SetInstanceProperty(value);
        }
    }
}
