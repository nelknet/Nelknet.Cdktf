using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ExpressRouteConnection
{
    [JsiiClass(nativeType: typeof(azurerm.ExpressRouteConnection.ExpressRouteConnectionRoutingOutputReference), fullyQualifiedName: "azurerm.expressRouteConnection.ExpressRouteConnectionRoutingOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ExpressRouteConnectionRoutingOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ExpressRouteConnectionRoutingOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected ExpressRouteConnectionRoutingOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ExpressRouteConnectionRoutingOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putPropagatedRouteTable", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.expressRouteConnection.ExpressRouteConnectionRoutingPropagatedRouteTable\"}}]")]
        public virtual void PutPropagatedRouteTable(azurerm.ExpressRouteConnection.IExpressRouteConnectionRoutingPropagatedRouteTable @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.ExpressRouteConnection.IExpressRouteConnectionRoutingPropagatedRouteTable)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAssociatedRouteTableId")]
        public virtual void ResetAssociatedRouteTableId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
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

        [JsiiProperty(name: "propagatedRouteTable", typeJson: "{\"fqn\":\"azurerm.expressRouteConnection.ExpressRouteConnectionRoutingPropagatedRouteTableOutputReference\"}")]
        public virtual azurerm.ExpressRouteConnection.ExpressRouteConnectionRoutingPropagatedRouteTableOutputReference PropagatedRouteTable
        {
            get => GetInstanceProperty<azurerm.ExpressRouteConnection.ExpressRouteConnectionRoutingPropagatedRouteTableOutputReference>()!;
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
        [JsiiProperty(name: "propagatedRouteTableInput", typeJson: "{\"fqn\":\"azurerm.expressRouteConnection.ExpressRouteConnectionRoutingPropagatedRouteTable\"}", isOptional: true)]
        public virtual azurerm.ExpressRouteConnection.IExpressRouteConnectionRoutingPropagatedRouteTable? PropagatedRouteTableInput
        {
            get => GetInstanceProperty<azurerm.ExpressRouteConnection.IExpressRouteConnectionRoutingPropagatedRouteTable?>();
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
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.expressRouteConnection.ExpressRouteConnectionRouting\"}", isOptional: true)]
        public virtual azurerm.ExpressRouteConnection.IExpressRouteConnectionRouting? InternalValue
        {
            get => GetInstanceProperty<azurerm.ExpressRouteConnection.IExpressRouteConnectionRouting?>();
            set => SetInstanceProperty(value);
        }
    }
}
