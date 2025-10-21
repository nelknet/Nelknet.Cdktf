using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.KubernetesFleetUpdateRun
{
    [JsiiClass(nativeType: typeof(azurerm.KubernetesFleetUpdateRun.KubernetesFleetUpdateRunManagedClusterUpdateOutputReference), fullyQualifiedName: "azurerm.kubernetesFleetUpdateRun.KubernetesFleetUpdateRunManagedClusterUpdateOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class KubernetesFleetUpdateRunManagedClusterUpdateOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public KubernetesFleetUpdateRunManagedClusterUpdateOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected KubernetesFleetUpdateRunManagedClusterUpdateOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected KubernetesFleetUpdateRunManagedClusterUpdateOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putNodeImageSelection", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.kubernetesFleetUpdateRun.KubernetesFleetUpdateRunManagedClusterUpdateNodeImageSelection\"}}]")]
        public virtual void PutNodeImageSelection(azurerm.KubernetesFleetUpdateRun.IKubernetesFleetUpdateRunManagedClusterUpdateNodeImageSelection @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.KubernetesFleetUpdateRun.IKubernetesFleetUpdateRunManagedClusterUpdateNodeImageSelection)}, new object[]{@value});
        }

        [JsiiMethod(name: "putUpgrade", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.kubernetesFleetUpdateRun.KubernetesFleetUpdateRunManagedClusterUpdateUpgrade\"}}]")]
        public virtual void PutUpgrade(azurerm.KubernetesFleetUpdateRun.IKubernetesFleetUpdateRunManagedClusterUpdateUpgrade @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.KubernetesFleetUpdateRun.IKubernetesFleetUpdateRunManagedClusterUpdateUpgrade)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetNodeImageSelection")]
        public virtual void ResetNodeImageSelection()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "nodeImageSelection", typeJson: "{\"fqn\":\"azurerm.kubernetesFleetUpdateRun.KubernetesFleetUpdateRunManagedClusterUpdateNodeImageSelectionOutputReference\"}")]
        public virtual azurerm.KubernetesFleetUpdateRun.KubernetesFleetUpdateRunManagedClusterUpdateNodeImageSelectionOutputReference NodeImageSelection
        {
            get => GetInstanceProperty<azurerm.KubernetesFleetUpdateRun.KubernetesFleetUpdateRunManagedClusterUpdateNodeImageSelectionOutputReference>()!;
        }

        [JsiiProperty(name: "upgrade", typeJson: "{\"fqn\":\"azurerm.kubernetesFleetUpdateRun.KubernetesFleetUpdateRunManagedClusterUpdateUpgradeOutputReference\"}")]
        public virtual azurerm.KubernetesFleetUpdateRun.KubernetesFleetUpdateRunManagedClusterUpdateUpgradeOutputReference Upgrade
        {
            get => GetInstanceProperty<azurerm.KubernetesFleetUpdateRun.KubernetesFleetUpdateRunManagedClusterUpdateUpgradeOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "nodeImageSelectionInput", typeJson: "{\"fqn\":\"azurerm.kubernetesFleetUpdateRun.KubernetesFleetUpdateRunManagedClusterUpdateNodeImageSelection\"}", isOptional: true)]
        public virtual azurerm.KubernetesFleetUpdateRun.IKubernetesFleetUpdateRunManagedClusterUpdateNodeImageSelection? NodeImageSelectionInput
        {
            get => GetInstanceProperty<azurerm.KubernetesFleetUpdateRun.IKubernetesFleetUpdateRunManagedClusterUpdateNodeImageSelection?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "upgradeInput", typeJson: "{\"fqn\":\"azurerm.kubernetesFleetUpdateRun.KubernetesFleetUpdateRunManagedClusterUpdateUpgrade\"}", isOptional: true)]
        public virtual azurerm.KubernetesFleetUpdateRun.IKubernetesFleetUpdateRunManagedClusterUpdateUpgrade? UpgradeInput
        {
            get => GetInstanceProperty<azurerm.KubernetesFleetUpdateRun.IKubernetesFleetUpdateRunManagedClusterUpdateUpgrade?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.kubernetesFleetUpdateRun.KubernetesFleetUpdateRunManagedClusterUpdate\"}", isOptional: true)]
        public virtual azurerm.KubernetesFleetUpdateRun.IKubernetesFleetUpdateRunManagedClusterUpdate? InternalValue
        {
            get => GetInstanceProperty<azurerm.KubernetesFleetUpdateRun.IKubernetesFleetUpdateRunManagedClusterUpdate?>();
            set => SetInstanceProperty(value);
        }
    }
}
