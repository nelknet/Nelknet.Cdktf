using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EmrserverlessApplication
{
    [JsiiClass(nativeType: typeof(aws.EmrserverlessApplication.EmrserverlessApplicationInitialCapacityInitialCapacityConfigOutputReference), fullyQualifiedName: "aws.emrserverlessApplication.EmrserverlessApplicationInitialCapacityInitialCapacityConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class EmrserverlessApplicationInitialCapacityInitialCapacityConfigOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public EmrserverlessApplicationInitialCapacityInitialCapacityConfigOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected EmrserverlessApplicationInitialCapacityInitialCapacityConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EmrserverlessApplicationInitialCapacityInitialCapacityConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putWorkerConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.emrserverlessApplication.EmrserverlessApplicationInitialCapacityInitialCapacityConfigWorkerConfiguration\"}}]")]
        public virtual void PutWorkerConfiguration(aws.EmrserverlessApplication.IEmrserverlessApplicationInitialCapacityInitialCapacityConfigWorkerConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.EmrserverlessApplication.IEmrserverlessApplicationInitialCapacityInitialCapacityConfigWorkerConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetWorkerConfiguration")]
        public virtual void ResetWorkerConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "workerConfiguration", typeJson: "{\"fqn\":\"aws.emrserverlessApplication.EmrserverlessApplicationInitialCapacityInitialCapacityConfigWorkerConfigurationOutputReference\"}")]
        public virtual aws.EmrserverlessApplication.EmrserverlessApplicationInitialCapacityInitialCapacityConfigWorkerConfigurationOutputReference WorkerConfiguration
        {
            get => GetInstanceProperty<aws.EmrserverlessApplication.EmrserverlessApplicationInitialCapacityInitialCapacityConfigWorkerConfigurationOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "workerConfigurationInput", typeJson: "{\"fqn\":\"aws.emrserverlessApplication.EmrserverlessApplicationInitialCapacityInitialCapacityConfigWorkerConfiguration\"}", isOptional: true)]
        public virtual aws.EmrserverlessApplication.IEmrserverlessApplicationInitialCapacityInitialCapacityConfigWorkerConfiguration? WorkerConfigurationInput
        {
            get => GetInstanceProperty<aws.EmrserverlessApplication.IEmrserverlessApplicationInitialCapacityInitialCapacityConfigWorkerConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "workerCountInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? WorkerCountInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "workerCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double WorkerCount
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.emrserverlessApplication.EmrserverlessApplicationInitialCapacityInitialCapacityConfig\"}", isOptional: true)]
        public virtual aws.EmrserverlessApplication.IEmrserverlessApplicationInitialCapacityInitialCapacityConfig? InternalValue
        {
            get => GetInstanceProperty<aws.EmrserverlessApplication.IEmrserverlessApplicationInitialCapacityInitialCapacityConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
