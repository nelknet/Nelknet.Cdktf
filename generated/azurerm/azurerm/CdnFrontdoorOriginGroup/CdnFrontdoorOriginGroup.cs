using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.CdnFrontdoorOriginGroup
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_origin_group azurerm_cdn_frontdoor_origin_group}.</summary>
    [JsiiClass(nativeType: typeof(azurerm.CdnFrontdoorOriginGroup.CdnFrontdoorOriginGroup), fullyQualifiedName: "azurerm.cdnFrontdoorOriginGroup.CdnFrontdoorOriginGroup", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurerm.cdnFrontdoorOriginGroup.CdnFrontdoorOriginGroupConfig\"}}]")]
    public class CdnFrontdoorOriginGroup : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_origin_group azurerm_cdn_frontdoor_origin_group} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public CdnFrontdoorOriginGroup(Constructs.Construct scope, string id, azurerm.CdnFrontdoorOriginGroup.ICdnFrontdoorOriginGroupConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurerm.CdnFrontdoorOriginGroup.ICdnFrontdoorOriginGroupConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CdnFrontdoorOriginGroup(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CdnFrontdoorOriginGroup(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a CdnFrontdoorOriginGroup resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the CdnFrontdoorOriginGroup to import.</param>
        /// <param name="importFromId">The id of the existing CdnFrontdoorOriginGroup that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the CdnFrontdoorOriginGroup to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the CdnFrontdoorOriginGroup to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_origin_group#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing CdnFrontdoorOriginGroup that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the CdnFrontdoorOriginGroup to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(azurerm.CdnFrontdoorOriginGroup.CdnFrontdoorOriginGroup), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putHealthProbe", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.cdnFrontdoorOriginGroup.CdnFrontdoorOriginGroupHealthProbe\"}}]")]
        public virtual void PutHealthProbe(azurerm.CdnFrontdoorOriginGroup.ICdnFrontdoorOriginGroupHealthProbe @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.CdnFrontdoorOriginGroup.ICdnFrontdoorOriginGroupHealthProbe)}, new object[]{@value});
        }

        [JsiiMethod(name: "putLoadBalancing", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.cdnFrontdoorOriginGroup.CdnFrontdoorOriginGroupLoadBalancing\"}}]")]
        public virtual void PutLoadBalancing(azurerm.CdnFrontdoorOriginGroup.ICdnFrontdoorOriginGroupLoadBalancing @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.CdnFrontdoorOriginGroup.ICdnFrontdoorOriginGroupLoadBalancing)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.cdnFrontdoorOriginGroup.CdnFrontdoorOriginGroupTimeouts\"}}]")]
        public virtual void PutTimeouts(azurerm.CdnFrontdoorOriginGroup.ICdnFrontdoorOriginGroupTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.CdnFrontdoorOriginGroup.ICdnFrontdoorOriginGroupTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetHealthProbe")]
        public virtual void ResetHealthProbe()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRestoreTrafficTimeToHealedOrNewEndpointInMinutes")]
        public virtual void ResetRestoreTrafficTimeToHealedOrNewEndpointInMinutes()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSessionAffinityEnabled")]
        public virtual void ResetSessionAffinityEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiMethod(name: "synthesizeHclAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeHclAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "tfResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public static string TfResourceType
        {
            get;
        }
        = GetStaticProperty<string>(typeof(azurerm.CdnFrontdoorOriginGroup.CdnFrontdoorOriginGroup))!;

        [JsiiProperty(name: "healthProbe", typeJson: "{\"fqn\":\"azurerm.cdnFrontdoorOriginGroup.CdnFrontdoorOriginGroupHealthProbeOutputReference\"}")]
        public virtual azurerm.CdnFrontdoorOriginGroup.CdnFrontdoorOriginGroupHealthProbeOutputReference HealthProbe
        {
            get => GetInstanceProperty<azurerm.CdnFrontdoorOriginGroup.CdnFrontdoorOriginGroupHealthProbeOutputReference>()!;
        }

        [JsiiProperty(name: "loadBalancing", typeJson: "{\"fqn\":\"azurerm.cdnFrontdoorOriginGroup.CdnFrontdoorOriginGroupLoadBalancingOutputReference\"}")]
        public virtual azurerm.CdnFrontdoorOriginGroup.CdnFrontdoorOriginGroupLoadBalancingOutputReference LoadBalancing
        {
            get => GetInstanceProperty<azurerm.CdnFrontdoorOriginGroup.CdnFrontdoorOriginGroupLoadBalancingOutputReference>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.cdnFrontdoorOriginGroup.CdnFrontdoorOriginGroupTimeoutsOutputReference\"}")]
        public virtual azurerm.CdnFrontdoorOriginGroup.CdnFrontdoorOriginGroupTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurerm.CdnFrontdoorOriginGroup.CdnFrontdoorOriginGroupTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "cdnFrontdoorProfileIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CdnFrontdoorProfileIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "healthProbeInput", typeJson: "{\"fqn\":\"azurerm.cdnFrontdoorOriginGroup.CdnFrontdoorOriginGroupHealthProbe\"}", isOptional: true)]
        public virtual azurerm.CdnFrontdoorOriginGroup.ICdnFrontdoorOriginGroupHealthProbe? HealthProbeInput
        {
            get => GetInstanceProperty<azurerm.CdnFrontdoorOriginGroup.ICdnFrontdoorOriginGroupHealthProbe?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "loadBalancingInput", typeJson: "{\"fqn\":\"azurerm.cdnFrontdoorOriginGroup.CdnFrontdoorOriginGroupLoadBalancing\"}", isOptional: true)]
        public virtual azurerm.CdnFrontdoorOriginGroup.ICdnFrontdoorOriginGroupLoadBalancing? LoadBalancingInput
        {
            get => GetInstanceProperty<azurerm.CdnFrontdoorOriginGroup.ICdnFrontdoorOriginGroupLoadBalancing?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "restoreTrafficTimeToHealedOrNewEndpointInMinutesInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? RestoreTrafficTimeToHealedOrNewEndpointInMinutesInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sessionAffinityEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? SessionAffinityEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"azurerm.cdnFrontdoorOriginGroup.CdnFrontdoorOriginGroupTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "cdnFrontdoorProfileId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CdnFrontdoorProfileId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "restoreTrafficTimeToHealedOrNewEndpointInMinutes", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double RestoreTrafficTimeToHealedOrNewEndpointInMinutes
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sessionAffinityEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object SessionAffinityEnabled
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
    }
}
