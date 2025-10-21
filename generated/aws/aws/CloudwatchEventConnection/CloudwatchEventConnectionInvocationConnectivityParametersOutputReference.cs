using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudwatchEventConnection
{
    [JsiiClass(nativeType: typeof(aws.CloudwatchEventConnection.CloudwatchEventConnectionInvocationConnectivityParametersOutputReference), fullyQualifiedName: "aws.cloudwatchEventConnection.CloudwatchEventConnectionInvocationConnectivityParametersOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class CloudwatchEventConnectionInvocationConnectivityParametersOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public CloudwatchEventConnectionInvocationConnectivityParametersOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected CloudwatchEventConnectionInvocationConnectivityParametersOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CloudwatchEventConnectionInvocationConnectivityParametersOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putResourceParameters", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.cloudwatchEventConnection.CloudwatchEventConnectionInvocationConnectivityParametersResourceParameters\"}}]")]
        public virtual void PutResourceParameters(aws.CloudwatchEventConnection.ICloudwatchEventConnectionInvocationConnectivityParametersResourceParameters @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.CloudwatchEventConnection.ICloudwatchEventConnectionInvocationConnectivityParametersResourceParameters)}, new object[]{@value});
        }

        [JsiiProperty(name: "resourceParameters", typeJson: "{\"fqn\":\"aws.cloudwatchEventConnection.CloudwatchEventConnectionInvocationConnectivityParametersResourceParametersOutputReference\"}")]
        public virtual aws.CloudwatchEventConnection.CloudwatchEventConnectionInvocationConnectivityParametersResourceParametersOutputReference ResourceParameters
        {
            get => GetInstanceProperty<aws.CloudwatchEventConnection.CloudwatchEventConnectionInvocationConnectivityParametersResourceParametersOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "resourceParametersInput", typeJson: "{\"fqn\":\"aws.cloudwatchEventConnection.CloudwatchEventConnectionInvocationConnectivityParametersResourceParameters\"}", isOptional: true)]
        public virtual aws.CloudwatchEventConnection.ICloudwatchEventConnectionInvocationConnectivityParametersResourceParameters? ResourceParametersInput
        {
            get => GetInstanceProperty<aws.CloudwatchEventConnection.ICloudwatchEventConnectionInvocationConnectivityParametersResourceParameters?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.cloudwatchEventConnection.CloudwatchEventConnectionInvocationConnectivityParameters\"}", isOptional: true)]
        public virtual aws.CloudwatchEventConnection.ICloudwatchEventConnectionInvocationConnectivityParameters? InternalValue
        {
            get => GetInstanceProperty<aws.CloudwatchEventConnection.ICloudwatchEventConnectionInvocationConnectivityParameters?>();
            set => SetInstanceProperty(value);
        }
    }
}
