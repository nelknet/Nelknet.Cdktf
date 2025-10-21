using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermNetappVolumeGroupSapHana
{
    [JsiiClass(nativeType: typeof(azurerm.DataAzurermNetappVolumeGroupSapHana.DataAzurermNetappVolumeGroupSapHanaVolumeExportPolicyRuleOutputReference), fullyQualifiedName: "azurerm.dataAzurermNetappVolumeGroupSapHana.DataAzurermNetappVolumeGroupSapHanaVolumeExportPolicyRuleOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataAzurermNetappVolumeGroupSapHanaVolumeExportPolicyRuleOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataAzurermNetappVolumeGroupSapHanaVolumeExportPolicyRuleOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataAzurermNetappVolumeGroupSapHanaVolumeExportPolicyRuleOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzurermNetappVolumeGroupSapHanaVolumeExportPolicyRuleOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "allowedClients", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AllowedClients
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "nfsv3Enabled", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable Nfsv3Enabled
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "nfsv41Enabled", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable Nfsv41Enabled
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "rootAccessEnabled", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable RootAccessEnabled
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "ruleIndex", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double RuleIndex
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "unixReadOnly", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable UnixReadOnly
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "unixReadWrite", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable UnixReadWrite
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.dataAzurermNetappVolumeGroupSapHana.DataAzurermNetappVolumeGroupSapHanaVolumeExportPolicyRule\"}", isOptional: true)]
        public virtual azurerm.DataAzurermNetappVolumeGroupSapHana.IDataAzurermNetappVolumeGroupSapHanaVolumeExportPolicyRule? InternalValue
        {
            get => GetInstanceProperty<azurerm.DataAzurermNetappVolumeGroupSapHana.IDataAzurermNetappVolumeGroupSapHanaVolumeExportPolicyRule?>();
            set => SetInstanceProperty(value);
        }
    }
}
