using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CodebuildProject
{
    [JsiiClass(nativeType: typeof(aws.CodebuildProject.CodebuildProjectLogsConfigOutputReference), fullyQualifiedName: "aws.codebuildProject.CodebuildProjectLogsConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class CodebuildProjectLogsConfigOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public CodebuildProjectLogsConfigOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected CodebuildProjectLogsConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CodebuildProjectLogsConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCloudwatchLogs", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.codebuildProject.CodebuildProjectLogsConfigCloudwatchLogs\"}}]")]
        public virtual void PutCloudwatchLogs(aws.CodebuildProject.ICodebuildProjectLogsConfigCloudwatchLogs @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.CodebuildProject.ICodebuildProjectLogsConfigCloudwatchLogs)}, new object[]{@value});
        }

        [JsiiMethod(name: "putS3Logs", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.codebuildProject.CodebuildProjectLogsConfigS3Logs\"}}]")]
        public virtual void PutS3Logs(aws.CodebuildProject.ICodebuildProjectLogsConfigS3Logs @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.CodebuildProject.ICodebuildProjectLogsConfigS3Logs)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCloudwatchLogs")]
        public virtual void ResetCloudwatchLogs()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetS3Logs")]
        public virtual void ResetS3Logs()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "cloudwatchLogs", typeJson: "{\"fqn\":\"aws.codebuildProject.CodebuildProjectLogsConfigCloudwatchLogsOutputReference\"}")]
        public virtual aws.CodebuildProject.CodebuildProjectLogsConfigCloudwatchLogsOutputReference CloudwatchLogs
        {
            get => GetInstanceProperty<aws.CodebuildProject.CodebuildProjectLogsConfigCloudwatchLogsOutputReference>()!;
        }

        [JsiiProperty(name: "s3Logs", typeJson: "{\"fqn\":\"aws.codebuildProject.CodebuildProjectLogsConfigS3LogsOutputReference\"}")]
        public virtual aws.CodebuildProject.CodebuildProjectLogsConfigS3LogsOutputReference S3Logs
        {
            get => GetInstanceProperty<aws.CodebuildProject.CodebuildProjectLogsConfigS3LogsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "cloudwatchLogsInput", typeJson: "{\"fqn\":\"aws.codebuildProject.CodebuildProjectLogsConfigCloudwatchLogs\"}", isOptional: true)]
        public virtual aws.CodebuildProject.ICodebuildProjectLogsConfigCloudwatchLogs? CloudwatchLogsInput
        {
            get => GetInstanceProperty<aws.CodebuildProject.ICodebuildProjectLogsConfigCloudwatchLogs?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "s3LogsInput", typeJson: "{\"fqn\":\"aws.codebuildProject.CodebuildProjectLogsConfigS3Logs\"}", isOptional: true)]
        public virtual aws.CodebuildProject.ICodebuildProjectLogsConfigS3Logs? S3LogsInput
        {
            get => GetInstanceProperty<aws.CodebuildProject.ICodebuildProjectLogsConfigS3Logs?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.codebuildProject.CodebuildProjectLogsConfig\"}", isOptional: true)]
        public virtual aws.CodebuildProject.ICodebuildProjectLogsConfig? InternalValue
        {
            get => GetInstanceProperty<aws.CodebuildProject.ICodebuildProjectLogsConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
