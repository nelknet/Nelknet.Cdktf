using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.GuarddutyOrganizationConfiguration
{
    [JsiiClass(nativeType: typeof(aws.GuarddutyOrganizationConfiguration.GuarddutyOrganizationConfigurationDatasourcesOutputReference), fullyQualifiedName: "aws.guarddutyOrganizationConfiguration.GuarddutyOrganizationConfigurationDatasourcesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class GuarddutyOrganizationConfigurationDatasourcesOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public GuarddutyOrganizationConfigurationDatasourcesOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected GuarddutyOrganizationConfigurationDatasourcesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected GuarddutyOrganizationConfigurationDatasourcesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putKubernetes", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.guarddutyOrganizationConfiguration.GuarddutyOrganizationConfigurationDatasourcesKubernetes\"}}]")]
        public virtual void PutKubernetes(aws.GuarddutyOrganizationConfiguration.IGuarddutyOrganizationConfigurationDatasourcesKubernetes @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.GuarddutyOrganizationConfiguration.IGuarddutyOrganizationConfigurationDatasourcesKubernetes)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMalwareProtection", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.guarddutyOrganizationConfiguration.GuarddutyOrganizationConfigurationDatasourcesMalwareProtection\"}}]")]
        public virtual void PutMalwareProtection(aws.GuarddutyOrganizationConfiguration.IGuarddutyOrganizationConfigurationDatasourcesMalwareProtection @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.GuarddutyOrganizationConfiguration.IGuarddutyOrganizationConfigurationDatasourcesMalwareProtection)}, new object[]{@value});
        }

        [JsiiMethod(name: "putS3Logs", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.guarddutyOrganizationConfiguration.GuarddutyOrganizationConfigurationDatasourcesS3Logs\"}}]")]
        public virtual void PutS3Logs(aws.GuarddutyOrganizationConfiguration.IGuarddutyOrganizationConfigurationDatasourcesS3Logs @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.GuarddutyOrganizationConfiguration.IGuarddutyOrganizationConfigurationDatasourcesS3Logs)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetKubernetes")]
        public virtual void ResetKubernetes()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMalwareProtection")]
        public virtual void ResetMalwareProtection()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetS3Logs")]
        public virtual void ResetS3Logs()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "kubernetes", typeJson: "{\"fqn\":\"aws.guarddutyOrganizationConfiguration.GuarddutyOrganizationConfigurationDatasourcesKubernetesOutputReference\"}")]
        public virtual aws.GuarddutyOrganizationConfiguration.GuarddutyOrganizationConfigurationDatasourcesKubernetesOutputReference Kubernetes
        {
            get => GetInstanceProperty<aws.GuarddutyOrganizationConfiguration.GuarddutyOrganizationConfigurationDatasourcesKubernetesOutputReference>()!;
        }

        [JsiiProperty(name: "malwareProtection", typeJson: "{\"fqn\":\"aws.guarddutyOrganizationConfiguration.GuarddutyOrganizationConfigurationDatasourcesMalwareProtectionOutputReference\"}")]
        public virtual aws.GuarddutyOrganizationConfiguration.GuarddutyOrganizationConfigurationDatasourcesMalwareProtectionOutputReference MalwareProtection
        {
            get => GetInstanceProperty<aws.GuarddutyOrganizationConfiguration.GuarddutyOrganizationConfigurationDatasourcesMalwareProtectionOutputReference>()!;
        }

        [JsiiProperty(name: "s3Logs", typeJson: "{\"fqn\":\"aws.guarddutyOrganizationConfiguration.GuarddutyOrganizationConfigurationDatasourcesS3LogsOutputReference\"}")]
        public virtual aws.GuarddutyOrganizationConfiguration.GuarddutyOrganizationConfigurationDatasourcesS3LogsOutputReference S3Logs
        {
            get => GetInstanceProperty<aws.GuarddutyOrganizationConfiguration.GuarddutyOrganizationConfigurationDatasourcesS3LogsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "kubernetesInput", typeJson: "{\"fqn\":\"aws.guarddutyOrganizationConfiguration.GuarddutyOrganizationConfigurationDatasourcesKubernetes\"}", isOptional: true)]
        public virtual aws.GuarddutyOrganizationConfiguration.IGuarddutyOrganizationConfigurationDatasourcesKubernetes? KubernetesInput
        {
            get => GetInstanceProperty<aws.GuarddutyOrganizationConfiguration.IGuarddutyOrganizationConfigurationDatasourcesKubernetes?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "malwareProtectionInput", typeJson: "{\"fqn\":\"aws.guarddutyOrganizationConfiguration.GuarddutyOrganizationConfigurationDatasourcesMalwareProtection\"}", isOptional: true)]
        public virtual aws.GuarddutyOrganizationConfiguration.IGuarddutyOrganizationConfigurationDatasourcesMalwareProtection? MalwareProtectionInput
        {
            get => GetInstanceProperty<aws.GuarddutyOrganizationConfiguration.IGuarddutyOrganizationConfigurationDatasourcesMalwareProtection?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "s3LogsInput", typeJson: "{\"fqn\":\"aws.guarddutyOrganizationConfiguration.GuarddutyOrganizationConfigurationDatasourcesS3Logs\"}", isOptional: true)]
        public virtual aws.GuarddutyOrganizationConfiguration.IGuarddutyOrganizationConfigurationDatasourcesS3Logs? S3LogsInput
        {
            get => GetInstanceProperty<aws.GuarddutyOrganizationConfiguration.IGuarddutyOrganizationConfigurationDatasourcesS3Logs?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.guarddutyOrganizationConfiguration.GuarddutyOrganizationConfigurationDatasources\"}", isOptional: true)]
        public virtual aws.GuarddutyOrganizationConfiguration.IGuarddutyOrganizationConfigurationDatasources? InternalValue
        {
            get => GetInstanceProperty<aws.GuarddutyOrganizationConfiguration.IGuarddutyOrganizationConfigurationDatasources?>();
            set => SetInstanceProperty(value);
        }
    }
}
