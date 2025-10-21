using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ApprunnerService
{
    [JsiiClass(nativeType: typeof(aws.ApprunnerService.ApprunnerServiceNetworkConfigurationOutputReference), fullyQualifiedName: "aws.apprunnerService.ApprunnerServiceNetworkConfigurationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ApprunnerServiceNetworkConfigurationOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ApprunnerServiceNetworkConfigurationOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected ApprunnerServiceNetworkConfigurationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ApprunnerServiceNetworkConfigurationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putEgressConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.apprunnerService.ApprunnerServiceNetworkConfigurationEgressConfiguration\"}}]")]
        public virtual void PutEgressConfiguration(aws.ApprunnerService.IApprunnerServiceNetworkConfigurationEgressConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.ApprunnerService.IApprunnerServiceNetworkConfigurationEgressConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putIngressConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.apprunnerService.ApprunnerServiceNetworkConfigurationIngressConfiguration\"}}]")]
        public virtual void PutIngressConfiguration(aws.ApprunnerService.IApprunnerServiceNetworkConfigurationIngressConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.ApprunnerService.IApprunnerServiceNetworkConfigurationIngressConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetEgressConfiguration")]
        public virtual void ResetEgressConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIngressConfiguration")]
        public virtual void ResetIngressConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIpAddressType")]
        public virtual void ResetIpAddressType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "egressConfiguration", typeJson: "{\"fqn\":\"aws.apprunnerService.ApprunnerServiceNetworkConfigurationEgressConfigurationOutputReference\"}")]
        public virtual aws.ApprunnerService.ApprunnerServiceNetworkConfigurationEgressConfigurationOutputReference EgressConfiguration
        {
            get => GetInstanceProperty<aws.ApprunnerService.ApprunnerServiceNetworkConfigurationEgressConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "ingressConfiguration", typeJson: "{\"fqn\":\"aws.apprunnerService.ApprunnerServiceNetworkConfigurationIngressConfigurationOutputReference\"}")]
        public virtual aws.ApprunnerService.ApprunnerServiceNetworkConfigurationIngressConfigurationOutputReference IngressConfiguration
        {
            get => GetInstanceProperty<aws.ApprunnerService.ApprunnerServiceNetworkConfigurationIngressConfigurationOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "egressConfigurationInput", typeJson: "{\"fqn\":\"aws.apprunnerService.ApprunnerServiceNetworkConfigurationEgressConfiguration\"}", isOptional: true)]
        public virtual aws.ApprunnerService.IApprunnerServiceNetworkConfigurationEgressConfiguration? EgressConfigurationInput
        {
            get => GetInstanceProperty<aws.ApprunnerService.IApprunnerServiceNetworkConfigurationEgressConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ingressConfigurationInput", typeJson: "{\"fqn\":\"aws.apprunnerService.ApprunnerServiceNetworkConfigurationIngressConfiguration\"}", isOptional: true)]
        public virtual aws.ApprunnerService.IApprunnerServiceNetworkConfigurationIngressConfiguration? IngressConfigurationInput
        {
            get => GetInstanceProperty<aws.ApprunnerService.IApprunnerServiceNetworkConfigurationIngressConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ipAddressTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IpAddressTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "ipAddressType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IpAddressType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.apprunnerService.ApprunnerServiceNetworkConfiguration\"}", isOptional: true)]
        public virtual aws.ApprunnerService.IApprunnerServiceNetworkConfiguration? InternalValue
        {
            get => GetInstanceProperty<aws.ApprunnerService.IApprunnerServiceNetworkConfiguration?>();
            set => SetInstanceProperty(value);
        }
    }
}
