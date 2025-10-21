using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermVirtualMachineScaleSet
{
    [JsiiClass(nativeType: typeof(azurerm.DataAzurermVirtualMachineScaleSet.DataAzurermVirtualMachineScaleSetNetworkInterfaceIpConfigurationPublicIpAddressOutputReference), fullyQualifiedName: "azurerm.dataAzurermVirtualMachineScaleSet.DataAzurermVirtualMachineScaleSetNetworkInterfaceIpConfigurationPublicIpAddressOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataAzurermVirtualMachineScaleSetNetworkInterfaceIpConfigurationPublicIpAddressOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataAzurermVirtualMachineScaleSetNetworkInterfaceIpConfigurationPublicIpAddressOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataAzurermVirtualMachineScaleSetNetworkInterfaceIpConfigurationPublicIpAddressOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzurermVirtualMachineScaleSetNetworkInterfaceIpConfigurationPublicIpAddressOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "domainNameLabel", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DomainNameLabel
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "idleTimeoutInMinutes", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double IdleTimeoutInMinutes
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "ipTag", typeJson: "{\"fqn\":\"azurerm.dataAzurermVirtualMachineScaleSet.DataAzurermVirtualMachineScaleSetNetworkInterfaceIpConfigurationPublicIpAddressIpTagList\"}")]
        public virtual azurerm.DataAzurermVirtualMachineScaleSet.DataAzurermVirtualMachineScaleSetNetworkInterfaceIpConfigurationPublicIpAddressIpTagList IpTag
        {
            get => GetInstanceProperty<azurerm.DataAzurermVirtualMachineScaleSet.DataAzurermVirtualMachineScaleSetNetworkInterfaceIpConfigurationPublicIpAddressIpTagList>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "publicIpPrefixId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PublicIpPrefixId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Version
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.dataAzurermVirtualMachineScaleSet.DataAzurermVirtualMachineScaleSetNetworkInterfaceIpConfigurationPublicIpAddress\"}", isOptional: true)]
        public virtual azurerm.DataAzurermVirtualMachineScaleSet.IDataAzurermVirtualMachineScaleSetNetworkInterfaceIpConfigurationPublicIpAddress? InternalValue
        {
            get => GetInstanceProperty<azurerm.DataAzurermVirtualMachineScaleSet.IDataAzurermVirtualMachineScaleSetNetworkInterfaceIpConfigurationPublicIpAddress?>();
            set => SetInstanceProperty(value);
        }
    }
}
