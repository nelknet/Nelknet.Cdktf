using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermApplicationGateway
{
    [JsiiClass(nativeType: typeof(azurerm.DataAzurermApplicationGateway.DataAzurermApplicationGatewayRewriteRuleSetRewriteRuleOutputReference), fullyQualifiedName: "azurerm.dataAzurermApplicationGateway.DataAzurermApplicationGatewayRewriteRuleSetRewriteRuleOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataAzurermApplicationGatewayRewriteRuleSetRewriteRuleOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataAzurermApplicationGatewayRewriteRuleSetRewriteRuleOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataAzurermApplicationGatewayRewriteRuleSetRewriteRuleOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzurermApplicationGatewayRewriteRuleSetRewriteRuleOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "condition", typeJson: "{\"fqn\":\"azurerm.dataAzurermApplicationGateway.DataAzurermApplicationGatewayRewriteRuleSetRewriteRuleConditionList\"}")]
        public virtual azurerm.DataAzurermApplicationGateway.DataAzurermApplicationGatewayRewriteRuleSetRewriteRuleConditionList Condition
        {
            get => GetInstanceProperty<azurerm.DataAzurermApplicationGateway.DataAzurermApplicationGatewayRewriteRuleSetRewriteRuleConditionList>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "requestHeaderConfiguration", typeJson: "{\"fqn\":\"azurerm.dataAzurermApplicationGateway.DataAzurermApplicationGatewayRewriteRuleSetRewriteRuleRequestHeaderConfigurationList\"}")]
        public virtual azurerm.DataAzurermApplicationGateway.DataAzurermApplicationGatewayRewriteRuleSetRewriteRuleRequestHeaderConfigurationList RequestHeaderConfiguration
        {
            get => GetInstanceProperty<azurerm.DataAzurermApplicationGateway.DataAzurermApplicationGatewayRewriteRuleSetRewriteRuleRequestHeaderConfigurationList>()!;
        }

        [JsiiProperty(name: "responseHeaderConfiguration", typeJson: "{\"fqn\":\"azurerm.dataAzurermApplicationGateway.DataAzurermApplicationGatewayRewriteRuleSetRewriteRuleResponseHeaderConfigurationList\"}")]
        public virtual azurerm.DataAzurermApplicationGateway.DataAzurermApplicationGatewayRewriteRuleSetRewriteRuleResponseHeaderConfigurationList ResponseHeaderConfiguration
        {
            get => GetInstanceProperty<azurerm.DataAzurermApplicationGateway.DataAzurermApplicationGatewayRewriteRuleSetRewriteRuleResponseHeaderConfigurationList>()!;
        }

        [JsiiProperty(name: "ruleSequence", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double RuleSequence
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "url", typeJson: "{\"fqn\":\"azurerm.dataAzurermApplicationGateway.DataAzurermApplicationGatewayRewriteRuleSetRewriteRuleUrlList\"}")]
        public virtual azurerm.DataAzurermApplicationGateway.DataAzurermApplicationGatewayRewriteRuleSetRewriteRuleUrlList Url
        {
            get => GetInstanceProperty<azurerm.DataAzurermApplicationGateway.DataAzurermApplicationGatewayRewriteRuleSetRewriteRuleUrlList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.dataAzurermApplicationGateway.DataAzurermApplicationGatewayRewriteRuleSetRewriteRule\"}", isOptional: true)]
        public virtual azurerm.DataAzurermApplicationGateway.IDataAzurermApplicationGatewayRewriteRuleSetRewriteRule? InternalValue
        {
            get => GetInstanceProperty<azurerm.DataAzurermApplicationGateway.IDataAzurermApplicationGatewayRewriteRuleSetRewriteRule?>();
            set => SetInstanceProperty(value);
        }
    }
}
