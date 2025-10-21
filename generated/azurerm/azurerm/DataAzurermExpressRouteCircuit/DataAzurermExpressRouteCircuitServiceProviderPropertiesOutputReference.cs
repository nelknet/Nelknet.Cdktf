using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermExpressRouteCircuit
{
    [JsiiClass(nativeType: typeof(azurerm.DataAzurermExpressRouteCircuit.DataAzurermExpressRouteCircuitServiceProviderPropertiesOutputReference), fullyQualifiedName: "azurerm.dataAzurermExpressRouteCircuit.DataAzurermExpressRouteCircuitServiceProviderPropertiesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataAzurermExpressRouteCircuitServiceProviderPropertiesOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataAzurermExpressRouteCircuitServiceProviderPropertiesOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataAzurermExpressRouteCircuitServiceProviderPropertiesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzurermExpressRouteCircuitServiceProviderPropertiesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "bandwidthInMbps", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double BandwidthInMbps
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "peeringLocation", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PeeringLocation
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "serviceProviderName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceProviderName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.dataAzurermExpressRouteCircuit.DataAzurermExpressRouteCircuitServiceProviderProperties\"}", isOptional: true)]
        public virtual azurerm.DataAzurermExpressRouteCircuit.IDataAzurermExpressRouteCircuitServiceProviderProperties? InternalValue
        {
            get => GetInstanceProperty<azurerm.DataAzurermExpressRouteCircuit.IDataAzurermExpressRouteCircuitServiceProviderProperties?>();
            set => SetInstanceProperty(value);
        }
    }
}
