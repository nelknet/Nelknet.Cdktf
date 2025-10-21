using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermApplicationGateway
{
    [JsiiClass(nativeType: typeof(azurerm.DataAzurermApplicationGateway.DataAzurermApplicationGatewaySslProfileOutputReference), fullyQualifiedName: "azurerm.dataAzurermApplicationGateway.DataAzurermApplicationGatewaySslProfileOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataAzurermApplicationGatewaySslProfileOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataAzurermApplicationGatewaySslProfileOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataAzurermApplicationGatewaySslProfileOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzurermApplicationGatewaySslProfileOutputReference(DeputyProps props): base(props)
        {
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

        [JsiiProperty(name: "sslPolicy", typeJson: "{\"fqn\":\"azurerm.dataAzurermApplicationGateway.DataAzurermApplicationGatewaySslProfileSslPolicyList\"}")]
        public virtual azurerm.DataAzurermApplicationGateway.DataAzurermApplicationGatewaySslProfileSslPolicyList SslPolicy
        {
            get => GetInstanceProperty<azurerm.DataAzurermApplicationGateway.DataAzurermApplicationGatewaySslProfileSslPolicyList>()!;
        }

        [JsiiProperty(name: "trustedClientCertificateNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] TrustedClientCertificateNames
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "verifyClientCertificateIssuerDn", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable VerifyClientCertificateIssuerDn
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "verifyClientCertificateRevocation", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VerifyClientCertificateRevocation
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.dataAzurermApplicationGateway.DataAzurermApplicationGatewaySslProfile\"}", isOptional: true)]
        public virtual azurerm.DataAzurermApplicationGateway.IDataAzurermApplicationGatewaySslProfile? InternalValue
        {
            get => GetInstanceProperty<azurerm.DataAzurermApplicationGateway.IDataAzurermApplicationGatewaySslProfile?>();
            set => SetInstanceProperty(value);
        }
    }
}
