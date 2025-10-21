using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MediaServicesAccountFilter
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/media_services_account_filter azurerm_media_services_account_filter}.</summary>
    [JsiiClass(nativeType: typeof(azurerm.MediaServicesAccountFilter.MediaServicesAccountFilter), fullyQualifiedName: "azurerm.mediaServicesAccountFilter.MediaServicesAccountFilter", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurerm.mediaServicesAccountFilter.MediaServicesAccountFilterConfig\"}}]")]
    public class MediaServicesAccountFilter : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/media_services_account_filter azurerm_media_services_account_filter} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public MediaServicesAccountFilter(Constructs.Construct scope, string id, azurerm.MediaServicesAccountFilter.IMediaServicesAccountFilterConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurerm.MediaServicesAccountFilter.IMediaServicesAccountFilterConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MediaServicesAccountFilter(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MediaServicesAccountFilter(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a MediaServicesAccountFilter resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the MediaServicesAccountFilter to import.</param>
        /// <param name="importFromId">The id of the existing MediaServicesAccountFilter that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the MediaServicesAccountFilter to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the MediaServicesAccountFilter to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/media_services_account_filter#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing MediaServicesAccountFilter that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the MediaServicesAccountFilter to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(azurerm.MediaServicesAccountFilter.MediaServicesAccountFilter), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putPresentationTimeRange", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.mediaServicesAccountFilter.MediaServicesAccountFilterPresentationTimeRange\"}}]")]
        public virtual void PutPresentationTimeRange(azurerm.MediaServicesAccountFilter.IMediaServicesAccountFilterPresentationTimeRange @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.MediaServicesAccountFilter.IMediaServicesAccountFilterPresentationTimeRange)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.mediaServicesAccountFilter.MediaServicesAccountFilterTimeouts\"}}]")]
        public virtual void PutTimeouts(azurerm.MediaServicesAccountFilter.IMediaServicesAccountFilterTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.MediaServicesAccountFilter.IMediaServicesAccountFilterTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTrackSelection", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.mediaServicesAccountFilter.MediaServicesAccountFilterTrackSelection\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutTrackSelection(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.MediaServicesAccountFilter.IMediaServicesAccountFilterTrackSelection[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.MediaServicesAccountFilter.IMediaServicesAccountFilterTrackSelection).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.MediaServicesAccountFilter.IMediaServicesAccountFilterTrackSelection).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetFirstQualityBitrate")]
        public virtual void ResetFirstQualityBitrate()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPresentationTimeRange")]
        public virtual void ResetPresentationTimeRange()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTrackSelection")]
        public virtual void ResetTrackSelection()
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
        = GetStaticProperty<string>(typeof(azurerm.MediaServicesAccountFilter.MediaServicesAccountFilter))!;

        [JsiiProperty(name: "presentationTimeRange", typeJson: "{\"fqn\":\"azurerm.mediaServicesAccountFilter.MediaServicesAccountFilterPresentationTimeRangeOutputReference\"}")]
        public virtual azurerm.MediaServicesAccountFilter.MediaServicesAccountFilterPresentationTimeRangeOutputReference PresentationTimeRange
        {
            get => GetInstanceProperty<azurerm.MediaServicesAccountFilter.MediaServicesAccountFilterPresentationTimeRangeOutputReference>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.mediaServicesAccountFilter.MediaServicesAccountFilterTimeoutsOutputReference\"}")]
        public virtual azurerm.MediaServicesAccountFilter.MediaServicesAccountFilterTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurerm.MediaServicesAccountFilter.MediaServicesAccountFilterTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "trackSelection", typeJson: "{\"fqn\":\"azurerm.mediaServicesAccountFilter.MediaServicesAccountFilterTrackSelectionList\"}")]
        public virtual azurerm.MediaServicesAccountFilter.MediaServicesAccountFilterTrackSelectionList TrackSelection
        {
            get => GetInstanceProperty<azurerm.MediaServicesAccountFilter.MediaServicesAccountFilterTrackSelectionList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "firstQualityBitrateInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? FirstQualityBitrateInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "mediaServicesAccountNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MediaServicesAccountNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "presentationTimeRangeInput", typeJson: "{\"fqn\":\"azurerm.mediaServicesAccountFilter.MediaServicesAccountFilterPresentationTimeRange\"}", isOptional: true)]
        public virtual azurerm.MediaServicesAccountFilter.IMediaServicesAccountFilterPresentationTimeRange? PresentationTimeRangeInput
        {
            get => GetInstanceProperty<azurerm.MediaServicesAccountFilter.IMediaServicesAccountFilterPresentationTimeRange?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "resourceGroupNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ResourceGroupNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"azurerm.mediaServicesAccountFilter.MediaServicesAccountFilterTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "trackSelectionInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.mediaServicesAccountFilter.MediaServicesAccountFilterTrackSelection\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? TrackSelectionInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "firstQualityBitrate", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double FirstQualityBitrate
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "mediaServicesAccountName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MediaServicesAccountName
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

        [JsiiProperty(name: "resourceGroupName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourceGroupName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
