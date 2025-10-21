using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.WorkspacesWorkspace
{
    [JsiiClass(nativeType: typeof(aws.WorkspacesWorkspace.WorkspacesWorkspaceWorkspacePropertiesOutputReference), fullyQualifiedName: "aws.workspacesWorkspace.WorkspacesWorkspaceWorkspacePropertiesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class WorkspacesWorkspaceWorkspacePropertiesOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public WorkspacesWorkspaceWorkspacePropertiesOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected WorkspacesWorkspaceWorkspacePropertiesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected WorkspacesWorkspaceWorkspacePropertiesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetComputeTypeName")]
        public virtual void ResetComputeTypeName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRootVolumeSizeGib")]
        public virtual void ResetRootVolumeSizeGib()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRunningMode")]
        public virtual void ResetRunningMode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRunningModeAutoStopTimeoutInMinutes")]
        public virtual void ResetRunningModeAutoStopTimeoutInMinutes()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUserVolumeSizeGib")]
        public virtual void ResetUserVolumeSizeGib()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "computeTypeNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ComputeTypeNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "rootVolumeSizeGibInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? RootVolumeSizeGibInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "runningModeAutoStopTimeoutInMinutesInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? RunningModeAutoStopTimeoutInMinutesInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "runningModeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RunningModeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "userVolumeSizeGibInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? UserVolumeSizeGibInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "computeTypeName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ComputeTypeName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "rootVolumeSizeGib", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double RootVolumeSizeGib
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "runningMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RunningMode
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "runningModeAutoStopTimeoutInMinutes", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double RunningModeAutoStopTimeoutInMinutes
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "userVolumeSizeGib", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double UserVolumeSizeGib
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.workspacesWorkspace.WorkspacesWorkspaceWorkspaceProperties\"}", isOptional: true)]
        public virtual aws.WorkspacesWorkspace.IWorkspacesWorkspaceWorkspaceProperties? InternalValue
        {
            get => GetInstanceProperty<aws.WorkspacesWorkspace.IWorkspacesWorkspaceWorkspaceProperties?>();
            set => SetInstanceProperty(value);
        }
    }
}
