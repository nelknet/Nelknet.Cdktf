using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.GlueJob
{
    [JsiiByValue(fqn: "aws.glueJob.GlueJobSourceControlDetails")]
    public class GlueJobSourceControlDetails : aws.GlueJob.IGlueJobSourceControlDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_job#auth_strategy GlueJob#auth_strategy}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "authStrategy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AuthStrategy
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_job#auth_token GlueJob#auth_token}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "authToken", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AuthToken
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_job#branch GlueJob#branch}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "branch", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Branch
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_job#folder GlueJob#folder}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "folder", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Folder
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_job#last_commit_id GlueJob#last_commit_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "lastCommitId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LastCommitId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_job#owner GlueJob#owner}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "owner", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Owner
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_job#provider GlueJob#provider}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "provider", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Provider
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_job#repository GlueJob#repository}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "repository", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Repository
        {
            get;
            set;
        }
    }
}
