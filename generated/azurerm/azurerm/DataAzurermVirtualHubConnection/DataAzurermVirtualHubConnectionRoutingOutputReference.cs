using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermVirtualHubConnection
{
    [JsiiClass(nativeType: typeof(azurerm.DataAzurermVirtualHubConnection.DataAzurermVirtualHubConnectionRoutingOutputReference), fullyQualifiedName: "azurerm.dataAzurermVirtualHubConnection.DataAzurermVirtualHubConnectionRoutingOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataAzurermVirtualHubConnectionRoutingOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataAzurermVirtualHubConnectionRoutingOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataAzurermVirtualHubConnectionRoutingOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzurermVirtualHubConnectionRoutingOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "associatedRouteTableId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AssociatedRouteTableId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "inboundRouteMapId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InboundRouteMapId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "outboundRouteMapId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OutboundRouteMapId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "propagatedRouteTable", typeJson: "{\"fqn\":\"azurerm.dataAzurermVirtualHubConnection.DataAzurermVirtualHubConnectionRoutingPropagatedRouteTableList\"}")]
        public virtual azurerm.DataAzurermVirtualHubConnection.DataAzurermVirtualHubConnectionRoutingPropagatedRouteTableList PropagatedRouteTable
        {
            get => GetInstanceProperty<azurerm.DataAzurermVirtualHubConnection.DataAzurermVirtualHubConnectionRoutingPropagatedRouteTableList>()!;
        }

        [JsiiProperty(name: "staticVnetLocalRouteOverrideCriteria", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StaticVnetLocalRouteOverrideCriteria
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "staticVnetRoute", typeJson: "{\"fqn\":\"azurerm.dataAzurermVirtualHubConnection.DataAzurermVirtualHubConnectionRoutingStaticVnetRouteList\"}")]
        public virtual azurerm.DataAzurermVirtualHubConnection.DataAzurermVirtualHubConnectionRoutingStaticVnetRouteList StaticVnetRoute
        {
            get => GetInstanceProperty<azurerm.DataAzurermVirtualHubConnection.DataAzurermVirtualHubConnectionRoutingStaticVnetRouteList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.dataAzurermVirtualHubConnection.DataAzurermVirtualHubConnectionRouting\"}", isOptional: true)]
        public virtual azurerm.DataAzurermVirtualHubConnection.IDataAzurermVirtualHubConnectionRouting? InternalValue
        {
            get => GetInstanceProperty<azurerm.DataAzurermVirtualHubConnection.IDataAzurermVirtualHubConnectionRouting?>();
            set => SetInstanceProperty(value);
        }
    }
}
