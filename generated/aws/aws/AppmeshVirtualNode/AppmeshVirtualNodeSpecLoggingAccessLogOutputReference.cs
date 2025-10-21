using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppmeshVirtualNode
{
    [JsiiClass(nativeType: typeof(aws.AppmeshVirtualNode.AppmeshVirtualNodeSpecLoggingAccessLogOutputReference), fullyQualifiedName: "aws.appmeshVirtualNode.AppmeshVirtualNodeSpecLoggingAccessLogOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class AppmeshVirtualNodeSpecLoggingAccessLogOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public AppmeshVirtualNodeSpecLoggingAccessLogOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected AppmeshVirtualNodeSpecLoggingAccessLogOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppmeshVirtualNodeSpecLoggingAccessLogOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putFile", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appmeshVirtualNode.AppmeshVirtualNodeSpecLoggingAccessLogFile\"}}]")]
        public virtual void PutFile(aws.AppmeshVirtualNode.IAppmeshVirtualNodeSpecLoggingAccessLogFile @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.AppmeshVirtualNode.IAppmeshVirtualNodeSpecLoggingAccessLogFile)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetFile")]
        public virtual void ResetFile()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "file", typeJson: "{\"fqn\":\"aws.appmeshVirtualNode.AppmeshVirtualNodeSpecLoggingAccessLogFileOutputReference\"}")]
        public virtual aws.AppmeshVirtualNode.AppmeshVirtualNodeSpecLoggingAccessLogFileOutputReference File
        {
            get => GetInstanceProperty<aws.AppmeshVirtualNode.AppmeshVirtualNodeSpecLoggingAccessLogFileOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "fileInput", typeJson: "{\"fqn\":\"aws.appmeshVirtualNode.AppmeshVirtualNodeSpecLoggingAccessLogFile\"}", isOptional: true)]
        public virtual aws.AppmeshVirtualNode.IAppmeshVirtualNodeSpecLoggingAccessLogFile? FileInput
        {
            get => GetInstanceProperty<aws.AppmeshVirtualNode.IAppmeshVirtualNodeSpecLoggingAccessLogFile?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.appmeshVirtualNode.AppmeshVirtualNodeSpecLoggingAccessLog\"}", isOptional: true)]
        public virtual aws.AppmeshVirtualNode.IAppmeshVirtualNodeSpecLoggingAccessLog? InternalValue
        {
            get => GetInstanceProperty<aws.AppmeshVirtualNode.IAppmeshVirtualNodeSpecLoggingAccessLog?>();
            set => SetInstanceProperty(value);
        }
    }
}
