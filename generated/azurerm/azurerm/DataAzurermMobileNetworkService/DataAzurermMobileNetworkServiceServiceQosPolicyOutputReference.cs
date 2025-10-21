using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermMobileNetworkService
{
    [JsiiClass(nativeType: typeof(azurerm.DataAzurermMobileNetworkService.DataAzurermMobileNetworkServiceServiceQosPolicyOutputReference), fullyQualifiedName: "azurerm.dataAzurermMobileNetworkService.DataAzurermMobileNetworkServiceServiceQosPolicyOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataAzurermMobileNetworkServiceServiceQosPolicyOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataAzurermMobileNetworkServiceServiceQosPolicyOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataAzurermMobileNetworkServiceServiceQosPolicyOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzurermMobileNetworkServiceServiceQosPolicyOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "allocationAndRetentionPriorityLevel", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AllocationAndRetentionPriorityLevel
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "maximumBitRate", typeJson: "{\"fqn\":\"azurerm.dataAzurermMobileNetworkService.DataAzurermMobileNetworkServiceServiceQosPolicyMaximumBitRateList\"}")]
        public virtual azurerm.DataAzurermMobileNetworkService.DataAzurermMobileNetworkServiceServiceQosPolicyMaximumBitRateList MaximumBitRate
        {
            get => GetInstanceProperty<azurerm.DataAzurermMobileNetworkService.DataAzurermMobileNetworkServiceServiceQosPolicyMaximumBitRateList>()!;
        }

        [JsiiProperty(name: "preemptionCapability", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PreemptionCapability
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "preemptionVulnerability", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PreemptionVulnerability
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "qosIndicator", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double QosIndicator
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.dataAzurermMobileNetworkService.DataAzurermMobileNetworkServiceServiceQosPolicy\"}", isOptional: true)]
        public virtual azurerm.DataAzurermMobileNetworkService.IDataAzurermMobileNetworkServiceServiceQosPolicy? InternalValue
        {
            get => GetInstanceProperty<azurerm.DataAzurermMobileNetworkService.IDataAzurermMobileNetworkServiceServiceQosPolicy?>();
            set => SetInstanceProperty(value);
        }
    }
}
