using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermStreamAnalyticsJob
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/stream_analytics_job azurerm_stream_analytics_job}.</summary>
    [JsiiClass(nativeType: typeof(azurerm.DataAzurermStreamAnalyticsJob.DataAzurermStreamAnalyticsJob), fullyQualifiedName: "azurerm.dataAzurermStreamAnalyticsJob.DataAzurermStreamAnalyticsJob", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurerm.dataAzurermStreamAnalyticsJob.DataAzurermStreamAnalyticsJobConfig\"}}]")]
    public class DataAzurermStreamAnalyticsJob : HashiCorp.Cdktf.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/stream_analytics_job azurerm_stream_analytics_job} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataAzurermStreamAnalyticsJob(Constructs.Construct scope, string id, azurerm.DataAzurermStreamAnalyticsJob.IDataAzurermStreamAnalyticsJobConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurerm.DataAzurermStreamAnalyticsJob.IDataAzurermStreamAnalyticsJobConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzurermStreamAnalyticsJob(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzurermStreamAnalyticsJob(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a DataAzurermStreamAnalyticsJob resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataAzurermStreamAnalyticsJob to import.</param>
        /// <param name="importFromId">The id of the existing DataAzurermStreamAnalyticsJob that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataAzurermStreamAnalyticsJob to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataAzurermStreamAnalyticsJob to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/stream_analytics_job#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataAzurermStreamAnalyticsJob that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataAzurermStreamAnalyticsJob to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(azurerm.DataAzurermStreamAnalyticsJob.DataAzurermStreamAnalyticsJob), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.dataAzurermStreamAnalyticsJob.DataAzurermStreamAnalyticsJobTimeouts\"}}]")]
        public virtual void PutTimeouts(azurerm.DataAzurermStreamAnalyticsJob.IDataAzurermStreamAnalyticsJobTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.DataAzurermStreamAnalyticsJob.IDataAzurermStreamAnalyticsJobTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
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
        = GetStaticProperty<string>(typeof(azurerm.DataAzurermStreamAnalyticsJob.DataAzurermStreamAnalyticsJob))!;

        [JsiiProperty(name: "compatibilityLevel", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompatibilityLevel
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dataLocale", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DataLocale
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "eventsLateArrivalMaxDelayInSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double EventsLateArrivalMaxDelayInSeconds
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "eventsOutOfOrderMaxDelayInSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double EventsOutOfOrderMaxDelayInSeconds
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "eventsOutOfOrderPolicy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EventsOutOfOrderPolicy
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "identity", typeJson: "{\"fqn\":\"azurerm.dataAzurermStreamAnalyticsJob.DataAzurermStreamAnalyticsJobIdentityList\"}")]
        public virtual azurerm.DataAzurermStreamAnalyticsJob.DataAzurermStreamAnalyticsJobIdentityList Identity
        {
            get => GetInstanceProperty<azurerm.DataAzurermStreamAnalyticsJob.DataAzurermStreamAnalyticsJobIdentityList>()!;
        }

        [JsiiProperty(name: "jobId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string JobId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lastOutputTime", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LastOutputTime
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Location
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "outputErrorPolicy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OutputErrorPolicy
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "skuName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SkuName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "startMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StartMode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "startTime", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StartTime
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "streamingUnits", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double StreamingUnits
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.dataAzurermStreamAnalyticsJob.DataAzurermStreamAnalyticsJobTimeoutsOutputReference\"}")]
        public virtual azurerm.DataAzurermStreamAnalyticsJob.DataAzurermStreamAnalyticsJobTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurerm.DataAzurermStreamAnalyticsJob.DataAzurermStreamAnalyticsJobTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "transformationQuery", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TransformationQuery
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
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
        [JsiiProperty(name: "resourceGroupNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ResourceGroupNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"azurerm.dataAzurermStreamAnalyticsJob.DataAzurermStreamAnalyticsJobTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
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

        [JsiiProperty(name: "resourceGroupName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourceGroupName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
