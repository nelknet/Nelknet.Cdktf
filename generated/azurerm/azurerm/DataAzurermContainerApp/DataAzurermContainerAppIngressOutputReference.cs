using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermContainerApp
{
    [JsiiClass(nativeType: typeof(azurerm.DataAzurermContainerApp.DataAzurermContainerAppIngressOutputReference), fullyQualifiedName: "azurerm.dataAzurermContainerApp.DataAzurermContainerAppIngressOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataAzurermContainerAppIngressOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataAzurermContainerAppIngressOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataAzurermContainerAppIngressOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzurermContainerAppIngressOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "allowInsecureConnections", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable AllowInsecureConnections
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "customDomain", typeJson: "{\"fqn\":\"azurerm.dataAzurermContainerApp.DataAzurermContainerAppIngressCustomDomainList\"}")]
        public virtual azurerm.DataAzurermContainerApp.DataAzurermContainerAppIngressCustomDomainList CustomDomain
        {
            get => GetInstanceProperty<azurerm.DataAzurermContainerApp.DataAzurermContainerAppIngressCustomDomainList>()!;
        }

        [JsiiProperty(name: "exposedPort", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ExposedPort
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "externalEnabled", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable ExternalEnabled
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "fqdn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Fqdn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ipSecurityRestriction", typeJson: "{\"fqn\":\"azurerm.dataAzurermContainerApp.DataAzurermContainerAppIngressIpSecurityRestrictionList\"}")]
        public virtual azurerm.DataAzurermContainerApp.DataAzurermContainerAppIngressIpSecurityRestrictionList IpSecurityRestriction
        {
            get => GetInstanceProperty<azurerm.DataAzurermContainerApp.DataAzurermContainerAppIngressIpSecurityRestrictionList>()!;
        }

        [JsiiProperty(name: "targetPort", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TargetPort
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "trafficWeight", typeJson: "{\"fqn\":\"azurerm.dataAzurermContainerApp.DataAzurermContainerAppIngressTrafficWeightList\"}")]
        public virtual azurerm.DataAzurermContainerApp.DataAzurermContainerAppIngressTrafficWeightList TrafficWeight
        {
            get => GetInstanceProperty<azurerm.DataAzurermContainerApp.DataAzurermContainerAppIngressTrafficWeightList>()!;
        }

        [JsiiProperty(name: "transport", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Transport
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.dataAzurermContainerApp.DataAzurermContainerAppIngress\"}", isOptional: true)]
        public virtual azurerm.DataAzurermContainerApp.IDataAzurermContainerAppIngress? InternalValue
        {
            get => GetInstanceProperty<azurerm.DataAzurermContainerApp.IDataAzurermContainerAppIngress?>();
            set => SetInstanceProperty(value);
        }
    }
}
