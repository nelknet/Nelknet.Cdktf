using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermApplicationGateway
{
    [JsiiClass(nativeType: typeof(azurerm.DataAzurermApplicationGateway.DataAzurermApplicationGatewayUrlPathMapOutputReference), fullyQualifiedName: "azurerm.dataAzurermApplicationGateway.DataAzurermApplicationGatewayUrlPathMapOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataAzurermApplicationGatewayUrlPathMapOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataAzurermApplicationGatewayUrlPathMapOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataAzurermApplicationGatewayUrlPathMapOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzurermApplicationGatewayUrlPathMapOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "defaultBackendAddressPoolId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DefaultBackendAddressPoolId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "defaultBackendAddressPoolName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DefaultBackendAddressPoolName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "defaultBackendHttpSettingsId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DefaultBackendHttpSettingsId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "defaultBackendHttpSettingsName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DefaultBackendHttpSettingsName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "defaultRedirectConfigurationId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DefaultRedirectConfigurationId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "defaultRedirectConfigurationName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DefaultRedirectConfigurationName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "defaultRewriteRuleSetId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DefaultRewriteRuleSetId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "defaultRewriteRuleSetName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DefaultRewriteRuleSetName
        {
            get => GetInstanceProperty<string>()!;
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

        [JsiiProperty(name: "pathRule", typeJson: "{\"fqn\":\"azurerm.dataAzurermApplicationGateway.DataAzurermApplicationGatewayUrlPathMapPathRuleList\"}")]
        public virtual azurerm.DataAzurermApplicationGateway.DataAzurermApplicationGatewayUrlPathMapPathRuleList PathRule
        {
            get => GetInstanceProperty<azurerm.DataAzurermApplicationGateway.DataAzurermApplicationGatewayUrlPathMapPathRuleList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.dataAzurermApplicationGateway.DataAzurermApplicationGatewayUrlPathMap\"}", isOptional: true)]
        public virtual azurerm.DataAzurermApplicationGateway.IDataAzurermApplicationGatewayUrlPathMap? InternalValue
        {
            get => GetInstanceProperty<azurerm.DataAzurermApplicationGateway.IDataAzurermApplicationGatewayUrlPathMap?>();
            set => SetInstanceProperty(value);
        }
    }
}
