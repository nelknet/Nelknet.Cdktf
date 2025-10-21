using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MwaaEnvironment
{
    [JsiiClass(nativeType: typeof(aws.MwaaEnvironment.MwaaEnvironmentLoggingConfigurationOutputReference), fullyQualifiedName: "aws.mwaaEnvironment.MwaaEnvironmentLoggingConfigurationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class MwaaEnvironmentLoggingConfigurationOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public MwaaEnvironmentLoggingConfigurationOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected MwaaEnvironmentLoggingConfigurationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MwaaEnvironmentLoggingConfigurationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putDagProcessingLogs", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.mwaaEnvironment.MwaaEnvironmentLoggingConfigurationDagProcessingLogs\"}}]")]
        public virtual void PutDagProcessingLogs(aws.MwaaEnvironment.IMwaaEnvironmentLoggingConfigurationDagProcessingLogs @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.MwaaEnvironment.IMwaaEnvironmentLoggingConfigurationDagProcessingLogs)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSchedulerLogs", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.mwaaEnvironment.MwaaEnvironmentLoggingConfigurationSchedulerLogs\"}}]")]
        public virtual void PutSchedulerLogs(aws.MwaaEnvironment.IMwaaEnvironmentLoggingConfigurationSchedulerLogs @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.MwaaEnvironment.IMwaaEnvironmentLoggingConfigurationSchedulerLogs)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTaskLogs", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.mwaaEnvironment.MwaaEnvironmentLoggingConfigurationTaskLogs\"}}]")]
        public virtual void PutTaskLogs(aws.MwaaEnvironment.IMwaaEnvironmentLoggingConfigurationTaskLogs @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.MwaaEnvironment.IMwaaEnvironmentLoggingConfigurationTaskLogs)}, new object[]{@value});
        }

        [JsiiMethod(name: "putWebserverLogs", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.mwaaEnvironment.MwaaEnvironmentLoggingConfigurationWebserverLogs\"}}]")]
        public virtual void PutWebserverLogs(aws.MwaaEnvironment.IMwaaEnvironmentLoggingConfigurationWebserverLogs @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.MwaaEnvironment.IMwaaEnvironmentLoggingConfigurationWebserverLogs)}, new object[]{@value});
        }

        [JsiiMethod(name: "putWorkerLogs", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.mwaaEnvironment.MwaaEnvironmentLoggingConfigurationWorkerLogs\"}}]")]
        public virtual void PutWorkerLogs(aws.MwaaEnvironment.IMwaaEnvironmentLoggingConfigurationWorkerLogs @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.MwaaEnvironment.IMwaaEnvironmentLoggingConfigurationWorkerLogs)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDagProcessingLogs")]
        public virtual void ResetDagProcessingLogs()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSchedulerLogs")]
        public virtual void ResetSchedulerLogs()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTaskLogs")]
        public virtual void ResetTaskLogs()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetWebserverLogs")]
        public virtual void ResetWebserverLogs()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetWorkerLogs")]
        public virtual void ResetWorkerLogs()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "dagProcessingLogs", typeJson: "{\"fqn\":\"aws.mwaaEnvironment.MwaaEnvironmentLoggingConfigurationDagProcessingLogsOutputReference\"}")]
        public virtual aws.MwaaEnvironment.MwaaEnvironmentLoggingConfigurationDagProcessingLogsOutputReference DagProcessingLogs
        {
            get => GetInstanceProperty<aws.MwaaEnvironment.MwaaEnvironmentLoggingConfigurationDagProcessingLogsOutputReference>()!;
        }

        [JsiiProperty(name: "schedulerLogs", typeJson: "{\"fqn\":\"aws.mwaaEnvironment.MwaaEnvironmentLoggingConfigurationSchedulerLogsOutputReference\"}")]
        public virtual aws.MwaaEnvironment.MwaaEnvironmentLoggingConfigurationSchedulerLogsOutputReference SchedulerLogs
        {
            get => GetInstanceProperty<aws.MwaaEnvironment.MwaaEnvironmentLoggingConfigurationSchedulerLogsOutputReference>()!;
        }

        [JsiiProperty(name: "taskLogs", typeJson: "{\"fqn\":\"aws.mwaaEnvironment.MwaaEnvironmentLoggingConfigurationTaskLogsOutputReference\"}")]
        public virtual aws.MwaaEnvironment.MwaaEnvironmentLoggingConfigurationTaskLogsOutputReference TaskLogs
        {
            get => GetInstanceProperty<aws.MwaaEnvironment.MwaaEnvironmentLoggingConfigurationTaskLogsOutputReference>()!;
        }

        [JsiiProperty(name: "webserverLogs", typeJson: "{\"fqn\":\"aws.mwaaEnvironment.MwaaEnvironmentLoggingConfigurationWebserverLogsOutputReference\"}")]
        public virtual aws.MwaaEnvironment.MwaaEnvironmentLoggingConfigurationWebserverLogsOutputReference WebserverLogs
        {
            get => GetInstanceProperty<aws.MwaaEnvironment.MwaaEnvironmentLoggingConfigurationWebserverLogsOutputReference>()!;
        }

        [JsiiProperty(name: "workerLogs", typeJson: "{\"fqn\":\"aws.mwaaEnvironment.MwaaEnvironmentLoggingConfigurationWorkerLogsOutputReference\"}")]
        public virtual aws.MwaaEnvironment.MwaaEnvironmentLoggingConfigurationWorkerLogsOutputReference WorkerLogs
        {
            get => GetInstanceProperty<aws.MwaaEnvironment.MwaaEnvironmentLoggingConfigurationWorkerLogsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "dagProcessingLogsInput", typeJson: "{\"fqn\":\"aws.mwaaEnvironment.MwaaEnvironmentLoggingConfigurationDagProcessingLogs\"}", isOptional: true)]
        public virtual aws.MwaaEnvironment.IMwaaEnvironmentLoggingConfigurationDagProcessingLogs? DagProcessingLogsInput
        {
            get => GetInstanceProperty<aws.MwaaEnvironment.IMwaaEnvironmentLoggingConfigurationDagProcessingLogs?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "schedulerLogsInput", typeJson: "{\"fqn\":\"aws.mwaaEnvironment.MwaaEnvironmentLoggingConfigurationSchedulerLogs\"}", isOptional: true)]
        public virtual aws.MwaaEnvironment.IMwaaEnvironmentLoggingConfigurationSchedulerLogs? SchedulerLogsInput
        {
            get => GetInstanceProperty<aws.MwaaEnvironment.IMwaaEnvironmentLoggingConfigurationSchedulerLogs?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "taskLogsInput", typeJson: "{\"fqn\":\"aws.mwaaEnvironment.MwaaEnvironmentLoggingConfigurationTaskLogs\"}", isOptional: true)]
        public virtual aws.MwaaEnvironment.IMwaaEnvironmentLoggingConfigurationTaskLogs? TaskLogsInput
        {
            get => GetInstanceProperty<aws.MwaaEnvironment.IMwaaEnvironmentLoggingConfigurationTaskLogs?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "webserverLogsInput", typeJson: "{\"fqn\":\"aws.mwaaEnvironment.MwaaEnvironmentLoggingConfigurationWebserverLogs\"}", isOptional: true)]
        public virtual aws.MwaaEnvironment.IMwaaEnvironmentLoggingConfigurationWebserverLogs? WebserverLogsInput
        {
            get => GetInstanceProperty<aws.MwaaEnvironment.IMwaaEnvironmentLoggingConfigurationWebserverLogs?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "workerLogsInput", typeJson: "{\"fqn\":\"aws.mwaaEnvironment.MwaaEnvironmentLoggingConfigurationWorkerLogs\"}", isOptional: true)]
        public virtual aws.MwaaEnvironment.IMwaaEnvironmentLoggingConfigurationWorkerLogs? WorkerLogsInput
        {
            get => GetInstanceProperty<aws.MwaaEnvironment.IMwaaEnvironmentLoggingConfigurationWorkerLogs?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.mwaaEnvironment.MwaaEnvironmentLoggingConfiguration\"}", isOptional: true)]
        public virtual aws.MwaaEnvironment.IMwaaEnvironmentLoggingConfiguration? InternalValue
        {
            get => GetInstanceProperty<aws.MwaaEnvironment.IMwaaEnvironmentLoggingConfiguration?>();
            set => SetInstanceProperty(value);
        }
    }
}
