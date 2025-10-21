using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.VpnGatewayConnection
{
    [JsiiClass(nativeType: typeof(azurerm.VpnGatewayConnection.VpnGatewayConnectionRoutingOutputReference), fullyQualifiedName: "azurerm.vpnGatewayConnection.VpnGatewayConnectionRoutingOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class VpnGatewayConnectionRoutingOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public VpnGatewayConnectionRoutingOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected VpnGatewayConnectionRoutingOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected VpnGatewayConnectionRoutingOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putPropagatedRouteTable", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.vpnGatewayConnection.VpnGatewayConnectionRoutingPropagatedRouteTable\"}}]")]
        public virtual void PutPropagatedRouteTable(azurerm.VpnGatewayConnection.IVpnGatewayConnectionRoutingPropagatedRouteTable @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.VpnGatewayConnection.IVpnGatewayConnectionRoutingPropagatedRouteTable)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetInboundRouteMapId")]
        public virtual void ResetInboundRouteMapId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOutboundRouteMapId")]
        public virtual void ResetOutboundRouteMapId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPropagatedRouteTable")]
        public virtual void ResetPropagatedRouteTable()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "propagatedRouteTable", typeJson: "{\"fqn\":\"azurerm.vpnGatewayConnection.VpnGatewayConnectionRoutingPropagatedRouteTableOutputReference\"}")]
        public virtual azurerm.VpnGatewayConnection.VpnGatewayConnectionRoutingPropagatedRouteTableOutputReference PropagatedRouteTable
        {
            get => GetInstanceProperty<azurerm.VpnGatewayConnection.VpnGatewayConnectionRoutingPropagatedRouteTableOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "associatedRouteTableInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AssociatedRouteTableInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "inboundRouteMapIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? InboundRouteMapIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "outboundRouteMapIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OutboundRouteMapIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "propagatedRouteTableInput", typeJson: "{\"fqn\":\"azurerm.vpnGatewayConnection.VpnGatewayConnectionRoutingPropagatedRouteTable\"}", isOptional: true)]
        public virtual azurerm.VpnGatewayConnection.IVpnGatewayConnectionRoutingPropagatedRouteTable? PropagatedRouteTableInput
        {
            get => GetInstanceProperty<azurerm.VpnGatewayConnection.IVpnGatewayConnectionRoutingPropagatedRouteTable?>();
        }

        [JsiiProperty(name: "associatedRouteTable", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AssociatedRouteTable
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "inboundRouteMapId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InboundRouteMapId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "outboundRouteMapId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OutboundRouteMapId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.vpnGatewayConnection.VpnGatewayConnectionRouting\"}", isOptional: true)]
        public virtual azurerm.VpnGatewayConnection.IVpnGatewayConnectionRouting? InternalValue
        {
            get => GetInstanceProperty<azurerm.VpnGatewayConnection.IVpnGatewayConnectionRouting?>();
            set => SetInstanceProperty(value);
        }
    }
}
