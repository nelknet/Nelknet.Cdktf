using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermContainerApp
{
    [JsiiClass(nativeType: typeof(azurerm.DataAzurermContainerApp.DataAzurermContainerAppTemplateOutputReference), fullyQualifiedName: "azurerm.dataAzurermContainerApp.DataAzurermContainerAppTemplateOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataAzurermContainerAppTemplateOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataAzurermContainerAppTemplateOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataAzurermContainerAppTemplateOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzurermContainerAppTemplateOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "azureQueueScaleRule", typeJson: "{\"fqn\":\"azurerm.dataAzurermContainerApp.DataAzurermContainerAppTemplateAzureQueueScaleRuleList\"}")]
        public virtual azurerm.DataAzurermContainerApp.DataAzurermContainerAppTemplateAzureQueueScaleRuleList AzureQueueScaleRule
        {
            get => GetInstanceProperty<azurerm.DataAzurermContainerApp.DataAzurermContainerAppTemplateAzureQueueScaleRuleList>()!;
        }

        [JsiiProperty(name: "container", typeJson: "{\"fqn\":\"azurerm.dataAzurermContainerApp.DataAzurermContainerAppTemplateContainerList\"}")]
        public virtual azurerm.DataAzurermContainerApp.DataAzurermContainerAppTemplateContainerList Container
        {
            get => GetInstanceProperty<azurerm.DataAzurermContainerApp.DataAzurermContainerAppTemplateContainerList>()!;
        }

        [JsiiProperty(name: "customScaleRule", typeJson: "{\"fqn\":\"azurerm.dataAzurermContainerApp.DataAzurermContainerAppTemplateCustomScaleRuleList\"}")]
        public virtual azurerm.DataAzurermContainerApp.DataAzurermContainerAppTemplateCustomScaleRuleList CustomScaleRule
        {
            get => GetInstanceProperty<azurerm.DataAzurermContainerApp.DataAzurermContainerAppTemplateCustomScaleRuleList>()!;
        }

        [JsiiProperty(name: "httpScaleRule", typeJson: "{\"fqn\":\"azurerm.dataAzurermContainerApp.DataAzurermContainerAppTemplateHttpScaleRuleList\"}")]
        public virtual azurerm.DataAzurermContainerApp.DataAzurermContainerAppTemplateHttpScaleRuleList HttpScaleRule
        {
            get => GetInstanceProperty<azurerm.DataAzurermContainerApp.DataAzurermContainerAppTemplateHttpScaleRuleList>()!;
        }

        [JsiiProperty(name: "initContainer", typeJson: "{\"fqn\":\"azurerm.dataAzurermContainerApp.DataAzurermContainerAppTemplateInitContainerList\"}")]
        public virtual azurerm.DataAzurermContainerApp.DataAzurermContainerAppTemplateInitContainerList InitContainer
        {
            get => GetInstanceProperty<azurerm.DataAzurermContainerApp.DataAzurermContainerAppTemplateInitContainerList>()!;
        }

        [JsiiProperty(name: "maxReplicas", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxReplicas
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "minReplicas", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MinReplicas
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "revisionSuffix", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RevisionSuffix
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tcpScaleRule", typeJson: "{\"fqn\":\"azurerm.dataAzurermContainerApp.DataAzurermContainerAppTemplateTcpScaleRuleList\"}")]
        public virtual azurerm.DataAzurermContainerApp.DataAzurermContainerAppTemplateTcpScaleRuleList TcpScaleRule
        {
            get => GetInstanceProperty<azurerm.DataAzurermContainerApp.DataAzurermContainerAppTemplateTcpScaleRuleList>()!;
        }

        [JsiiProperty(name: "volume", typeJson: "{\"fqn\":\"azurerm.dataAzurermContainerApp.DataAzurermContainerAppTemplateVolumeList\"}")]
        public virtual azurerm.DataAzurermContainerApp.DataAzurermContainerAppTemplateVolumeList Volume
        {
            get => GetInstanceProperty<azurerm.DataAzurermContainerApp.DataAzurermContainerAppTemplateVolumeList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.dataAzurermContainerApp.DataAzurermContainerAppTemplate\"}", isOptional: true)]
        public virtual azurerm.DataAzurermContainerApp.IDataAzurermContainerAppTemplate? InternalValue
        {
            get => GetInstanceProperty<azurerm.DataAzurermContainerApp.IDataAzurermContainerAppTemplate?>();
            set => SetInstanceProperty(value);
        }
    }
}
