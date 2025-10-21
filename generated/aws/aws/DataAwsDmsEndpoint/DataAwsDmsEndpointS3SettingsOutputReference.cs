using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsDmsEndpoint
{
    [JsiiClass(nativeType: typeof(aws.DataAwsDmsEndpoint.DataAwsDmsEndpointS3SettingsOutputReference), fullyQualifiedName: "aws.dataAwsDmsEndpoint.DataAwsDmsEndpointS3SettingsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataAwsDmsEndpointS3SettingsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataAwsDmsEndpointS3SettingsOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsDmsEndpointS3SettingsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsDmsEndpointS3SettingsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "addColumnName", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable AddColumnName
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "bucketFolder", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BucketFolder
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "bucketName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BucketName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "cannedAclForObjects", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CannedAclForObjects
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "cdcInsertsAndUpdates", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable CdcInsertsAndUpdates
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "cdcInsertsOnly", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable CdcInsertsOnly
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "cdcMaxBatchInterval", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double CdcMaxBatchInterval
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "cdcMinFileSize", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double CdcMinFileSize
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "cdcPath", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CdcPath
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "compressionType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompressionType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "csvDelimiter", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CsvDelimiter
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "csvNoSupValue", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CsvNoSupValue
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "csvNullValue", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CsvNullValue
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "csvRowDelimiter", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CsvRowDelimiter
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dataFormat", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DataFormat
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dataPageSize", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DataPageSize
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "datePartitionDelimiter", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DatePartitionDelimiter
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "datePartitionEnabled", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable DatePartitionEnabled
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "datePartitionSequence", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DatePartitionSequence
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dictPageSizeLimit", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DictPageSizeLimit
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "enableStatistics", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable EnableStatistics
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "encodingType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EncodingType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "encryptionMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EncryptionMode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "externalTableDefinition", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExternalTableDefinition
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "glueCatalogGeneration", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable GlueCatalogGeneration
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "ignoreHeaderRows", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double IgnoreHeaderRows
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "ignoreHeadersRow", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double IgnoreHeadersRow
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "includeOpForFullLoad", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable IncludeOpForFullLoad
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "maxFileSize", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxFileSize
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "parquetTimestampInMillisecond", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable ParquetTimestampInMillisecond
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "parquetVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ParquetVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "preserveTransactions", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable PreserveTransactions
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "rfc4180", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable Rfc4180
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "rowGroupLength", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double RowGroupLength
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "serverSideEncryptionKmsKeyId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServerSideEncryptionKmsKeyId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "serviceAccessRoleArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceAccessRoleArn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timestampColumnName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimestampColumnName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "useCsvNoSupValue", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable UseCsvNoSupValue
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "useTaskStartTimeForFullLoadTimestamp", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable UseTaskStartTimeForFullLoadTimestamp
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.dataAwsDmsEndpoint.DataAwsDmsEndpointS3Settings\"}", isOptional: true)]
        public virtual aws.DataAwsDmsEndpoint.IDataAwsDmsEndpointS3Settings? InternalValue
        {
            get => GetInstanceProperty<aws.DataAwsDmsEndpoint.IDataAwsDmsEndpointS3Settings?>();
            set => SetInstanceProperty(value);
        }
    }
}
