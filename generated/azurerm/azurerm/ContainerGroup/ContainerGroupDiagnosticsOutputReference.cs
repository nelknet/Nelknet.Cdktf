using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ContainerGroup
{
    [JsiiClass(nativeType: typeof(azurerm.ContainerGroup.ContainerGroupDiagnosticsOutputReference), fullyQualifiedName: "azurerm.containerGroup.ContainerGroupDiagnosticsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ContainerGroupDiagnosticsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ContainerGroupDiagnosticsOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected ContainerGroupDiagnosticsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ContainerGroupDiagnosticsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putLogAnalytics", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.containerGroup.ContainerGroupDiagnosticsLogAnalytics\"}}]")]
        public virtual void PutLogAnalytics(azurerm.ContainerGroup.IContainerGroupDiagnosticsLogAnalytics @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.ContainerGroup.IContainerGroupDiagnosticsLogAnalytics)}, new object[]{@value});
        }

        [JsiiProperty(name: "logAnalytics", typeJson: "{\"fqn\":\"azurerm.containerGroup.ContainerGroupDiagnosticsLogAnalyticsOutputReference\"}")]
        public virtual azurerm.ContainerGroup.ContainerGroupDiagnosticsLogAnalyticsOutputReference LogAnalytics
        {
            get => GetInstanceProperty<azurerm.ContainerGroup.ContainerGroupDiagnosticsLogAnalyticsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "logAnalyticsInput", typeJson: "{\"fqn\":\"azurerm.containerGroup.ContainerGroupDiagnosticsLogAnalytics\"}", isOptional: true)]
        public virtual azurerm.ContainerGroup.IContainerGroupDiagnosticsLogAnalytics? LogAnalyticsInput
        {
            get => GetInstanceProperty<azurerm.ContainerGroup.IContainerGroupDiagnosticsLogAnalytics?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.containerGroup.ContainerGroupDiagnostics\"}", isOptional: true)]
        public virtual azurerm.ContainerGroup.IContainerGroupDiagnostics? InternalValue
        {
            get => GetInstanceProperty<azurerm.ContainerGroup.IContainerGroupDiagnostics?>();
            set => SetInstanceProperty(value);
        }
    }
}
