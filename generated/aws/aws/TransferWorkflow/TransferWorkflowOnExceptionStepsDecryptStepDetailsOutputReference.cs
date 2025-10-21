using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.TransferWorkflow
{
    [JsiiClass(nativeType: typeof(aws.TransferWorkflow.TransferWorkflowOnExceptionStepsDecryptStepDetailsOutputReference), fullyQualifiedName: "aws.transferWorkflow.TransferWorkflowOnExceptionStepsDecryptStepDetailsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class TransferWorkflowOnExceptionStepsDecryptStepDetailsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public TransferWorkflowOnExceptionStepsDecryptStepDetailsOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected TransferWorkflowOnExceptionStepsDecryptStepDetailsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected TransferWorkflowOnExceptionStepsDecryptStepDetailsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putDestinationFileLocation", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.transferWorkflow.TransferWorkflowOnExceptionStepsDecryptStepDetailsDestinationFileLocation\"}}]")]
        public virtual void PutDestinationFileLocation(aws.TransferWorkflow.ITransferWorkflowOnExceptionStepsDecryptStepDetailsDestinationFileLocation @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.TransferWorkflow.ITransferWorkflowOnExceptionStepsDecryptStepDetailsDestinationFileLocation)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDestinationFileLocation")]
        public virtual void ResetDestinationFileLocation()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetName")]
        public virtual void ResetName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOverwriteExisting")]
        public virtual void ResetOverwriteExisting()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSourceFileLocation")]
        public virtual void ResetSourceFileLocation()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "destinationFileLocation", typeJson: "{\"fqn\":\"aws.transferWorkflow.TransferWorkflowOnExceptionStepsDecryptStepDetailsDestinationFileLocationOutputReference\"}")]
        public virtual aws.TransferWorkflow.TransferWorkflowOnExceptionStepsDecryptStepDetailsDestinationFileLocationOutputReference DestinationFileLocation
        {
            get => GetInstanceProperty<aws.TransferWorkflow.TransferWorkflowOnExceptionStepsDecryptStepDetailsDestinationFileLocationOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "destinationFileLocationInput", typeJson: "{\"fqn\":\"aws.transferWorkflow.TransferWorkflowOnExceptionStepsDecryptStepDetailsDestinationFileLocation\"}", isOptional: true)]
        public virtual aws.TransferWorkflow.ITransferWorkflowOnExceptionStepsDecryptStepDetailsDestinationFileLocation? DestinationFileLocationInput
        {
            get => GetInstanceProperty<aws.TransferWorkflow.ITransferWorkflowOnExceptionStepsDecryptStepDetailsDestinationFileLocation?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "overwriteExistingInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OverwriteExistingInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sourceFileLocationInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SourceFileLocationInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "typeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "overwriteExisting", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OverwriteExisting
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sourceFileLocation", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SourceFileLocation
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.transferWorkflow.TransferWorkflowOnExceptionStepsDecryptStepDetails\"}", isOptional: true)]
        public virtual aws.TransferWorkflow.ITransferWorkflowOnExceptionStepsDecryptStepDetails? InternalValue
        {
            get => GetInstanceProperty<aws.TransferWorkflow.ITransferWorkflowOnExceptionStepsDecryptStepDetails?>();
            set => SetInstanceProperty(value);
        }
    }
}
