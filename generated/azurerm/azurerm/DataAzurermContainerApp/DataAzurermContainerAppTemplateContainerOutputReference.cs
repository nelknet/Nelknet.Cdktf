using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermContainerApp
{
    [JsiiClass(nativeType: typeof(azurerm.DataAzurermContainerApp.DataAzurermContainerAppTemplateContainerOutputReference), fullyQualifiedName: "azurerm.dataAzurermContainerApp.DataAzurermContainerAppTemplateContainerOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataAzurermContainerAppTemplateContainerOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataAzurermContainerAppTemplateContainerOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataAzurermContainerAppTemplateContainerOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzurermContainerAppTemplateContainerOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "args", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Args
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "command", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Command
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "cpu", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Cpu
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "env", typeJson: "{\"fqn\":\"azurerm.dataAzurermContainerApp.DataAzurermContainerAppTemplateContainerEnvList\"}")]
        public virtual azurerm.DataAzurermContainerApp.DataAzurermContainerAppTemplateContainerEnvList Env
        {
            get => GetInstanceProperty<azurerm.DataAzurermContainerApp.DataAzurermContainerAppTemplateContainerEnvList>()!;
        }

        [JsiiProperty(name: "ephemeralStorage", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EphemeralStorage
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "image", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Image
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "livenessProbe", typeJson: "{\"fqn\":\"azurerm.dataAzurermContainerApp.DataAzurermContainerAppTemplateContainerLivenessProbeList\"}")]
        public virtual azurerm.DataAzurermContainerApp.DataAzurermContainerAppTemplateContainerLivenessProbeList LivenessProbe
        {
            get => GetInstanceProperty<azurerm.DataAzurermContainerApp.DataAzurermContainerAppTemplateContainerLivenessProbeList>()!;
        }

        [JsiiProperty(name: "memory", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Memory
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "readinessProbe", typeJson: "{\"fqn\":\"azurerm.dataAzurermContainerApp.DataAzurermContainerAppTemplateContainerReadinessProbeList\"}")]
        public virtual azurerm.DataAzurermContainerApp.DataAzurermContainerAppTemplateContainerReadinessProbeList ReadinessProbe
        {
            get => GetInstanceProperty<azurerm.DataAzurermContainerApp.DataAzurermContainerAppTemplateContainerReadinessProbeList>()!;
        }

        [JsiiProperty(name: "startupProbe", typeJson: "{\"fqn\":\"azurerm.dataAzurermContainerApp.DataAzurermContainerAppTemplateContainerStartupProbeList\"}")]
        public virtual azurerm.DataAzurermContainerApp.DataAzurermContainerAppTemplateContainerStartupProbeList StartupProbe
        {
            get => GetInstanceProperty<azurerm.DataAzurermContainerApp.DataAzurermContainerAppTemplateContainerStartupProbeList>()!;
        }

        [JsiiProperty(name: "volumeMounts", typeJson: "{\"fqn\":\"azurerm.dataAzurermContainerApp.DataAzurermContainerAppTemplateContainerVolumeMountsList\"}")]
        public virtual azurerm.DataAzurermContainerApp.DataAzurermContainerAppTemplateContainerVolumeMountsList VolumeMounts
        {
            get => GetInstanceProperty<azurerm.DataAzurermContainerApp.DataAzurermContainerAppTemplateContainerVolumeMountsList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.dataAzurermContainerApp.DataAzurermContainerAppTemplateContainer\"}", isOptional: true)]
        public virtual azurerm.DataAzurermContainerApp.IDataAzurermContainerAppTemplateContainer? InternalValue
        {
            get => GetInstanceProperty<azurerm.DataAzurermContainerApp.IDataAzurermContainerAppTemplateContainer?>();
            set => SetInstanceProperty(value);
        }
    }
}
