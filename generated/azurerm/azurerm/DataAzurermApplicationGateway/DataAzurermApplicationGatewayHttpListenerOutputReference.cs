using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermApplicationGateway
{
    [JsiiClass(nativeType: typeof(azurerm.DataAzurermApplicationGateway.DataAzurermApplicationGatewayHttpListenerOutputReference), fullyQualifiedName: "azurerm.dataAzurermApplicationGateway.DataAzurermApplicationGatewayHttpListenerOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataAzurermApplicationGatewayHttpListenerOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataAzurermApplicationGatewayHttpListenerOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzurermApplicationGatewayHttpListenerOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzurermApplicationGatewayHttpListenerOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "customErrorConfiguration", typeJson: "{\"fqn\":\"azurerm.dataAzurermApplicationGateway.DataAzurermApplicationGatewayHttpListenerCustomErrorConfigurationList\"}")]
        public virtual azurerm.DataAzurermApplicationGateway.DataAzurermApplicationGatewayHttpListenerCustomErrorConfigurationList CustomErrorConfiguration
        {
            get => GetInstanceProperty<azurerm.DataAzurermApplicationGateway.DataAzurermApplicationGatewayHttpListenerCustomErrorConfigurationList>()!;
        }

        [JsiiProperty(name: "firewallPolicyId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FirewallPolicyId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "frontendIpConfigurationId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FrontendIpConfigurationId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "frontendIpConfigurationName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FrontendIpConfigurationName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "frontendPortId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FrontendPortId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "frontendPortName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FrontendPortName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "hostName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HostName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "hostNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] HostNames
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Protocol
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "requireSni", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable RequireSni
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "sslCertificateId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SslCertificateId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sslCertificateName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SslCertificateName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sslProfileId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SslProfileId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sslProfileName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SslProfileName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.dataAzurermApplicationGateway.DataAzurermApplicationGatewayHttpListener\"}", isOptional: true)]
        public virtual azurerm.DataAzurermApplicationGateway.IDataAzurermApplicationGatewayHttpListener? InternalValue
        {
            get => GetInstanceProperty<azurerm.DataAzurermApplicationGateway.IDataAzurermApplicationGatewayHttpListener?>();
            set => SetInstanceProperty(value);
        }
    }
}
