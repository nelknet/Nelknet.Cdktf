using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.KinesisFirehoseDeliveryStream
{
    [JsiiClass(nativeType: typeof(aws.KinesisFirehoseDeliveryStream.KinesisFirehoseDeliveryStreamRedshiftConfigurationOutputReference), fullyQualifiedName: "aws.kinesisFirehoseDeliveryStream.KinesisFirehoseDeliveryStreamRedshiftConfigurationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class KinesisFirehoseDeliveryStreamRedshiftConfigurationOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public KinesisFirehoseDeliveryStreamRedshiftConfigurationOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected KinesisFirehoseDeliveryStreamRedshiftConfigurationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected KinesisFirehoseDeliveryStreamRedshiftConfigurationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCloudwatchLoggingOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.kinesisFirehoseDeliveryStream.KinesisFirehoseDeliveryStreamRedshiftConfigurationCloudwatchLoggingOptions\"}}]")]
        public virtual void PutCloudwatchLoggingOptions(aws.KinesisFirehoseDeliveryStream.IKinesisFirehoseDeliveryStreamRedshiftConfigurationCloudwatchLoggingOptions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.KinesisFirehoseDeliveryStream.IKinesisFirehoseDeliveryStreamRedshiftConfigurationCloudwatchLoggingOptions)}, new object[]{@value});
        }

        [JsiiMethod(name: "putProcessingConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.kinesisFirehoseDeliveryStream.KinesisFirehoseDeliveryStreamRedshiftConfigurationProcessingConfiguration\"}}]")]
        public virtual void PutProcessingConfiguration(aws.KinesisFirehoseDeliveryStream.IKinesisFirehoseDeliveryStreamRedshiftConfigurationProcessingConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.KinesisFirehoseDeliveryStream.IKinesisFirehoseDeliveryStreamRedshiftConfigurationProcessingConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putS3BackupConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.kinesisFirehoseDeliveryStream.KinesisFirehoseDeliveryStreamRedshiftConfigurationS3BackupConfiguration\"}}]")]
        public virtual void PutS3BackupConfiguration(aws.KinesisFirehoseDeliveryStream.IKinesisFirehoseDeliveryStreamRedshiftConfigurationS3BackupConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.KinesisFirehoseDeliveryStream.IKinesisFirehoseDeliveryStreamRedshiftConfigurationS3BackupConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putS3Configuration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.kinesisFirehoseDeliveryStream.KinesisFirehoseDeliveryStreamRedshiftConfigurationS3Configuration\"}}]")]
        public virtual void PutS3Configuration(aws.KinesisFirehoseDeliveryStream.IKinesisFirehoseDeliveryStreamRedshiftConfigurationS3Configuration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.KinesisFirehoseDeliveryStream.IKinesisFirehoseDeliveryStreamRedshiftConfigurationS3Configuration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSecretsManagerConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.kinesisFirehoseDeliveryStream.KinesisFirehoseDeliveryStreamRedshiftConfigurationSecretsManagerConfiguration\"}}]")]
        public virtual void PutSecretsManagerConfiguration(aws.KinesisFirehoseDeliveryStream.IKinesisFirehoseDeliveryStreamRedshiftConfigurationSecretsManagerConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.KinesisFirehoseDeliveryStream.IKinesisFirehoseDeliveryStreamRedshiftConfigurationSecretsManagerConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCloudwatchLoggingOptions")]
        public virtual void ResetCloudwatchLoggingOptions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCopyOptions")]
        public virtual void ResetCopyOptions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDataTableColumns")]
        public virtual void ResetDataTableColumns()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPassword")]
        public virtual void ResetPassword()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetProcessingConfiguration")]
        public virtual void ResetProcessingConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRetryDuration")]
        public virtual void ResetRetryDuration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetS3BackupConfiguration")]
        public virtual void ResetS3BackupConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetS3BackupMode")]
        public virtual void ResetS3BackupMode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSecretsManagerConfiguration")]
        public virtual void ResetSecretsManagerConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUsername")]
        public virtual void ResetUsername()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "cloudwatchLoggingOptions", typeJson: "{\"fqn\":\"aws.kinesisFirehoseDeliveryStream.KinesisFirehoseDeliveryStreamRedshiftConfigurationCloudwatchLoggingOptionsOutputReference\"}")]
        public virtual aws.KinesisFirehoseDeliveryStream.KinesisFirehoseDeliveryStreamRedshiftConfigurationCloudwatchLoggingOptionsOutputReference CloudwatchLoggingOptions
        {
            get => GetInstanceProperty<aws.KinesisFirehoseDeliveryStream.KinesisFirehoseDeliveryStreamRedshiftConfigurationCloudwatchLoggingOptionsOutputReference>()!;
        }

        [JsiiProperty(name: "processingConfiguration", typeJson: "{\"fqn\":\"aws.kinesisFirehoseDeliveryStream.KinesisFirehoseDeliveryStreamRedshiftConfigurationProcessingConfigurationOutputReference\"}")]
        public virtual aws.KinesisFirehoseDeliveryStream.KinesisFirehoseDeliveryStreamRedshiftConfigurationProcessingConfigurationOutputReference ProcessingConfiguration
        {
            get => GetInstanceProperty<aws.KinesisFirehoseDeliveryStream.KinesisFirehoseDeliveryStreamRedshiftConfigurationProcessingConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "s3BackupConfiguration", typeJson: "{\"fqn\":\"aws.kinesisFirehoseDeliveryStream.KinesisFirehoseDeliveryStreamRedshiftConfigurationS3BackupConfigurationOutputReference\"}")]
        public virtual aws.KinesisFirehoseDeliveryStream.KinesisFirehoseDeliveryStreamRedshiftConfigurationS3BackupConfigurationOutputReference S3BackupConfiguration
        {
            get => GetInstanceProperty<aws.KinesisFirehoseDeliveryStream.KinesisFirehoseDeliveryStreamRedshiftConfigurationS3BackupConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "s3Configuration", typeJson: "{\"fqn\":\"aws.kinesisFirehoseDeliveryStream.KinesisFirehoseDeliveryStreamRedshiftConfigurationS3ConfigurationOutputReference\"}")]
        public virtual aws.KinesisFirehoseDeliveryStream.KinesisFirehoseDeliveryStreamRedshiftConfigurationS3ConfigurationOutputReference S3Configuration
        {
            get => GetInstanceProperty<aws.KinesisFirehoseDeliveryStream.KinesisFirehoseDeliveryStreamRedshiftConfigurationS3ConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "secretsManagerConfiguration", typeJson: "{\"fqn\":\"aws.kinesisFirehoseDeliveryStream.KinesisFirehoseDeliveryStreamRedshiftConfigurationSecretsManagerConfigurationOutputReference\"}")]
        public virtual aws.KinesisFirehoseDeliveryStream.KinesisFirehoseDeliveryStreamRedshiftConfigurationSecretsManagerConfigurationOutputReference SecretsManagerConfiguration
        {
            get => GetInstanceProperty<aws.KinesisFirehoseDeliveryStream.KinesisFirehoseDeliveryStreamRedshiftConfigurationSecretsManagerConfigurationOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "cloudwatchLoggingOptionsInput", typeJson: "{\"fqn\":\"aws.kinesisFirehoseDeliveryStream.KinesisFirehoseDeliveryStreamRedshiftConfigurationCloudwatchLoggingOptions\"}", isOptional: true)]
        public virtual aws.KinesisFirehoseDeliveryStream.IKinesisFirehoseDeliveryStreamRedshiftConfigurationCloudwatchLoggingOptions? CloudwatchLoggingOptionsInput
        {
            get => GetInstanceProperty<aws.KinesisFirehoseDeliveryStream.IKinesisFirehoseDeliveryStreamRedshiftConfigurationCloudwatchLoggingOptions?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "clusterJdbcurlInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ClusterJdbcurlInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "copyOptionsInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CopyOptionsInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dataTableColumnsInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DataTableColumnsInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dataTableNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DataTableNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "passwordInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PasswordInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "processingConfigurationInput", typeJson: "{\"fqn\":\"aws.kinesisFirehoseDeliveryStream.KinesisFirehoseDeliveryStreamRedshiftConfigurationProcessingConfiguration\"}", isOptional: true)]
        public virtual aws.KinesisFirehoseDeliveryStream.IKinesisFirehoseDeliveryStreamRedshiftConfigurationProcessingConfiguration? ProcessingConfigurationInput
        {
            get => GetInstanceProperty<aws.KinesisFirehoseDeliveryStream.IKinesisFirehoseDeliveryStreamRedshiftConfigurationProcessingConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "retryDurationInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? RetryDurationInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "roleArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RoleArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "s3BackupConfigurationInput", typeJson: "{\"fqn\":\"aws.kinesisFirehoseDeliveryStream.KinesisFirehoseDeliveryStreamRedshiftConfigurationS3BackupConfiguration\"}", isOptional: true)]
        public virtual aws.KinesisFirehoseDeliveryStream.IKinesisFirehoseDeliveryStreamRedshiftConfigurationS3BackupConfiguration? S3BackupConfigurationInput
        {
            get => GetInstanceProperty<aws.KinesisFirehoseDeliveryStream.IKinesisFirehoseDeliveryStreamRedshiftConfigurationS3BackupConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "s3BackupModeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? S3BackupModeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "s3ConfigurationInput", typeJson: "{\"fqn\":\"aws.kinesisFirehoseDeliveryStream.KinesisFirehoseDeliveryStreamRedshiftConfigurationS3Configuration\"}", isOptional: true)]
        public virtual aws.KinesisFirehoseDeliveryStream.IKinesisFirehoseDeliveryStreamRedshiftConfigurationS3Configuration? S3ConfigurationInput
        {
            get => GetInstanceProperty<aws.KinesisFirehoseDeliveryStream.IKinesisFirehoseDeliveryStreamRedshiftConfigurationS3Configuration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "secretsManagerConfigurationInput", typeJson: "{\"fqn\":\"aws.kinesisFirehoseDeliveryStream.KinesisFirehoseDeliveryStreamRedshiftConfigurationSecretsManagerConfiguration\"}", isOptional: true)]
        public virtual aws.KinesisFirehoseDeliveryStream.IKinesisFirehoseDeliveryStreamRedshiftConfigurationSecretsManagerConfiguration? SecretsManagerConfigurationInput
        {
            get => GetInstanceProperty<aws.KinesisFirehoseDeliveryStream.IKinesisFirehoseDeliveryStreamRedshiftConfigurationSecretsManagerConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "usernameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? UsernameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "clusterJdbcurl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClusterJdbcurl
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "copyOptions", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CopyOptions
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "dataTableColumns", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DataTableColumns
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "dataTableName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DataTableName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Password
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "retryDuration", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double RetryDuration
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RoleArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "s3BackupMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string S3BackupMode
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "username", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Username
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.kinesisFirehoseDeliveryStream.KinesisFirehoseDeliveryStreamRedshiftConfiguration\"}", isOptional: true)]
        public virtual aws.KinesisFirehoseDeliveryStream.IKinesisFirehoseDeliveryStreamRedshiftConfiguration? InternalValue
        {
            get => GetInstanceProperty<aws.KinesisFirehoseDeliveryStream.IKinesisFirehoseDeliveryStreamRedshiftConfiguration?>();
            set => SetInstanceProperty(value);
        }
    }
}
