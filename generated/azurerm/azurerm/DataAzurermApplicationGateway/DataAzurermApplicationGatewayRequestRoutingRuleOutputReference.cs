using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermApplicationGateway
{
    [JsiiClass(nativeType: typeof(azurerm.DataAzurermApplicationGateway.DataAzurermApplicationGatewayRequestRoutingRuleOutputReference), fullyQualifiedName: "azurerm.dataAzurermApplicationGateway.DataAzurermApplicationGatewayRequestRoutingRuleOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataAzurermApplicationGatewayRequestRoutingRuleOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataAzurermApplicationGatewayRequestRoutingRuleOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataAzurermApplicationGatewayRequestRoutingRuleOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzurermApplicationGatewayRequestRoutingRuleOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "backendAddressPoolId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BackendAddressPoolId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "backendAddressPoolName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BackendAddressPoolName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "backendHttpSettingsId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BackendHttpSettingsId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "backendHttpSettingsName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BackendHttpSettingsName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "httpListenerId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HttpListenerId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "httpListenerName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HttpListenerName
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

        [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Priority
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "redirectConfigurationId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RedirectConfigurationId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "redirectConfigurationName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RedirectConfigurationName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "rewriteRuleSetId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RewriteRuleSetId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "rewriteRuleSetName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RewriteRuleSetName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ruleType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RuleType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "urlPathMapId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UrlPathMapId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "urlPathMapName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UrlPathMapName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.dataAzurermApplicationGateway.DataAzurermApplicationGatewayRequestRoutingRule\"}", isOptional: true)]
        public virtual azurerm.DataAzurermApplicationGateway.IDataAzurermApplicationGatewayRequestRoutingRule? InternalValue
        {
            get => GetInstanceProperty<azurerm.DataAzurermApplicationGateway.IDataAzurermApplicationGatewayRequestRoutingRule?>();
            set => SetInstanceProperty(value);
        }
    }
}
