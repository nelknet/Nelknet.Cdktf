using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.VpnSite
{
    [JsiiClass(nativeType: typeof(azurerm.VpnSite.VpnSiteO365PolicyOutputReference), fullyQualifiedName: "azurerm.vpnSite.VpnSiteO365PolicyOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class VpnSiteO365PolicyOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public VpnSiteO365PolicyOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected VpnSiteO365PolicyOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected VpnSiteO365PolicyOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putTrafficCategory", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.vpnSite.VpnSiteO365PolicyTrafficCategory\"}}]")]
        public virtual void PutTrafficCategory(azurerm.VpnSite.IVpnSiteO365PolicyTrafficCategory @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.VpnSite.IVpnSiteO365PolicyTrafficCategory)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetTrafficCategory")]
        public virtual void ResetTrafficCategory()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "trafficCategory", typeJson: "{\"fqn\":\"azurerm.vpnSite.VpnSiteO365PolicyTrafficCategoryOutputReference\"}")]
        public virtual azurerm.VpnSite.VpnSiteO365PolicyTrafficCategoryOutputReference TrafficCategory
        {
            get => GetInstanceProperty<azurerm.VpnSite.VpnSiteO365PolicyTrafficCategoryOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "trafficCategoryInput", typeJson: "{\"fqn\":\"azurerm.vpnSite.VpnSiteO365PolicyTrafficCategory\"}", isOptional: true)]
        public virtual azurerm.VpnSite.IVpnSiteO365PolicyTrafficCategory? TrafficCategoryInput
        {
            get => GetInstanceProperty<azurerm.VpnSite.IVpnSiteO365PolicyTrafficCategory?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.vpnSite.VpnSiteO365Policy\"}", isOptional: true)]
        public virtual azurerm.VpnSite.IVpnSiteO365Policy? InternalValue
        {
            get => GetInstanceProperty<azurerm.VpnSite.IVpnSiteO365Policy?>();
            set => SetInstanceProperty(value);
        }
    }
}
