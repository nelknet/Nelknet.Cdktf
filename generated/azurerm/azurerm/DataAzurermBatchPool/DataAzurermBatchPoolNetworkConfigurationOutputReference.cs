using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermBatchPool
{
    [JsiiClass(nativeType: typeof(azurerm.DataAzurermBatchPool.DataAzurermBatchPoolNetworkConfigurationOutputReference), fullyQualifiedName: "azurerm.dataAzurermBatchPool.DataAzurermBatchPoolNetworkConfigurationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataAzurermBatchPoolNetworkConfigurationOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataAzurermBatchPoolNetworkConfigurationOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataAzurermBatchPoolNetworkConfigurationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzurermBatchPoolNetworkConfigurationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "acceleratedNetworkingEnabled", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable AcceleratedNetworkingEnabled
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "dynamicVnetAssignmentScope", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DynamicVnetAssignmentScope
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "endpointConfiguration", typeJson: "{\"fqn\":\"azurerm.dataAzurermBatchPool.DataAzurermBatchPoolNetworkConfigurationEndpointConfigurationList\"}")]
        public virtual azurerm.DataAzurermBatchPool.DataAzurermBatchPoolNetworkConfigurationEndpointConfigurationList EndpointConfiguration
        {
            get => GetInstanceProperty<azurerm.DataAzurermBatchPool.DataAzurermBatchPoolNetworkConfigurationEndpointConfigurationList>()!;
        }

        [JsiiProperty(name: "publicAddressProvisioningType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PublicAddressProvisioningType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "publicIps", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] PublicIps
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SubnetId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.dataAzurermBatchPool.DataAzurermBatchPoolNetworkConfiguration\"}", isOptional: true)]
        public virtual azurerm.DataAzurermBatchPool.IDataAzurermBatchPoolNetworkConfiguration? InternalValue
        {
            get => GetInstanceProperty<azurerm.DataAzurermBatchPool.IDataAzurermBatchPoolNetworkConfiguration?>();
            set => SetInstanceProperty(value);
        }
    }
}
