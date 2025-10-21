using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.InternetmonitorMonitor
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/internetmonitor_monitor aws_internetmonitor_monitor}.</summary>
    [JsiiClass(nativeType: typeof(aws.InternetmonitorMonitor.InternetmonitorMonitor), fullyQualifiedName: "aws.internetmonitorMonitor.InternetmonitorMonitor", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.internetmonitorMonitor.InternetmonitorMonitorConfig\"}}]")]
    public class InternetmonitorMonitor : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/internetmonitor_monitor aws_internetmonitor_monitor} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public InternetmonitorMonitor(Constructs.Construct scope, string id, aws.InternetmonitorMonitor.IInternetmonitorMonitorConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.InternetmonitorMonitor.IInternetmonitorMonitorConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected InternetmonitorMonitor(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected InternetmonitorMonitor(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a InternetmonitorMonitor resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the InternetmonitorMonitor to import.</param>
        /// <param name="importFromId">The id of the existing InternetmonitorMonitor that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the InternetmonitorMonitor to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the InternetmonitorMonitor to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/internetmonitor_monitor#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing InternetmonitorMonitor that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the InternetmonitorMonitor to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(aws.InternetmonitorMonitor.InternetmonitorMonitor), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putHealthEventsConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.internetmonitorMonitor.InternetmonitorMonitorHealthEventsConfig\"}}]")]
        public virtual void PutHealthEventsConfig(aws.InternetmonitorMonitor.IInternetmonitorMonitorHealthEventsConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.InternetmonitorMonitor.IInternetmonitorMonitorHealthEventsConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putInternetMeasurementsLogDelivery", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.internetmonitorMonitor.InternetmonitorMonitorInternetMeasurementsLogDelivery\"}}]")]
        public virtual void PutInternetMeasurementsLogDelivery(aws.InternetmonitorMonitor.IInternetmonitorMonitorInternetMeasurementsLogDelivery @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.InternetmonitorMonitor.IInternetmonitorMonitorInternetMeasurementsLogDelivery)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetHealthEventsConfig")]
        public virtual void ResetHealthEventsConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInternetMeasurementsLogDelivery")]
        public virtual void ResetInternetMeasurementsLogDelivery()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaxCityNetworksToMonitor")]
        public virtual void ResetMaxCityNetworksToMonitor()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetResources")]
        public virtual void ResetResources()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStatus")]
        public virtual void ResetStatus()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTagsAll")]
        public virtual void ResetTagsAll()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTrafficPercentageToMonitor")]
        public virtual void ResetTrafficPercentageToMonitor()
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
        = GetStaticProperty<string>(typeof(aws.InternetmonitorMonitor.InternetmonitorMonitor))!;

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "healthEventsConfig", typeJson: "{\"fqn\":\"aws.internetmonitorMonitor.InternetmonitorMonitorHealthEventsConfigOutputReference\"}")]
        public virtual aws.InternetmonitorMonitor.InternetmonitorMonitorHealthEventsConfigOutputReference HealthEventsConfig
        {
            get => GetInstanceProperty<aws.InternetmonitorMonitor.InternetmonitorMonitorHealthEventsConfigOutputReference>()!;
        }

        [JsiiProperty(name: "internetMeasurementsLogDelivery", typeJson: "{\"fqn\":\"aws.internetmonitorMonitor.InternetmonitorMonitorInternetMeasurementsLogDeliveryOutputReference\"}")]
        public virtual aws.InternetmonitorMonitor.InternetmonitorMonitorInternetMeasurementsLogDeliveryOutputReference InternetMeasurementsLogDelivery
        {
            get => GetInstanceProperty<aws.InternetmonitorMonitor.InternetmonitorMonitorInternetMeasurementsLogDeliveryOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "healthEventsConfigInput", typeJson: "{\"fqn\":\"aws.internetmonitorMonitor.InternetmonitorMonitorHealthEventsConfig\"}", isOptional: true)]
        public virtual aws.InternetmonitorMonitor.IInternetmonitorMonitorHealthEventsConfig? HealthEventsConfigInput
        {
            get => GetInstanceProperty<aws.InternetmonitorMonitor.IInternetmonitorMonitorHealthEventsConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internetMeasurementsLogDeliveryInput", typeJson: "{\"fqn\":\"aws.internetmonitorMonitor.InternetmonitorMonitorInternetMeasurementsLogDelivery\"}", isOptional: true)]
        public virtual aws.InternetmonitorMonitor.IInternetmonitorMonitorInternetMeasurementsLogDelivery? InternetMeasurementsLogDeliveryInput
        {
            get => GetInstanceProperty<aws.InternetmonitorMonitor.IInternetmonitorMonitorInternetMeasurementsLogDelivery?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxCityNetworksToMonitorInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaxCityNetworksToMonitorInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "monitorNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MonitorNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "resourcesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? ResourcesInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "statusInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? StatusInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsAllInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsAllInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "trafficPercentageToMonitorInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? TrafficPercentageToMonitorInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "maxCityNetworksToMonitor", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxCityNetworksToMonitor
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "monitorName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MonitorName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "resources", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Resources
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Tags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tagsAll", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> TagsAll
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "trafficPercentageToMonitor", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TrafficPercentageToMonitor
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }
    }
}
