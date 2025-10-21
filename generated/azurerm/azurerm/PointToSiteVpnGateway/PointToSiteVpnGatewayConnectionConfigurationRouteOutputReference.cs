using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.PointToSiteVpnGateway
{
    [JsiiClass(nativeType: typeof(azurerm.PointToSiteVpnGateway.PointToSiteVpnGatewayConnectionConfigurationRouteOutputReference), fullyQualifiedName: "azurerm.pointToSiteVpnGateway.PointToSiteVpnGatewayConnectionConfigurationRouteOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class PointToSiteVpnGatewayConnectionConfigurationRouteOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public PointToSiteVpnGatewayConnectionConfigurationRouteOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected PointToSiteVpnGatewayConnectionConfigurationRouteOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected PointToSiteVpnGatewayConnectionConfigurationRouteOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putPropagatedRouteTable", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.pointToSiteVpnGateway.PointToSiteVpnGatewayConnectionConfigurationRoutePropagatedRouteTable\"}}]")]
        public virtual void PutPropagatedRouteTable(azurerm.PointToSiteVpnGateway.IPointToSiteVpnGatewayConnectionConfigurationRoutePropagatedRouteTable @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.PointToSiteVpnGateway.IPointToSiteVpnGatewayConnectionConfigurationRoutePropagatedRouteTable)}, new object[]{@value});
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

        [JsiiProperty(name: "propagatedRouteTable", typeJson: "{\"fqn\":\"azurerm.pointToSiteVpnGateway.PointToSiteVpnGatewayConnectionConfigurationRoutePropagatedRouteTableOutputReference\"}")]
        public virtual azurerm.PointToSiteVpnGateway.PointToSiteVpnGatewayConnectionConfigurationRoutePropagatedRouteTableOutputReference PropagatedRouteTable
        {
            get => GetInstanceProperty<azurerm.PointToSiteVpnGateway.PointToSiteVpnGatewayConnectionConfigurationRoutePropagatedRouteTableOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "associatedRouteTableIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AssociatedRouteTableIdInput
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
        [JsiiProperty(name: "propagatedRouteTableInput", typeJson: "{\"fqn\":\"azurerm.pointToSiteVpnGateway.PointToSiteVpnGatewayConnectionConfigurationRoutePropagatedRouteTable\"}", isOptional: true)]
        public virtual azurerm.PointToSiteVpnGateway.IPointToSiteVpnGatewayConnectionConfigurationRoutePropagatedRouteTable? PropagatedRouteTableInput
        {
            get => GetInstanceProperty<azurerm.PointToSiteVpnGateway.IPointToSiteVpnGatewayConnectionConfigurationRoutePropagatedRouteTable?>();
        }

        [JsiiProperty(name: "associatedRouteTableId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AssociatedRouteTableId
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
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.pointToSiteVpnGateway.PointToSiteVpnGatewayConnectionConfigurationRoute\"}", isOptional: true)]
        public virtual azurerm.PointToSiteVpnGateway.IPointToSiteVpnGatewayConnectionConfigurationRoute? InternalValue
        {
            get => GetInstanceProperty<azurerm.PointToSiteVpnGateway.IPointToSiteVpnGatewayConnectionConfigurationRoute?>();
            set => SetInstanceProperty(value);
        }
    }
}
