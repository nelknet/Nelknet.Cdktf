using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CodegurureviewerRepositoryAssociation
{
    [JsiiByValue(fqn: "aws.codegurureviewerRepositoryAssociation.CodegurureviewerRepositoryAssociationRepository")]
    public class CodegurureviewerRepositoryAssociationRepository : aws.CodegurureviewerRepositoryAssociation.ICodegurureviewerRepositoryAssociationRepository
    {
        /// <summary>bitbucket block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codegurureviewer_repository_association#bitbucket CodegurureviewerRepositoryAssociation#bitbucket}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "bitbucket", typeJson: "{\"fqn\":\"aws.codegurureviewerRepositoryAssociation.CodegurureviewerRepositoryAssociationRepositoryBitbucket\"}", isOptional: true)]
        public aws.CodegurureviewerRepositoryAssociation.ICodegurureviewerRepositoryAssociationRepositoryBitbucket? Bitbucket
        {
            get;
            set;
        }

        /// <summary>codecommit block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codegurureviewer_repository_association#codecommit CodegurureviewerRepositoryAssociation#codecommit}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "codecommit", typeJson: "{\"fqn\":\"aws.codegurureviewerRepositoryAssociation.CodegurureviewerRepositoryAssociationRepositoryCodecommit\"}", isOptional: true)]
        public aws.CodegurureviewerRepositoryAssociation.ICodegurureviewerRepositoryAssociationRepositoryCodecommit? Codecommit
        {
            get;
            set;
        }

        /// <summary>github_enterprise_server block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codegurureviewer_repository_association#github_enterprise_server CodegurureviewerRepositoryAssociation#github_enterprise_server}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "githubEnterpriseServer", typeJson: "{\"fqn\":\"aws.codegurureviewerRepositoryAssociation.CodegurureviewerRepositoryAssociationRepositoryGithubEnterpriseServer\"}", isOptional: true)]
        public aws.CodegurureviewerRepositoryAssociation.ICodegurureviewerRepositoryAssociationRepositoryGithubEnterpriseServer? GithubEnterpriseServer
        {
            get;
            set;
        }

        /// <summary>s3_bucket block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codegurureviewer_repository_association#s3_bucket CodegurureviewerRepositoryAssociation#s3_bucket}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "s3Bucket", typeJson: "{\"fqn\":\"aws.codegurureviewerRepositoryAssociation.CodegurureviewerRepositoryAssociationRepositoryS3Bucket\"}", isOptional: true)]
        public aws.CodegurureviewerRepositoryAssociation.ICodegurureviewerRepositoryAssociationRepositoryS3Bucket? S3Bucket
        {
            get;
            set;
        }
    }
}
