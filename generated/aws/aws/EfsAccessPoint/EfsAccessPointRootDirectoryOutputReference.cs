using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EfsAccessPoint
{
    [JsiiClass(nativeType: typeof(aws.EfsAccessPoint.EfsAccessPointRootDirectoryOutputReference), fullyQualifiedName: "aws.efsAccessPoint.EfsAccessPointRootDirectoryOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class EfsAccessPointRootDirectoryOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public EfsAccessPointRootDirectoryOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected EfsAccessPointRootDirectoryOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EfsAccessPointRootDirectoryOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCreationInfo", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.efsAccessPoint.EfsAccessPointRootDirectoryCreationInfo\"}}]")]
        public virtual void PutCreationInfo(aws.EfsAccessPoint.IEfsAccessPointRootDirectoryCreationInfo @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.EfsAccessPoint.IEfsAccessPointRootDirectoryCreationInfo)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCreationInfo")]
        public virtual void ResetCreationInfo()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPath")]
        public virtual void ResetPath()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "creationInfo", typeJson: "{\"fqn\":\"aws.efsAccessPoint.EfsAccessPointRootDirectoryCreationInfoOutputReference\"}")]
        public virtual aws.EfsAccessPoint.EfsAccessPointRootDirectoryCreationInfoOutputReference CreationInfo
        {
            get => GetInstanceProperty<aws.EfsAccessPoint.EfsAccessPointRootDirectoryCreationInfoOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "creationInfoInput", typeJson: "{\"fqn\":\"aws.efsAccessPoint.EfsAccessPointRootDirectoryCreationInfo\"}", isOptional: true)]
        public virtual aws.EfsAccessPoint.IEfsAccessPointRootDirectoryCreationInfo? CreationInfoInput
        {
            get => GetInstanceProperty<aws.EfsAccessPoint.IEfsAccessPointRootDirectoryCreationInfo?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "pathInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PathInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Path
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.efsAccessPoint.EfsAccessPointRootDirectory\"}", isOptional: true)]
        public virtual aws.EfsAccessPoint.IEfsAccessPointRootDirectory? InternalValue
        {
            get => GetInstanceProperty<aws.EfsAccessPoint.IEfsAccessPointRootDirectory?>();
            set => SetInstanceProperty(value);
        }
    }
}
