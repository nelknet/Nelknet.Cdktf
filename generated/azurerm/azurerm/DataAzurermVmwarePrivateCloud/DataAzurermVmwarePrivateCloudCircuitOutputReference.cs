using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermVmwarePrivateCloud
{
    [JsiiClass(nativeType: typeof(azurerm.DataAzurermVmwarePrivateCloud.DataAzurermVmwarePrivateCloudCircuitOutputReference), fullyQualifiedName: "azurerm.dataAzurermVmwarePrivateCloud.DataAzurermVmwarePrivateCloudCircuitOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataAzurermVmwarePrivateCloudCircuitOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataAzurermVmwarePrivateCloudCircuitOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataAzurermVmwarePrivateCloudCircuitOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzurermVmwarePrivateCloudCircuitOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "expressRouteId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExpressRouteId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "expressRoutePrivatePeeringId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExpressRoutePrivatePeeringId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "primarySubnetCidr", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrimarySubnetCidr
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "secondarySubnetCidr", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SecondarySubnetCidr
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.dataAzurermVmwarePrivateCloud.DataAzurermVmwarePrivateCloudCircuit\"}", isOptional: true)]
        public virtual azurerm.DataAzurermVmwarePrivateCloud.IDataAzurermVmwarePrivateCloudCircuit? InternalValue
        {
            get => GetInstanceProperty<azurerm.DataAzurermVmwarePrivateCloud.IDataAzurermVmwarePrivateCloudCircuit?>();
            set => SetInstanceProperty(value);
        }
    }
}
