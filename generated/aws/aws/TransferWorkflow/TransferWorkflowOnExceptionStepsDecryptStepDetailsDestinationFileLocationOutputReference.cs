using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.TransferWorkflow
{
    [JsiiClass(nativeType: typeof(aws.TransferWorkflow.TransferWorkflowOnExceptionStepsDecryptStepDetailsDestinationFileLocationOutputReference), fullyQualifiedName: "aws.transferWorkflow.TransferWorkflowOnExceptionStepsDecryptStepDetailsDestinationFileLocationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class TransferWorkflowOnExceptionStepsDecryptStepDetailsDestinationFileLocationOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public TransferWorkflowOnExceptionStepsDecryptStepDetailsDestinationFileLocationOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected TransferWorkflowOnExceptionStepsDecryptStepDetailsDestinationFileLocationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected TransferWorkflowOnExceptionStepsDecryptStepDetailsDestinationFileLocationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putEfsFileLocation", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.transferWorkflow.TransferWorkflowOnExceptionStepsDecryptStepDetailsDestinationFileLocationEfsFileLocation\"}}]")]
        public virtual void PutEfsFileLocation(aws.TransferWorkflow.ITransferWorkflowOnExceptionStepsDecryptStepDetailsDestinationFileLocationEfsFileLocation @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.TransferWorkflow.ITransferWorkflowOnExceptionStepsDecryptStepDetailsDestinationFileLocationEfsFileLocation)}, new object[]{@value});
        }

        [JsiiMethod(name: "putS3FileLocation", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.transferWorkflow.TransferWorkflowOnExceptionStepsDecryptStepDetailsDestinationFileLocationS3FileLocation\"}}]")]
        public virtual void PutS3FileLocation(aws.TransferWorkflow.ITransferWorkflowOnExceptionStepsDecryptStepDetailsDestinationFileLocationS3FileLocation @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.TransferWorkflow.ITransferWorkflowOnExceptionStepsDecryptStepDetailsDestinationFileLocationS3FileLocation)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetEfsFileLocation")]
        public virtual void ResetEfsFileLocation()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetS3FileLocation")]
        public virtual void ResetS3FileLocation()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "efsFileLocation", typeJson: "{\"fqn\":\"aws.transferWorkflow.TransferWorkflowOnExceptionStepsDecryptStepDetailsDestinationFileLocationEfsFileLocationOutputReference\"}")]
        public virtual aws.TransferWorkflow.TransferWorkflowOnExceptionStepsDecryptStepDetailsDestinationFileLocationEfsFileLocationOutputReference EfsFileLocation
        {
            get => GetInstanceProperty<aws.TransferWorkflow.TransferWorkflowOnExceptionStepsDecryptStepDetailsDestinationFileLocationEfsFileLocationOutputReference>()!;
        }

        [JsiiProperty(name: "s3FileLocation", typeJson: "{\"fqn\":\"aws.transferWorkflow.TransferWorkflowOnExceptionStepsDecryptStepDetailsDestinationFileLocationS3FileLocationOutputReference\"}")]
        public virtual aws.TransferWorkflow.TransferWorkflowOnExceptionStepsDecryptStepDetailsDestinationFileLocationS3FileLocationOutputReference S3FileLocation
        {
            get => GetInstanceProperty<aws.TransferWorkflow.TransferWorkflowOnExceptionStepsDecryptStepDetailsDestinationFileLocationS3FileLocationOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "efsFileLocationInput", typeJson: "{\"fqn\":\"aws.transferWorkflow.TransferWorkflowOnExceptionStepsDecryptStepDetailsDestinationFileLocationEfsFileLocation\"}", isOptional: true)]
        public virtual aws.TransferWorkflow.ITransferWorkflowOnExceptionStepsDecryptStepDetailsDestinationFileLocationEfsFileLocation? EfsFileLocationInput
        {
            get => GetInstanceProperty<aws.TransferWorkflow.ITransferWorkflowOnExceptionStepsDecryptStepDetailsDestinationFileLocationEfsFileLocation?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "s3FileLocationInput", typeJson: "{\"fqn\":\"aws.transferWorkflow.TransferWorkflowOnExceptionStepsDecryptStepDetailsDestinationFileLocationS3FileLocation\"}", isOptional: true)]
        public virtual aws.TransferWorkflow.ITransferWorkflowOnExceptionStepsDecryptStepDetailsDestinationFileLocationS3FileLocation? S3FileLocationInput
        {
            get => GetInstanceProperty<aws.TransferWorkflow.ITransferWorkflowOnExceptionStepsDecryptStepDetailsDestinationFileLocationS3FileLocation?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.transferWorkflow.TransferWorkflowOnExceptionStepsDecryptStepDetailsDestinationFileLocation\"}", isOptional: true)]
        public virtual aws.TransferWorkflow.ITransferWorkflowOnExceptionStepsDecryptStepDetailsDestinationFileLocation? InternalValue
        {
            get => GetInstanceProperty<aws.TransferWorkflow.ITransferWorkflowOnExceptionStepsDecryptStepDetailsDestinationFileLocation?>();
            set => SetInstanceProperty(value);
        }
    }
}
