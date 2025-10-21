using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CodedeployDeploymentConfig
{
    [JsiiClass(nativeType: typeof(aws.CodedeployDeploymentConfig.CodedeployDeploymentConfigZonalConfigOutputReference), fullyQualifiedName: "aws.codedeployDeploymentConfig.CodedeployDeploymentConfigZonalConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class CodedeployDeploymentConfigZonalConfigOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public CodedeployDeploymentConfigZonalConfigOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected CodedeployDeploymentConfigZonalConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CodedeployDeploymentConfigZonalConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putMinimumHealthyHostsPerZone", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.codedeployDeploymentConfig.CodedeployDeploymentConfigZonalConfigMinimumHealthyHostsPerZone\"}}]")]
        public virtual void PutMinimumHealthyHostsPerZone(aws.CodedeployDeploymentConfig.ICodedeployDeploymentConfigZonalConfigMinimumHealthyHostsPerZone @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.CodedeployDeploymentConfig.ICodedeployDeploymentConfigZonalConfigMinimumHealthyHostsPerZone)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetFirstZoneMonitorDurationInSeconds")]
        public virtual void ResetFirstZoneMonitorDurationInSeconds()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMinimumHealthyHostsPerZone")]
        public virtual void ResetMinimumHealthyHostsPerZone()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMonitorDurationInSeconds")]
        public virtual void ResetMonitorDurationInSeconds()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "minimumHealthyHostsPerZone", typeJson: "{\"fqn\":\"aws.codedeployDeploymentConfig.CodedeployDeploymentConfigZonalConfigMinimumHealthyHostsPerZoneOutputReference\"}")]
        public virtual aws.CodedeployDeploymentConfig.CodedeployDeploymentConfigZonalConfigMinimumHealthyHostsPerZoneOutputReference MinimumHealthyHostsPerZone
        {
            get => GetInstanceProperty<aws.CodedeployDeploymentConfig.CodedeployDeploymentConfigZonalConfigMinimumHealthyHostsPerZoneOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "firstZoneMonitorDurationInSecondsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? FirstZoneMonitorDurationInSecondsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "minimumHealthyHostsPerZoneInput", typeJson: "{\"fqn\":\"aws.codedeployDeploymentConfig.CodedeployDeploymentConfigZonalConfigMinimumHealthyHostsPerZone\"}", isOptional: true)]
        public virtual aws.CodedeployDeploymentConfig.ICodedeployDeploymentConfigZonalConfigMinimumHealthyHostsPerZone? MinimumHealthyHostsPerZoneInput
        {
            get => GetInstanceProperty<aws.CodedeployDeploymentConfig.ICodedeployDeploymentConfigZonalConfigMinimumHealthyHostsPerZone?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "monitorDurationInSecondsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MonitorDurationInSecondsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "firstZoneMonitorDurationInSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double FirstZoneMonitorDurationInSeconds
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "monitorDurationInSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MonitorDurationInSeconds
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.codedeployDeploymentConfig.CodedeployDeploymentConfigZonalConfig\"}", isOptional: true)]
        public virtual aws.CodedeployDeploymentConfig.ICodedeployDeploymentConfigZonalConfig? InternalValue
        {
            get => GetInstanceProperty<aws.CodedeployDeploymentConfig.ICodedeployDeploymentConfigZonalConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
