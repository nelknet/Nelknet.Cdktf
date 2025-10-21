using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermContainerApp
{
    [JsiiClass(nativeType: typeof(azurerm.DataAzurermContainerApp.DataAzurermContainerAppTemplateContainerStartupProbeOutputReference), fullyQualifiedName: "azurerm.dataAzurermContainerApp.DataAzurermContainerAppTemplateContainerStartupProbeOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataAzurermContainerAppTemplateContainerStartupProbeOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataAzurermContainerAppTemplateContainerStartupProbeOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataAzurermContainerAppTemplateContainerStartupProbeOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzurermContainerAppTemplateContainerStartupProbeOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "failureCountThreshold", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double FailureCountThreshold
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "header", typeJson: "{\"fqn\":\"azurerm.dataAzurermContainerApp.DataAzurermContainerAppTemplateContainerStartupProbeHeaderList\"}")]
        public virtual azurerm.DataAzurermContainerApp.DataAzurermContainerAppTemplateContainerStartupProbeHeaderList Header
        {
            get => GetInstanceProperty<azurerm.DataAzurermContainerApp.DataAzurermContainerAppTemplateContainerStartupProbeHeaderList>()!;
        }

        [JsiiProperty(name: "host", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Host
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "intervalSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double IntervalSeconds
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Path
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Port
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "terminationGracePeriodSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TerminationGracePeriodSeconds
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "timeout", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Timeout
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "transport", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Transport
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.dataAzurermContainerApp.DataAzurermContainerAppTemplateContainerStartupProbe\"}", isOptional: true)]
        public virtual azurerm.DataAzurermContainerApp.IDataAzurermContainerAppTemplateContainerStartupProbe? InternalValue
        {
            get => GetInstanceProperty<azurerm.DataAzurermContainerApp.IDataAzurermContainerAppTemplateContainerStartupProbe?>();
            set => SetInstanceProperty(value);
        }
    }
}
