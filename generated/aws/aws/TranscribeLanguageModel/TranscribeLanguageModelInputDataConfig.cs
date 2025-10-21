using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.TranscribeLanguageModel
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.transcribeLanguageModel.TranscribeLanguageModelInputDataConfig")]
    public class TranscribeLanguageModelInputDataConfig : aws.TranscribeLanguageModel.ITranscribeLanguageModelInputDataConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transcribe_language_model#data_access_role_arn TranscribeLanguageModel#data_access_role_arn}.</summary>
        [JsiiProperty(name: "dataAccessRoleArn", typeJson: "{\"primitive\":\"string\"}")]
        public string DataAccessRoleArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transcribe_language_model#s3_uri TranscribeLanguageModel#s3_uri}.</summary>
        [JsiiProperty(name: "s3Uri", typeJson: "{\"primitive\":\"string\"}")]
        public string S3Uri
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transcribe_language_model#tuning_data_s3_uri TranscribeLanguageModel#tuning_data_s3_uri}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tuningDataS3Uri", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TuningDataS3Uri
        {
            get;
            set;
        }
    }
}
