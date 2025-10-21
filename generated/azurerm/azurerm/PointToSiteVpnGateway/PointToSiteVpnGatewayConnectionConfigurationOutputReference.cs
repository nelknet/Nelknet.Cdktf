using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.PointToSiteVpnGateway
{
    [JsiiClass(nativeType: typeof(azurerm.PointToSiteVpnGateway.PointToSiteVpnGatewayConnectionConfigurationOutputReference), fullyQualifiedName: "azurerm.pointToSiteVpnGateway.PointToSiteVpnGatewayConnectionConfigurationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class PointToSiteVpnGatewayConnectionConfigurationOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public PointToSiteVpnGatewayConnectionConfigurationOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected PointToSiteVpnGatewayConnectionConfigurationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected PointToSiteVpnGatewayConnectionConfigurationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putRoute", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.pointToSiteVpnGateway.PointToSiteVpnGatewayConnectionConfigurationRoute\"}}]")]
        public virtual void PutRoute(azurerm.PointToSiteVpnGateway.IPointToSiteVpnGatewayConnectionConfigurationRoute @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.PointToSiteVpnGateway.IPointToSiteVpnGatewayConnectionConfigurationRoute)}, new object[]{@value});
        }

        [JsiiMethod(name: "putVpnClientAddressPool", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.pointToSiteVpnGateway.PointToSiteVpnGatewayConnectionConfigurationVpnClientAddressPool\"}}]")]
        public virtual void PutVpnClientAddressPool(azurerm.PointToSiteVpnGateway.IPointToSiteVpnGatewayConnectionConfigurationVpnClientAddressPool @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.PointToSiteVpnGateway.IPointToSiteVpnGatewayConnectionConfigurationVpnClientAddressPool)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetInternetSecurityEnabled")]
        public virtual void ResetInternetSecurityEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRoute")]
        public virtual void ResetRoute()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "route", typeJson: "{\"fqn\":\"azurerm.pointToSiteVpnGateway.PointToSiteVpnGatewayConnectionConfigurationRouteOutputReference\"}")]
        public virtual azurerm.PointToSiteVpnGateway.PointToSiteVpnGatewayConnectionConfigurationRouteOutputReference Route
        {
            get => GetInstanceProperty<azurerm.PointToSiteVpnGateway.PointToSiteVpnGatewayConnectionConfigurationRouteOutputReference>()!;
        }

        [JsiiProperty(name: "vpnClientAddressPool", typeJson: "{\"fqn\":\"azurerm.pointToSiteVpnGateway.PointToSiteVpnGatewayConnectionConfigurationVpnClientAddressPoolOutputReference\"}")]
        public virtual azurerm.PointToSiteVpnGateway.PointToSiteVpnGatewayConnectionConfigurationVpnClientAddressPoolOutputReference VpnClientAddressPool
        {
            get => GetInstanceProperty<azurerm.PointToSiteVpnGateway.PointToSiteVpnGatewayConnectionConfigurationVpnClientAddressPoolOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internetSecurityEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? InternetSecurityEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "routeInput", typeJson: "{\"fqn\":\"azurerm.pointToSiteVpnGateway.PointToSiteVpnGatewayConnectionConfigurationRoute\"}", isOptional: true)]
        public virtual azurerm.PointToSiteVpnGateway.IPointToSiteVpnGatewayConnectionConfigurationRoute? RouteInput
        {
            get => GetInstanceProperty<azurerm.PointToSiteVpnGateway.IPointToSiteVpnGatewayConnectionConfigurationRoute?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "vpnClientAddressPoolInput", typeJson: "{\"fqn\":\"azurerm.pointToSiteVpnGateway.PointToSiteVpnGatewayConnectionConfigurationVpnClientAddressPool\"}", isOptional: true)]
        public virtual azurerm.PointToSiteVpnGateway.IPointToSiteVpnGatewayConnectionConfigurationVpnClientAddressPool? VpnClientAddressPoolInput
        {
            get => GetInstanceProperty<azurerm.PointToSiteVpnGateway.IPointToSiteVpnGatewayConnectionConfigurationVpnClientAddressPool?>();
        }

        [JsiiProperty(name: "internetSecurityEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object InternetSecurityEnabled
        {
            get => GetInstanceProperty<object>()!;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"azurerm.pointToSiteVpnGateway.PointToSiteVpnGatewayConnectionConfiguration\"}]}}", isOptional: true)]
        public virtual object? InternalValue
        {
            get => GetInstanceProperty<object?>();
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.PointToSiteVpnGateway.IPointToSiteVpnGatewayConnectionConfiguration cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.PointToSiteVpnGateway.IPointToSiteVpnGatewayConnectionConfiguration).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
